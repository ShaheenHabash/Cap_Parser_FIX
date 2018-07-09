using CAP_Parser_FIX.Proccess;
using CAP_Parser_FIX.Tools;
using CAP_Parser_FIX.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;

namespace Optiq_Parser_OEG.View
{
    /// <summary>
    /// Interaction logic for winLogin.xaml
    /// </summary>
    public partial class winLogin : Window
    {
        private prcCapParser prc;
        //*************************************************************
        public winLogin()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }
        //*************************************************************
        private void btnLogon_Click(object sender, RoutedEventArgs e)
        {
            MybusyIndicator.BusyContent = "Loading in process";
            MybusyIndicator.IsBusy = true;
            string xUserName = txtUserName.Text.Nvl("");
            string xPassword = txtPassword.Text.Nvl("");
            string xSenderCompID = txtSenderCompID.Text.Nvl("");
            string xSenderSubID = txtSenderSubID.Text.Nvl("");
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                prc = new prcCapParser(xUserName, xPassword, xSenderCompID, xSenderSubID, xPassword);
                ObservableCollection<string> xReVal = prc.Logon();
                this.Dispatcher.Invoke(() =>
                {
                    if (xReVal.Count - 2 < 0)
                    {
                        MessageBox.Show("Not appropriate response");
                    }
                    if (xReVal[xReVal.Count - 2].GetMessageType() == "A")
                    {
                        //Logon successfully ==> Go to Main win.
                        winMain pg = new winMain(prc);
                        pg.Show();
                        pg.WriteLog(xReVal);
                        this.Close();
                        MybusyIndicator.IsBusy = false;
                        return;
                    }
                    else
                    {
                        //Error message ==> Display the error.

                        string xError = xReVal[xReVal.Count - 2].GetTagValue("58");
                        MessageBox.Show(xError);
                    }
                });
            }).Start();
        }
        //*************************************************************
    }
}
