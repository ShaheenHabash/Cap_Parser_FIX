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
    /// Interaction logic for winNewOrder.xaml
    /// </summary>
    public partial class winNewOrder : Window
    {
        public event EventHandler SubmitClicked;
        private prcCapParser prc;
        //*************************************************************
        public winNewOrder(prcCapParser vPrc)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            prc = vPrc;
        }
        //*************************************************************
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MybusyIndicator.BusyContent = "Loading in process";
            MybusyIndicator.IsBusy = true;
            string xAccount = txtAccount.Text.Nvl("");
            string xClientId = txtClientId.Text.Nvl("");
            string xTimeInForce = txtTimeInForce.Text.Nvl("");
            decimal xPrice = (decimal)txtPrice.Text.Nvl(0.0);
            string xSymbol = txtSymbol.Text.Nvl("");
            int xSide = txtSide.Text.Nvl(0);
            int xQuantity = txtQuantity.Text.Nvl(0);
            string xStation = txtStation.Text.Nvl("");
            string xStopPx = txtStopPx.Text.Nvl("").Trim();
            string xMinQty = txtMinQty.Text.Nvl("").Trim();
            string xMaxFloor = txtMaxFloor.Text.Nvl("").Trim();
            string xExpireTime = txtExpireTime.Text.Nvl("").Trim();
            string xTraderId = Tool.GetTraderId(xAccount,xStation);
            string xOrderId = Tool.GetOrderID();
            ObservableCollection<string> xReVal = prc.NewOrderSingle(xStopPx, xMinQty, xMaxFloor, xAccount, xClientId, xTraderId, xOrderId,xSymbol,xSide,xQuantity,2,xTimeInForce,xPrice, xExpireTime);

            SubmitClicked(xReVal, new EventArgs());
            this.Close();
            MybusyIndicator.IsBusy = false;
        }
        //*************************************************************
    }
}
