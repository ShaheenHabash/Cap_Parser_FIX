using CAP_Parser_FIX.Tools;
using System;
using System.Globalization;
using System.Threading;

namespace CAP_Parser_FIX.Entity.Customs
{
    public class FixDateyyyyMMdd
    {
        public ulong _DateyyyyMMdd = 0;
        public DateTime _Date
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                if (_DateyyyyMMdd.Nvl("").Substring(_DateyyyyMMdd.Nvl("").Length - 2) == "00")
                {
                    //Replace 00 with Month number of days 
                    _DateyyyyMMdd = (_DateyyyyMMdd.Nvl("").Substring(0, 6) + DateTime.DaysInMonth(_DateyyyyMMdd.Nvl("").Substring(0, 4).Nvl(0), _DateyyyyMMdd.Nvl("").Substring(3, 2).Nvl(0)).Nvl("")).UNvl(0);
                }

                DateTime xResult = DateTime.ParseExact(_DateyyyyMMdd.Nvl(""), "yyyyMMdd", new CultureInfo("en-US"));
                return xResult;
            }
        }

        public FixDateyyyyMMdd(Byte[] vArrAll)
        {
            _DateyyyyMMdd = vArrAll.ToUNumerical();
        }
    }
}
