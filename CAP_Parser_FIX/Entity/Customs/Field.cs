using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Parser_FIX.Entity.Customs
{
    public class Field
    {
        public int _Tag { get; set; }
        public string _FieldName { get; set; }
        public Format _Format { get; set; }
        public int _Length { get; set; }
        //Not declear in the decumentation.
        public int _Position { get; set; }
        public string _PassibleValues { get; set; }
        public Persence _Presence { get; set; }
        public bool _IsEnabeled { get; set; }
        public string _ShortDescription { get; set; }


        //Char
        //String
        public string _Alphanumerical { get; set; }
        //Bool
        public bool _Boolean { get; set; }
        //Int
        //Qty
        //SeqNum
        public int _Int { get; set; }
        //Price
        public double _Price { get; set; }
        //Float
        public float _Float { get; set; }

        //LocalMktDate
        public FixDateyyyyMMdd _DateyyyyMMdd { get; set; }
        //UTCTimestamp
        public FixTimestamp _Timestamp { get; set; }
        //********************************************************************************************
        public Field(int vTag, string vFieldName, Format vFormat, int vLength, int vPosition, string vPassibleValues, Persence vPresence, bool vIsEnabeled, string vShortDescription)
        {
            this._Tag = vTag;
            this._FieldName = vFieldName;
            this._Format = vFormat;
            this._Length = vLength;
            this._Position = vPosition;
            this._PassibleValues = vPassibleValues;
            this._Presence = vPresence;
            this._IsEnabeled = vIsEnabeled;
            this._ShortDescription = vShortDescription;
        }
        //********************************************************************************************
    }
}
