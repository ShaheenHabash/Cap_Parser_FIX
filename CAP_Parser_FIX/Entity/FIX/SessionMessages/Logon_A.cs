using System;
using CAP_Parser_FIX.Entity.Customs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAP_Parser_FIX.Tools;

namespace Optiq_Parser_OEG.Entity.SBE.SessionMessages
{
    public class Logon_A : MessageContents
    {
        public Logon_A()
        {
            _ObsFields = new ObservableCollection<Field>();
            Field xField;

            xField = new Field(108, "HeartBtInt", Format.Int, 3, _ObsFields.GetObsBytesLength(), "SSS", Persence.Required, true, "Heartbeat interval (seconds)");
            _ObsFields.Add(xField);

            xField = new Field(98, "EncryptMethod", Format.Int, 1, _ObsFields.GetObsBytesLength(), "Always set to 0 = None", Persence.Required, true, "Method of encryption");
            _ObsFields.Add(xField);

            xField = new Field(95, "RawDataLength", Format.Int, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Optional, true, "Number of bytes in raw data field");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);

            xField = new Field(0, "STX", Format.String, 1, _ObsFields.GetObsBytesLength(), "PassibleValues", Persence.Required, true, "ShortDescription");
            _ObsFields.Add(xField);
        }
    }
}
