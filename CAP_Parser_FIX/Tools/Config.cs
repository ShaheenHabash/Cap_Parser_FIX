using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Parser_FIX.Tools
{
    class Config
    {
        public static string _Ip = ConfigurationManager.AppSettings["Ip"];
        public static string _Port = ConfigurationManager.AppSettings["Port"];
        public static string _HeartbeatInterval = ConfigurationManager.AppSettings["HeartbeatInterval"];

        public static string _AutoRun = ConfigurationManager.AppSettings["AutoRun"];

        public static string _WriteOPTIQLogMessageUnReadable = ConfigurationManager.AppSettings["WriteOPTIQLogMessageUnReadable"];
        public static string _WriteOPTIQLogMessageReadable = ConfigurationManager.AppSettings["WriteOPTIQLogMessageReadable"];
    }
}
