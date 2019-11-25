using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace CSharpCtp.Trader
{
    public class TraderWrapper : IDisposable
	{

        public TraderWrapper(TraderInfo traderInfo)
        {
            InitDelegates();
            
            TraderDllWrapper.CreateTrader(ref traderInfo, out m_handler);
            RegisterDelegatesToHandler();
        }

        ~TraderWrapper()
        {
            Dispose(false);
        }

        private IntPtr m_handler;

        public int Connect()
        {
            return TraderDllWrapper.ConnectTrader(m_handler);
        }

        public int Disconnect()
        {
            if (m_handler != IntPtr.Zero)
            {
                TraderDllWrapper.DisconnectTrader(m_handler);
                m_handler = IntPtr.Zero;
            }
            return 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            //use called(release managed object)
            if (disposing) { }
            //Release Unmanaged objects
            if (m_handler != IntPtr.Zero)
            {
                TraderDllWrapper.DisconnectTrader(m_handler);
                m_handler = IntPtr.Zero;
            }

            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void InitDelegates()
        {
            onFrontConnectedDelegate = RaiseOnFrontConnected;
            onFrontDisconnectedDelegate = RaiseOnFrontDisconnected;
            onHeartBeatWarningDelegate = RaiseOnHeartBeatWarning;
            onRspAuthenticateDelegate = RaiseOnRspAuthenticate;
            onRspUserLoginDelegate = RaiseOnRspUserLogin;
            onRspUserLogoutDelegate = RaiseOnRspUserLogout;
            onRspUserPasswordUpdateDelegate = RaiseOnRspUserPasswordUpdate;
            onRspTradingAccountPasswordUpdateDelegate = RaiseOnRspTradingAccountPasswordUpdate;
            onRspUserAuthMethodDelegate = RaiseOnRspUserAuthMethod;
            onRspGenUserCaptchaDelegate = RaiseOnRspGenUserCaptcha;
            onRspGenUserTextDelegate = RaiseOnRspGenUserText;
            onRspOrderInsertDelegate = RaiseOnRspOrderInsert;
            onRspParkedOrderInsertDelegate = RaiseOnRspParkedOrderInsert;
            onRspParkedOrderActionDelegate = RaiseOnRspParkedOrderAction;
            onRspOrderActionDelegate = RaiseOnRspOrderAction;
            onRspQueryMaxOrderVolumeDelegate = RaiseOnRspQueryMaxOrderVolume;
            onRspSettlementInfoConfirmDelegate = RaiseOnRspSettlementInfoConfirm;
            onRspRemoveParkedOrderDelegate = RaiseOnRspRemoveParkedOrder;
            onRspRemoveParkedOrderActionDelegate = RaiseOnRspRemoveParkedOrderAction;
            onRspExecOrderInsertDelegate = RaiseOnRspExecOrderInsert;
            onRspExecOrderActionDelegate = RaiseOnRspExecOrderAction;
            onRspForQuoteInsertDelegate = RaiseOnRspForQuoteInsert;
            onRspQuoteInsertDelegate = RaiseOnRspQuoteInsert;
            onRspQuoteActionDelegate = RaiseOnRspQuoteAction;
            onRspBatchOrderActionDelegate = RaiseOnRspBatchOrderAction;
            onRspOptionSelfCloseInsertDelegate = RaiseOnRspOptionSelfCloseInsert;
            onRspOptionSelfCloseActionDelegate = RaiseOnRspOptionSelfCloseAction;
            onRspCombActionInsertDelegate = RaiseOnRspCombActionInsert;
            onRspQryOrderDelegate = RaiseOnRspQryOrder;
            onRspQryTradeDelegate = RaiseOnRspQryTrade;
            onRspQryInvestorPositionDelegate = RaiseOnRspQryInvestorPosition;
            onRspQryTradingAccountDelegate = RaiseOnRspQryTradingAccount;
            onRspQryInvestorDelegate = RaiseOnRspQryInvestor;
            onRspQryTradingCodeDelegate = RaiseOnRspQryTradingCode;
            onRspQryInstrumentMarginRateDelegate = RaiseOnRspQryInstrumentMarginRate;
            onRspQryInstrumentCommissionRateDelegate = RaiseOnRspQryInstrumentCommissionRate;
            onRspQryExchangeDelegate = RaiseOnRspQryExchange;
            onRspQryProductDelegate = RaiseOnRspQryProduct;
            onRspQryInstrumentDelegate = RaiseOnRspQryInstrument;
            onRspQryDepthMarketDataDelegate = RaiseOnRspQryDepthMarketData;
            onRspQrySettlementInfoDelegate = RaiseOnRspQrySettlementInfo;
            onRspQryTransferBankDelegate = RaiseOnRspQryTransferBank;
            onRspQryInvestorPositionDetailDelegate = RaiseOnRspQryInvestorPositionDetail;
            onRspQryNoticeDelegate = RaiseOnRspQryNotice;
            onRspQrySettlementInfoConfirmDelegate = RaiseOnRspQrySettlementInfoConfirm;
            onRspQryInvestorPositionCombineDetailDelegate = RaiseOnRspQryInvestorPositionCombineDetail;
            onRspQryCFMMCTradingAccountKeyDelegate = RaiseOnRspQryCFMMCTradingAccountKey;
            onRspQryEWarrantOffsetDelegate = RaiseOnRspQryEWarrantOffset;
            onRspQryInvestorProductGroupMarginDelegate = RaiseOnRspQryInvestorProductGroupMargin;
            onRspQryExchangeMarginRateDelegate = RaiseOnRspQryExchangeMarginRate;
            onRspQryExchangeMarginRateAdjustDelegate = RaiseOnRspQryExchangeMarginRateAdjust;
            onRspQryExchangeRateDelegate = RaiseOnRspQryExchangeRate;
            onRspQrySecAgentACIDMapDelegate = RaiseOnRspQrySecAgentACIDMap;
            onRspQryProductExchRateDelegate = RaiseOnRspQryProductExchRate;
            onRspQryProductGroupDelegate = RaiseOnRspQryProductGroup;
            onRspQryMMInstrumentCommissionRateDelegate = RaiseOnRspQryMMInstrumentCommissionRate;
            onRspQryMMOptionInstrCommRateDelegate = RaiseOnRspQryMMOptionInstrCommRate;
            onRspQryInstrumentOrderCommRateDelegate = RaiseOnRspQryInstrumentOrderCommRate;
            onRspQrySecAgentTradingAccountDelegate = RaiseOnRspQrySecAgentTradingAccount;
            onRspQrySecAgentCheckModeDelegate = RaiseOnRspQrySecAgentCheckMode;
            onRspQrySecAgentTradeInfoDelegate = RaiseOnRspQrySecAgentTradeInfo;
            onRspQryOptionInstrTradeCostDelegate = RaiseOnRspQryOptionInstrTradeCost;
            onRspQryOptionInstrCommRateDelegate = RaiseOnRspQryOptionInstrCommRate;
            onRspQryExecOrderDelegate = RaiseOnRspQryExecOrder;
            onRspQryForQuoteDelegate = RaiseOnRspQryForQuote;
            onRspQryQuoteDelegate = RaiseOnRspQryQuote;
            onRspQryOptionSelfCloseDelegate = RaiseOnRspQryOptionSelfClose;
            onRspQryInvestUnitDelegate = RaiseOnRspQryInvestUnit;
            onRspQryCombInstrumentGuardDelegate = RaiseOnRspQryCombInstrumentGuard;
            onRspQryCombActionDelegate = RaiseOnRspQryCombAction;
            onRspQryTransferSerialDelegate = RaiseOnRspQryTransferSerial;
            onRspQryAccountregisterDelegate = RaiseOnRspQryAccountregister;
            onRspErrorDelegate = RaiseOnRspError;
            onRtnOrderDelegate = RaiseOnRtnOrder;
            onRtnTradeDelegate = RaiseOnRtnTrade;
            onErrRtnOrderInsertDelegate = RaiseOnErrRtnOrderInsert;
            onErrRtnOrderActionDelegate = RaiseOnErrRtnOrderAction;
            onRtnInstrumentStatusDelegate = RaiseOnRtnInstrumentStatus;
            onRtnBulletinDelegate = RaiseOnRtnBulletin;
            onRtnTradingNoticeDelegate = RaiseOnRtnTradingNotice;
            onRtnErrorConditionalOrderDelegate = RaiseOnRtnErrorConditionalOrder;
            onRtnExecOrderDelegate = RaiseOnRtnExecOrder;
            onErrRtnExecOrderInsertDelegate = RaiseOnErrRtnExecOrderInsert;
            onErrRtnExecOrderActionDelegate = RaiseOnErrRtnExecOrderAction;
            onErrRtnForQuoteInsertDelegate = RaiseOnErrRtnForQuoteInsert;
            onRtnQuoteDelegate = RaiseOnRtnQuote;
            onErrRtnQuoteInsertDelegate = RaiseOnErrRtnQuoteInsert;
            onErrRtnQuoteActionDelegate = RaiseOnErrRtnQuoteAction;
            onRtnForQuoteRspDelegate = RaiseOnRtnForQuoteRsp;
            onRtnCFMMCTradingAccountTokenDelegate = RaiseOnRtnCFMMCTradingAccountToken;
            onErrRtnBatchOrderActionDelegate = RaiseOnErrRtnBatchOrderAction;
            onRtnOptionSelfCloseDelegate = RaiseOnRtnOptionSelfClose;
            onErrRtnOptionSelfCloseInsertDelegate = RaiseOnErrRtnOptionSelfCloseInsert;
            onErrRtnOptionSelfCloseActionDelegate = RaiseOnErrRtnOptionSelfCloseAction;
            onRtnCombActionDelegate = RaiseOnRtnCombAction;
            onErrRtnCombActionInsertDelegate = RaiseOnErrRtnCombActionInsert;
            onRspQryContractBankDelegate = RaiseOnRspQryContractBank;
            onRspQryParkedOrderDelegate = RaiseOnRspQryParkedOrder;
            onRspQryParkedOrderActionDelegate = RaiseOnRspQryParkedOrderAction;
            onRspQryTradingNoticeDelegate = RaiseOnRspQryTradingNotice;
            onRspQryBrokerTradingParamsDelegate = RaiseOnRspQryBrokerTradingParams;
            onRspQryBrokerTradingAlgosDelegate = RaiseOnRspQryBrokerTradingAlgos;
            onRspQueryCFMMCTradingAccountTokenDelegate = RaiseOnRspQueryCFMMCTradingAccountToken;
            onRtnFromBankToFutureByBankDelegate = RaiseOnRtnFromBankToFutureByBank;
            onRtnFromFutureToBankByBankDelegate = RaiseOnRtnFromFutureToBankByBank;
            onRtnRepealFromBankToFutureByBankDelegate = RaiseOnRtnRepealFromBankToFutureByBank;
            onRtnRepealFromFutureToBankByBankDelegate = RaiseOnRtnRepealFromFutureToBankByBank;
            onRtnFromBankToFutureByFutureDelegate = RaiseOnRtnFromBankToFutureByFuture;
            onRtnFromFutureToBankByFutureDelegate = RaiseOnRtnFromFutureToBankByFuture;
            onRtnRepealFromBankToFutureByFutureManualDelegate = RaiseOnRtnRepealFromBankToFutureByFutureManual;
            onRtnRepealFromFutureToBankByFutureManualDelegate = RaiseOnRtnRepealFromFutureToBankByFutureManual;
            onRtnQueryBankBalanceByFutureDelegate = RaiseOnRtnQueryBankBalanceByFuture;
            onErrRtnBankToFutureByFutureDelegate = RaiseOnErrRtnBankToFutureByFuture;
            onErrRtnFutureToBankByFutureDelegate = RaiseOnErrRtnFutureToBankByFuture;
            onErrRtnRepealBankToFutureByFutureManualDelegate = RaiseOnErrRtnRepealBankToFutureByFutureManual;
            onErrRtnRepealFutureToBankByFutureManualDelegate = RaiseOnErrRtnRepealFutureToBankByFutureManual;
            onErrRtnQueryBankBalanceByFutureDelegate = RaiseOnErrRtnQueryBankBalanceByFuture;
            onRtnRepealFromBankToFutureByFutureDelegate = RaiseOnRtnRepealFromBankToFutureByFuture;
            onRtnRepealFromFutureToBankByFutureDelegate = RaiseOnRtnRepealFromFutureToBankByFuture;
            onRspFromBankToFutureByFutureDelegate = RaiseOnRspFromBankToFutureByFuture;
            onRspFromFutureToBankByFutureDelegate = RaiseOnRspFromFutureToBankByFuture;
            onRspQueryBankAccountMoneyByFutureDelegate = RaiseOnRspQueryBankAccountMoneyByFuture;
            onRtnOpenAccountByBankDelegate = RaiseOnRtnOpenAccountByBank;
            onRtnCancelAccountByBankDelegate = RaiseOnRtnCancelAccountByBank;
            onRtnChangeAccountByBankDelegate = RaiseOnRtnChangeAccountByBank;
        }

        private void RegisterDelegatesToHandler()
        {
            if(m_handler != IntPtr.Zero)
            {
                TraderDllWrapper.RegisterOnFrontConnectedCallback(m_handler, onFrontConnectedDelegate);
                TraderDllWrapper.RegisterOnFrontDisconnectedCallback(m_handler, onFrontDisconnectedDelegate);
                TraderDllWrapper.RegisterOnHeartBeatWarningCallback(m_handler, onHeartBeatWarningDelegate);
                TraderDllWrapper.RegisterOnRspAuthenticateCallback(m_handler, onRspAuthenticateDelegate);
                TraderDllWrapper.RegisterOnRspUserLoginCallback(m_handler, onRspUserLoginDelegate);
                TraderDllWrapper.RegisterOnRspUserLogoutCallback(m_handler, onRspUserLogoutDelegate);
                TraderDllWrapper.RegisterOnRspUserPasswordUpdateCallback(m_handler, onRspUserPasswordUpdateDelegate);
                TraderDllWrapper.RegisterOnRspTradingAccountPasswordUpdateCallback(m_handler, onRspTradingAccountPasswordUpdateDelegate);
                TraderDllWrapper.RegisterOnRspUserAuthMethodCallback(m_handler, onRspUserAuthMethodDelegate);
                TraderDllWrapper.RegisterOnRspGenUserCaptchaCallback(m_handler, onRspGenUserCaptchaDelegate);
                TraderDllWrapper.RegisterOnRspGenUserTextCallback(m_handler, onRspGenUserTextDelegate);
                TraderDllWrapper.RegisterOnRspOrderInsertCallback(m_handler, onRspOrderInsertDelegate);
                TraderDllWrapper.RegisterOnRspParkedOrderInsertCallback(m_handler, onRspParkedOrderInsertDelegate);
                TraderDllWrapper.RegisterOnRspParkedOrderActionCallback(m_handler, onRspParkedOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspOrderActionCallback(m_handler, onRspOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspQueryMaxOrderVolumeCallback(m_handler, onRspQueryMaxOrderVolumeDelegate);
                TraderDllWrapper.RegisterOnRspSettlementInfoConfirmCallback(m_handler, onRspSettlementInfoConfirmDelegate);
                TraderDllWrapper.RegisterOnRspRemoveParkedOrderCallback(m_handler, onRspRemoveParkedOrderDelegate);
                TraderDllWrapper.RegisterOnRspRemoveParkedOrderActionCallback(m_handler, onRspRemoveParkedOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspExecOrderInsertCallback(m_handler, onRspExecOrderInsertDelegate);
                TraderDllWrapper.RegisterOnRspExecOrderActionCallback(m_handler, onRspExecOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspForQuoteInsertCallback(m_handler, onRspForQuoteInsertDelegate);
                TraderDllWrapper.RegisterOnRspQuoteInsertCallback(m_handler, onRspQuoteInsertDelegate);
                TraderDllWrapper.RegisterOnRspQuoteActionCallback(m_handler, onRspQuoteActionDelegate);
                TraderDllWrapper.RegisterOnRspBatchOrderActionCallback(m_handler, onRspBatchOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspOptionSelfCloseInsertCallback(m_handler, onRspOptionSelfCloseInsertDelegate);
                TraderDllWrapper.RegisterOnRspOptionSelfCloseActionCallback(m_handler, onRspOptionSelfCloseActionDelegate);
                TraderDllWrapper.RegisterOnRspCombActionInsertCallback(m_handler, onRspCombActionInsertDelegate);
                TraderDllWrapper.RegisterOnRspQryOrderCallback(m_handler, onRspQryOrderDelegate);
                TraderDllWrapper.RegisterOnRspQryTradeCallback(m_handler, onRspQryTradeDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestorPositionCallback(m_handler, onRspQryInvestorPositionDelegate);
                TraderDllWrapper.RegisterOnRspQryTradingAccountCallback(m_handler, onRspQryTradingAccountDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestorCallback(m_handler, onRspQryInvestorDelegate);
                TraderDllWrapper.RegisterOnRspQryTradingCodeCallback(m_handler, onRspQryTradingCodeDelegate);
                TraderDllWrapper.RegisterOnRspQryInstrumentMarginRateCallback(m_handler, onRspQryInstrumentMarginRateDelegate);
                TraderDllWrapper.RegisterOnRspQryInstrumentCommissionRateCallback(m_handler, onRspQryInstrumentCommissionRateDelegate);
                TraderDllWrapper.RegisterOnRspQryExchangeCallback(m_handler, onRspQryExchangeDelegate);
                TraderDllWrapper.RegisterOnRspQryProductCallback(m_handler, onRspQryProductDelegate);
                TraderDllWrapper.RegisterOnRspQryInstrumentCallback(m_handler, onRspQryInstrumentDelegate);
                TraderDllWrapper.RegisterOnRspQryDepthMarketDataCallback(m_handler, onRspQryDepthMarketDataDelegate);
                TraderDllWrapper.RegisterOnRspQrySettlementInfoCallback(m_handler, onRspQrySettlementInfoDelegate);
                TraderDllWrapper.RegisterOnRspQryTransferBankCallback(m_handler, onRspQryTransferBankDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestorPositionDetailCallback(m_handler, onRspQryInvestorPositionDetailDelegate);
                TraderDllWrapper.RegisterOnRspQryNoticeCallback(m_handler, onRspQryNoticeDelegate);
                TraderDllWrapper.RegisterOnRspQrySettlementInfoConfirmCallback(m_handler, onRspQrySettlementInfoConfirmDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestorPositionCombineDetailCallback(m_handler, onRspQryInvestorPositionCombineDetailDelegate);
                TraderDllWrapper.RegisterOnRspQryCFMMCTradingAccountKeyCallback(m_handler, onRspQryCFMMCTradingAccountKeyDelegate);
                TraderDllWrapper.RegisterOnRspQryEWarrantOffsetCallback(m_handler, onRspQryEWarrantOffsetDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestorProductGroupMarginCallback(m_handler, onRspQryInvestorProductGroupMarginDelegate);
                TraderDllWrapper.RegisterOnRspQryExchangeMarginRateCallback(m_handler, onRspQryExchangeMarginRateDelegate);
                TraderDllWrapper.RegisterOnRspQryExchangeMarginRateAdjustCallback(m_handler, onRspQryExchangeMarginRateAdjustDelegate);
                TraderDllWrapper.RegisterOnRspQryExchangeRateCallback(m_handler, onRspQryExchangeRateDelegate);
                TraderDllWrapper.RegisterOnRspQrySecAgentACIDMapCallback(m_handler, onRspQrySecAgentACIDMapDelegate);
                TraderDllWrapper.RegisterOnRspQryProductExchRateCallback(m_handler, onRspQryProductExchRateDelegate);
                TraderDllWrapper.RegisterOnRspQryProductGroupCallback(m_handler, onRspQryProductGroupDelegate);
                TraderDllWrapper.RegisterOnRspQryMMInstrumentCommissionRateCallback(m_handler, onRspQryMMInstrumentCommissionRateDelegate);
                TraderDllWrapper.RegisterOnRspQryMMOptionInstrCommRateCallback(m_handler, onRspQryMMOptionInstrCommRateDelegate);
                TraderDllWrapper.RegisterOnRspQryInstrumentOrderCommRateCallback(m_handler, onRspQryInstrumentOrderCommRateDelegate);
                TraderDllWrapper.RegisterOnRspQrySecAgentTradingAccountCallback(m_handler, onRspQrySecAgentTradingAccountDelegate);
                TraderDllWrapper.RegisterOnRspQrySecAgentCheckModeCallback(m_handler, onRspQrySecAgentCheckModeDelegate);
                TraderDllWrapper.RegisterOnRspQrySecAgentTradeInfoCallback(m_handler, onRspQrySecAgentTradeInfoDelegate);
                TraderDllWrapper.RegisterOnRspQryOptionInstrTradeCostCallback(m_handler, onRspQryOptionInstrTradeCostDelegate);
                TraderDllWrapper.RegisterOnRspQryOptionInstrCommRateCallback(m_handler, onRspQryOptionInstrCommRateDelegate);
                TraderDllWrapper.RegisterOnRspQryExecOrderCallback(m_handler, onRspQryExecOrderDelegate);
                TraderDllWrapper.RegisterOnRspQryForQuoteCallback(m_handler, onRspQryForQuoteDelegate);
                TraderDllWrapper.RegisterOnRspQryQuoteCallback(m_handler, onRspQryQuoteDelegate);
                TraderDllWrapper.RegisterOnRspQryOptionSelfCloseCallback(m_handler, onRspQryOptionSelfCloseDelegate);
                TraderDllWrapper.RegisterOnRspQryInvestUnitCallback(m_handler, onRspQryInvestUnitDelegate);
                TraderDllWrapper.RegisterOnRspQryCombInstrumentGuardCallback(m_handler, onRspQryCombInstrumentGuardDelegate);
                TraderDllWrapper.RegisterOnRspQryCombActionCallback(m_handler, onRspQryCombActionDelegate);
                TraderDllWrapper.RegisterOnRspQryTransferSerialCallback(m_handler, onRspQryTransferSerialDelegate);
                TraderDllWrapper.RegisterOnRspQryAccountregisterCallback(m_handler, onRspQryAccountregisterDelegate);
                TraderDllWrapper.RegisterOnRspErrorCallback(m_handler, onRspErrorDelegate);
                TraderDllWrapper.RegisterOnRtnOrderCallback(m_handler, onRtnOrderDelegate);
                TraderDllWrapper.RegisterOnRtnTradeCallback(m_handler, onRtnTradeDelegate);
                TraderDllWrapper.RegisterOnErrRtnOrderInsertCallback(m_handler, onErrRtnOrderInsertDelegate);
                TraderDllWrapper.RegisterOnErrRtnOrderActionCallback(m_handler, onErrRtnOrderActionDelegate);
                TraderDllWrapper.RegisterOnRtnInstrumentStatusCallback(m_handler, onRtnInstrumentStatusDelegate);
                TraderDllWrapper.RegisterOnRtnBulletinCallback(m_handler, onRtnBulletinDelegate);
                TraderDllWrapper.RegisterOnRtnTradingNoticeCallback(m_handler, onRtnTradingNoticeDelegate);
                TraderDllWrapper.RegisterOnRtnErrorConditionalOrderCallback(m_handler, onRtnErrorConditionalOrderDelegate);
                TraderDllWrapper.RegisterOnRtnExecOrderCallback(m_handler, onRtnExecOrderDelegate);
                TraderDllWrapper.RegisterOnErrRtnExecOrderInsertCallback(m_handler, onErrRtnExecOrderInsertDelegate);
                TraderDllWrapper.RegisterOnErrRtnExecOrderActionCallback(m_handler, onErrRtnExecOrderActionDelegate);
                TraderDllWrapper.RegisterOnErrRtnForQuoteInsertCallback(m_handler, onErrRtnForQuoteInsertDelegate);
                TraderDllWrapper.RegisterOnRtnQuoteCallback(m_handler, onRtnQuoteDelegate);
                TraderDllWrapper.RegisterOnErrRtnQuoteInsertCallback(m_handler, onErrRtnQuoteInsertDelegate);
                TraderDllWrapper.RegisterOnErrRtnQuoteActionCallback(m_handler, onErrRtnQuoteActionDelegate);
                TraderDllWrapper.RegisterOnRtnForQuoteRspCallback(m_handler, onRtnForQuoteRspDelegate);
                TraderDllWrapper.RegisterOnRtnCFMMCTradingAccountTokenCallback(m_handler, onRtnCFMMCTradingAccountTokenDelegate);
                TraderDllWrapper.RegisterOnErrRtnBatchOrderActionCallback(m_handler, onErrRtnBatchOrderActionDelegate);
                TraderDllWrapper.RegisterOnRtnOptionSelfCloseCallback(m_handler, onRtnOptionSelfCloseDelegate);
                TraderDllWrapper.RegisterOnErrRtnOptionSelfCloseInsertCallback(m_handler, onErrRtnOptionSelfCloseInsertDelegate);
                TraderDllWrapper.RegisterOnErrRtnOptionSelfCloseActionCallback(m_handler, onErrRtnOptionSelfCloseActionDelegate);
                TraderDllWrapper.RegisterOnRtnCombActionCallback(m_handler, onRtnCombActionDelegate);
                TraderDllWrapper.RegisterOnErrRtnCombActionInsertCallback(m_handler, onErrRtnCombActionInsertDelegate);
                TraderDllWrapper.RegisterOnRspQryContractBankCallback(m_handler, onRspQryContractBankDelegate);
                TraderDllWrapper.RegisterOnRspQryParkedOrderCallback(m_handler, onRspQryParkedOrderDelegate);
                TraderDllWrapper.RegisterOnRspQryParkedOrderActionCallback(m_handler, onRspQryParkedOrderActionDelegate);
                TraderDllWrapper.RegisterOnRspQryTradingNoticeCallback(m_handler, onRspQryTradingNoticeDelegate);
                TraderDllWrapper.RegisterOnRspQryBrokerTradingParamsCallback(m_handler, onRspQryBrokerTradingParamsDelegate);
                TraderDllWrapper.RegisterOnRspQryBrokerTradingAlgosCallback(m_handler, onRspQryBrokerTradingAlgosDelegate);
                TraderDllWrapper.RegisterOnRspQueryCFMMCTradingAccountTokenCallback(m_handler, onRspQueryCFMMCTradingAccountTokenDelegate);
                TraderDllWrapper.RegisterOnRtnFromBankToFutureByBankCallback(m_handler, onRtnFromBankToFutureByBankDelegate);
                TraderDllWrapper.RegisterOnRtnFromFutureToBankByBankCallback(m_handler, onRtnFromFutureToBankByBankDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromBankToFutureByBankCallback(m_handler, onRtnRepealFromBankToFutureByBankDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromFutureToBankByBankCallback(m_handler, onRtnRepealFromFutureToBankByBankDelegate);
                TraderDllWrapper.RegisterOnRtnFromBankToFutureByFutureCallback(m_handler, onRtnFromBankToFutureByFutureDelegate);
                TraderDllWrapper.RegisterOnRtnFromFutureToBankByFutureCallback(m_handler, onRtnFromFutureToBankByFutureDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromBankToFutureByFutureManualCallback(m_handler, onRtnRepealFromBankToFutureByFutureManualDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromFutureToBankByFutureManualCallback(m_handler, onRtnRepealFromFutureToBankByFutureManualDelegate);
                TraderDllWrapper.RegisterOnRtnQueryBankBalanceByFutureCallback(m_handler, onRtnQueryBankBalanceByFutureDelegate);
                TraderDllWrapper.RegisterOnErrRtnBankToFutureByFutureCallback(m_handler, onErrRtnBankToFutureByFutureDelegate);
                TraderDllWrapper.RegisterOnErrRtnFutureToBankByFutureCallback(m_handler, onErrRtnFutureToBankByFutureDelegate);
                TraderDllWrapper.RegisterOnErrRtnRepealBankToFutureByFutureManualCallback(m_handler, onErrRtnRepealBankToFutureByFutureManualDelegate);
                TraderDllWrapper.RegisterOnErrRtnRepealFutureToBankByFutureManualCallback(m_handler, onErrRtnRepealFutureToBankByFutureManualDelegate);
                TraderDllWrapper.RegisterOnErrRtnQueryBankBalanceByFutureCallback(m_handler, onErrRtnQueryBankBalanceByFutureDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromBankToFutureByFutureCallback(m_handler, onRtnRepealFromBankToFutureByFutureDelegate);
                TraderDllWrapper.RegisterOnRtnRepealFromFutureToBankByFutureCallback(m_handler, onRtnRepealFromFutureToBankByFutureDelegate);
                TraderDllWrapper.RegisterOnRspFromBankToFutureByFutureCallback(m_handler, onRspFromBankToFutureByFutureDelegate);
                TraderDllWrapper.RegisterOnRspFromFutureToBankByFutureCallback(m_handler, onRspFromFutureToBankByFutureDelegate);
                TraderDllWrapper.RegisterOnRspQueryBankAccountMoneyByFutureCallback(m_handler, onRspQueryBankAccountMoneyByFutureDelegate);
                TraderDllWrapper.RegisterOnRtnOpenAccountByBankCallback(m_handler, onRtnOpenAccountByBankDelegate);
                TraderDllWrapper.RegisterOnRtnCancelAccountByBankCallback(m_handler, onRtnCancelAccountByBankDelegate);
                TraderDllWrapper.RegisterOnRtnChangeAccountByBankCallback(m_handler, onRtnChangeAccountByBankDelegate);
            }
        }

        #region event
        public event EventHandler<EventArgs> OnFrontConnected;
        public event EventHandler<OnFrontDisconnectedEventArgs> OnFrontDisconnected;
        public event EventHandler<OnHeartBeatWarningEventArgs> OnHeartBeatWarning;
        public event EventHandler<OnRspAuthenticateEventArgs> OnRspAuthenticate;
        public event EventHandler<OnRspUserLoginEventArgs> OnRspUserLogin;
        public event EventHandler<OnRspUserLogoutEventArgs> OnRspUserLogout;
        public event EventHandler<OnRspUserPasswordUpdateEventArgs> OnRspUserPasswordUpdate;
        public event EventHandler<OnRspTradingAccountPasswordUpdateEventArgs> OnRspTradingAccountPasswordUpdate;
        public event EventHandler<OnRspUserAuthMethodEventArgs> OnRspUserAuthMethod;
        public event EventHandler<OnRspGenUserCaptchaEventArgs> OnRspGenUserCaptcha;
        public event EventHandler<OnRspGenUserTextEventArgs> OnRspGenUserText;
        public event EventHandler<OnRspOrderInsertEventArgs> OnRspOrderInsert;
        public event EventHandler<OnRspParkedOrderInsertEventArgs> OnRspParkedOrderInsert;
        public event EventHandler<OnRspParkedOrderActionEventArgs> OnRspParkedOrderAction;
        public event EventHandler<OnRspOrderActionEventArgs> OnRspOrderAction;
        public event EventHandler<OnRspQueryMaxOrderVolumeEventArgs> OnRspQueryMaxOrderVolume;
        public event EventHandler<OnRspSettlementInfoConfirmEventArgs> OnRspSettlementInfoConfirm;
        public event EventHandler<OnRspRemoveParkedOrderEventArgs> OnRspRemoveParkedOrder;
        public event EventHandler<OnRspRemoveParkedOrderActionEventArgs> OnRspRemoveParkedOrderAction;
        public event EventHandler<OnRspExecOrderInsertEventArgs> OnRspExecOrderInsert;
        public event EventHandler<OnRspExecOrderActionEventArgs> OnRspExecOrderAction;
        public event EventHandler<OnRspForQuoteInsertEventArgs> OnRspForQuoteInsert;
        public event EventHandler<OnRspQuoteInsertEventArgs> OnRspQuoteInsert;
        public event EventHandler<OnRspQuoteActionEventArgs> OnRspQuoteAction;
        public event EventHandler<OnRspBatchOrderActionEventArgs> OnRspBatchOrderAction;
        public event EventHandler<OnRspOptionSelfCloseInsertEventArgs> OnRspOptionSelfCloseInsert;
        public event EventHandler<OnRspOptionSelfCloseActionEventArgs> OnRspOptionSelfCloseAction;
        public event EventHandler<OnRspCombActionInsertEventArgs> OnRspCombActionInsert;
        public event EventHandler<OnRspQryOrderEventArgs> OnRspQryOrder;
        public event EventHandler<OnRspQryTradeEventArgs> OnRspQryTrade;
        public event EventHandler<OnRspQryInvestorPositionEventArgs> OnRspQryInvestorPosition;
        public event EventHandler<OnRspQryTradingAccountEventArgs> OnRspQryTradingAccount;
        public event EventHandler<OnRspQryInvestorEventArgs> OnRspQryInvestor;
        public event EventHandler<OnRspQryTradingCodeEventArgs> OnRspQryTradingCode;
        public event EventHandler<OnRspQryInstrumentMarginRateEventArgs> OnRspQryInstrumentMarginRate;
        public event EventHandler<OnRspQryInstrumentCommissionRateEventArgs> OnRspQryInstrumentCommissionRate;
        public event EventHandler<OnRspQryExchangeEventArgs> OnRspQryExchange;
        public event EventHandler<OnRspQryProductEventArgs> OnRspQryProduct;
        public event EventHandler<OnRspQryInstrumentEventArgs> OnRspQryInstrument;
        public event EventHandler<OnRspQryDepthMarketDataEventArgs> OnRspQryDepthMarketData;
        public event EventHandler<OnRspQrySettlementInfoEventArgs> OnRspQrySettlementInfo;
        public event EventHandler<OnRspQryTransferBankEventArgs> OnRspQryTransferBank;
        public event EventHandler<OnRspQryInvestorPositionDetailEventArgs> OnRspQryInvestorPositionDetail;
        public event EventHandler<OnRspQryNoticeEventArgs> OnRspQryNotice;
        public event EventHandler<OnRspQrySettlementInfoConfirmEventArgs> OnRspQrySettlementInfoConfirm;
        public event EventHandler<OnRspQryInvestorPositionCombineDetailEventArgs> OnRspQryInvestorPositionCombineDetail;
        public event EventHandler<OnRspQryCFMMCTradingAccountKeyEventArgs> OnRspQryCFMMCTradingAccountKey;
        public event EventHandler<OnRspQryEWarrantOffsetEventArgs> OnRspQryEWarrantOffset;
        public event EventHandler<OnRspQryInvestorProductGroupMarginEventArgs> OnRspQryInvestorProductGroupMargin;
        public event EventHandler<OnRspQryExchangeMarginRateEventArgs> OnRspQryExchangeMarginRate;
        public event EventHandler<OnRspQryExchangeMarginRateAdjustEventArgs> OnRspQryExchangeMarginRateAdjust;
        public event EventHandler<OnRspQryExchangeRateEventArgs> OnRspQryExchangeRate;
        public event EventHandler<OnRspQrySecAgentACIDMapEventArgs> OnRspQrySecAgentACIDMap;
        public event EventHandler<OnRspQryProductExchRateEventArgs> OnRspQryProductExchRate;
        public event EventHandler<OnRspQryProductGroupEventArgs> OnRspQryProductGroup;
        public event EventHandler<OnRspQryMMInstrumentCommissionRateEventArgs> OnRspQryMMInstrumentCommissionRate;
        public event EventHandler<OnRspQryMMOptionInstrCommRateEventArgs> OnRspQryMMOptionInstrCommRate;
        public event EventHandler<OnRspQryInstrumentOrderCommRateEventArgs> OnRspQryInstrumentOrderCommRate;
        public event EventHandler<OnRspQrySecAgentTradingAccountEventArgs> OnRspQrySecAgentTradingAccount;
        public event EventHandler<OnRspQrySecAgentCheckModeEventArgs> OnRspQrySecAgentCheckMode;
        public event EventHandler<OnRspQrySecAgentTradeInfoEventArgs> OnRspQrySecAgentTradeInfo;
        public event EventHandler<OnRspQryOptionInstrTradeCostEventArgs> OnRspQryOptionInstrTradeCost;
        public event EventHandler<OnRspQryOptionInstrCommRateEventArgs> OnRspQryOptionInstrCommRate;
        public event EventHandler<OnRspQryExecOrderEventArgs> OnRspQryExecOrder;
        public event EventHandler<OnRspQryForQuoteEventArgs> OnRspQryForQuote;
        public event EventHandler<OnRspQryQuoteEventArgs> OnRspQryQuote;
        public event EventHandler<OnRspQryOptionSelfCloseEventArgs> OnRspQryOptionSelfClose;
        public event EventHandler<OnRspQryInvestUnitEventArgs> OnRspQryInvestUnit;
        public event EventHandler<OnRspQryCombInstrumentGuardEventArgs> OnRspQryCombInstrumentGuard;
        public event EventHandler<OnRspQryCombActionEventArgs> OnRspQryCombAction;
        public event EventHandler<OnRspQryTransferSerialEventArgs> OnRspQryTransferSerial;
        public event EventHandler<OnRspQryAccountregisterEventArgs> OnRspQryAccountregister;
        public event EventHandler<OnRspErrorEventArgs> OnRspError;
        public event EventHandler<OnRtnOrderEventArgs> OnRtnOrder;
        public event EventHandler<OnRtnTradeEventArgs> OnRtnTrade;
        public event EventHandler<OnErrRtnOrderInsertEventArgs> OnErrRtnOrderInsert;
        public event EventHandler<OnErrRtnOrderActionEventArgs> OnErrRtnOrderAction;
        public event EventHandler<OnRtnInstrumentStatusEventArgs> OnRtnInstrumentStatus;
        public event EventHandler<OnRtnBulletinEventArgs> OnRtnBulletin;
        public event EventHandler<OnRtnTradingNoticeEventArgs> OnRtnTradingNotice;
        public event EventHandler<OnRtnErrorConditionalOrderEventArgs> OnRtnErrorConditionalOrder;
        public event EventHandler<OnRtnExecOrderEventArgs> OnRtnExecOrder;
        public event EventHandler<OnErrRtnExecOrderInsertEventArgs> OnErrRtnExecOrderInsert;
        public event EventHandler<OnErrRtnExecOrderActionEventArgs> OnErrRtnExecOrderAction;
        public event EventHandler<OnErrRtnForQuoteInsertEventArgs> OnErrRtnForQuoteInsert;
        public event EventHandler<OnRtnQuoteEventArgs> OnRtnQuote;
        public event EventHandler<OnErrRtnQuoteInsertEventArgs> OnErrRtnQuoteInsert;
        public event EventHandler<OnErrRtnQuoteActionEventArgs> OnErrRtnQuoteAction;
        public event EventHandler<OnRtnForQuoteRspEventArgs> OnRtnForQuoteRsp;
        public event EventHandler<OnRtnCFMMCTradingAccountTokenEventArgs> OnRtnCFMMCTradingAccountToken;
        public event EventHandler<OnErrRtnBatchOrderActionEventArgs> OnErrRtnBatchOrderAction;
        public event EventHandler<OnRtnOptionSelfCloseEventArgs> OnRtnOptionSelfClose;
        public event EventHandler<OnErrRtnOptionSelfCloseInsertEventArgs> OnErrRtnOptionSelfCloseInsert;
        public event EventHandler<OnErrRtnOptionSelfCloseActionEventArgs> OnErrRtnOptionSelfCloseAction;
        public event EventHandler<OnRtnCombActionEventArgs> OnRtnCombAction;
        public event EventHandler<OnErrRtnCombActionInsertEventArgs> OnErrRtnCombActionInsert;
        public event EventHandler<OnRspQryContractBankEventArgs> OnRspQryContractBank;
        public event EventHandler<OnRspQryParkedOrderEventArgs> OnRspQryParkedOrder;
        public event EventHandler<OnRspQryParkedOrderActionEventArgs> OnRspQryParkedOrderAction;
        public event EventHandler<OnRspQryTradingNoticeEventArgs> OnRspQryTradingNotice;
        public event EventHandler<OnRspQryBrokerTradingParamsEventArgs> OnRspQryBrokerTradingParams;
        public event EventHandler<OnRspQryBrokerTradingAlgosEventArgs> OnRspQryBrokerTradingAlgos;
        public event EventHandler<OnRspQueryCFMMCTradingAccountTokenEventArgs> OnRspQueryCFMMCTradingAccountToken;
        public event EventHandler<OnRtnFromBankToFutureByBankEventArgs> OnRtnFromBankToFutureByBank;
        public event EventHandler<OnRtnFromFutureToBankByBankEventArgs> OnRtnFromFutureToBankByBank;
        public event EventHandler<OnRtnRepealFromBankToFutureByBankEventArgs> OnRtnRepealFromBankToFutureByBank;
        public event EventHandler<OnRtnRepealFromFutureToBankByBankEventArgs> OnRtnRepealFromFutureToBankByBank;
        public event EventHandler<OnRtnFromBankToFutureByFutureEventArgs> OnRtnFromBankToFutureByFuture;
        public event EventHandler<OnRtnFromFutureToBankByFutureEventArgs> OnRtnFromFutureToBankByFuture;
        public event EventHandler<OnRtnRepealFromBankToFutureByFutureManualEventArgs> OnRtnRepealFromBankToFutureByFutureManual;
        public event EventHandler<OnRtnRepealFromFutureToBankByFutureManualEventArgs> OnRtnRepealFromFutureToBankByFutureManual;
        public event EventHandler<OnRtnQueryBankBalanceByFutureEventArgs> OnRtnQueryBankBalanceByFuture;
        public event EventHandler<OnErrRtnBankToFutureByFutureEventArgs> OnErrRtnBankToFutureByFuture;
        public event EventHandler<OnErrRtnFutureToBankByFutureEventArgs> OnErrRtnFutureToBankByFuture;
        public event EventHandler<OnErrRtnRepealBankToFutureByFutureManualEventArgs> OnErrRtnRepealBankToFutureByFutureManual;
        public event EventHandler<OnErrRtnRepealFutureToBankByFutureManualEventArgs> OnErrRtnRepealFutureToBankByFutureManual;
        public event EventHandler<OnErrRtnQueryBankBalanceByFutureEventArgs> OnErrRtnQueryBankBalanceByFuture;
        public event EventHandler<OnRtnRepealFromBankToFutureByFutureEventArgs> OnRtnRepealFromBankToFutureByFuture;
        public event EventHandler<OnRtnRepealFromFutureToBankByFutureEventArgs> OnRtnRepealFromFutureToBankByFuture;
        public event EventHandler<OnRspFromBankToFutureByFutureEventArgs> OnRspFromBankToFutureByFuture;
        public event EventHandler<OnRspFromFutureToBankByFutureEventArgs> OnRspFromFutureToBankByFuture;
        public event EventHandler<OnRspQueryBankAccountMoneyByFutureEventArgs> OnRspQueryBankAccountMoneyByFuture;
        public event EventHandler<OnRtnOpenAccountByBankEventArgs> OnRtnOpenAccountByBank;
        public event EventHandler<OnRtnCancelAccountByBankEventArgs> OnRtnCancelAccountByBank;
        public event EventHandler<OnRtnChangeAccountByBankEventArgs> OnRtnChangeAccountByBank;
        #endregion

        #region TraderApi
        public int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
                return TraderDllWrapper.ReqUserLogin(m_handler, ref pReqUserLoginField, nRequestID);
        }
        
        public int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
                return TraderDllWrapper.ReqUserLogout(m_handler, ref pUserLogout, nRequestID);
        }
        
        public int ReqUserPasswordUpdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
                return TraderDllWrapper.ReqUserPasswordUpdate(m_handler, ref pUserPasswordUpdate, nRequestID);
        }
        
        public int ReqTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, int nRequestID)
        {
                return TraderDllWrapper.ReqTradingAccountPasswordUpdate(m_handler, ref pTradingAccountPasswordUpdate, nRequestID);
        }
        
        public int ReqUserAuthMethod(CThostFtdcReqUserAuthMethodField pReqUserAuthMethod, int nRequestID)
        {
                return TraderDllWrapper.ReqUserAuthMethod(m_handler, ref pReqUserAuthMethod, nRequestID);
        }
        
        public int ReqGenUserCaptcha(CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha, int nRequestID)
        {
                return TraderDllWrapper.ReqGenUserCaptcha(m_handler, ref pReqGenUserCaptcha, nRequestID);
        }
        
        public int ReqGenUserText(CThostFtdcReqGenUserTextField pReqGenUserText, int nRequestID)
        {
                return TraderDllWrapper.ReqGenUserText(m_handler, ref pReqGenUserText, nRequestID);
        }
        
        public int ReqUserLoginWithCaptcha(CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha, int nRequestID)
        {
                return TraderDllWrapper.ReqUserLoginWithCaptcha(m_handler, ref pReqUserLoginWithCaptcha, nRequestID);
        }
        
        public int ReqUserLoginWithText(CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText, int nRequestID)
        {
                return TraderDllWrapper.ReqUserLoginWithText(m_handler, ref pReqUserLoginWithText, nRequestID);
        }
        
        public int ReqUserLoginWithOTP(CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP, int nRequestID)
        {
                return TraderDllWrapper.ReqUserLoginWithOTP(m_handler, ref pReqUserLoginWithOTP, nRequestID);
        }
        
        public int ReqOrderInsert(CThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqOrderInsert(m_handler, ref pInputOrder, nRequestID);
        }
        
        public int ReqParkedOrderInsert(CThostFtdcParkedOrderField pParkedOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqParkedOrderInsert(m_handler, ref pParkedOrder, nRequestID);
        }
        
        public int ReqParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqParkedOrderAction(m_handler, ref pParkedOrderAction, nRequestID);
        }
        
        public int ReqOrderAction(CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqOrderAction(m_handler, ref pInputOrderAction, nRequestID);
        }
        
        public int ReqQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID)
        {
                return TraderDllWrapper.ReqQueryMaxOrderVolume(m_handler, ref pQueryMaxOrderVolume, nRequestID);
        }
        
        public int ReqSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID)
        {
                return TraderDllWrapper.ReqSettlementInfoConfirm(m_handler, ref pSettlementInfoConfirm, nRequestID);
        }
        
        public int ReqRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqRemoveParkedOrder(m_handler, ref pRemoveParkedOrder, nRequestID);
        }
        
        public int ReqRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqRemoveParkedOrderAction(m_handler, ref pRemoveParkedOrderAction, nRequestID);
        }
        
        public int ReqExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqExecOrderInsert(m_handler, ref pInputExecOrder, nRequestID);
        }
        
        public int ReqExecOrderAction(CThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqExecOrderAction(m_handler, ref pInputExecOrderAction, nRequestID);
        }
        
        public int ReqForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, int nRequestID)
        {
                return TraderDllWrapper.ReqForQuoteInsert(m_handler, ref pInputForQuote, nRequestID);
        }
        
        public int ReqQuoteInsert(CThostFtdcInputQuoteField pInputQuote, int nRequestID)
        {
                return TraderDllWrapper.ReqQuoteInsert(m_handler, ref pInputQuote, nRequestID);
        }
        
        public int ReqQuoteAction(CThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID)
        {
                return TraderDllWrapper.ReqQuoteAction(m_handler, ref pInputQuoteAction, nRequestID);
        }
        
        public int ReqBatchOrderAction(CThostFtdcInputBatchOrderActionField pInputBatchOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqBatchOrderAction(m_handler, ref pInputBatchOrderAction, nRequestID);
        }
        
        public int ReqOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose, int nRequestID)
        {
                return TraderDllWrapper.ReqOptionSelfCloseInsert(m_handler, ref pInputOptionSelfClose, nRequestID);
        }
        
        public int ReqOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction, int nRequestID)
        {
                return TraderDllWrapper.ReqOptionSelfCloseAction(m_handler, ref pInputOptionSelfCloseAction, nRequestID);
        }
        
        public int ReqCombActionInsert(CThostFtdcInputCombActionField pInputCombAction, int nRequestID)
        {
                return TraderDllWrapper.ReqCombActionInsert(m_handler, ref pInputCombAction, nRequestID);
        }
        
        public int ReqQryOrder(CThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqQryOrder(m_handler, ref pQryOrder, nRequestID);
        }
        
        public int ReqQryTrade(CThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTrade(m_handler, ref pQryTrade, nRequestID);
        }
        
        public int ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestorPosition(m_handler, ref pQryInvestorPosition, nRequestID);
        }
        
        public int ReqQryTradingAccount(CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTradingAccount(m_handler, ref pQryTradingAccount, nRequestID);
        }
        
        public int ReqQryInvestor(CThostFtdcQryInvestorField pQryInvestor, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestor(m_handler, ref pQryInvestor, nRequestID);
        }
        
        public int ReqQryTradingCode(CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTradingCode(m_handler, ref pQryTradingCode, nRequestID);
        }
        
        public int ReqQryInstrumentMarginRate(CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInstrumentMarginRate(m_handler, ref pQryInstrumentMarginRate, nRequestID);
        }
        
        public int ReqQryInstrumentCommissionRate(CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInstrumentCommissionRate(m_handler, ref pQryInstrumentCommissionRate, nRequestID);
        }
        
        public int ReqQryExchange(CThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
                return TraderDllWrapper.ReqQryExchange(m_handler, ref pQryExchange, nRequestID);
        }
        
        public int ReqQryProduct(CThostFtdcQryProductField pQryProduct, int nRequestID)
        {
                return TraderDllWrapper.ReqQryProduct(m_handler, ref pQryProduct, nRequestID);
        }
        
        public int ReqQryInstrument(CThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInstrument(m_handler, ref pQryInstrument, nRequestID);
        }
        
        public int ReqQryDepthMarketData(CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID)
        {
                return TraderDllWrapper.ReqQryDepthMarketData(m_handler, ref pQryDepthMarketData, nRequestID);
        }
        
        public int ReqQrySettlementInfo(CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySettlementInfo(m_handler, ref pQrySettlementInfo, nRequestID);
        }
        
        public int ReqQryTransferBank(CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTransferBank(m_handler, ref pQryTransferBank, nRequestID);
        }
        
        public int ReqQryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestorPositionDetail(m_handler, ref pQryInvestorPositionDetail, nRequestID);
        }
        
        public int ReqQryNotice(CThostFtdcQryNoticeField pQryNotice, int nRequestID)
        {
                return TraderDllWrapper.ReqQryNotice(m_handler, ref pQryNotice, nRequestID);
        }
        
        public int ReqQrySettlementInfoConfirm(CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySettlementInfoConfirm(m_handler, ref pQrySettlementInfoConfirm, nRequestID);
        }
        
        public int ReqQryInvestorPositionCombineDetail(CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestorPositionCombineDetail(m_handler, ref pQryInvestorPositionCombineDetail, nRequestID);
        }
        
        public int ReqQryCFMMCTradingAccountKey(CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey, int nRequestID)
        {
                return TraderDllWrapper.ReqQryCFMMCTradingAccountKey(m_handler, ref pQryCFMMCTradingAccountKey, nRequestID);
        }
        
        public int ReqQryEWarrantOffset(CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID)
        {
                return TraderDllWrapper.ReqQryEWarrantOffset(m_handler, ref pQryEWarrantOffset, nRequestID);
        }
        
        public int ReqQryInvestorProductGroupMargin(CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestorProductGroupMargin(m_handler, ref pQryInvestorProductGroupMargin, nRequestID);
        }
        
        public int ReqQryExchangeMarginRate(CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryExchangeMarginRate(m_handler, ref pQryExchangeMarginRate, nRequestID);
        }
        
        public int ReqQryExchangeMarginRateAdjust(CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust, int nRequestID)
        {
                return TraderDllWrapper.ReqQryExchangeMarginRateAdjust(m_handler, ref pQryExchangeMarginRateAdjust, nRequestID);
        }
        
        public int ReqQryExchangeRate(CThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryExchangeRate(m_handler, ref pQryExchangeRate, nRequestID);
        }
        
        public int ReqQrySecAgentACIDMap(CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySecAgentACIDMap(m_handler, ref pQrySecAgentACIDMap, nRequestID);
        }
        
        public int ReqQryProductExchRate(CThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryProductExchRate(m_handler, ref pQryProductExchRate, nRequestID);
        }
        
        public int ReqQryProductGroup(CThostFtdcQryProductGroupField pQryProductGroup, int nRequestID)
        {
                return TraderDllWrapper.ReqQryProductGroup(m_handler, ref pQryProductGroup, nRequestID);
        }
        
        public int ReqQryMMInstrumentCommissionRate(CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryMMInstrumentCommissionRate(m_handler, ref pQryMMInstrumentCommissionRate, nRequestID);
        }
        
        public int ReqQryMMOptionInstrCommRate(CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryMMOptionInstrCommRate(m_handler, ref pQryMMOptionInstrCommRate, nRequestID);
        }
        
        public int ReqQryInstrumentOrderCommRate(CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInstrumentOrderCommRate(m_handler, ref pQryInstrumentOrderCommRate, nRequestID);
        }
        
        public int ReqQrySecAgentTradingAccount(CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySecAgentTradingAccount(m_handler, ref pQryTradingAccount, nRequestID);
        }
        
        public int ReqQrySecAgentCheckMode(CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySecAgentCheckMode(m_handler, ref pQrySecAgentCheckMode, nRequestID);
        }
        
        public int ReqQrySecAgentTradeInfo(CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo, int nRequestID)
        {
                return TraderDllWrapper.ReqQrySecAgentTradeInfo(m_handler, ref pQrySecAgentTradeInfo, nRequestID);
        }
        
        public int ReqQryOptionInstrTradeCost(CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID)
        {
                return TraderDllWrapper.ReqQryOptionInstrTradeCost(m_handler, ref pQryOptionInstrTradeCost, nRequestID);
        }
        
        public int ReqQryOptionInstrCommRate(CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID)
        {
                return TraderDllWrapper.ReqQryOptionInstrCommRate(m_handler, ref pQryOptionInstrCommRate, nRequestID);
        }
        
        public int ReqQryExecOrder(CThostFtdcQryExecOrderField pQryExecOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqQryExecOrder(m_handler, ref pQryExecOrder, nRequestID);
        }
        
        public int ReqQryForQuote(CThostFtdcQryForQuoteField pQryForQuote, int nRequestID)
        {
                return TraderDllWrapper.ReqQryForQuote(m_handler, ref pQryForQuote, nRequestID);
        }
        
        public int ReqQryQuote(CThostFtdcQryQuoteField pQryQuote, int nRequestID)
        {
                return TraderDllWrapper.ReqQryQuote(m_handler, ref pQryQuote, nRequestID);
        }
        
        public int ReqQryOptionSelfClose(CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose, int nRequestID)
        {
                return TraderDllWrapper.ReqQryOptionSelfClose(m_handler, ref pQryOptionSelfClose, nRequestID);
        }
        
        public int ReqQryInvestUnit(CThostFtdcQryInvestUnitField pQryInvestUnit, int nRequestID)
        {
                return TraderDllWrapper.ReqQryInvestUnit(m_handler, ref pQryInvestUnit, nRequestID);
        }
        
        public int ReqQryCombInstrumentGuard(CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID)
        {
                return TraderDllWrapper.ReqQryCombInstrumentGuard(m_handler, ref pQryCombInstrumentGuard, nRequestID);
        }
        
        public int ReqQryCombAction(CThostFtdcQryCombActionField pQryCombAction, int nRequestID)
        {
                return TraderDllWrapper.ReqQryCombAction(m_handler, ref pQryCombAction, nRequestID);
        }
        
        public int ReqQryTransferSerial(CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTransferSerial(m_handler, ref pQryTransferSerial, nRequestID);
        }
        
        public int ReqQryAccountregister(CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID)
        {
                return TraderDllWrapper.ReqQryAccountregister(m_handler, ref pQryAccountregister, nRequestID);
        }
        
        public int ReqQryContractBank(CThostFtdcQryContractBankField pQryContractBank, int nRequestID)
        {
                return TraderDllWrapper.ReqQryContractBank(m_handler, ref pQryContractBank, nRequestID);
        }
        
        public int ReqQryParkedOrder(CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID)
        {
                return TraderDllWrapper.ReqQryParkedOrder(m_handler, ref pQryParkedOrder, nRequestID);
        }
        
        public int ReqQryParkedOrderAction(CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID)
        {
                return TraderDllWrapper.ReqQryParkedOrderAction(m_handler, ref pQryParkedOrderAction, nRequestID);
        }
        
        public int ReqQryTradingNotice(CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID)
        {
                return TraderDllWrapper.ReqQryTradingNotice(m_handler, ref pQryTradingNotice, nRequestID);
        }
        
        public int ReqQryBrokerTradingParams(CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID)
        {
                return TraderDllWrapper.ReqQryBrokerTradingParams(m_handler, ref pQryBrokerTradingParams, nRequestID);
        }
        
        public int ReqQryBrokerTradingAlgos(CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID)
        {
                return TraderDllWrapper.ReqQryBrokerTradingAlgos(m_handler, ref pQryBrokerTradingAlgos, nRequestID);
        }
        
        public int ReqQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID)
        {
                return TraderDllWrapper.ReqQueryCFMMCTradingAccountToken(m_handler, ref pQueryCFMMCTradingAccountToken, nRequestID);
        }
        
        public int ReqFromBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
                return TraderDllWrapper.ReqFromBankToFutureByFuture(m_handler, ref pReqTransfer, nRequestID);
        }
        
        public int ReqFromFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
                return TraderDllWrapper.ReqFromFutureToBankByFuture(m_handler, ref pReqTransfer, nRequestID);
        }
        
        public int ReqQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID)
        {
                return TraderDllWrapper.ReqQueryBankAccountMoneyByFuture(m_handler, ref pReqQueryAccount, nRequestID);
        }
        
        #endregion

        #region RaiseEvents
        private void RaiseOnFrontConnected()
        {
            
            EventArgs eventArgs = new EventArgs();
            Volatile.Read(ref OnFrontConnected)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnFrontDisconnected(int nReason)
        {
            
            OnFrontDisconnectedEventArgs eventArgs = new OnFrontDisconnectedEventArgs(nReason);
            Volatile.Read(ref OnFrontDisconnected)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnHeartBeatWarning(int nTimeLapse)
        {
            
            OnHeartBeatWarningEventArgs eventArgs = new OnHeartBeatWarningEventArgs(nTimeLapse);
            Volatile.Read(ref OnHeartBeatWarning)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspAuthenticate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspAuthenticateField? pRspAuthenticateField = null;
            if (ptr0 != IntPtr.Zero)
                pRspAuthenticateField = Marshal.PtrToStructure<CThostFtdcRspAuthenticateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspAuthenticateEventArgs eventArgs = new OnRspAuthenticateEventArgs(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspAuthenticate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUserLogin(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspUserLoginField? pRspUserLogin = null;
            if (ptr0 != IntPtr.Zero)
                pRspUserLogin = Marshal.PtrToStructure<CThostFtdcRspUserLoginField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUserLoginEventArgs eventArgs = new OnRspUserLoginEventArgs(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUserLogin)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUserLogout(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcUserLogoutField? pUserLogout = null;
            if (ptr0 != IntPtr.Zero)
                pUserLogout = Marshal.PtrToStructure<CThostFtdcUserLogoutField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUserLogoutEventArgs eventArgs = new OnRspUserLogoutEventArgs(pUserLogout, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUserLogout)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUserPasswordUpdate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcUserPasswordUpdateField? pUserPasswordUpdate = null;
            if (ptr0 != IntPtr.Zero)
                pUserPasswordUpdate = Marshal.PtrToStructure<CThostFtdcUserPasswordUpdateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUserPasswordUpdateEventArgs eventArgs = new OnRspUserPasswordUpdateEventArgs(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUserPasswordUpdate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspTradingAccountPasswordUpdate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradingAccountPasswordUpdateField? pTradingAccountPasswordUpdate = null;
            if (ptr0 != IntPtr.Zero)
                pTradingAccountPasswordUpdate = Marshal.PtrToStructure<CThostFtdcTradingAccountPasswordUpdateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspTradingAccountPasswordUpdateEventArgs eventArgs = new OnRspTradingAccountPasswordUpdateEventArgs(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspTradingAccountPasswordUpdate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUserAuthMethod(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspUserAuthMethodField? pRspUserAuthMethod = null;
            if (ptr0 != IntPtr.Zero)
                pRspUserAuthMethod = Marshal.PtrToStructure<CThostFtdcRspUserAuthMethodField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUserAuthMethodEventArgs eventArgs = new OnRspUserAuthMethodEventArgs(pRspUserAuthMethod, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUserAuthMethod)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspGenUserCaptcha(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspGenUserCaptchaField? pRspGenUserCaptcha = null;
            if (ptr0 != IntPtr.Zero)
                pRspGenUserCaptcha = Marshal.PtrToStructure<CThostFtdcRspGenUserCaptchaField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspGenUserCaptchaEventArgs eventArgs = new OnRspGenUserCaptchaEventArgs(pRspGenUserCaptcha, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspGenUserCaptcha)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspGenUserText(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspGenUserTextField? pRspGenUserText = null;
            if (ptr0 != IntPtr.Zero)
                pRspGenUserText = Marshal.PtrToStructure<CThostFtdcRspGenUserTextField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspGenUserTextEventArgs eventArgs = new OnRspGenUserTextEventArgs(pRspGenUserText, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspGenUserText)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspOrderInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputOrderField? pInputOrder = null;
            if (ptr0 != IntPtr.Zero)
                pInputOrder = Marshal.PtrToStructure<CThostFtdcInputOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspOrderInsertEventArgs eventArgs = new OnRspOrderInsertEventArgs(pInputOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspOrderInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspParkedOrderInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcParkedOrderField? pParkedOrder = null;
            if (ptr0 != IntPtr.Zero)
                pParkedOrder = Marshal.PtrToStructure<CThostFtdcParkedOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspParkedOrderInsertEventArgs eventArgs = new OnRspParkedOrderInsertEventArgs(pParkedOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspParkedOrderInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspParkedOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcParkedOrderActionField? pParkedOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pParkedOrderAction = Marshal.PtrToStructure<CThostFtdcParkedOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspParkedOrderActionEventArgs eventArgs = new OnRspParkedOrderActionEventArgs(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspParkedOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputOrderActionField? pInputOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputOrderAction = Marshal.PtrToStructure<CThostFtdcInputOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspOrderActionEventArgs eventArgs = new OnRspOrderActionEventArgs(pInputOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQueryMaxOrderVolume(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcQueryMaxOrderVolumeField? pQueryMaxOrderVolume = null;
            if (ptr0 != IntPtr.Zero)
                pQueryMaxOrderVolume = Marshal.PtrToStructure<CThostFtdcQueryMaxOrderVolumeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQueryMaxOrderVolumeEventArgs eventArgs = new OnRspQueryMaxOrderVolumeEventArgs(pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQueryMaxOrderVolume)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspSettlementInfoConfirm(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm = null;
            if (ptr0 != IntPtr.Zero)
                pSettlementInfoConfirm = Marshal.PtrToStructure<CThostFtdcSettlementInfoConfirmField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspSettlementInfoConfirmEventArgs eventArgs = new OnRspSettlementInfoConfirmEventArgs(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspSettlementInfoConfirm)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspRemoveParkedOrder(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRemoveParkedOrderField? pRemoveParkedOrder = null;
            if (ptr0 != IntPtr.Zero)
                pRemoveParkedOrder = Marshal.PtrToStructure<CThostFtdcRemoveParkedOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspRemoveParkedOrderEventArgs eventArgs = new OnRspRemoveParkedOrderEventArgs(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspRemoveParkedOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspRemoveParkedOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcRemoveParkedOrderActionField? pRemoveParkedOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pRemoveParkedOrderAction = Marshal.PtrToStructure<CThostFtdcRemoveParkedOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspRemoveParkedOrderActionEventArgs eventArgs = new OnRspRemoveParkedOrderActionEventArgs(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspRemoveParkedOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspExecOrderInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputExecOrderField? pInputExecOrder = null;
            if (ptr0 != IntPtr.Zero)
                pInputExecOrder = Marshal.PtrToStructure<CThostFtdcInputExecOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspExecOrderInsertEventArgs eventArgs = new OnRspExecOrderInsertEventArgs(pInputExecOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspExecOrderInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspExecOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputExecOrderActionField? pInputExecOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputExecOrderAction = Marshal.PtrToStructure<CThostFtdcInputExecOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspExecOrderActionEventArgs eventArgs = new OnRspExecOrderActionEventArgs(pInputExecOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspExecOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspForQuoteInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputForQuoteField? pInputForQuote = null;
            if (ptr0 != IntPtr.Zero)
                pInputForQuote = Marshal.PtrToStructure<CThostFtdcInputForQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspForQuoteInsertEventArgs eventArgs = new OnRspForQuoteInsertEventArgs(pInputForQuote, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspForQuoteInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQuoteInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputQuoteField? pInputQuote = null;
            if (ptr0 != IntPtr.Zero)
                pInputQuote = Marshal.PtrToStructure<CThostFtdcInputQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQuoteInsertEventArgs eventArgs = new OnRspQuoteInsertEventArgs(pInputQuote, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQuoteInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQuoteAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputQuoteActionField? pInputQuoteAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputQuoteAction = Marshal.PtrToStructure<CThostFtdcInputQuoteActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQuoteActionEventArgs eventArgs = new OnRspQuoteActionEventArgs(pInputQuoteAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQuoteAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspBatchOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputBatchOrderActionField? pInputBatchOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputBatchOrderAction = Marshal.PtrToStructure<CThostFtdcInputBatchOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspBatchOrderActionEventArgs eventArgs = new OnRspBatchOrderActionEventArgs(pInputBatchOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspBatchOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspOptionSelfCloseInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputOptionSelfCloseField? pInputOptionSelfClose = null;
            if (ptr0 != IntPtr.Zero)
                pInputOptionSelfClose = Marshal.PtrToStructure<CThostFtdcInputOptionSelfCloseField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspOptionSelfCloseInsertEventArgs eventArgs = new OnRspOptionSelfCloseInsertEventArgs(pInputOptionSelfClose, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspOptionSelfCloseInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspOptionSelfCloseAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputOptionSelfCloseActionField? pInputOptionSelfCloseAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputOptionSelfCloseAction = Marshal.PtrToStructure<CThostFtdcInputOptionSelfCloseActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspOptionSelfCloseActionEventArgs eventArgs = new OnRspOptionSelfCloseActionEventArgs(pInputOptionSelfCloseAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspOptionSelfCloseAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspCombActionInsert(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInputCombActionField? pInputCombAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputCombAction = Marshal.PtrToStructure<CThostFtdcInputCombActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspCombActionInsertEventArgs eventArgs = new OnRspCombActionInsertEventArgs(pInputCombAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspCombActionInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryOrder(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcOrderField? pOrder = null;
            if (ptr0 != IntPtr.Zero)
                pOrder = Marshal.PtrToStructure<CThostFtdcOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryOrderEventArgs eventArgs = new OnRspQryOrderEventArgs(pOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTrade(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradeField? pTrade = null;
            if (ptr0 != IntPtr.Zero)
                pTrade = Marshal.PtrToStructure<CThostFtdcTradeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTradeEventArgs eventArgs = new OnRspQryTradeEventArgs(pTrade, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTrade)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestorPosition(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestorPositionField? pInvestorPosition = null;
            if (ptr0 != IntPtr.Zero)
                pInvestorPosition = Marshal.PtrToStructure<CThostFtdcInvestorPositionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestorPositionEventArgs eventArgs = new OnRspQryInvestorPositionEventArgs(pInvestorPosition, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestorPosition)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTradingAccount(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradingAccountField? pTradingAccount = null;
            if (ptr0 != IntPtr.Zero)
                pTradingAccount = Marshal.PtrToStructure<CThostFtdcTradingAccountField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTradingAccountEventArgs eventArgs = new OnRspQryTradingAccountEventArgs(pTradingAccount, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTradingAccount)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestor(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestorField? pInvestor = null;
            if (ptr0 != IntPtr.Zero)
                pInvestor = Marshal.PtrToStructure<CThostFtdcInvestorField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestorEventArgs eventArgs = new OnRspQryInvestorEventArgs(pInvestor, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestor)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTradingCode(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradingCodeField? pTradingCode = null;
            if (ptr0 != IntPtr.Zero)
                pTradingCode = Marshal.PtrToStructure<CThostFtdcTradingCodeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTradingCodeEventArgs eventArgs = new OnRspQryTradingCodeEventArgs(pTradingCode, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTradingCode)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInstrumentMarginRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate = null;
            if (ptr0 != IntPtr.Zero)
                pInstrumentMarginRate = Marshal.PtrToStructure<CThostFtdcInstrumentMarginRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInstrumentMarginRateEventArgs eventArgs = new OnRspQryInstrumentMarginRateEventArgs(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInstrumentMarginRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInstrumentCommissionRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate = null;
            if (ptr0 != IntPtr.Zero)
                pInstrumentCommissionRate = Marshal.PtrToStructure<CThostFtdcInstrumentCommissionRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInstrumentCommissionRateEventArgs eventArgs = new OnRspQryInstrumentCommissionRateEventArgs(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInstrumentCommissionRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryExchange(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcExchangeField? pExchange = null;
            if (ptr0 != IntPtr.Zero)
                pExchange = Marshal.PtrToStructure<CThostFtdcExchangeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryExchangeEventArgs eventArgs = new OnRspQryExchangeEventArgs(pExchange, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryExchange)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryProduct(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcProductField? pProduct = null;
            if (ptr0 != IntPtr.Zero)
                pProduct = Marshal.PtrToStructure<CThostFtdcProductField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryProductEventArgs eventArgs = new OnRspQryProductEventArgs(pProduct, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryProduct)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInstrument(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInstrumentField? pInstrument = null;
            if (ptr0 != IntPtr.Zero)
                pInstrument = Marshal.PtrToStructure<CThostFtdcInstrumentField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInstrumentEventArgs eventArgs = new OnRspQryInstrumentEventArgs(pInstrument, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInstrument)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryDepthMarketData(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcDepthMarketDataField? pDepthMarketData = null;
            if (ptr0 != IntPtr.Zero)
                pDepthMarketData = Marshal.PtrToStructure<CThostFtdcDepthMarketDataField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryDepthMarketDataEventArgs eventArgs = new OnRspQryDepthMarketDataEventArgs(pDepthMarketData, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryDepthMarketData)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySettlementInfo(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSettlementInfoField? pSettlementInfo = null;
            if (ptr0 != IntPtr.Zero)
                pSettlementInfo = Marshal.PtrToStructure<CThostFtdcSettlementInfoField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySettlementInfoEventArgs eventArgs = new OnRspQrySettlementInfoEventArgs(pSettlementInfo, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySettlementInfo)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTransferBank(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTransferBankField? pTransferBank = null;
            if (ptr0 != IntPtr.Zero)
                pTransferBank = Marshal.PtrToStructure<CThostFtdcTransferBankField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTransferBankEventArgs eventArgs = new OnRspQryTransferBankEventArgs(pTransferBank, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTransferBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestorPositionDetail(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail = null;
            if (ptr0 != IntPtr.Zero)
                pInvestorPositionDetail = Marshal.PtrToStructure<CThostFtdcInvestorPositionDetailField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestorPositionDetailEventArgs eventArgs = new OnRspQryInvestorPositionDetailEventArgs(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestorPositionDetail)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryNotice(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcNoticeField? pNotice = null;
            if (ptr0 != IntPtr.Zero)
                pNotice = Marshal.PtrToStructure<CThostFtdcNoticeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryNoticeEventArgs eventArgs = new OnRspQryNoticeEventArgs(pNotice, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryNotice)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySettlementInfoConfirm(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm = null;
            if (ptr0 != IntPtr.Zero)
                pSettlementInfoConfirm = Marshal.PtrToStructure<CThostFtdcSettlementInfoConfirmField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySettlementInfoConfirmEventArgs eventArgs = new OnRspQrySettlementInfoConfirmEventArgs(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySettlementInfoConfirm)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestorPositionCombineDetail(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestorPositionCombineDetailField? pInvestorPositionCombineDetail = null;
            if (ptr0 != IntPtr.Zero)
                pInvestorPositionCombineDetail = Marshal.PtrToStructure<CThostFtdcInvestorPositionCombineDetailField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestorPositionCombineDetailEventArgs eventArgs = new OnRspQryInvestorPositionCombineDetailEventArgs(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestorPositionCombineDetail)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryCFMMCTradingAccountKey(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcCFMMCTradingAccountKeyField? pCFMMCTradingAccountKey = null;
            if (ptr0 != IntPtr.Zero)
                pCFMMCTradingAccountKey = Marshal.PtrToStructure<CThostFtdcCFMMCTradingAccountKeyField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryCFMMCTradingAccountKeyEventArgs eventArgs = new OnRspQryCFMMCTradingAccountKeyEventArgs(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryCFMMCTradingAccountKey)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryEWarrantOffset(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcEWarrantOffsetField? pEWarrantOffset = null;
            if (ptr0 != IntPtr.Zero)
                pEWarrantOffset = Marshal.PtrToStructure<CThostFtdcEWarrantOffsetField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryEWarrantOffsetEventArgs eventArgs = new OnRspQryEWarrantOffsetEventArgs(pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryEWarrantOffset)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestorProductGroupMargin(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestorProductGroupMarginField? pInvestorProductGroupMargin = null;
            if (ptr0 != IntPtr.Zero)
                pInvestorProductGroupMargin = Marshal.PtrToStructure<CThostFtdcInvestorProductGroupMarginField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestorProductGroupMarginEventArgs eventArgs = new OnRspQryInvestorProductGroupMarginEventArgs(pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestorProductGroupMargin)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryExchangeMarginRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcExchangeMarginRateField? pExchangeMarginRate = null;
            if (ptr0 != IntPtr.Zero)
                pExchangeMarginRate = Marshal.PtrToStructure<CThostFtdcExchangeMarginRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryExchangeMarginRateEventArgs eventArgs = new OnRspQryExchangeMarginRateEventArgs(pExchangeMarginRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryExchangeMarginRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryExchangeMarginRateAdjust(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcExchangeMarginRateAdjustField? pExchangeMarginRateAdjust = null;
            if (ptr0 != IntPtr.Zero)
                pExchangeMarginRateAdjust = Marshal.PtrToStructure<CThostFtdcExchangeMarginRateAdjustField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryExchangeMarginRateAdjustEventArgs eventArgs = new OnRspQryExchangeMarginRateAdjustEventArgs(pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryExchangeMarginRateAdjust)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryExchangeRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcExchangeRateField? pExchangeRate = null;
            if (ptr0 != IntPtr.Zero)
                pExchangeRate = Marshal.PtrToStructure<CThostFtdcExchangeRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryExchangeRateEventArgs eventArgs = new OnRspQryExchangeRateEventArgs(pExchangeRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryExchangeRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySecAgentACIDMap(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSecAgentACIDMapField? pSecAgentACIDMap = null;
            if (ptr0 != IntPtr.Zero)
                pSecAgentACIDMap = Marshal.PtrToStructure<CThostFtdcSecAgentACIDMapField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySecAgentACIDMapEventArgs eventArgs = new OnRspQrySecAgentACIDMapEventArgs(pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySecAgentACIDMap)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryProductExchRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcProductExchRateField? pProductExchRate = null;
            if (ptr0 != IntPtr.Zero)
                pProductExchRate = Marshal.PtrToStructure<CThostFtdcProductExchRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryProductExchRateEventArgs eventArgs = new OnRspQryProductExchRateEventArgs(pProductExchRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryProductExchRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryProductGroup(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcProductGroupField? pProductGroup = null;
            if (ptr0 != IntPtr.Zero)
                pProductGroup = Marshal.PtrToStructure<CThostFtdcProductGroupField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryProductGroupEventArgs eventArgs = new OnRspQryProductGroupEventArgs(pProductGroup, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryProductGroup)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryMMInstrumentCommissionRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcMMInstrumentCommissionRateField? pMMInstrumentCommissionRate = null;
            if (ptr0 != IntPtr.Zero)
                pMMInstrumentCommissionRate = Marshal.PtrToStructure<CThostFtdcMMInstrumentCommissionRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryMMInstrumentCommissionRateEventArgs eventArgs = new OnRspQryMMInstrumentCommissionRateEventArgs(pMMInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryMMInstrumentCommissionRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryMMOptionInstrCommRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcMMOptionInstrCommRateField? pMMOptionInstrCommRate = null;
            if (ptr0 != IntPtr.Zero)
                pMMOptionInstrCommRate = Marshal.PtrToStructure<CThostFtdcMMOptionInstrCommRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryMMOptionInstrCommRateEventArgs eventArgs = new OnRspQryMMOptionInstrCommRateEventArgs(pMMOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryMMOptionInstrCommRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInstrumentOrderCommRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInstrumentOrderCommRateField? pInstrumentOrderCommRate = null;
            if (ptr0 != IntPtr.Zero)
                pInstrumentOrderCommRate = Marshal.PtrToStructure<CThostFtdcInstrumentOrderCommRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInstrumentOrderCommRateEventArgs eventArgs = new OnRspQryInstrumentOrderCommRateEventArgs(pInstrumentOrderCommRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInstrumentOrderCommRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySecAgentTradingAccount(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradingAccountField? pTradingAccount = null;
            if (ptr0 != IntPtr.Zero)
                pTradingAccount = Marshal.PtrToStructure<CThostFtdcTradingAccountField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySecAgentTradingAccountEventArgs eventArgs = new OnRspQrySecAgentTradingAccountEventArgs(pTradingAccount, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySecAgentTradingAccount)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySecAgentCheckMode(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSecAgentCheckModeField? pSecAgentCheckMode = null;
            if (ptr0 != IntPtr.Zero)
                pSecAgentCheckMode = Marshal.PtrToStructure<CThostFtdcSecAgentCheckModeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySecAgentCheckModeEventArgs eventArgs = new OnRspQrySecAgentCheckModeEventArgs(pSecAgentCheckMode, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySecAgentCheckMode)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQrySecAgentTradeInfo(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSecAgentTradeInfoField? pSecAgentTradeInfo = null;
            if (ptr0 != IntPtr.Zero)
                pSecAgentTradeInfo = Marshal.PtrToStructure<CThostFtdcSecAgentTradeInfoField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQrySecAgentTradeInfoEventArgs eventArgs = new OnRspQrySecAgentTradeInfoEventArgs(pSecAgentTradeInfo, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQrySecAgentTradeInfo)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryOptionInstrTradeCost(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcOptionInstrTradeCostField? pOptionInstrTradeCost = null;
            if (ptr0 != IntPtr.Zero)
                pOptionInstrTradeCost = Marshal.PtrToStructure<CThostFtdcOptionInstrTradeCostField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryOptionInstrTradeCostEventArgs eventArgs = new OnRspQryOptionInstrTradeCostEventArgs(pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryOptionInstrTradeCost)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryOptionInstrCommRate(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcOptionInstrCommRateField? pOptionInstrCommRate = null;
            if (ptr0 != IntPtr.Zero)
                pOptionInstrCommRate = Marshal.PtrToStructure<CThostFtdcOptionInstrCommRateField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryOptionInstrCommRateEventArgs eventArgs = new OnRspQryOptionInstrCommRateEventArgs(pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryOptionInstrCommRate)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryExecOrder(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcExecOrderField? pExecOrder = null;
            if (ptr0 != IntPtr.Zero)
                pExecOrder = Marshal.PtrToStructure<CThostFtdcExecOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryExecOrderEventArgs eventArgs = new OnRspQryExecOrderEventArgs(pExecOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryExecOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryForQuote(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcForQuoteField? pForQuote = null;
            if (ptr0 != IntPtr.Zero)
                pForQuote = Marshal.PtrToStructure<CThostFtdcForQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryForQuoteEventArgs eventArgs = new OnRspQryForQuoteEventArgs(pForQuote, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryForQuote)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryQuote(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcQuoteField? pQuote = null;
            if (ptr0 != IntPtr.Zero)
                pQuote = Marshal.PtrToStructure<CThostFtdcQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryQuoteEventArgs eventArgs = new OnRspQryQuoteEventArgs(pQuote, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryQuote)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryOptionSelfClose(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcOptionSelfCloseField? pOptionSelfClose = null;
            if (ptr0 != IntPtr.Zero)
                pOptionSelfClose = Marshal.PtrToStructure<CThostFtdcOptionSelfCloseField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryOptionSelfCloseEventArgs eventArgs = new OnRspQryOptionSelfCloseEventArgs(pOptionSelfClose, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryOptionSelfClose)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryInvestUnit(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcInvestUnitField? pInvestUnit = null;
            if (ptr0 != IntPtr.Zero)
                pInvestUnit = Marshal.PtrToStructure<CThostFtdcInvestUnitField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryInvestUnitEventArgs eventArgs = new OnRspQryInvestUnitEventArgs(pInvestUnit, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryInvestUnit)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryCombInstrumentGuard(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcCombInstrumentGuardField? pCombInstrumentGuard = null;
            if (ptr0 != IntPtr.Zero)
                pCombInstrumentGuard = Marshal.PtrToStructure<CThostFtdcCombInstrumentGuardField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryCombInstrumentGuardEventArgs eventArgs = new OnRspQryCombInstrumentGuardEventArgs(pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryCombInstrumentGuard)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryCombAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcCombActionField? pCombAction = null;
            if (ptr0 != IntPtr.Zero)
                pCombAction = Marshal.PtrToStructure<CThostFtdcCombActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryCombActionEventArgs eventArgs = new OnRspQryCombActionEventArgs(pCombAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryCombAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTransferSerial(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTransferSerialField? pTransferSerial = null;
            if (ptr0 != IntPtr.Zero)
                pTransferSerial = Marshal.PtrToStructure<CThostFtdcTransferSerialField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTransferSerialEventArgs eventArgs = new OnRspQryTransferSerialEventArgs(pTransferSerial, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTransferSerial)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryAccountregister(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcAccountregisterField? pAccountregister = null;
            if (ptr0 != IntPtr.Zero)
                pAccountregister = Marshal.PtrToStructure<CThostFtdcAccountregisterField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryAccountregisterEventArgs eventArgs = new OnRspQryAccountregisterEventArgs(pAccountregister, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryAccountregister)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspError(IntPtr ptr0, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr0 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr0);
            OnRspErrorEventArgs eventArgs = new OnRspErrorEventArgs(pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspError)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnOrder(IntPtr ptr0)
        {
            CThostFtdcOrderField? pOrder = null;
            if (ptr0 != IntPtr.Zero)
                pOrder = Marshal.PtrToStructure<CThostFtdcOrderField>(ptr0);
            OnRtnOrderEventArgs eventArgs = new OnRtnOrderEventArgs(pOrder);
            Volatile.Read(ref OnRtnOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnTrade(IntPtr ptr0)
        {
            CThostFtdcTradeField? pTrade = null;
            if (ptr0 != IntPtr.Zero)
                pTrade = Marshal.PtrToStructure<CThostFtdcTradeField>(ptr0);
            OnRtnTradeEventArgs eventArgs = new OnRtnTradeEventArgs(pTrade);
            Volatile.Read(ref OnRtnTrade)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnOrderInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputOrderField? pInputOrder = null;
            if (ptr0 != IntPtr.Zero)
                pInputOrder = Marshal.PtrToStructure<CThostFtdcInputOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnOrderInsertEventArgs eventArgs = new OnErrRtnOrderInsertEventArgs(pInputOrder, pRspInfo);
            Volatile.Read(ref OnErrRtnOrderInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnOrderAction(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcOrderActionField? pOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pOrderAction = Marshal.PtrToStructure<CThostFtdcOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnOrderActionEventArgs eventArgs = new OnErrRtnOrderActionEventArgs(pOrderAction, pRspInfo);
            Volatile.Read(ref OnErrRtnOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnInstrumentStatus(IntPtr ptr0)
        {
            CThostFtdcInstrumentStatusField? pInstrumentStatus = null;
            if (ptr0 != IntPtr.Zero)
                pInstrumentStatus = Marshal.PtrToStructure<CThostFtdcInstrumentStatusField>(ptr0);
            OnRtnInstrumentStatusEventArgs eventArgs = new OnRtnInstrumentStatusEventArgs(pInstrumentStatus);
            Volatile.Read(ref OnRtnInstrumentStatus)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnBulletin(IntPtr ptr0)
        {
            CThostFtdcBulletinField? pBulletin = null;
            if (ptr0 != IntPtr.Zero)
                pBulletin = Marshal.PtrToStructure<CThostFtdcBulletinField>(ptr0);
            OnRtnBulletinEventArgs eventArgs = new OnRtnBulletinEventArgs(pBulletin);
            Volatile.Read(ref OnRtnBulletin)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnTradingNotice(IntPtr ptr0)
        {
            CThostFtdcTradingNoticeInfoField? pTradingNoticeInfo = null;
            if (ptr0 != IntPtr.Zero)
                pTradingNoticeInfo = Marshal.PtrToStructure<CThostFtdcTradingNoticeInfoField>(ptr0);
            OnRtnTradingNoticeEventArgs eventArgs = new OnRtnTradingNoticeEventArgs(pTradingNoticeInfo);
            Volatile.Read(ref OnRtnTradingNotice)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnErrorConditionalOrder(IntPtr ptr0)
        {
            CThostFtdcErrorConditionalOrderField? pErrorConditionalOrder = null;
            if (ptr0 != IntPtr.Zero)
                pErrorConditionalOrder = Marshal.PtrToStructure<CThostFtdcErrorConditionalOrderField>(ptr0);
            OnRtnErrorConditionalOrderEventArgs eventArgs = new OnRtnErrorConditionalOrderEventArgs(pErrorConditionalOrder);
            Volatile.Read(ref OnRtnErrorConditionalOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnExecOrder(IntPtr ptr0)
        {
            CThostFtdcExecOrderField? pExecOrder = null;
            if (ptr0 != IntPtr.Zero)
                pExecOrder = Marshal.PtrToStructure<CThostFtdcExecOrderField>(ptr0);
            OnRtnExecOrderEventArgs eventArgs = new OnRtnExecOrderEventArgs(pExecOrder);
            Volatile.Read(ref OnRtnExecOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnExecOrderInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputExecOrderField? pInputExecOrder = null;
            if (ptr0 != IntPtr.Zero)
                pInputExecOrder = Marshal.PtrToStructure<CThostFtdcInputExecOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnExecOrderInsertEventArgs eventArgs = new OnErrRtnExecOrderInsertEventArgs(pInputExecOrder, pRspInfo);
            Volatile.Read(ref OnErrRtnExecOrderInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnExecOrderAction(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcExecOrderActionField? pExecOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pExecOrderAction = Marshal.PtrToStructure<CThostFtdcExecOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnExecOrderActionEventArgs eventArgs = new OnErrRtnExecOrderActionEventArgs(pExecOrderAction, pRspInfo);
            Volatile.Read(ref OnErrRtnExecOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnForQuoteInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputForQuoteField? pInputForQuote = null;
            if (ptr0 != IntPtr.Zero)
                pInputForQuote = Marshal.PtrToStructure<CThostFtdcInputForQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnForQuoteInsertEventArgs eventArgs = new OnErrRtnForQuoteInsertEventArgs(pInputForQuote, pRspInfo);
            Volatile.Read(ref OnErrRtnForQuoteInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnQuote(IntPtr ptr0)
        {
            CThostFtdcQuoteField? pQuote = null;
            if (ptr0 != IntPtr.Zero)
                pQuote = Marshal.PtrToStructure<CThostFtdcQuoteField>(ptr0);
            OnRtnQuoteEventArgs eventArgs = new OnRtnQuoteEventArgs(pQuote);
            Volatile.Read(ref OnRtnQuote)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnQuoteInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputQuoteField? pInputQuote = null;
            if (ptr0 != IntPtr.Zero)
                pInputQuote = Marshal.PtrToStructure<CThostFtdcInputQuoteField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnQuoteInsertEventArgs eventArgs = new OnErrRtnQuoteInsertEventArgs(pInputQuote, pRspInfo);
            Volatile.Read(ref OnErrRtnQuoteInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnQuoteAction(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcQuoteActionField? pQuoteAction = null;
            if (ptr0 != IntPtr.Zero)
                pQuoteAction = Marshal.PtrToStructure<CThostFtdcQuoteActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnQuoteActionEventArgs eventArgs = new OnErrRtnQuoteActionEventArgs(pQuoteAction, pRspInfo);
            Volatile.Read(ref OnErrRtnQuoteAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnForQuoteRsp(IntPtr ptr0)
        {
            CThostFtdcForQuoteRspField? pForQuoteRsp = null;
            if (ptr0 != IntPtr.Zero)
                pForQuoteRsp = Marshal.PtrToStructure<CThostFtdcForQuoteRspField>(ptr0);
            OnRtnForQuoteRspEventArgs eventArgs = new OnRtnForQuoteRspEventArgs(pForQuoteRsp);
            Volatile.Read(ref OnRtnForQuoteRsp)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnCFMMCTradingAccountToken(IntPtr ptr0)
        {
            CThostFtdcCFMMCTradingAccountTokenField? pCFMMCTradingAccountToken = null;
            if (ptr0 != IntPtr.Zero)
                pCFMMCTradingAccountToken = Marshal.PtrToStructure<CThostFtdcCFMMCTradingAccountTokenField>(ptr0);
            OnRtnCFMMCTradingAccountTokenEventArgs eventArgs = new OnRtnCFMMCTradingAccountTokenEventArgs(pCFMMCTradingAccountToken);
            Volatile.Read(ref OnRtnCFMMCTradingAccountToken)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnBatchOrderAction(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcBatchOrderActionField? pBatchOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pBatchOrderAction = Marshal.PtrToStructure<CThostFtdcBatchOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnBatchOrderActionEventArgs eventArgs = new OnErrRtnBatchOrderActionEventArgs(pBatchOrderAction, pRspInfo);
            Volatile.Read(ref OnErrRtnBatchOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnOptionSelfClose(IntPtr ptr0)
        {
            CThostFtdcOptionSelfCloseField? pOptionSelfClose = null;
            if (ptr0 != IntPtr.Zero)
                pOptionSelfClose = Marshal.PtrToStructure<CThostFtdcOptionSelfCloseField>(ptr0);
            OnRtnOptionSelfCloseEventArgs eventArgs = new OnRtnOptionSelfCloseEventArgs(pOptionSelfClose);
            Volatile.Read(ref OnRtnOptionSelfClose)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnOptionSelfCloseInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputOptionSelfCloseField? pInputOptionSelfClose = null;
            if (ptr0 != IntPtr.Zero)
                pInputOptionSelfClose = Marshal.PtrToStructure<CThostFtdcInputOptionSelfCloseField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnOptionSelfCloseInsertEventArgs eventArgs = new OnErrRtnOptionSelfCloseInsertEventArgs(pInputOptionSelfClose, pRspInfo);
            Volatile.Read(ref OnErrRtnOptionSelfCloseInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnOptionSelfCloseAction(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcOptionSelfCloseActionField? pOptionSelfCloseAction = null;
            if (ptr0 != IntPtr.Zero)
                pOptionSelfCloseAction = Marshal.PtrToStructure<CThostFtdcOptionSelfCloseActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnOptionSelfCloseActionEventArgs eventArgs = new OnErrRtnOptionSelfCloseActionEventArgs(pOptionSelfCloseAction, pRspInfo);
            Volatile.Read(ref OnErrRtnOptionSelfCloseAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnCombAction(IntPtr ptr0)
        {
            CThostFtdcCombActionField? pCombAction = null;
            if (ptr0 != IntPtr.Zero)
                pCombAction = Marshal.PtrToStructure<CThostFtdcCombActionField>(ptr0);
            OnRtnCombActionEventArgs eventArgs = new OnRtnCombActionEventArgs(pCombAction);
            Volatile.Read(ref OnRtnCombAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnCombActionInsert(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcInputCombActionField? pInputCombAction = null;
            if (ptr0 != IntPtr.Zero)
                pInputCombAction = Marshal.PtrToStructure<CThostFtdcInputCombActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnCombActionInsertEventArgs eventArgs = new OnErrRtnCombActionInsertEventArgs(pInputCombAction, pRspInfo);
            Volatile.Read(ref OnErrRtnCombActionInsert)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryContractBank(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcContractBankField? pContractBank = null;
            if (ptr0 != IntPtr.Zero)
                pContractBank = Marshal.PtrToStructure<CThostFtdcContractBankField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryContractBankEventArgs eventArgs = new OnRspQryContractBankEventArgs(pContractBank, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryContractBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryParkedOrder(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcParkedOrderField? pParkedOrder = null;
            if (ptr0 != IntPtr.Zero)
                pParkedOrder = Marshal.PtrToStructure<CThostFtdcParkedOrderField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryParkedOrderEventArgs eventArgs = new OnRspQryParkedOrderEventArgs(pParkedOrder, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryParkedOrder)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryParkedOrderAction(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcParkedOrderActionField? pParkedOrderAction = null;
            if (ptr0 != IntPtr.Zero)
                pParkedOrderAction = Marshal.PtrToStructure<CThostFtdcParkedOrderActionField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryParkedOrderActionEventArgs eventArgs = new OnRspQryParkedOrderActionEventArgs(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryParkedOrderAction)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryTradingNotice(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcTradingNoticeField? pTradingNotice = null;
            if (ptr0 != IntPtr.Zero)
                pTradingNotice = Marshal.PtrToStructure<CThostFtdcTradingNoticeField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryTradingNoticeEventArgs eventArgs = new OnRspQryTradingNoticeEventArgs(pTradingNotice, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryTradingNotice)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryBrokerTradingParams(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcBrokerTradingParamsField? pBrokerTradingParams = null;
            if (ptr0 != IntPtr.Zero)
                pBrokerTradingParams = Marshal.PtrToStructure<CThostFtdcBrokerTradingParamsField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryBrokerTradingParamsEventArgs eventArgs = new OnRspQryBrokerTradingParamsEventArgs(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryBrokerTradingParams)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQryBrokerTradingAlgos(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcBrokerTradingAlgosField? pBrokerTradingAlgos = null;
            if (ptr0 != IntPtr.Zero)
                pBrokerTradingAlgos = Marshal.PtrToStructure<CThostFtdcBrokerTradingAlgosField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQryBrokerTradingAlgosEventArgs eventArgs = new OnRspQryBrokerTradingAlgosEventArgs(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQryBrokerTradingAlgos)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQueryCFMMCTradingAccountToken(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcQueryCFMMCTradingAccountTokenField? pQueryCFMMCTradingAccountToken = null;
            if (ptr0 != IntPtr.Zero)
                pQueryCFMMCTradingAccountToken = Marshal.PtrToStructure<CThostFtdcQueryCFMMCTradingAccountTokenField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQueryCFMMCTradingAccountTokenEventArgs eventArgs = new OnRspQueryCFMMCTradingAccountTokenEventArgs(pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQueryCFMMCTradingAccountToken)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnFromBankToFutureByBank(IntPtr ptr0)
        {
            CThostFtdcRspTransferField? pRspTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pRspTransfer = Marshal.PtrToStructure<CThostFtdcRspTransferField>(ptr0);
            OnRtnFromBankToFutureByBankEventArgs eventArgs = new OnRtnFromBankToFutureByBankEventArgs(pRspTransfer);
            Volatile.Read(ref OnRtnFromBankToFutureByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnFromFutureToBankByBank(IntPtr ptr0)
        {
            CThostFtdcRspTransferField? pRspTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pRspTransfer = Marshal.PtrToStructure<CThostFtdcRspTransferField>(ptr0);
            OnRtnFromFutureToBankByBankEventArgs eventArgs = new OnRtnFromFutureToBankByBankEventArgs(pRspTransfer);
            Volatile.Read(ref OnRtnFromFutureToBankByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromBankToFutureByBank(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromBankToFutureByBankEventArgs eventArgs = new OnRtnRepealFromBankToFutureByBankEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromBankToFutureByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromFutureToBankByBank(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromFutureToBankByBankEventArgs eventArgs = new OnRtnRepealFromFutureToBankByBankEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromFutureToBankByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnFromBankToFutureByFuture(IntPtr ptr0)
        {
            CThostFtdcRspTransferField? pRspTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pRspTransfer = Marshal.PtrToStructure<CThostFtdcRspTransferField>(ptr0);
            OnRtnFromBankToFutureByFutureEventArgs eventArgs = new OnRtnFromBankToFutureByFutureEventArgs(pRspTransfer);
            Volatile.Read(ref OnRtnFromBankToFutureByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnFromFutureToBankByFuture(IntPtr ptr0)
        {
            CThostFtdcRspTransferField? pRspTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pRspTransfer = Marshal.PtrToStructure<CThostFtdcRspTransferField>(ptr0);
            OnRtnFromFutureToBankByFutureEventArgs eventArgs = new OnRtnFromFutureToBankByFutureEventArgs(pRspTransfer);
            Volatile.Read(ref OnRtnFromFutureToBankByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromBankToFutureByFutureManual(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromBankToFutureByFutureManualEventArgs eventArgs = new OnRtnRepealFromBankToFutureByFutureManualEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromBankToFutureByFutureManual)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromFutureToBankByFutureManual(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromFutureToBankByFutureManualEventArgs eventArgs = new OnRtnRepealFromFutureToBankByFutureManualEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromFutureToBankByFutureManual)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnQueryBankBalanceByFuture(IntPtr ptr0)
        {
            CThostFtdcNotifyQueryAccountField? pNotifyQueryAccount = null;
            if (ptr0 != IntPtr.Zero)
                pNotifyQueryAccount = Marshal.PtrToStructure<CThostFtdcNotifyQueryAccountField>(ptr0);
            OnRtnQueryBankBalanceByFutureEventArgs eventArgs = new OnRtnQueryBankBalanceByFutureEventArgs(pNotifyQueryAccount);
            Volatile.Read(ref OnRtnQueryBankBalanceByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnBankToFutureByFuture(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcReqTransferField? pReqTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pReqTransfer = Marshal.PtrToStructure<CThostFtdcReqTransferField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnBankToFutureByFutureEventArgs eventArgs = new OnErrRtnBankToFutureByFutureEventArgs(pReqTransfer, pRspInfo);
            Volatile.Read(ref OnErrRtnBankToFutureByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnFutureToBankByFuture(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcReqTransferField? pReqTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pReqTransfer = Marshal.PtrToStructure<CThostFtdcReqTransferField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnFutureToBankByFutureEventArgs eventArgs = new OnErrRtnFutureToBankByFutureEventArgs(pReqTransfer, pRspInfo);
            Volatile.Read(ref OnErrRtnFutureToBankByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnRepealBankToFutureByFutureManual(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcReqRepealField? pReqRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pReqRepeal = Marshal.PtrToStructure<CThostFtdcReqRepealField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnRepealBankToFutureByFutureManualEventArgs eventArgs = new OnErrRtnRepealBankToFutureByFutureManualEventArgs(pReqRepeal, pRspInfo);
            Volatile.Read(ref OnErrRtnRepealBankToFutureByFutureManual)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnRepealFutureToBankByFutureManual(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcReqRepealField? pReqRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pReqRepeal = Marshal.PtrToStructure<CThostFtdcReqRepealField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnRepealFutureToBankByFutureManualEventArgs eventArgs = new OnErrRtnRepealFutureToBankByFutureManualEventArgs(pReqRepeal, pRspInfo);
            Volatile.Read(ref OnErrRtnRepealFutureToBankByFutureManual)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnErrRtnQueryBankBalanceByFuture(IntPtr ptr0, IntPtr ptr1)
        {
            CThostFtdcReqQueryAccountField? pReqQueryAccount = null;
            if (ptr0 != IntPtr.Zero)
                pReqQueryAccount = Marshal.PtrToStructure<CThostFtdcReqQueryAccountField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnErrRtnQueryBankBalanceByFutureEventArgs eventArgs = new OnErrRtnQueryBankBalanceByFutureEventArgs(pReqQueryAccount, pRspInfo);
            Volatile.Read(ref OnErrRtnQueryBankBalanceByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromBankToFutureByFuture(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromBankToFutureByFutureEventArgs eventArgs = new OnRtnRepealFromBankToFutureByFutureEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromBankToFutureByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnRepealFromFutureToBankByFuture(IntPtr ptr0)
        {
            CThostFtdcRspRepealField? pRspRepeal = null;
            if (ptr0 != IntPtr.Zero)
                pRspRepeal = Marshal.PtrToStructure<CThostFtdcRspRepealField>(ptr0);
            OnRtnRepealFromFutureToBankByFutureEventArgs eventArgs = new OnRtnRepealFromFutureToBankByFutureEventArgs(pRspRepeal);
            Volatile.Read(ref OnRtnRepealFromFutureToBankByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspFromBankToFutureByFuture(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcReqTransferField? pReqTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pReqTransfer = Marshal.PtrToStructure<CThostFtdcReqTransferField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspFromBankToFutureByFutureEventArgs eventArgs = new OnRspFromBankToFutureByFutureEventArgs(pReqTransfer, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspFromBankToFutureByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspFromFutureToBankByFuture(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcReqTransferField? pReqTransfer = null;
            if (ptr0 != IntPtr.Zero)
                pReqTransfer = Marshal.PtrToStructure<CThostFtdcReqTransferField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspFromFutureToBankByFutureEventArgs eventArgs = new OnRspFromFutureToBankByFutureEventArgs(pReqTransfer, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspFromFutureToBankByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspQueryBankAccountMoneyByFuture(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcReqQueryAccountField? pReqQueryAccount = null;
            if (ptr0 != IntPtr.Zero)
                pReqQueryAccount = Marshal.PtrToStructure<CThostFtdcReqQueryAccountField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspQueryBankAccountMoneyByFutureEventArgs eventArgs = new OnRspQueryBankAccountMoneyByFutureEventArgs(pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspQueryBankAccountMoneyByFuture)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnOpenAccountByBank(IntPtr ptr0)
        {
            CThostFtdcOpenAccountField? pOpenAccount = null;
            if (ptr0 != IntPtr.Zero)
                pOpenAccount = Marshal.PtrToStructure<CThostFtdcOpenAccountField>(ptr0);
            OnRtnOpenAccountByBankEventArgs eventArgs = new OnRtnOpenAccountByBankEventArgs(pOpenAccount);
            Volatile.Read(ref OnRtnOpenAccountByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnCancelAccountByBank(IntPtr ptr0)
        {
            CThostFtdcCancelAccountField? pCancelAccount = null;
            if (ptr0 != IntPtr.Zero)
                pCancelAccount = Marshal.PtrToStructure<CThostFtdcCancelAccountField>(ptr0);
            OnRtnCancelAccountByBankEventArgs eventArgs = new OnRtnCancelAccountByBankEventArgs(pCancelAccount);
            Volatile.Read(ref OnRtnCancelAccountByBank)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnChangeAccountByBank(IntPtr ptr0)
        {
            CThostFtdcChangeAccountField? pChangeAccount = null;
            if (ptr0 != IntPtr.Zero)
                pChangeAccount = Marshal.PtrToStructure<CThostFtdcChangeAccountField>(ptr0);
            OnRtnChangeAccountByBankEventArgs eventArgs = new OnRtnChangeAccountByBankEventArgs(pChangeAccount);
            Volatile.Read(ref OnRtnChangeAccountByBank)?.Invoke(this, eventArgs);
        }
         
        #endregion

        #region delegate variables
        OnFrontConnectedDelegate onFrontConnectedDelegate;
        OnFrontDisconnectedDelegate onFrontDisconnectedDelegate;
        OnHeartBeatWarningDelegate onHeartBeatWarningDelegate;
        OnRspAuthenticateDelegate onRspAuthenticateDelegate;
        OnRspUserLoginDelegate onRspUserLoginDelegate;
        OnRspUserLogoutDelegate onRspUserLogoutDelegate;
        OnRspUserPasswordUpdateDelegate onRspUserPasswordUpdateDelegate;
        OnRspTradingAccountPasswordUpdateDelegate onRspTradingAccountPasswordUpdateDelegate;
        OnRspUserAuthMethodDelegate onRspUserAuthMethodDelegate;
        OnRspGenUserCaptchaDelegate onRspGenUserCaptchaDelegate;
        OnRspGenUserTextDelegate onRspGenUserTextDelegate;
        OnRspOrderInsertDelegate onRspOrderInsertDelegate;
        OnRspParkedOrderInsertDelegate onRspParkedOrderInsertDelegate;
        OnRspParkedOrderActionDelegate onRspParkedOrderActionDelegate;
        OnRspOrderActionDelegate onRspOrderActionDelegate;
        OnRspQueryMaxOrderVolumeDelegate onRspQueryMaxOrderVolumeDelegate;
        OnRspSettlementInfoConfirmDelegate onRspSettlementInfoConfirmDelegate;
        OnRspRemoveParkedOrderDelegate onRspRemoveParkedOrderDelegate;
        OnRspRemoveParkedOrderActionDelegate onRspRemoveParkedOrderActionDelegate;
        OnRspExecOrderInsertDelegate onRspExecOrderInsertDelegate;
        OnRspExecOrderActionDelegate onRspExecOrderActionDelegate;
        OnRspForQuoteInsertDelegate onRspForQuoteInsertDelegate;
        OnRspQuoteInsertDelegate onRspQuoteInsertDelegate;
        OnRspQuoteActionDelegate onRspQuoteActionDelegate;
        OnRspBatchOrderActionDelegate onRspBatchOrderActionDelegate;
        OnRspOptionSelfCloseInsertDelegate onRspOptionSelfCloseInsertDelegate;
        OnRspOptionSelfCloseActionDelegate onRspOptionSelfCloseActionDelegate;
        OnRspCombActionInsertDelegate onRspCombActionInsertDelegate;
        OnRspQryOrderDelegate onRspQryOrderDelegate;
        OnRspQryTradeDelegate onRspQryTradeDelegate;
        OnRspQryInvestorPositionDelegate onRspQryInvestorPositionDelegate;
        OnRspQryTradingAccountDelegate onRspQryTradingAccountDelegate;
        OnRspQryInvestorDelegate onRspQryInvestorDelegate;
        OnRspQryTradingCodeDelegate onRspQryTradingCodeDelegate;
        OnRspQryInstrumentMarginRateDelegate onRspQryInstrumentMarginRateDelegate;
        OnRspQryInstrumentCommissionRateDelegate onRspQryInstrumentCommissionRateDelegate;
        OnRspQryExchangeDelegate onRspQryExchangeDelegate;
        OnRspQryProductDelegate onRspQryProductDelegate;
        OnRspQryInstrumentDelegate onRspQryInstrumentDelegate;
        OnRspQryDepthMarketDataDelegate onRspQryDepthMarketDataDelegate;
        OnRspQrySettlementInfoDelegate onRspQrySettlementInfoDelegate;
        OnRspQryTransferBankDelegate onRspQryTransferBankDelegate;
        OnRspQryInvestorPositionDetailDelegate onRspQryInvestorPositionDetailDelegate;
        OnRspQryNoticeDelegate onRspQryNoticeDelegate;
        OnRspQrySettlementInfoConfirmDelegate onRspQrySettlementInfoConfirmDelegate;
        OnRspQryInvestorPositionCombineDetailDelegate onRspQryInvestorPositionCombineDetailDelegate;
        OnRspQryCFMMCTradingAccountKeyDelegate onRspQryCFMMCTradingAccountKeyDelegate;
        OnRspQryEWarrantOffsetDelegate onRspQryEWarrantOffsetDelegate;
        OnRspQryInvestorProductGroupMarginDelegate onRspQryInvestorProductGroupMarginDelegate;
        OnRspQryExchangeMarginRateDelegate onRspQryExchangeMarginRateDelegate;
        OnRspQryExchangeMarginRateAdjustDelegate onRspQryExchangeMarginRateAdjustDelegate;
        OnRspQryExchangeRateDelegate onRspQryExchangeRateDelegate;
        OnRspQrySecAgentACIDMapDelegate onRspQrySecAgentACIDMapDelegate;
        OnRspQryProductExchRateDelegate onRspQryProductExchRateDelegate;
        OnRspQryProductGroupDelegate onRspQryProductGroupDelegate;
        OnRspQryMMInstrumentCommissionRateDelegate onRspQryMMInstrumentCommissionRateDelegate;
        OnRspQryMMOptionInstrCommRateDelegate onRspQryMMOptionInstrCommRateDelegate;
        OnRspQryInstrumentOrderCommRateDelegate onRspQryInstrumentOrderCommRateDelegate;
        OnRspQrySecAgentTradingAccountDelegate onRspQrySecAgentTradingAccountDelegate;
        OnRspQrySecAgentCheckModeDelegate onRspQrySecAgentCheckModeDelegate;
        OnRspQrySecAgentTradeInfoDelegate onRspQrySecAgentTradeInfoDelegate;
        OnRspQryOptionInstrTradeCostDelegate onRspQryOptionInstrTradeCostDelegate;
        OnRspQryOptionInstrCommRateDelegate onRspQryOptionInstrCommRateDelegate;
        OnRspQryExecOrderDelegate onRspQryExecOrderDelegate;
        OnRspQryForQuoteDelegate onRspQryForQuoteDelegate;
        OnRspQryQuoteDelegate onRspQryQuoteDelegate;
        OnRspQryOptionSelfCloseDelegate onRspQryOptionSelfCloseDelegate;
        OnRspQryInvestUnitDelegate onRspQryInvestUnitDelegate;
        OnRspQryCombInstrumentGuardDelegate onRspQryCombInstrumentGuardDelegate;
        OnRspQryCombActionDelegate onRspQryCombActionDelegate;
        OnRspQryTransferSerialDelegate onRspQryTransferSerialDelegate;
        OnRspQryAccountregisterDelegate onRspQryAccountregisterDelegate;
        OnRspErrorDelegate onRspErrorDelegate;
        OnRtnOrderDelegate onRtnOrderDelegate;
        OnRtnTradeDelegate onRtnTradeDelegate;
        OnErrRtnOrderInsertDelegate onErrRtnOrderInsertDelegate;
        OnErrRtnOrderActionDelegate onErrRtnOrderActionDelegate;
        OnRtnInstrumentStatusDelegate onRtnInstrumentStatusDelegate;
        OnRtnBulletinDelegate onRtnBulletinDelegate;
        OnRtnTradingNoticeDelegate onRtnTradingNoticeDelegate;
        OnRtnErrorConditionalOrderDelegate onRtnErrorConditionalOrderDelegate;
        OnRtnExecOrderDelegate onRtnExecOrderDelegate;
        OnErrRtnExecOrderInsertDelegate onErrRtnExecOrderInsertDelegate;
        OnErrRtnExecOrderActionDelegate onErrRtnExecOrderActionDelegate;
        OnErrRtnForQuoteInsertDelegate onErrRtnForQuoteInsertDelegate;
        OnRtnQuoteDelegate onRtnQuoteDelegate;
        OnErrRtnQuoteInsertDelegate onErrRtnQuoteInsertDelegate;
        OnErrRtnQuoteActionDelegate onErrRtnQuoteActionDelegate;
        OnRtnForQuoteRspDelegate onRtnForQuoteRspDelegate;
        OnRtnCFMMCTradingAccountTokenDelegate onRtnCFMMCTradingAccountTokenDelegate;
        OnErrRtnBatchOrderActionDelegate onErrRtnBatchOrderActionDelegate;
        OnRtnOptionSelfCloseDelegate onRtnOptionSelfCloseDelegate;
        OnErrRtnOptionSelfCloseInsertDelegate onErrRtnOptionSelfCloseInsertDelegate;
        OnErrRtnOptionSelfCloseActionDelegate onErrRtnOptionSelfCloseActionDelegate;
        OnRtnCombActionDelegate onRtnCombActionDelegate;
        OnErrRtnCombActionInsertDelegate onErrRtnCombActionInsertDelegate;
        OnRspQryContractBankDelegate onRspQryContractBankDelegate;
        OnRspQryParkedOrderDelegate onRspQryParkedOrderDelegate;
        OnRspQryParkedOrderActionDelegate onRspQryParkedOrderActionDelegate;
        OnRspQryTradingNoticeDelegate onRspQryTradingNoticeDelegate;
        OnRspQryBrokerTradingParamsDelegate onRspQryBrokerTradingParamsDelegate;
        OnRspQryBrokerTradingAlgosDelegate onRspQryBrokerTradingAlgosDelegate;
        OnRspQueryCFMMCTradingAccountTokenDelegate onRspQueryCFMMCTradingAccountTokenDelegate;
        OnRtnFromBankToFutureByBankDelegate onRtnFromBankToFutureByBankDelegate;
        OnRtnFromFutureToBankByBankDelegate onRtnFromFutureToBankByBankDelegate;
        OnRtnRepealFromBankToFutureByBankDelegate onRtnRepealFromBankToFutureByBankDelegate;
        OnRtnRepealFromFutureToBankByBankDelegate onRtnRepealFromFutureToBankByBankDelegate;
        OnRtnFromBankToFutureByFutureDelegate onRtnFromBankToFutureByFutureDelegate;
        OnRtnFromFutureToBankByFutureDelegate onRtnFromFutureToBankByFutureDelegate;
        OnRtnRepealFromBankToFutureByFutureManualDelegate onRtnRepealFromBankToFutureByFutureManualDelegate;
        OnRtnRepealFromFutureToBankByFutureManualDelegate onRtnRepealFromFutureToBankByFutureManualDelegate;
        OnRtnQueryBankBalanceByFutureDelegate onRtnQueryBankBalanceByFutureDelegate;
        OnErrRtnBankToFutureByFutureDelegate onErrRtnBankToFutureByFutureDelegate;
        OnErrRtnFutureToBankByFutureDelegate onErrRtnFutureToBankByFutureDelegate;
        OnErrRtnRepealBankToFutureByFutureManualDelegate onErrRtnRepealBankToFutureByFutureManualDelegate;
        OnErrRtnRepealFutureToBankByFutureManualDelegate onErrRtnRepealFutureToBankByFutureManualDelegate;
        OnErrRtnQueryBankBalanceByFutureDelegate onErrRtnQueryBankBalanceByFutureDelegate;
        OnRtnRepealFromBankToFutureByFutureDelegate onRtnRepealFromBankToFutureByFutureDelegate;
        OnRtnRepealFromFutureToBankByFutureDelegate onRtnRepealFromFutureToBankByFutureDelegate;
        OnRspFromBankToFutureByFutureDelegate onRspFromBankToFutureByFutureDelegate;
        OnRspFromFutureToBankByFutureDelegate onRspFromFutureToBankByFutureDelegate;
        OnRspQueryBankAccountMoneyByFutureDelegate onRspQueryBankAccountMoneyByFutureDelegate;
        OnRtnOpenAccountByBankDelegate onRtnOpenAccountByBankDelegate;
        OnRtnCancelAccountByBankDelegate onRtnCancelAccountByBankDelegate;
        OnRtnChangeAccountByBankDelegate onRtnChangeAccountByBankDelegate;
        #endregion




	}
}
