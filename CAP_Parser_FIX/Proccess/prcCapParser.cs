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

namespace CAP_Parser_FIX.Proccess
{
    public class prcCapParser
    {
        private TcpClient _Sock = null;
        private NetworkStream _NetStream = null;
        private MessageConstructor _MessageConstructor;

        private string _UserName;
        private string _Password;
        private string _SenderCompID;
        private string _SenderSubID;
        private string _TargetCompID;

        int _MessageSequenceNumber = 1;
        //*************************************************************
        public prcCapParser(string vUserName, string vPassword, string vSenderCompID, string vSenderSubID, string vTargetCompID)
        {
            _UserName = vUserName;
            _Password = vPassword;
            _SenderCompID = vSenderCompID;
            _SenderSubID = vSenderSubID;
            _TargetCompID = vTargetCompID;
            ConnectToServer();
        }
        //*************************************************************
        private void ConnectToServer()
        {
            _Sock = new TcpClient(Config._Ip, Config._Port.Nvl(0));
            _NetStream = _Sock.GetStream();
            _MessageConstructor = new MessageConstructor(Config._Ip, _UserName,
                _Password, _SenderCompID, _SenderSubID, _TargetCompID);
        }
        //*************************************************************
        public ObservableCollection<string> Logon()
        {
            ObservableCollection<string> xReVal = new ObservableCollection<string>();
            try
            {

                string xOut = _MessageConstructor.LogonMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber, 20, false);
                string xIn = SendMessage(xOut, _NetStream, true);
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));

                if (xIn.GetMessageType() != "A")
                {
                    int xSeq = GetExpectedSeq(xIn);
                    if (xSeq != 0)
                    {
                        ConnectToServer();
                        _MessageSequenceNumber = xSeq;

                        xOut = _MessageConstructor.LogonMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber, 20, false);
                        xIn = SendMessage(xOut, _NetStream, true);
                        xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                        xReVal.Add(xIn.Replace(Tool.SOH, '|'));
                    }
                }
                else
                {
                    _MessageSequenceNumber = 1;
                    xOut = _MessageConstructor.LogonMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber, 20, true);
                    xIn = SendMessage(xOut, _NetStream, true);
                    xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                    xReVal.Add(xIn.Replace(Tool.SOH, '|'));
                }

                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        public ObservableCollection<string> SequenceReset(int vNewSeqNo)
        {
            try
            {
                ObservableCollection<string> xReVal = new ObservableCollection<string>();

                string xOut = _MessageConstructor.SequenceResetMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber, vNewSeqNo);
                string xIn = SendMessage(xOut, _NetStream, true);
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));


                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        public ObservableCollection<string> Heartbeat()
        {
            try
            {
                ObservableCollection<string> xReVal = new ObservableCollection<string>();

                string xOut = _MessageConstructor.HeartbeatMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber);
                string xIn = SendMessage(xOut, _NetStream, true).Replace(Tool.SOH, '|'); ;
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));
                //if (xIn.GetMessageType() == "0")
                //{
                //    //Heartbeat successfully ==> return true.
                //    xReVal = true;
                //}
                //else if (xIn.GetMessageType() == "2")
                //{
                //    //Heartbeat successfully ==> return true.
                //    xReVal = true;
                //}
                //else
                //{
                //    //Heartbeat failed ==> return false.
                //    xReVal = false;
                //}

                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        public ObservableCollection<string> NewOrderSingle(string vStopPx, string vMinQty, string vMaxFloor, string vAccount, string vClientId, string vTraderId, string vOrderID, string vSymbol, int vSide, int vOrderQuantity, int vOrderType, string vTimeInForce, decimal vPrice, string vExpireTime)
        {
            try
            {
                ObservableCollection<string> xReVal = new ObservableCollection<string>();

                string xOut = _MessageConstructor.NewOrderSingleMessage(MessageConstructor.SessionQualifier.TRADE, _MessageSequenceNumber, vStopPx, vMinQty, vMaxFloor, vAccount, vClientId, vTraderId, vOrderID, vSymbol, vSide, vOrderQuantity, vOrderType, vTimeInForce, vPrice, vExpireTime);
                string xIn = SendMessage(xOut, _NetStream, true);
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));


                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        public ObservableCollection<string> OrderCancelRequest(string vOrigOrderID, string vOrderID, string vSymbol, int vSide, int vOrderQuantity)
        {
            try
            {
                ObservableCollection<string> xReVal = new ObservableCollection<string>();

                string xOut = _MessageConstructor.OrderCancelRequestMessage(MessageConstructor.SessionQualifier.TRADE, _MessageSequenceNumber, vOrigOrderID, vOrderID, vSymbol, vSide, vOrderQuantity);
                string xIn = SendMessage(xOut, _NetStream, true);
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));


                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        public ObservableCollection<string> Logout()
        {
            try
            {
                ObservableCollection<string> xReVal = new ObservableCollection<string>();

                string xOut = _MessageConstructor.LogoutMessage(MessageConstructor.SessionQualifier.QUOTE, _MessageSequenceNumber);
                string xIn = SendMessage(xOut, _NetStream, true);
                xReVal.Add(xOut.Replace(Tool.SOH, '|'));
                xReVal.Add(xIn.Replace(Tool.SOH, '|'));


                return xReVal;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        private string SendMessage(string vMessage, Stream vStream, bool vReadResponse = true)
        {
            try
            {
                var xByteArray = Encoding.ASCII.GetBytes(vMessage);
                vStream.Write(xByteArray, 0, xByteArray.Length);
                string xReturnMessage = "";
                if (vReadResponse)
                {
                    xReturnMessage = ReadMessage(vStream);
                }
                _MessageSequenceNumber++;
                return xReturnMessage;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        private string ReadMessage(Stream vStream)
        {
            try
            {
                var xBuffer = new byte[102400];
                Thread.Sleep(100);
                vStream.Read(xBuffer, 0, 102400);
                var xReturnMessage = Encoding.ASCII.GetString(xBuffer.Decode());
                return xReturnMessage;
            }
            catch (IOException ex)
            {
                throw ex;
            }
        }
        //*************************************************************
        private int GetExpectedSeq(string vMessage)
        {
            int xReVal = 0;

            if (vMessage.Replace(Tool.SOH, '|').GetMessageType() == "5")
            {
                string xErrorText = vMessage.Replace(Tool.SOH, '|').GetTagValue("58");
                if (xErrorText.Contains("logon sequence number is less than expected"))
                {
                    string xParameter = xErrorText.Split('[', ']')[1];
                    xReVal = xParameter.Replace(',', Tool.SOH).GetTagValue("expected").Nvl(0);
                }
            }

            return xReVal;
        }
        //*************************************************************
    }
}
