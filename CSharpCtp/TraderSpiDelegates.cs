using System;
using System.Runtime.InteropServices;

namespace CSharpCtp.Trader
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnFrontConnectedDelegate ();
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnFrontDisconnectedDelegate (int nReason);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnHeartBeatWarningDelegate (int nTimeLapse);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspAuthenticateDelegate (IntPtr pRspAuthenticateField, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserLoginDelegate (IntPtr pRspUserLogin, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserLogoutDelegate (IntPtr pUserLogout, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserPasswordUpdateDelegate (IntPtr pUserPasswordUpdate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspTradingAccountPasswordUpdateDelegate (IntPtr pTradingAccountPasswordUpdate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserAuthMethodDelegate (IntPtr pRspUserAuthMethod, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspGenUserCaptchaDelegate (IntPtr pRspGenUserCaptcha, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspGenUserTextDelegate (IntPtr pRspGenUserText, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspOrderInsertDelegate (IntPtr pInputOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspParkedOrderInsertDelegate (IntPtr pParkedOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspParkedOrderActionDelegate (IntPtr pParkedOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspOrderActionDelegate (IntPtr pInputOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQueryMaxOrderVolumeDelegate (IntPtr pQueryMaxOrderVolume, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspSettlementInfoConfirmDelegate (IntPtr pSettlementInfoConfirm, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspRemoveParkedOrderDelegate (IntPtr pRemoveParkedOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspRemoveParkedOrderActionDelegate (IntPtr pRemoveParkedOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspExecOrderInsertDelegate (IntPtr pInputExecOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspExecOrderActionDelegate (IntPtr pInputExecOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspForQuoteInsertDelegate (IntPtr pInputForQuote, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQuoteInsertDelegate (IntPtr pInputQuote, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQuoteActionDelegate (IntPtr pInputQuoteAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspBatchOrderActionDelegate (IntPtr pInputBatchOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspOptionSelfCloseInsertDelegate (IntPtr pInputOptionSelfClose, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspOptionSelfCloseActionDelegate (IntPtr pInputOptionSelfCloseAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspCombActionInsertDelegate (IntPtr pInputCombAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryOrderDelegate (IntPtr pOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTradeDelegate (IntPtr pTrade, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestorPositionDelegate (IntPtr pInvestorPosition, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTradingAccountDelegate (IntPtr pTradingAccount, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestorDelegate (IntPtr pInvestor, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTradingCodeDelegate (IntPtr pTradingCode, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInstrumentMarginRateDelegate (IntPtr pInstrumentMarginRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInstrumentCommissionRateDelegate (IntPtr pInstrumentCommissionRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryExchangeDelegate (IntPtr pExchange, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryProductDelegate (IntPtr pProduct, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInstrumentDelegate (IntPtr pInstrument, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryDepthMarketDataDelegate (IntPtr pDepthMarketData, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySettlementInfoDelegate (IntPtr pSettlementInfo, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTransferBankDelegate (IntPtr pTransferBank, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestorPositionDetailDelegate (IntPtr pInvestorPositionDetail, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryNoticeDelegate (IntPtr pNotice, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySettlementInfoConfirmDelegate (IntPtr pSettlementInfoConfirm, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestorPositionCombineDetailDelegate (IntPtr pInvestorPositionCombineDetail, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryCFMMCTradingAccountKeyDelegate (IntPtr pCFMMCTradingAccountKey, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryEWarrantOffsetDelegate (IntPtr pEWarrantOffset, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestorProductGroupMarginDelegate (IntPtr pInvestorProductGroupMargin, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryExchangeMarginRateDelegate (IntPtr pExchangeMarginRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryExchangeMarginRateAdjustDelegate (IntPtr pExchangeMarginRateAdjust, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryExchangeRateDelegate (IntPtr pExchangeRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySecAgentACIDMapDelegate (IntPtr pSecAgentACIDMap, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryProductExchRateDelegate (IntPtr pProductExchRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryProductGroupDelegate (IntPtr pProductGroup, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryMMInstrumentCommissionRateDelegate (IntPtr pMMInstrumentCommissionRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryMMOptionInstrCommRateDelegate (IntPtr pMMOptionInstrCommRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInstrumentOrderCommRateDelegate (IntPtr pInstrumentOrderCommRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySecAgentTradingAccountDelegate (IntPtr pTradingAccount, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySecAgentCheckModeDelegate (IntPtr pSecAgentCheckMode, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQrySecAgentTradeInfoDelegate (IntPtr pSecAgentTradeInfo, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryOptionInstrTradeCostDelegate (IntPtr pOptionInstrTradeCost, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryOptionInstrCommRateDelegate (IntPtr pOptionInstrCommRate, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryExecOrderDelegate (IntPtr pExecOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryForQuoteDelegate (IntPtr pForQuote, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryQuoteDelegate (IntPtr pQuote, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryOptionSelfCloseDelegate (IntPtr pOptionSelfClose, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryInvestUnitDelegate (IntPtr pInvestUnit, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryCombInstrumentGuardDelegate (IntPtr pCombInstrumentGuard, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryCombActionDelegate (IntPtr pCombAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTransferSerialDelegate (IntPtr pTransferSerial, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryAccountregisterDelegate (IntPtr pAccountregister, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspErrorDelegate (IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnOrderDelegate (IntPtr pOrder);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnTradeDelegate (IntPtr pTrade);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnOrderInsertDelegate (IntPtr pInputOrder, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnOrderActionDelegate (IntPtr pOrderAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnInstrumentStatusDelegate (IntPtr pInstrumentStatus);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnBulletinDelegate (IntPtr pBulletin);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnTradingNoticeDelegate (IntPtr pTradingNoticeInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnErrorConditionalOrderDelegate (IntPtr pErrorConditionalOrder);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnExecOrderDelegate (IntPtr pExecOrder);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnExecOrderInsertDelegate (IntPtr pInputExecOrder, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnExecOrderActionDelegate (IntPtr pExecOrderAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnForQuoteInsertDelegate (IntPtr pInputForQuote, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnQuoteDelegate (IntPtr pQuote);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnQuoteInsertDelegate (IntPtr pInputQuote, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnQuoteActionDelegate (IntPtr pQuoteAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnForQuoteRspDelegate (IntPtr pForQuoteRsp);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnCFMMCTradingAccountTokenDelegate (IntPtr pCFMMCTradingAccountToken);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnBatchOrderActionDelegate (IntPtr pBatchOrderAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnOptionSelfCloseDelegate (IntPtr pOptionSelfClose);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnOptionSelfCloseInsertDelegate (IntPtr pInputOptionSelfClose, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnOptionSelfCloseActionDelegate (IntPtr pOptionSelfCloseAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnCombActionDelegate (IntPtr pCombAction);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnCombActionInsertDelegate (IntPtr pInputCombAction, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryContractBankDelegate (IntPtr pContractBank, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryParkedOrderDelegate (IntPtr pParkedOrder, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryParkedOrderActionDelegate (IntPtr pParkedOrderAction, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryTradingNoticeDelegate (IntPtr pTradingNotice, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryBrokerTradingParamsDelegate (IntPtr pBrokerTradingParams, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQryBrokerTradingAlgosDelegate (IntPtr pBrokerTradingAlgos, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQueryCFMMCTradingAccountTokenDelegate (IntPtr pQueryCFMMCTradingAccountToken, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnFromBankToFutureByBankDelegate (IntPtr pRspTransfer);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnFromFutureToBankByBankDelegate (IntPtr pRspTransfer);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromBankToFutureByBankDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromFutureToBankByBankDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnFromBankToFutureByFutureDelegate (IntPtr pRspTransfer);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnFromFutureToBankByFutureDelegate (IntPtr pRspTransfer);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromBankToFutureByFutureManualDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromFutureToBankByFutureManualDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnQueryBankBalanceByFutureDelegate (IntPtr pNotifyQueryAccount);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnBankToFutureByFutureDelegate (IntPtr pReqTransfer, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnFutureToBankByFutureDelegate (IntPtr pReqTransfer, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnRepealBankToFutureByFutureManualDelegate (IntPtr pReqRepeal, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnRepealFutureToBankByFutureManualDelegate (IntPtr pReqRepeal, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnErrRtnQueryBankBalanceByFutureDelegate (IntPtr pReqQueryAccount, IntPtr pRspInfo);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromBankToFutureByFutureDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnRepealFromFutureToBankByFutureDelegate (IntPtr pRspRepeal);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspFromBankToFutureByFutureDelegate (IntPtr pReqTransfer, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspFromFutureToBankByFutureDelegate (IntPtr pReqTransfer, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspQueryBankAccountMoneyByFutureDelegate (IntPtr pReqQueryAccount, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnOpenAccountByBankDelegate (IntPtr pOpenAccount);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnCancelAccountByBankDelegate (IntPtr pCancelAccount);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnChangeAccountByBankDelegate (IntPtr pChangeAccount);
    
}
