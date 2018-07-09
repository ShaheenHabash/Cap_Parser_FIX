using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Parser_FIX.Entity.Customs
{
    public class EnumeratedField
    {
        public string _Name = "";
        public string _Description = "";
        public string _Value = "";
        public EnumeratedField(string vName, string vDescription, string vValue)
        {
            this._Name = vName;
            this._Description = vDescription;  
            this._Value = vValue;
        }
    }
}
