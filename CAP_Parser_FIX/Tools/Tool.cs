using CAP_Parser_FIX.Entity;
using CAP_Parser_FIX.Entity.Customs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CAP_Parser_FIX.Tools
{
    public static class Tool
    {
        public static char SOH = '\u0001';//START OF HEADING (SOH)
        public static Bitmap _Bitmap = new Bitmap();
        public static Enumerated _Enumerated = new Enumerated();
        //********************************************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-29
        /// </summary>
        /// <param name="vObs"></param>
        /// <returns>int</returns>
        public static int GetObsBytesLength(this ObservableCollection<Field> vObs)
        {
            int xReval = 0;
            foreach (var iItem in vObs)
            {
                if (iItem._IsEnabeled)
                {
                    xReval += iItem._Length;
                }
            }
            return xReval;
        }
        //********************************************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-12
        /// </summary>
        /// <param name="vArrAll"></param>
        /// <returns>ulong</returns>
        public static ulong ToUNumerical(this byte[] vArrAll)
        {
            ulong xReval = 0;
            try
            {
                switch (vArrAll.Length)
                {
                    case 1:
                        xReval = vArrAll[0].UNvl(0);
                        break;
                    case 2:
                        xReval = BitConverter.ToUInt16(vArrAll, 0);
                        break;
                    case 4:
                        xReval = BitConverter.ToUInt32(vArrAll, 0);
                        break;
                    case 8:
                        xReval = BitConverter.ToUInt64(vArrAll, 0);
                        break;
                }
            }
            catch (Exception)
            {
            }
            return xReval;
        }
        //********************************************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-12
        /// </summary>
        /// <param name="vArrAll"></param>
        /// <returns>long</returns>
        public static long ToNumerical(this byte[] vArrAll)
        {
            long xReval = 0;
            try
            {
                switch (vArrAll.Length)
                {
                    case 1:
                        xReval = vArrAll[0].UNvl(0);
                        break;
                    case 2:
                        xReval = BitConverter.ToInt16(vArrAll, 0);
                        break;
                    case 4:
                        xReval = BitConverter.ToInt32(vArrAll, 0);
                        break;
                    case 8:
                        xReval = BitConverter.ToInt64(vArrAll, 0);
                        break;
                }
            }
            catch (Exception)
            {
            }
            return xReval;
        }
        //********************************************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-12
        /// </summary>
        /// <param name="vArrAll"></param>
        /// <returns>ObservableCollection<Field></returns>
        //********************************************************************************************
        //public static ObservableCollection<Field> FillArrByteInObsField(this ObservableCollection<Field> vObs, Byte[] vArrAll)
        //{
        //    foreach (var iItem in vObs)
        //    {
        //        if (iItem._Position < vArrAll.Length)
        //        {
        //            switch (iItem._Format)
        //            {
        //                case Format.Bitmap:
        //                    string xBitmapValue = vArrAll.SubArray(iItem._Position, iItem._Length).ToUNumerical().Nvl("");
        //                    iItem._Bitmap = _Bitmap._ObsBitmapField.GetEnumeratedFieldFromObs(xBitmapValue);
        //                    break;

        //                case Format.Boolean:
        //                    iItem._Boolean = vArrAll.SubArray(iItem._Position, iItem._Length)[0].Nvl(false);
        //                    break;

        //                case Format.Date:
        //                    iItem._Date = new OptiqDate(vArrAll.SubArray(iItem._Position, iItem._Length));
        //                    break;

        //                case Format.DateyyyyMMdd:
        //                    iItem._DateyyyyMMdd = new FixDateyyyyMMdd(vArrAll.SubArray(iItem._Position, iItem._Length));
        //                    break;

        //                case Format.DateMMdd:
        //                    iItem._DateMMdd = new OptiqDateMMdd(vArrAll.SubArray(iItem._Position, iItem._Length));
        //                    break;

        //                case Format.Enumerated:
        //                    string xEnumeratedValue = vArrAll.SubArray(iItem._Position, iItem._Length).ToUNumerical().Nvl("");
        //                    iItem._Enumerated = _Enumerated._ObsEnumeratedField.GetEnumeratedFieldFromObs(xEnumeratedValue);
        //                    break;

        //                case Format.Timestamp:
        //                    iItem._Timestamp = new FixTimestamp(vArrAll.SubArray(iItem._Position, iItem._Length));
        //                    break;

        //                case Format.Frame:
        //                    break;

        //                case Format.AlphanumericalId:
        //                case Format.Text:
        //                    iItem._Alphanumerical = Encoding.UTF8.GetString(vArrAll, iItem._Position, iItem._Length);
        //                    break;

        //                case Format.UAmount:
        //                case Format.USequence:
        //                case Format.UQuantity:
        //                case Format.UPrice:
        //                case Format.UNumerical:
        //                case Format.UNumericalId:
        //                    iItem._UNumerical = vArrAll.SubArray(iItem._Position, iItem._Length).ToUNumerical();
        //                    break;

        //                case Format.Quantity:
        //                case Format.Price:
        //                case Format.Numerical:
        //                case Format.NumericalId:
        //                    iItem._Numerical = vArrAll.SubArray(iItem._Position, iItem._Length).ToNumerical();
        //                    break;
        //            }
        //        }
        //    }
        //    return vObs;
        //}
        //********************************************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-12
        /// </summary>
        /// <param name="vData"></param>
        /// <param name="vIndex"></param>
        /// <param name="vLength"></param>
        /// <returns>T[]</returns>
        public static T[] SubArray<T>(this T[] vData, int vIndex, int vLength)
        {
            T[] xResult = new T[vLength];
            Array.Copy(vData, vIndex, xResult, 0, vLength);
            return xResult;
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-11-12
        /// </summary>
        /// <param name="vObs"></param>
        /// <param name="vName"></param>
        /// <returns>Field</returns>
        public static Field GetFieldFromObs(this ObservableCollection<Field> vObs, string vName)
        {
            foreach (var iItem in vObs)
            {
                if (iItem._FieldName == vName)
                {
                    return iItem;
                }
            }
            return null;
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-12-05
        /// </summary>
        /// <param name="vObs"></param>
        /// <param name="vName"></param>
        /// <returns>Field</returns>
        public static EnumeratedField GetEnumeratedFieldFromObs(this ObservableCollection<EnumeratedField> vObs, string vValue)
        {
            foreach (var iItem in vObs)
            {
                if (iItem._Value == vValue)
                {
                    return iItem;
                }
            }
            return null;
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-12-05
        /// </summary>
        /// <param name="vValue"></param>
        /// <param name="vReValue"></param>
        /// <returns>bool</returns>
        public static bool Nvl(this object vValue, bool vReValue)
        {
            if (vValue == null)
                return Convert.ToBoolean(vReValue);//Convert.ToInt32(vReValue);
            else if (vValue is DBNull)
                return Convert.ToBoolean(vReValue);//Convert.ToInt32(vReValue);

            else
                return Convert.ToBoolean(vValue);
        }

        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2016-01-24
        /// </summary>
        /// <param name="vValue"></param>
        /// <param name="vReValue"></param>
        /// <returns>int</returns>
        public static int Nvl(this object vValue, int vReValue)
        {
            if (vValue == null)
                return vReValue;
            else if (vValue is System.DBNull)
                return vReValue;
            else if (vValue.ToString() == "")
                return vReValue;
            else
                try
                {
                    return Convert.ToInt32(vValue);

                }
                catch (FormatException)
                {
                    return Convert.ToInt32(Convert.ToDouble(vValue));

                }
        }

        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2016-01-24
        /// </summary>
        /// <param name="vValue"></param>
        /// <param name="vReValue"></param>
        /// <returns>uint</returns>
        public static uint UNvl(this object vValue, uint vReValue)
        {
            if (vValue == null)
                return vReValue;
            else if (vValue is System.DBNull)
                return vReValue;
            else if (vValue.ToString() == "")
                return vReValue;
            else
                try
                {
                    return Convert.ToUInt32(vValue);

                }
                catch (FormatException)
                {
                    return Convert.ToUInt32(Convert.ToDouble(vValue));

                }
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2016-01-24
        /// </summary>
        /// <param name="vValue"></param>
        /// <param name="vReValue"></param>
        /// <returns>double</returns>
        public static double Nvl(this object vValue, double vReValue)
        {
            if (vValue == null)
                return vReValue;
            else if (vValue is System.DBNull)
                return vReValue;
            else if (vValue.ToString() == "")
                return vReValue;
            else
                return Convert.ToDouble(vValue);
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2016-01-24
        /// </summary>
        /// <param name="vValue"></param>
        /// <param name="vReValue"></param>
        /// <returns>string</returns>
        public static string Nvl(this object vValue, string vReValue)
        {
            if (vValue == null)
                return vReValue;
            else if (vValue is DBNull)
                return vReValue;
            else if (vValue.ToString() == "")
                return vReValue;
            else
                return Convert.ToString(vValue);
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2016-01-24
        /// Move Pointer Of vNetStream number of byte equal to vNumOfByte
        /// </summary>
        /// <param name="vNetStream"></param>
        /// <param name="vNumOfByte"></param>
        public static void ReadDummy(this NetworkStream vNetStream, int vNumOfByte)
        {
            for (int i = 0; i < vNumOfByte; i++)
            {
                vNetStream.ReadByte();
            }
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-10-23
        /// check if vStr string is charecter
        /// vStr Values ==>
        /// a-z OR A-Z
        /// </summary>
        /// <param name="vStr"></param>
        /// <returns>bool</returns>
        private static bool IsChar(String vStr)
        {
            return Regex.IsMatch(vStr, @"^[a-zA-Z]+$");
        }
        //*************************************************************
        /// <summary>
        /// Powered by Shaheen Al-Habash 2017-10-23
        /// Convert vChar to its equivalent integer
        /// vChar Values ==>
        /// a-z OR A-Z
        /// </summary>
        /// <param name="vChar"></param>
        /// <returns>int</returns>
        private static int CharToInteger(char vChar)
        {
            return (char.ToUpper(vChar) - 64);// For 'A'  ==> index == 1
        }
        //*************************************************************
        public static void WriteOPTIQLogMessageUnReadable(Byte[] vArrFirstSub, Byte[] vArrSecondSub)
        {
            if (Config._WriteOPTIQLogMessageUnReadable.Nvl(0) == 1)
            {
                using (FileStream fs = new FileStream(string.Format("OPTIQ-OEG-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + ".log"), FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    string xMessage = "";
                    foreach (var iItem in vArrFirstSub)
                    {
                        xMessage += iItem + ",";
                    }
                    foreach (var iItem in vArrSecondSub)
                    {
                        xMessage += iItem + ",";
                    }
                    xMessage = xMessage.Remove(xMessage.Length - 1);
                    sw.Write(xMessage + "\n"); ;
                }
            }
        }
        //*************************************************************
        public static byte[] Decode(this byte[] vPacket)
        {
            var i = vPacket.Length - 1;
            while (vPacket[i] == 0)
            {
                --i;
                if (i == 0)
                {
                    return new byte[0];
                }
            }
            var xTemp = new byte[i + 1];
            Array.Copy(vPacket, xTemp, i + 1);
            return xTemp;
        }
        //*************************************************************
        public static string GetTagValue(this string vMessage, string vTag)
        {
            string xReVal = "";
            string xMessage = vMessage.Replace(Tool.SOH, '|');

            string[] xArr = xMessage.Split('|');
            Dictionary<string, string> xDicMessageObj = new Dictionary<string, string>();
            for (int i = 0; i < xArr.Length; i++)
            {
                string[] xArrKeyVal = xArr[i].Split(new[] { '=' }, 2);
                if (xArrKeyVal.Count() == 2)
                {
                    if (!xDicMessageObj.ContainsKey(xArrKeyVal[0]))
                    {
                        xDicMessageObj.Add(xArrKeyVal[0], xArrKeyVal[1]);
                    }
                }
            }

            if (xDicMessageObj.ContainsKey(vTag))
            {
                xReVal = xDicMessageObj[vTag];
            }
            else
            {
                xReVal = String.Format("Tag {0} Not Found in the message.", vTag);
            }

            return xReVal;
        }
        //*************************************************************
        public static string GetMessageType(this string vMessage)
        {
            string xReVal = "";

            xReVal = vMessage.GetTagValue("35");

            return xReVal;
        }
        //*************************************************************
        public static string GetTraderId(string vAccount, string vStation)
        {
            string xReVal = "";
            string[] xArrAccount = vAccount.Split(new string[] { "-----" }, StringSplitOptions.None);
            string xZeros = "";
            int xForLength = 8 - xArrAccount[0].Length - vStation.Length;
            for (int i = 0; i < xForLength; i++)
            {
                xZeros += "0";
            }
            xReVal = xArrAccount[0] + xZeros + vStation;

            return xReVal;
        }
        //*************************************************************
        public static string GetOrderID()
        {
            string xReVal = "";

            Random xGenerator = new Random();
            string xRandom = xGenerator.Next(0, 999999).ToString("D6");

            xReVal = "FIXTEST" + xRandom;

            return xReVal;
        }
        //*************************************************************
        //public static void WriteOPTIQLogMessageReadable(SBEHeader vSBEHeader)
        //{
        //    if (Config._WriteOPTIQLogMessageReadable.Nvl(0) == 1)
        //    {
        //        string xMessageReadable = "";
        //        foreach (var item in vSBEHeader._ObsFields)
        //        {
        //            xMessageReadable += item._FieldName + "==>";
        //            try
        //            {
        //                switch (item._Format)
        //                {
        //                    case Format.Bitmap:
        //                        xMessageReadable += "(" + item._Bitmap._Value + " | " + item._Bitmap._Description + ")" + ",";
        //                        break;

        //                    case Format.Boolean:
        //                        xMessageReadable += (item._Boolean ? "True" : "False") + ",";
        //                        break;

        //                    case Format.Date:
        //                        xMessageReadable += item._Date._Date + ",";
        //                        break;

        //                    case Format.DateyyyyMMdd:
        //                        xMessageReadable += item._DateyyyyMMdd._Date + ",";
        //                        break;

        //                    case Format.DateMMdd:
        //                        xMessageReadable += item._DateMMdd._Date + ",";
        //                        break;

        //                    case Format.Enumerated:
        //                        xMessageReadable += "(" + item._Enumerated._Value + " | " + item._Enumerated._Description + ")" + ",";
        //                        break;

        //                    case Format.Timestamp:
        //                        xMessageReadable += item._Timestamp._Date + ",";
        //                        break;

        //                    case Format.Frame:
        //                        break;

        //                    case Format.AlphanumericalId:
        //                    case Format.Text:
        //                        xMessageReadable += item._Alphanumerical + ",";
        //                        break;

        //                    case Format.UAmount:
        //                    case Format.USequence:
        //                    case Format.UQuantity:
        //                    case Format.UPrice:
        //                    case Format.UNumerical:
        //                    case Format.UNumericalId:
        //                        xMessageReadable += item._UNumerical + ",";
        //                        break;

        //                    case Format.Quantity:
        //                    case Format.Price:
        //                    case Format.Numerical:
        //                    case Format.NumericalId:
        //                        xMessageReadable += item._Numerical + ",";
        //                        break;
        //                    default:
        //                        xMessageReadable += ",";
        //                        break;
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                xMessageReadable += ",";
        //            }
        //        }
        //        foreach (var item in vSBEHeader._MessageContents._ObsFields)
        //        {
        //            xMessageReadable += item._FieldName + "==>";
        //            try
        //            {
        //                switch (item._Format)
        //                {
        //                    case Format.Bitmap:
        //                        xMessageReadable += "(" + item._Bitmap._Value + " | " + item._Bitmap._Description + ")" + ",";
        //                        break;

        //                    case Format.Boolean:
        //                        xMessageReadable += (item._Boolean ? "True" : "False") + ",";
        //                        break;

        //                    case Format.Date:
        //                        xMessageReadable += item._Date._Date + ",";
        //                        break;

        //                    case Format.DateyyyyMMdd:
        //                        xMessageReadable += item._DateyyyyMMdd._Date + ",";
        //                        break;

        //                    case Format.DateMMdd:
        //                        xMessageReadable += item._DateMMdd._Date + ",";
        //                        break;

        //                    case Format.Enumerated:
        //                        xMessageReadable += "(" + item._Enumerated._Value + " | " + item._Enumerated._Description + ")" + ",";
        //                        break;

        //                    case Format.Timestamp:
        //                        xMessageReadable += item._Timestamp._Date + ",";
        //                        break;

        //                    case Format.Frame:
        //                        break;

        //                    case Format.AlphanumericalId:
        //                    case Format.Text:
        //                        xMessageReadable += item._Alphanumerical + ",";
        //                        break;

        //                    case Format.UAmount:
        //                    case Format.USequence:
        //                    case Format.UQuantity:
        //                    case Format.UPrice:
        //                    case Format.UNumerical:
        //                    case Format.UNumericalId:
        //                        xMessageReadable += item._UNumerical + ",";
        //                        break;

        //                    case Format.Quantity:
        //                    case Format.Price:
        //                    case Format.Numerical:
        //                    case Format.NumericalId:
        //                        xMessageReadable += item._Numerical + ",";
        //                        break;
        //                    default:
        //                        xMessageReadable += ",";
        //                        break;
        //                }
        //            }
        //            catch (Exception)
        //            {
        //                xMessageReadable += ",";
        //            }
        //        }
        //        xMessageReadable = xMessageReadable.Remove(xMessageReadable.Length - 1);
        //        using (FileStream fs = new FileStream(string.Format("OPTIQ-OEG-Readable-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + ".log"), FileMode.Append, FileAccess.Write))
        //        using (StreamWriter sw = new StreamWriter(fs))
        //        {
        //            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
        //            sw.Write(xMessageReadable + "\n");
        //        }
        //    }
        //}
        //*************************************************************
    }
}
