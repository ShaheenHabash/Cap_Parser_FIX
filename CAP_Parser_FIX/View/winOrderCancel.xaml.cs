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

namespace CAP_Parser_FIX.View
{
    /// <summary>
    /// Interaction logic for winOrderCancel.xaml
    /// </summary>
    public partial class winOrderCancel : Window
    {
        public event EventHandler SubmitClicked;
        private prcCapParser prc;
        //*************************************************************
        public winOrderCancel(prcCapParser vPrc,string vLastOrderId)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            prc = vPrc;
            if(vLastOrderId != "")
            {
                txtOrigOrderID.Text = vLastOrderId;
            }
        }
        //*************************************************************
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MybusyIndicator.BusyContent = "Loading in process";
            MybusyIndicator.IsBusy = true;
            string xOrigOrderID = txtOrigOrderID.Text.Nvl("");
            string xOrderId = Tool.GetOrderID();
            string xSymbol = txtSymbol.Text.Nvl("");
            int xSide = txtSide.Text.Nvl(0);
            int xQuantity = txtQuantity.Text.Nvl(0);
            ObservableCollection<string> xReVal = prc.OrderCancelRequest(xOrigOrderID, xOrderId, xSymbol,xSide,xQuantity);

            SubmitClicked(xReVal, new EventArgs());
            this.Close();
            MybusyIndicator.IsBusy = false;
        }
        //*************************************************************
    }
}