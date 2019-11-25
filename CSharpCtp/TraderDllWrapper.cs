using System;
using System.Runtime.InteropServices;


namespace CSharpCtp.Trader
{
    public class TraderDllWrapper
	{
		[DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "CreateTrader",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void CreateTrader(ref TraderInfo traderInfo, out IntPtr phandler);        

        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyTrader",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyTrader(out IntPtr phandler);

		[DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ConnectTrader",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ConnectTrader(IntPtr phandler);

        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "DisconnectTrader",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int DisconnectTrader(IntPtr phandler);

        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "GetTradingDay",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern String GetTradingDay(IntPtr phandler);

        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLogin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLogin(IntPtr phandler, ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLogout",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLogout(IntPtr phandler, ref CThostFtdcUserLogoutField pUserLogout, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserPasswordUpdate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserPasswordUpdate(IntPtr phandler, ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqTradingAccountPasswordUpdate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqTradingAccountPasswordUpdate(IntPtr phandler, ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserAuthMethod",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserAuthMethod(IntPtr phandler, ref CThostFtdcReqUserAuthMethodField pReqUserAuthMethod, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqGenUserCaptcha",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqGenUserCaptcha(IntPtr phandler, ref CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqGenUserText",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqGenUserText(IntPtr phandler, ref CThostFtdcReqGenUserTextField pReqGenUserText, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLoginWithCaptcha",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLoginWithCaptcha(IntPtr phandler, ref CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLoginWithText",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLoginWithText(IntPtr phandler, ref CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLoginWithOTP",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLoginWithOTP(IntPtr phandler, ref CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqOrderInsert(IntPtr phandler, ref CThostFtdcInputOrderField pInputOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqParkedOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqParkedOrderInsert(IntPtr phandler, ref CThostFtdcParkedOrderField pParkedOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqParkedOrderAction(IntPtr phandler, ref CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqOrderAction(IntPtr phandler, ref CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQueryMaxOrderVolume",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQueryMaxOrderVolume(IntPtr phandler, ref CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqSettlementInfoConfirm",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqSettlementInfoConfirm(IntPtr phandler, ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqRemoveParkedOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqRemoveParkedOrder(IntPtr phandler, ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqRemoveParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqRemoveParkedOrderAction(IntPtr phandler, ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqExecOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqExecOrderInsert(IntPtr phandler, ref CThostFtdcInputExecOrderField pInputExecOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqExecOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqExecOrderAction(IntPtr phandler, ref CThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqForQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqForQuoteInsert(IntPtr phandler, ref CThostFtdcInputForQuoteField pInputForQuote, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQuoteInsert(IntPtr phandler, ref CThostFtdcInputQuoteField pInputQuote, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQuoteAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQuoteAction(IntPtr phandler, ref CThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqBatchOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqBatchOrderAction(IntPtr phandler, ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqOptionSelfCloseInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqOptionSelfCloseInsert(IntPtr phandler, ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqOptionSelfCloseAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqOptionSelfCloseAction(IntPtr phandler, ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqCombActionInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqCombActionInsert(IntPtr phandler, ref CThostFtdcInputCombActionField pInputCombAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryOrder(IntPtr phandler, ref CThostFtdcQryOrderField pQryOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTrade",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTrade(IntPtr phandler, ref CThostFtdcQryTradeField pQryTrade, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestorPosition",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestorPosition(IntPtr phandler, ref CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTradingAccount",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTradingAccount(IntPtr phandler, ref CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestor",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestor(IntPtr phandler, ref CThostFtdcQryInvestorField pQryInvestor, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTradingCode",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTradingCode(IntPtr phandler, ref CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInstrumentMarginRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInstrumentMarginRate(IntPtr phandler, ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInstrumentCommissionRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInstrumentCommissionRate(IntPtr phandler, ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryExchange",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryExchange(IntPtr phandler, ref CThostFtdcQryExchangeField pQryExchange, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryProduct",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryProduct(IntPtr phandler, ref CThostFtdcQryProductField pQryProduct, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInstrument",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInstrument(IntPtr phandler, ref CThostFtdcQryInstrumentField pQryInstrument, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryDepthMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryDepthMarketData(IntPtr phandler, ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySettlementInfo",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySettlementInfo(IntPtr phandler, ref CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTransferBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTransferBank(IntPtr phandler, ref CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestorPositionDetail",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestorPositionDetail(IntPtr phandler, ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryNotice",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryNotice(IntPtr phandler, ref CThostFtdcQryNoticeField pQryNotice, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySettlementInfoConfirm",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySettlementInfoConfirm(IntPtr phandler, ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestorPositionCombineDetail",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestorPositionCombineDetail(IntPtr phandler, ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryCFMMCTradingAccountKey",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryCFMMCTradingAccountKey(IntPtr phandler, ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryEWarrantOffset",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryEWarrantOffset(IntPtr phandler, ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestorProductGroupMargin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestorProductGroupMargin(IntPtr phandler, ref CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryExchangeMarginRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryExchangeMarginRate(IntPtr phandler, ref CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryExchangeMarginRateAdjust",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryExchangeMarginRateAdjust(IntPtr phandler, ref CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryExchangeRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryExchangeRate(IntPtr phandler, ref CThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySecAgentACIDMap",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySecAgentACIDMap(IntPtr phandler, ref CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryProductExchRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryProductExchRate(IntPtr phandler, ref CThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryProductGroup",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryProductGroup(IntPtr phandler, ref CThostFtdcQryProductGroupField pQryProductGroup, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryMMInstrumentCommissionRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryMMInstrumentCommissionRate(IntPtr phandler, ref CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryMMOptionInstrCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryMMOptionInstrCommRate(IntPtr phandler, ref CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInstrumentOrderCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInstrumentOrderCommRate(IntPtr phandler, ref CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySecAgentTradingAccount",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySecAgentTradingAccount(IntPtr phandler, ref CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySecAgentCheckMode",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySecAgentCheckMode(IntPtr phandler, ref CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQrySecAgentTradeInfo",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQrySecAgentTradeInfo(IntPtr phandler, ref CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryOptionInstrTradeCost",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryOptionInstrTradeCost(IntPtr phandler, ref CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryOptionInstrCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryOptionInstrCommRate(IntPtr phandler, ref CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryExecOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryExecOrder(IntPtr phandler, ref CThostFtdcQryExecOrderField pQryExecOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryForQuote",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryForQuote(IntPtr phandler, ref CThostFtdcQryForQuoteField pQryForQuote, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryQuote",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryQuote(IntPtr phandler, ref CThostFtdcQryQuoteField pQryQuote, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryOptionSelfClose",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryOptionSelfClose(IntPtr phandler, ref CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryInvestUnit",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryInvestUnit(IntPtr phandler, ref CThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryCombInstrumentGuard",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryCombInstrumentGuard(IntPtr phandler, ref CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryCombAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryCombAction(IntPtr phandler, ref CThostFtdcQryCombActionField pQryCombAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTransferSerial",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTransferSerial(IntPtr phandler, ref CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryAccountregister",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryAccountregister(IntPtr phandler, ref CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryContractBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryContractBank(IntPtr phandler, ref CThostFtdcQryContractBankField pQryContractBank, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryParkedOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryParkedOrder(IntPtr phandler, ref CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryParkedOrderAction(IntPtr phandler, ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryTradingNotice",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryTradingNotice(IntPtr phandler, ref CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryBrokerTradingParams",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryBrokerTradingParams(IntPtr phandler, ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQryBrokerTradingAlgos",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQryBrokerTradingAlgos(IntPtr phandler, ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQueryCFMMCTradingAccountToken",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQueryCFMMCTradingAccountToken(IntPtr phandler, ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqFromBankToFutureByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqFromBankToFutureByFuture(IntPtr phandler, ref CThostFtdcReqTransferField pReqTransfer, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqFromFutureToBankByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqFromFutureToBankByFuture(IntPtr phandler, ref CThostFtdcReqTransferField pReqTransfer, int nRequestID);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "ReqQueryBankAccountMoneyByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqQueryBankAccountMoneyByFuture(IntPtr phandler, ref CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID);
        

        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnFrontConnected",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnFrontConnectedCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnFrontConnectedDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnFrontDisconnected",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnFrontDisconnectedCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnFrontDisconnectedDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnHeartBeatWarning",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnHeartBeatWarningCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnHeartBeatWarningDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspAuthenticate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspAuthenticateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspAuthenticateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspUserLogin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserLoginCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserLoginDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspUserLogout",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserLogoutCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserLogoutDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspUserPasswordUpdate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserPasswordUpdateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserPasswordUpdateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspTradingAccountPasswordUpdate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspTradingAccountPasswordUpdateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspTradingAccountPasswordUpdateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspUserAuthMethod",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserAuthMethodCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserAuthMethodDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspGenUserCaptcha",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspGenUserCaptchaCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspGenUserCaptchaDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspGenUserText",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspGenUserTextCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspGenUserTextDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspOrderInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspOrderInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspParkedOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspParkedOrderInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspParkedOrderInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspParkedOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspParkedOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQueryMaxOrderVolume",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQueryMaxOrderVolumeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQueryMaxOrderVolumeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspSettlementInfoConfirm",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspSettlementInfoConfirmCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspSettlementInfoConfirmDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspRemoveParkedOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspRemoveParkedOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspRemoveParkedOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspRemoveParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspRemoveParkedOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspRemoveParkedOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspExecOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspExecOrderInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspExecOrderInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspExecOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspExecOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspExecOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspForQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspForQuoteInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspForQuoteInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQuoteInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQuoteInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQuoteAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQuoteActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQuoteActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspBatchOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspBatchOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspBatchOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspOptionSelfCloseInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspOptionSelfCloseInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspOptionSelfCloseInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspOptionSelfCloseAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspOptionSelfCloseActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspOptionSelfCloseActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspCombActionInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspCombActionInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspCombActionInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTrade",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTradeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTradeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestorPosition",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestorPositionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestorPositionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTradingAccount",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTradingAccountCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTradingAccountDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestor",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestorCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestorDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTradingCode",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTradingCodeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTradingCodeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInstrumentMarginRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInstrumentMarginRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInstrumentMarginRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInstrumentCommissionRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInstrumentCommissionRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInstrumentCommissionRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryExchange",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryExchangeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryExchangeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryProduct",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryProductCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryProductDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInstrument",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInstrumentCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInstrumentDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryDepthMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryDepthMarketDataCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryDepthMarketDataDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySettlementInfo",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySettlementInfoCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySettlementInfoDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTransferBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTransferBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTransferBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestorPositionDetail",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestorPositionDetailCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestorPositionDetailDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryNotice",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryNoticeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryNoticeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySettlementInfoConfirm",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySettlementInfoConfirmCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySettlementInfoConfirmDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestorPositionCombineDetail",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestorPositionCombineDetailCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestorPositionCombineDetailDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryCFMMCTradingAccountKey",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryCFMMCTradingAccountKeyCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryCFMMCTradingAccountKeyDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryEWarrantOffset",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryEWarrantOffsetCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryEWarrantOffsetDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestorProductGroupMargin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestorProductGroupMarginCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestorProductGroupMarginDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryExchangeMarginRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryExchangeMarginRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryExchangeMarginRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryExchangeMarginRateAdjust",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryExchangeMarginRateAdjustCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryExchangeMarginRateAdjustDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryExchangeRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryExchangeRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryExchangeRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySecAgentACIDMap",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySecAgentACIDMapCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySecAgentACIDMapDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryProductExchRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryProductExchRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryProductExchRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryProductGroup",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryProductGroupCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryProductGroupDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryMMInstrumentCommissionRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryMMInstrumentCommissionRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryMMInstrumentCommissionRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryMMOptionInstrCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryMMOptionInstrCommRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryMMOptionInstrCommRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInstrumentOrderCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInstrumentOrderCommRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInstrumentOrderCommRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySecAgentTradingAccount",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySecAgentTradingAccountCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySecAgentTradingAccountDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySecAgentCheckMode",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySecAgentCheckModeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySecAgentCheckModeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQrySecAgentTradeInfo",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQrySecAgentTradeInfoCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQrySecAgentTradeInfoDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryOptionInstrTradeCost",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryOptionInstrTradeCostCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryOptionInstrTradeCostDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryOptionInstrCommRate",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryOptionInstrCommRateCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryOptionInstrCommRateDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryExecOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryExecOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryExecOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryForQuote",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryForQuoteCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryForQuoteDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryQuote",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryQuoteCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryQuoteDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryOptionSelfClose",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryOptionSelfCloseCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryOptionSelfCloseDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryInvestUnit",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryInvestUnitCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryInvestUnitDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryCombInstrumentGuard",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryCombInstrumentGuardCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryCombInstrumentGuardDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryCombAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryCombActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryCombActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTransferSerial",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTransferSerialCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTransferSerialDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryAccountregister",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryAccountregisterCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryAccountregisterDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspError",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspErrorCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspErrorDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnTrade",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnTradeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnTradeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnOrderInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnOrderInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnInstrumentStatus",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnInstrumentStatusCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnInstrumentStatusDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnBulletin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnBulletinCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnBulletinDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnTradingNotice",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnTradingNoticeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnTradingNoticeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnErrorConditionalOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnErrorConditionalOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnErrorConditionalOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnExecOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnExecOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnExecOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnExecOrderInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnExecOrderInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnExecOrderInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnExecOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnExecOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnExecOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnForQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnForQuoteInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnForQuoteInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnQuote",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnQuoteCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnQuoteDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnQuoteInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnQuoteInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnQuoteInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnQuoteAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnQuoteActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnQuoteActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnForQuoteRspCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnForQuoteRspDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnCFMMCTradingAccountToken",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnCFMMCTradingAccountTokenCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnCFMMCTradingAccountTokenDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnBatchOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnBatchOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnBatchOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnOptionSelfClose",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnOptionSelfCloseCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnOptionSelfCloseDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnOptionSelfCloseInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnOptionSelfCloseInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnOptionSelfCloseInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnOptionSelfCloseAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnOptionSelfCloseActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnOptionSelfCloseActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnCombAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnCombActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnCombActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnCombActionInsert",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnCombActionInsertCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnCombActionInsertDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryContractBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryContractBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryContractBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryParkedOrder",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryParkedOrderCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryParkedOrderDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryParkedOrderAction",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryParkedOrderActionCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryParkedOrderActionDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryTradingNotice",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryTradingNoticeCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryTradingNoticeDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryBrokerTradingParams",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryBrokerTradingParamsCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryBrokerTradingParamsDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQryBrokerTradingAlgos",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQryBrokerTradingAlgosCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQryBrokerTradingAlgosDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQueryCFMMCTradingAccountToken",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQueryCFMMCTradingAccountTokenCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQueryCFMMCTradingAccountTokenDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnFromBankToFutureByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnFromBankToFutureByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnFromBankToFutureByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnFromFutureToBankByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnFromFutureToBankByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnFromFutureToBankByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromBankToFutureByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromBankToFutureByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromBankToFutureByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromFutureToBankByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromFutureToBankByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromFutureToBankByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnFromBankToFutureByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnFromBankToFutureByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnFromBankToFutureByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnFromFutureToBankByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnFromFutureToBankByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnFromFutureToBankByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromBankToFutureByFutureManual",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromBankToFutureByFutureManualCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromBankToFutureByFutureManualDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromFutureToBankByFutureManual",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromFutureToBankByFutureManualCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromFutureToBankByFutureManualDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnQueryBankBalanceByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnQueryBankBalanceByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnQueryBankBalanceByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnBankToFutureByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnBankToFutureByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnBankToFutureByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnFutureToBankByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnFutureToBankByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnFutureToBankByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnRepealBankToFutureByFutureManual",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnRepealBankToFutureByFutureManualCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnRepealBankToFutureByFutureManualDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnRepealFutureToBankByFutureManual",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnRepealFutureToBankByFutureManualCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnRepealFutureToBankByFutureManualDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnErrRtnQueryBankBalanceByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnErrRtnQueryBankBalanceByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnErrRtnQueryBankBalanceByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromBankToFutureByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromBankToFutureByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromBankToFutureByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnRepealFromFutureToBankByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnRepealFromFutureToBankByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnRepealFromFutureToBankByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspFromBankToFutureByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspFromBankToFutureByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspFromBankToFutureByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspFromFutureToBankByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspFromFutureToBankByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspFromFutureToBankByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRspQueryBankAccountMoneyByFuture",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspQueryBankAccountMoneyByFutureCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspQueryBankAccountMoneyByFutureDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnOpenAccountByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnOpenAccountByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnOpenAccountByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnCancelAccountByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnCancelAccountByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnCancelAccountByBankDelegate callback);
        
        [DllImport("cctp_trader.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterTradeFPOnRtnChangeAccountByBank",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnChangeAccountByBankCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnChangeAccountByBankDelegate callback);
        
	}
}
