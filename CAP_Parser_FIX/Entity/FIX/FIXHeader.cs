using CAP_Parser_FIX.Entity.Customs;
using System;
using System.Collections.ObjectModel;
using CAP_Parser_FIX.Tools;

namespace Optiq_Parser_OEG.Entity.FIX
{
    public class FIXHeader
    {
        public ObservableCollection<Field> _ObsFields { get; set; }
        public MessageContents _MessageContents { get; set; }
        public bool _IsFirstSubFiled = false;
        public bool _IsValedMessage = false;

        //********************************************************************************************
        public void FillFirstSub(Byte[] vArrAll)
        {
            _ObsFields = new ObservableCollection<Field>();
            Field xField;

            xField = new Field(8, "BeginString", Format.String, 8, _ObsFields.GetObsBytesLength(), "FIX.4.2", Persence.Required, true, "Message sequence no. of first message");
            _ObsFields.Add(xField);

            xField = new Field(9, "BodyLength", Format.Int, 6, _ObsFields.GetObsBytesLength(), "Must be second field in message", Persence.Required, true, "Message length. (This is the length of the entire message including header and trailer).");
            _ObsFields.Add(xField);

            xField = new Field(35, "MsgType", Format.String, 2, _ObsFields.GetObsBytesLength(), "Must be third field in message", Persence.Required, true, "MsgType");
            _ObsFields.Add(xField);

            xField = new Field(49, "SenderCompID", Format.String, 5, _ObsFields.GetObsBytesLength(), "Assigned by the exchange", Persence.Required, true, "CompID of application sending the message");
            _ObsFields.Add(xField);

            xField = new Field(56, "TargetCompID", Format.String, 5, _ObsFields.GetObsBytesLength(), "Assigned by the exchange", Persence.Required, true, "CompID of application receiving the message");
            _ObsFields.Add(xField);

            xField = new Field(34, "MsgSeqNum", Format.SeqNum, 10, _ObsFields.GetObsBytesLength(), "Negative values are invalid", Persence.Required, true, "Message sequence number");
            _ObsFields.Add(xField);

            xField = new Field(50, "SenderSubID", Format.String, 5, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Optional, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(57, "TargetSubID", Format.String, 5, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Optional, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(43, "PossDupFlag", Format.Bool, 1, _ObsFields.GetObsBytesLength(), "‘Y’ = Possible duplicate , 'N' = Original transmission", Persence.Optional, true, "Possible retransmission of message with this sequence number");
            _ObsFields.Add(xField);

            xField = new Field(52, "SendingTime", Format.UTCTimestamp, 21, _ObsFields.GetObsBytesLength(), "YYYYMMDD-HH:MM:SS", Persence.Required, true, "Time of message transmission");
            _ObsFields.Add(xField);

            //xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            //_ObsFields.Add(xField);


            //_ObsFields.FillArrByteInObsField(vArrAll);
            _IsFirstSubFiled = true;
        }
        //***************************************************************************************
        public void FillSecondSub(Byte[] vArrSecondSub)
        {
            //switch (_ObsFields.GetFieldFromObs("MsgType")._Alphanumerical)
            //{
            //    case "A":
            //        _MessageContents = new LogonAck_101();
            //        _IsValedMessage = true;
            //        break;
            //    case 0003:
            //        _MessageContents = new Ack_03();
            //        _IsValedMessage = true;
            //        break;
            //    case 0004:
            //        _MessageContents = new Fill_04();
            //        _IsValedMessage = true;
            //        break;
            //    default:
            //        _IsValedMessage = false;
            //        break;
            //}

            if (_IsValedMessage && _MessageContents._ObsFields != null)
            {
                //_MessageContents._ObsFields = _MessageContents._ObsFields.FillArrByteInObsField(vArrSecondSub);
            }
        }
    }
}