using System.Collections.ObjectModel;
namespace CAP_Parser_FIX.Entity.Customs
{
    public class Bitmap
    {
        public ObservableCollection<EnumeratedField> _ObsBitmapField = new ObservableCollection<EnumeratedField>();
        public Bitmap()
        {
            //OrderTypeRules
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "Market", "0"));
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "Limit", "1"));
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "Stop_OR_StopLoss", "2"));
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "StopLimit", "3"));
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "MarketOnOpen_MOO", "4"));
            _ObsBitmapField.Add(new EnumeratedField("OrderTypeRules", "TradeAtSettlement", "5"));

            //TradingMode
            _ObsBitmapField.Add(new EnumeratedField("TradingMode", "CallBBOOnly_CashOnly", "0"));
            _ObsBitmapField.Add(new EnumeratedField("TradingMode", "TradingAtLast_CashOnly", "1"));
            _ObsBitmapField.Add(new EnumeratedField("TradingMode", "RandomUncrossing_Cash", "2"));
            _ObsBitmapField.Add(new EnumeratedField("TradingMode", "Suspended_DerivativesOnly", "3"));
            _ObsBitmapField.Add(new EnumeratedField("TradingMode", "None", "4"));

            //TradeQualifier
            _ObsBitmapField.Add(new EnumeratedField("TradeQualifier", "UncrossingTrade", "0"));
            _ObsBitmapField.Add(new EnumeratedField("TradeQualifier", "OpeningTrade", "1"));
            _ObsBitmapField.Add(new EnumeratedField("TradeQualifier", "PassiveOrder", "2"));
            _ObsBitmapField.Add(new EnumeratedField("TradeQualifier", "AggressiveOrder", "3"));
            _ObsBitmapField.Add(new EnumeratedField("TradeQualifier", "TradeCreationByMarketOperations", "4"));

            //ExecutionInstruction
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "Disclosed Quantity Randomization [C]", "2"));
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "Disabled Cancel On Disconnect Indicator", "3"));
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "RFQ Answer [C]", "4"));
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "RFQ Confirmation [C]", "5"));
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "Future use 1", "6"));
            _ObsBitmapField.Add(new EnumeratedField("ExecutionInstruction", "Future use 2", "7"));

            //OpenClose
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 1", "0"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 2", "1"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 3", "2"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 4", "3"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 5", "4"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 6", "5"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 7", "6"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 8", "7"));
            _ObsBitmapField.Add(new EnumeratedField("OpenClose", "Leg 9", "8"));
        }
    }
}
