using System;
using CAP_Parser_FIX.Tools;
using System.Threading;
using System.Globalization;

namespace CAP_Parser_FIX.Entity.Customs
{
    public class FixTimestamp
    {
        public ulong _NoOfNanoseconds = 0;
        public DateTime _Date
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                DateTime xUnixEpochTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime xResult = xUnixEpochTime.AddTicks((long)_NoOfNanoseconds / 100);
                return xResult;
            }
        }

        public FixTimestamp(Byte[] vArrAll)
        {
            _NoOfNanoseconds = vArrAll.ToUNumerical();
        }
    }
}
