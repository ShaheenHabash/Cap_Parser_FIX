using System.Collections.ObjectModel;
namespace CAP_Parser_FIX.Entity.Customs
{
    public class Enumerated
    {
        public ObservableCollection<EnumeratedField> _ObsEnumeratedField = new ObservableCollection<EnumeratedField>();
        public Enumerated()
        {
            //ExchangeMarketMechanism
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism", "CashAndDerivativeCentralOrderBook", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism", "NAVTradingFacility", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism", "PrimaryMarket", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism", "CashOnExchangeOffBook", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism", "NotApplicable", "254"));

            //GuaranteeIndicator
            _ObsEnumeratedField.Add(new EnumeratedField("GuaranteeIndicator", "AnyTradeExecutedOnThisInstrumentWillBeClearedButNotGuaranteedByAClearingHouse", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("GuaranteeIndicator", "AnyTradeExecutedOnThisInstrumentWillBeClearedAndGuaranteedByAClearingHouse", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("GuaranteeIndicator", "AnyTradeExecutedOnThisInstrumentIsNotClearableByAClearingHouse", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("GuaranteeIndicator", "InCaseOfLendingAndBorrowingInstrument", "8"));

            //TradingCurrencyIndicator
            _ObsEnumeratedField.Add(new EnumeratedField("TradingCurrencyIndicator", "ChangeRateNotAppliedToTheTradedPrice", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingCurrencyIndicator", "ChangeRateAppliedToTheTradedPrice", "1"));

            //StrikeCurrencyIndicator
            _ObsEnumeratedField.Add(new EnumeratedField("StrikeCurrencyIndicator", "ChangeRateNotAppliedToTheStrikePrice", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrikeCurrencyIndicator", "ChangeRateAppliedToTheStrikePrice", "1"));

            //InstrumentUnitExpression
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentUnitExpression", "Units", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentUnitExpression", "PercentageOfNominalExcludingAccruedInterest_Clean", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentUnitExpression", "PercentageOfNominalIncludingAccruedInterest_Dirty", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentUnitExpression", "Kilograms", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentUnitExpression", "Ounces", "9"));

            //TaxCode
            _ObsEnumeratedField.Add(new EnumeratedField("TaxCode", "NotEligibleToPEA", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("TaxCode", "EligibleToPEA", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TaxCode", "NotApplicable", "9"));

            //TypeOfMarketAdmission
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "InstrumentsTradedOnThePrimaryMarket", "A"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "InstrumentsTradedOnTheSecondaryMarket", "B"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "InstrumentsTradedOnTheNewMarket", "C"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "NonRegulatedMarket_OR_InstrumentsTradedOnTheFreeMarket_MarcheLibre", "D"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "NonRegulatedmarket_OR_Alternext", "E"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "NonListed", "F"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_NonEquities", "G"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_Equities_OR_SegmentA", "H"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_Equities_OR_SegmentB", "I"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_Equities_OR_SegmentC", "J"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_Allsecurities_OR_SpecialSegment", "K"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "RegulatedMarket_OR_Equities_OR_OtherInstruments", "L"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "OPCVM_AND_SICOMINonListed_French_Investment_Funds", "S"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "Off_Market", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "Gold_AND_Currencies_AND_Indices", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("TypeOfMarketAdmission", "Foreign", "9"));

            //ExchangeCode
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "AmsterdamEquityDerivatives", "A"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "BrusselsEquityDerivatives", "B"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "ParisEquityUnderlyings", "C"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "BrusselsCashUnderlyings", "D"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "BrusselsIndexDerivatives", "F"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "AmsterdamCashUnderlyings", "G"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "LisbonCashUnderlyings", "H"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "ParisIndexDerivatives", "J"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "AmsterdamIndexDerivatives", "K"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "LisbonIndexDerivatives", "M"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "ParisEquityDerivatives", "P"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "AmsterdamCommoditiesDerivatives", "R"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "LisbonEquityDerivatives", "S"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "ParisCommoditiesDerivatives", "Y"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeCode", "AmsterdamCurrencyDerivatives", "Z"));

            //ExerciseStyle
            _ObsEnumeratedField.Add(new EnumeratedField("ExerciseStyle", "European", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExerciseStyle", "American", "1"));

            //ContractType
            _ObsEnumeratedField.Add(new EnumeratedField("ContractType", "Future", "F"));
            _ObsEnumeratedField.Add(new EnumeratedField("ContractType", "Option", "O"));

            //UnderlyingType
            _ObsEnumeratedField.Add(new EnumeratedField("UnderlyingType", "Commodity", "C"));
            _ObsEnumeratedField.Add(new EnumeratedField("UnderlyingType", "Future", "F"));
            _ObsEnumeratedField.Add(new EnumeratedField("UnderlyingType", "Index", "I"));
            _ObsEnumeratedField.Add(new EnumeratedField("UnderlyingType", "Stock", "S"));
            _ObsEnumeratedField.Add(new EnumeratedField("UnderlyingType", "ExchangeRate", "X"));

            //DeltaProtectForMM
            _ObsEnumeratedField.Add(new EnumeratedField("DeltaProtectForMM", "ProtectionForMarketMakersEnabledAtAContractLevel", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("DeltaProtectForMM", "ProtectionForMarketMakersEnabledAtAContractAndExpiryLevel", "1"));

            //VegaProtectForMM
            _ObsEnumeratedField.Add(new EnumeratedField("VegaProtectForMM", "ProtectionForMarketMakersEnabledAtAContractLevel", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("VegaProtectForMM", "ProtectionForMarketMakersEnabledAtAContractAndExpiryLevel", "1"));

            //VolumeProtectForMM
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "ProtectionForMarketMakersEnabledAtAContractLevel", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "ProtectionForMarketMakersEnabledAtAContractAndExpiryLevel", "1"));

            //ContractTradingType
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "TradedAsAnOutright", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "NotTraded_ButListedInContractData_TradersMaySubscribeToIt", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "TradedAsASimpleInter_CommoditySpread", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("VolumeProtectForMM", "TradedAsAnInter_CommoditySpread", "4"));

            //OptionType
            _ObsEnumeratedField.Add(new EnumeratedField("OptionType", "Call", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("OptionType", "Put", "2"));

            //StrategyCode
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "JellyRoll", "A"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Butterfly", "B"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CallOrPutCabinet", "C"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Spread", "D"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CalendarSpread", "E"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "DiagonalCalendarSpread", "F"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Guts", "G"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "TwoByOneRatioSpread", "H"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "IronButterfly", "I"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Combo", "J"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Strangle", "K"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Ladder", "L"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Strip", "M"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "StraddleCalendarSpread", "N"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Pack", "O"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "DiagonalStraddleCalendarSpread", "P"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "SimpleInterCommoditySpread", "Q"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Conversion_OR_Reversal", "R"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Straddle", "S"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "VolatilityTrade", "V"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Condor", "W"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Box", "X"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Bundle", "Y"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "ReducedTickSpread", "Z"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "LadderVersusUnderlying", "a"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "ButterflyVersusUnderlying", "b"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CallSpreadVersusPutversusUnderlying", "c"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CallOrPutSpreadversusUnderlying", "d"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CallOrPutCalendarSpreadVersusUnderlying", "e"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Cal_OR_PutDiagonalCalendarSpreadVersusUnderlying", "f"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "GutsVersusUnderlying", "g"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "TwoByOneCallOrPutRatioSpreadVersusUnderlying", "h"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "IronButterflyVersusUnderlying", "i"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "ComboVersusUnderlying", "j"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "StrangleVersusUnderlying", "k"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "ExchangeForPhysical", "m"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "StraddleCalendarSpreadVersusUnderlying", "n"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "PutSpreadVersusCallVersusUnderlying", "p"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "DiagonalStraddleCalendarSpreadVersusUnderlying", "q"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "Synthetic", "r"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "StraddleVersusUnderlying", "s"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CondorVersusUnderlying", "t"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "BuyWrite", "u"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "IronCondorVersusUnderlying", "v"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "IronCondor", "w"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "CallSpreadVersusSellAPut", "x"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "PutSpreadVersusSellACall", "y"));
            _ObsEnumeratedField.Add(new EnumeratedField("StrategyCode", "PutStraddleVersusSellACallOrAPut", "z"));

            //LegBuyOrSell
            _ObsEnumeratedField.Add(new EnumeratedField("LegBuyOrSell", "Buy", "B"));
            _ObsEnumeratedField.Add(new EnumeratedField("LegBuyOrSell", "Sell", "S"));

            //InstrumentState
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Inaccessible", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Closed", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Call", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Uncrossing", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Continuous", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("InstrumentState", "Halted_UsedInMarketStatusChangeMessageOnly", "6"));

             //TradingPeriod
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "StandardOpening_CashAndDerivatives", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "StandardCore_CashAndDerivatives", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "StandardClosing_CashAndDerivatives", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "LateOpening_CashAndDerivatives", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "LateCore_CashAndDerivatives", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "LateClosing_CashAndDerivatives", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "EarlyOpening_ForFutureUse", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "EarlyCore_ForFutureUse", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingPeriod", "EarlyClosing_ForFutureUse", "9"));

            //TradingSide
            _ObsEnumeratedField.Add(new EnumeratedField("TradingSide", "BidOnly_CashOnly", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingSide", "OfferOnly_CashOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradingSide", "PAKO_CashOnly", "3"));

            //PriceLimits
            _ObsEnumeratedField.Add(new EnumeratedField("PriceLimits", "PriceLimitsEnabled_Normal_DerivativesOnly", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("PriceLimits", "PriceLimitsEnabled_Wide_DerivativesOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("PriceLimits", "Price_Limits_Enabled_Widest_DerivativesOnly", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("PriceLimits", "Price_Limits_Disabled_DerivativesOnly", "4"));

            //QuoteSpreadMultiplier
            _ObsEnumeratedField.Add(new EnumeratedField("QuoteSpreadMultiplier", "QuoteSpreadMultiplier1_DerivativesOnly", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("QuoteSpreadMultiplier", "QuoteSpreadMultiplier2_DerivativesOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("QuoteSpreadMultiplier", "QuoteSpreadMultiplier3_DerivativesOnly", "3"));

            //OrderEntryQualifier
            _ObsEnumeratedField.Add(new EnumeratedField("OrderEntryQualifier", "OrderEntry_OR_Cancel_OR_ModifyDisabled", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderEntryQualifier", "OrderEntry_OR_Cancel_OR_ModifyEnabled", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderEntryQualifier", "CancelAndModifyOnly_DerivativesOnly", "2"));

            //Session
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session0", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session1", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session2", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session3", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session4", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session5", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session6", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session7", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session8", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("Session", "Session9", "9"));

            //MarketDataUpdateType
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "BestBid_CashAndDerivatives", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "BestOffer_CashAndDerivatives", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "NewBid_CashAndDerivatives", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "NewOffer_CashAndDerivatives", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "UpdatedBid_CashAndDerivatives", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "UpdatedOffer_CashAndDerivatives", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "TotalTradedVolume_DerivativesOnly", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ImpliedBid_DerivativesOnly", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ImpliedOffer_DerivativesOnly", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForQuote_CashAndDerivatives", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForQuoteBid_Cash", "11"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForSize_Cash", "12"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForQuoteOffer_Cash", "13"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "HighDynamicCollar_CashOnly", "14"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "LowDynamicCollar_CashOnly", "15"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "None1", "16"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ConventionalTrade_CashAndDerivatives", "24"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForCross_RFC_Queued_DerivativesOnly", "25"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForCross_RFC_DerivativesOnly", "26"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "LargeinScale_LiS_Trade_DerivativesOnly", "27"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "BasisTrade_DerivativesOnly", "28"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "LargeInScale_LiS_PackageTrade_DerivativesOnly", "29"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "GuaranteedCrossTrade_CashAndDerivatives", "30"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "AgainstActualTrade_Derivatives_Only", "31"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "AssetAllocationTrade_DerivativesOnly", "32"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ExchangeForSwapTrade_DerivativesOnly", "34"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "None2", "35"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ExchangeForPhysicalTrade_CashLeg_DerivativesOnly", "36"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegConventionalTrade_DerivativesOnly", "37"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegLargeinScale_LiS_Trade_DerivativesOnly", "38"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegBasisTrade_DerivativesOnly", "39"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegGuaranteedCrossTrade_DerivativesOnly", "40"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegAgainstActualTrade_DerivativesOnly", "41"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegAssetAllocationTrade_DerivativesOnly", "42"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegExchangeForSwapTrade_DerivativesOnly", "44"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "StrategyLegExchangeForPhysicalTrade_DerivativesOnly", "45"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "TradeCancellation_CashAndDerivatives", "50"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "OutOfMarketTrade_CashOnly", "51"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "DeltaNeutralTrade_UnderlyingCashLeg_CashOnly", "52"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "DeltaNeutralTrade_UnderlyingFutureLeg_DerivativesOnly", "53"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "SecondaryListingTrade_CashOnly", "55"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForCrossTrade_DerivativesOnly", "56"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForCrossStrategyLegTrade_DerivativesOnly", "57"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "NewBidWithLiquidityProvider_CashOnly", "58"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "NewOfferWithLiquidityProvider_CashOnly", "59"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "UpdatedBidWithLiquidityProvider_CashOnly", "60"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "UpdatedOfferWithLiquidityProvider_CashOnly", "61"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "HiddenQuantityTrade_CashOnly", "62"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "LowStaticCollar_CashOnly", "63"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "HighStaticCollar_CashOnly", "64"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "MarketVWAPOperationTrade", "65"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForSizeBid_Cash", "66"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "RequestForSizeOffer_Cash", "67"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataUpdateType", "ClearBook_CashAndDerivatives", "254"));

            //MarketDataActionType
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataActionType", "NewOrder", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataActionType", "DeletionOfOrderIdentifiedByOrderReferenceNumber", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataActionType", "DeletionOfAllOrdersForTheGivenInstrument_DependingOnTheSide_IfSideIsNotProvided_AND_ItMeansBoth", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataActionType", "ModificationOfExistingOrder", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataActionType", "RetransmissionOfAllOrdersForTheGivenInstrument", "5"));

            //OrderType
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "Market", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "Limit", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "Stop_OR_StopOnQuote", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "StopLimit_OR_StopOnQuoteLimit", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "PrimaryPeg", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "MarketToLimit_OR_MarketOnOpening", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "MarketPeg", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderType", "Mid_PointPeg", "8"));

            //OrderSide
            _ObsEnumeratedField.Add(new EnumeratedField("OrderSide", "Buy", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderSide", "Sell", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("OrderSide", "Cross", "3"));

            //MarketDataPriceType
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "ProvisionalDaily_DerivativesOnly", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "OfficialDaily_DerivativesOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "ProvisionalMarketClose_DerivativesOnly", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "OfficialMarketClose_DerivativesOnly", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "ProvisionalExpiry_DerivativesOnly", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "OfficialExpiry_DerivativesOnly", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "ProvisionalIntraday_DerivativesOnly", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "OfficialIntraday_DerivativesOnly", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "OfficialYDSP_CashAndDerivatives", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "NetAssetValue_Plus_OR_Minus_ForTheInstrumentsEligibleToTheNAVTradingFacility_CashOnly", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "NewLastPrice_CashOnly", "11"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "AdjustedClosingPrice_CashOnly", "12"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "SubscriptionPrice_CashOnly", "13"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "IndicativeMatchingPrice_CashAndDerivatives", "14"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "MinPriceOutOfSessionTrades_CashOnly", "19"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "MaxPriceOutOfSessionTrades_CashOnly", "20"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "MinPriceOutOfSessionBlockTrades_CashOnly", "21"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "MaxPriceOutOfSessionBlockTrades_CashOnly", "22"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "ValuationPrice_CashOnly", "23"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "FundSubscription_CashOnly", "24"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "FundRedemption_CashOnly", "25"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "UncrossingPrice_CashAndDerivatives", "26"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "LastTradedPrice_CashAndDerivatives", "27"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataPriceType", "AlternativeIndicativePrice_AIP_CashOnly", "28"));

            //ImbalanceQuantitySide
            _ObsEnumeratedField.Add(new EnumeratedField("ImbalanceQuantitySide", "NoImbalance", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("ImbalanceQuantitySide", "Buy", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("ImbalanceQuantitySide", "Sell", "2"));

            //TradeType
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "ConventionalTrade_CashAndDerivatives", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "LargeInScale_LiS_Trade_DerivativesOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "BasisTrade_DerivativesOnly", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "LargeInScale_LiS_PackageTrade_DerivativesOnly", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "GuaranteedCrossTrade_CashAndDerivatives", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "AgainstActualTrade_DerivativesOnly", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "AssetAllocationTrade_DerivativesOnly", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "ExchangeForSwapTrade_DerivativesOnly", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "ExchangeForPhysicalTrade_CashLeg_DerivativesOnly", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_ConventionalTrade_DerivativesOnly", "11"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_LargeInScale_LiS_Trade_DerivativesOnly", "12"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_BasisTrade_DerivativesOnly", "13"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_GuaranteedCrossTrade_DerivativesOnly", "14"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_AgainstActualTrade_DerivativesOnly", "15"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_AssetAllocationTrade_DerivativesOnly", "16"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_ExchangeForSwapTrade_DerivativesOnly", "18"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Strategy_Leg_ExchangeForPhysicalTrade_DerivativesOnly", "19"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "None1", "20"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "ValuationTrade_CashOnly", "23"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "TradeCancellation_CashOnly", "24"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "OutOfMarketTrade_CashOnly", "25"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "DeltaNeutralTrade_CashLeg_CashAndDerivatives", "26"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "MarketVWAPOperationTrade_CashOnly", "27"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "None2", "28"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "SecondaryListingTrade_CashOnly", "29"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "RequestForCrossTrade_DerivativesOnly", "30"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "RequestForCrossStrategyLegTrade_DerivativesOnly", "31"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "TradePublication_CashOnly", "32"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "None3", "33"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Delta Neutral Trade - Future Leg (Cash and Derivatives)", "34"));
            _ObsEnumeratedField.Add(new EnumeratedField("TradeType", "Total Traded Volume (Derivatives Only)", "36"));

            //TransactionType
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "PlainVanillaTrade", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "None", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "BenchmarkTrade", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "TechnicalTrade", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "Give_Up_OR_Give_InTrade", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "Ex_OR_CumDividendTrade", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "TradeWithCondition", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransactionType", "SummaryReport", "15"));

            //BlockTradeCode
            _ObsEnumeratedField.Add(new EnumeratedField("BlockTradeCode", "BlockTrade", "B"));
            _ObsEnumeratedField.Add(new EnumeratedField("BlockTradeCode", "RegularTradeOrNegotiatedDeal", "N"));
            _ObsEnumeratedField.Add(new EnumeratedField("BlockTradeCode", "Hyphen_Undefined", "-"));

            //TransparencyIndicator
            _ObsEnumeratedField.Add(new EnumeratedField("TransparencyIndicator", "Lit_OR_RegularTrade", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("TransparencyIndicator", "ImmediatePublication", "1"));

            //MarketDataChangeType
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataChangeType", "StatusChanges", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataChangeType", "ScheduledEventNotification", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("MarketDataChangeType", "StatusChangesAndScheduledEventNotification", "2"));

            //StatusReason
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "Scheduled_CashAndDerivatives", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "SuspensionByMarketOperations_CashAndDerivatives", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "UnhaltedByMarketOperations_CashOnly", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "Suspension_CashOnly", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "CollarsBreach_CashOnly", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "AutomaticHaltingByMatchingEngine_CashOnly", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "AutomaticUnhaltingByMatchingEngine_CashOnly", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "NoLiquidityProvider_CashOnly", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "Knock_InByIssuerCashOnly", "11"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "Knock_OutByExchange_CashOnly", "12"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "Knock_OutByIssuer_CashOnly", "13"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "ActionByMarketOperations_CashAndDerivatives", "15"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "WaitingForTradableState_DerivativesOnly", "16"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "UncrossingByMarketOperations_CashAndDerivatives", "17"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "ClosingDueToSuspendedUnderlying_CashAndDerivatives", "18"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatusReason", "ClosingDueToHaltedUnderlying_DerivativesOnly", "19"));

            //ScheduledEvent
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "CancelPreviouslyScheduledEvent_CashAndDerivatives", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "Unhalt_CashOnly", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "Closed_CashAndDerivatives", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "Expiry_DerivativesOnly", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None1", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None2", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None3", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None4", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None5", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("ScheduledEvent", "None6", "11"));

            //StatsUpdateType
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "DailyHigh_CashAndDerivatives", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "DailyLow_CashAndDerivatives", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "YearlyHigh_CashAndDerivatives", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "YearlyLow_CashAndDerivatives", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "LifetimeHigh_CashAndDerivatives", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "LifetimeLow_CashAndDerivatives", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "VariationLastPrice_CashAndDerivatives", "14"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OpenPrice_CashAndDerivatives", "15"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "TradeCount_CashAndDerivatives", "16"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "LastTradePrice_CashAndDerivatives", "17"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "PercentVariationPreviousClose_CashAndDerivatives", "18"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OffBookCumulativeQuantity_Cash", "19"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OffExchangeCumulativeQuantity_Cash", "20"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OnBookAuctionCumulativeQuantity_Cash", "21"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OnbookContinuousCumulativeQuantity_Cash", "22"));
            _ObsEnumeratedField.Add(new EnumeratedField("StatsUpdateType", "OnandOffBookCumulativeQuantity_CashAndDerivatives", "23"));

            //IndexLevelType
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "IndicativeIndex", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "OfficialOpeningIndex", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "Real_TimeIndex", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "AutomaticIndicativeIndex", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "Preliminary_ReferenceIndex", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "ClosingReferenceIndex", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "Confirmed_ReferenceIndex", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexLevelType", "OptionsLiquidationIndex", "7"));

            //IndexPriceCode
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "OnlyIndex", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "IndexAndSessionHigh", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "IndexAndSessionLow", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "IndexAndSessionHighAndLow_TypicallyFirstPrice", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "OnlySessionHigh", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "OnlySessionLow", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("IndexPriceCode", "PreviousDayClose", "6"));

            //ExchangeMarketMechanism_OEG
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Equities Central Order Book", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "ETFs Central Order Book", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Bonds Central Order Book", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Warrants Central Order Book", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Equities Blocks/OTC", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Initial Public Offering (IPO)", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Equities Buy-in", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Equities Lending and Borrowing", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExchangeMarketMechanism_OEG", "Derivatives Central Order Book", "9"));

            //AckType
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "New Order Ack", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Replace Ack", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Order Creation By Market Operations", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Stop Triggered Ack [C]", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Collar Confirmation Ack [C]", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Refilled Iceberg Ack [C]", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "MTL Second Ack [C]", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Knock-In By Issuer (KIBI) Ack [C]", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Knock-Out By Issuer (KOBI) Ack [C]", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Payment After Knock-Out (PAKO) Ack [C]", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Price Input Ack [C]", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "RFQ Ack [C]", "11"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Bid Only Ack [C]", "12"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckType", "Offer Only Ack [C]", "13"));

            //AckPhase
            _ObsEnumeratedField.Add(new EnumeratedField("AckPhase", "Continuous Trading Phase", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckPhase", "Call Trading Phase", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckPhase", "Halt Phase [C]", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckPhase", "Closed Phase", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("AckPhase", "Trading At Last Phase", "5"));

            //ExecutionPhase
            _ObsEnumeratedField.Add(new EnumeratedField("ExecutionPhase", "Continuous Trading Phase", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExecutionPhase", "Uncrossing Phase", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("ExecutionPhase", "Trading At Last Phase", "3"));

            //LegSide
            _ObsEnumeratedField.Add(new EnumeratedField("LegSide", "Buy", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("LegSide", "Sell", "2"));

            //LogonRejectCode
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Unknown Connection Identifier", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "System unavailable", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Invalid sequence number", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Client session already logged on", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Client session disabled", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Connection type mismatch", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("LogonRejectCode", "Connection does not match port", "7"));

            //KillReason
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Order Cancelled", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Order Expired", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Order Cancelled by Market Operations", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Order Eliminated due to Corporate Event", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Done for day", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Cancelled MTL in an empty Order Book [C]", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Remaining quantity killed (IOC)", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Beginning of PAKO Period [C]", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Too many Collar Breach Confirmations [C]", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("KillReason", "Order Cancelled due to Cancel On Disconnect Mechanism", "11"));

            //CollarRejectionType
            _ObsEnumeratedField.Add(new EnumeratedField("CollarRejectionType", "Low collar", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("CollarRejectionType", "High collar", "2"));

            //AccountType
            _ObsEnumeratedField.Add(new EnumeratedField("AccountType", "Client", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("AccountType", "House", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("AccountType", "Liquidity Provider", "6"));

            //LPRole
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Liquidity Provider or Market Maker", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Supplementary Liquidity Provider [C]", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Retail Liquidity Provider Order [C]", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "MMP [C]", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Primary Market Maker [D]", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Extra Competitive Market Maker [D]", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Competitive Market Maker [D]", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Primary Liquidity Provider [D]", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Responding Market Maker [D]", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("LPRole", "Designated Market Maker [D]", "11"));

            //BuyRevisionIndicator
            _ObsEnumeratedField.Add(new EnumeratedField("BuyRevisionIndicator", "New [C]", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("BuyRevisionIndicator", "Replacement", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("BuyRevisionIndicator", "Cancellation", "2"));

            //TimeInForce
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Day", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Good Till Cancel", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Valid for Uncrossing [C]", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Immediate or Cancel", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Fill or Kill", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Good till Time [C]", "5"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Good till Date", "6"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Valid for Closing Uncrossing [C]", "7"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "For Future Use [C]", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("TimeInForce", "Good Till Month (GTM) [C]", "10"));

            //TechnicalOrigin
            _ObsEnumeratedField.Add(new EnumeratedField("TechnicalOrigin", "Index trading arbitrage", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("TechnicalOrigin", "Portfolio strategy", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("TechnicalOrigin", "Unwind order", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("TechnicalOrigin", "Other orders (default)", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("TechnicalOrigin", "Cross margining", "5"));

            //ClearingInstruction
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Process normally [C]", "0"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Manual mode", "8"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Automatic posting mode", "9"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Automatic give-up mode [C]", "10"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Automatic and account authorization [D]", "4008"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Manual and account authorization [D]", "4009"));
            _ObsEnumeratedField.Add(new EnumeratedField("ClearingInstruction", "Give-up to single firm [D]", "4010"));

            //AccountTypeCross
            _ObsEnumeratedField.Add(new EnumeratedField("AccountTypeCross", "Client", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("AccountTypeCross", "House", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("AccountTypeCross", "Liquidity Provider", "6"));

            //AFQReason
            _ObsEnumeratedField.Add(new EnumeratedField("AFQReason", "Quote cancelled by the Liquidity Provider", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("AFQReason", "Quote cancelled by Market Control", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("AFQReason", "No quote M minutes before an uncrossing", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("AFQReason", "No quote S seconds before an uncrossing", "4"));
            _ObsEnumeratedField.Add(new EnumeratedField("AFQReason", "Quote completely matched", "5"));

            //RFQUpdateType
            _ObsEnumeratedField.Add(new EnumeratedField("RFQUpdateType", "New", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("RFQUpdateType", "Cancelled by the RFQ issuer", "2"));
            _ObsEnumeratedField.Add(new EnumeratedField("RFQUpdateType", "Expired", "3"));
            _ObsEnumeratedField.Add(new EnumeratedField("RFQUpdateType", "Partially or Fully Matched", "4"));

            //RecipientType
            _ObsEnumeratedField.Add(new EnumeratedField("RecipientType", "RFQ Issuer", "1"));
            _ObsEnumeratedField.Add(new EnumeratedField("RecipientType", "RFQ recipient (LP)", "2"));

        }
    }
}
