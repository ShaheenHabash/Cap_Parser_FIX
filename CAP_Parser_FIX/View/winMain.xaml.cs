using CAP_Parser_FIX.Entity;
using CAP_Parser_FIX.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Net;
using System.Globalization;
using CAP_Parser_FIX.Proccess;

namespace CAP_Parser_FIX.View
{
    /// <summary>
    /// Interaction logic for winMain.xaml
    /// </summary>
    public partial class winMain : Window
    {
        private prcCapParser prc;

        private System.Windows.Forms.Timer _Timer;
        private string _LastOrderId = "";

        //*************************************************************
        public winMain(prcCapParser vPrc)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            prc = vPrc;

            RunHeartbeat();
        }
        //*************************************************************
        private void btnNewOrder_Click(object sender, RoutedEventArgs e)
        {
            winNewOrder pg = new winNewOrder(prc);
            pg.SubmitClicked += new EventHandler(winNewOrder_SubmitClicked);
            pg.Show();
        }
        //***************************************************************************
        private void winNewOrder_SubmitClicked(object sender, EventArgs e)
        {
            ObservableCollection<string> xReVal = (ObservableCollection<string>)sender;
            _LastOrderId = xReVal[xReVal.Count - 1].GetTagValue("37").Nvl("");
            WriteLog(xReVal);
        }
        //*************************************************************
        private void btnCancelOrder_Click(object sender, RoutedEventArgs e)
        {
            winOrderCancel pg = new winOrderCancel(prc, _LastOrderId);
            pg.SubmitClicked += new EventHandler(winOrderCancel_SubmitClicked);
            pg.Show();
        }
        //***************************************************************************
        private void winOrderCancel_SubmitClicked(object sender, EventArgs e)
        {
            ObservableCollection<string> xReVal = (ObservableCollection<string>)sender;
            WriteLog(xReVal);
        }
        //*************************************************************
        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<string> xReVal = prc.Logout();
            if (xReVal[1].GetMessageType() == "5")
            {
                //LogOut successfully
                lblLive.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#edb9ed"));
                _Timer.Stop();
            }
            else
            {
                //Error message ==> Display the error.

                string xError = xReVal[1].GetTagValue("58");
                MessageBox.Show(xError);
            }
            WriteLog(xReVal);
        }
        //*************************************************************
        private void RunHeartbeat()
        {
            _Timer = new System.Windows.Forms.Timer();
            _Timer.Tick += new EventHandler(xTimer_Tick);
            _Timer.Interval = Convert.ToInt32(Config._HeartbeatInterval);// in miliseconds
            _Timer.Start();
        }
        //*****************************************************************
        private void xTimer_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                ObservableCollection<string> xReVal = prc.Heartbeat();
                this.Dispatcher.Invoke(() =>
                {
                    WriteLog(xReVal);
                });
                bool xIsLive = false;
                if (xReVal[1].GetMessageType() == "0")
                {
                    //Heartbeat successfully ==> return true.
                    xIsLive = true;
                }
                else
                {
                    //Heartbeat failed ==> return false.
                    xIsLive = false;
                }
                if (xIsLive)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        lblLive.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#c1f2bd"));
                    });
                }
                else
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        lblLive.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#edb9ed"));
                    });
                    _Timer.Stop();
                }
            }).Start();
        }
        //*************************************************************
        public void WriteLog(ObservableCollection<string> vObsOutIn)
        {
            foreach (var iItem in vObsOutIn.Select((iValue, iIndex) => new { iValue, iIndex }))
            {
                if (iItem.iIndex % 2 == 0)
                {
                    txtIn.AppendText("<OUT>\n");
                    string[] xArrOut = iItem.iValue.Split(new[] { "8=FIX" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < xArrOut.Count(); i++)
                    {
                        txtIn.AppendText(iItem.iValue + "\n");
                        if (i == xArrOut.Count() - 1)
                        {
                            //LastOne
                            txtIn.AppendText("\n");
                        }
                    }
                }
                else
                {
                    txtIn.AppendText("<IN>\n");
                    string[] xArrIn = iItem.iValue.Split(new[] { "8=FIX" }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < xArrIn.Count(); i++)
                    {
                        txtIn.AppendText(iItem.iValue + "\n");
                        if (i == xArrIn.Count() - 1)
                        {
                            //LastOne
                            txtIn.AppendText("\n");
                        }
                    }
                    txtIn.AppendText("\n");
                }
            }
        }
        //*************************************************************
    }
}