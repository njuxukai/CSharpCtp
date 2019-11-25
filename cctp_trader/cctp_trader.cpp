#include "cctp_trader.h"
#include "CTrader.h"

int CreateTrader(TraderInfo* trader_info, void** phandler)
{
	*phandler = (void*)(new CTrader(trader_info));
	return 0;
}

int ConnectTrader(void* handler)
{
	CTrader* pTrader = (CTrader*)handler;
	return pTrader->Connect();
}

int DisconnectTrader(void* handler)
{
	CTrader* pTrader = (CTrader*)handler;
	return pTrader->Disconnect();
}

int DestroyTrader(void** phandler)
{
	CTrader* pTrader = (CTrader*)(*phandler);
	if (pTrader != nullptr)
		delete pTrader;
	*phandler = nullptr;
	return 0;
}

const char* GetTradingDay(void* phandler)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->GetTradingDay();
}

int SubmitUserSystemInfo(void* phandler, CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->SubmitUserSystemInfo(pUserSystemInfo);
}

int ReqUserLogout(void* phandler, CThostFtdcUserLogoutField* pUserLogout, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserLogout(pUserLogout, nRequestID);
}

int ReqUserPasswordUpdate(void* phandler, CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserPasswordUpdate(pUserPasswordUpdate, nRequestID);
}

int ReqTradingAccountPasswordUpdate(void* phandler, CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, nRequestID);
}

int ReqUserAuthMethod(void* phandler, CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserAuthMethod(pReqUserAuthMethod, nRequestID);
}

int ReqGenUserCaptcha(void* phandler, CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqGenUserCaptcha(pReqGenUserCaptcha, nRequestID);
}

int ReqGenUserText(void* phandler, CThostFtdcReqGenUserTextField* pReqGenUserText, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqGenUserText(pReqGenUserText, nRequestID);
}

int ReqUserLoginWithCaptcha(void* phandler, CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha, nRequestID);
}

int ReqUserLoginWithText(void* phandler, CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserLoginWithText(pReqUserLoginWithText, nRequestID);
}

int ReqUserLoginWithOTP(void* phandler, CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqUserLoginWithOTP(pReqUserLoginWithOTP, nRequestID);
}

int ReqOrderInsert(void* phandler, CThostFtdcInputOrderField* pInputOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqOrderInsert(pInputOrder, nRequestID);
}

int ReqParkedOrderInsert(void* phandler, CThostFtdcParkedOrderField* pParkedOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqParkedOrderInsert(pParkedOrder, nRequestID);
}

int ReqParkedOrderAction(void* phandler, CThostFtdcParkedOrderActionField* pParkedOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqParkedOrderAction(pParkedOrderAction, nRequestID);
}

int ReqOrderAction(void* phandler, CThostFtdcInputOrderActionField* pInputOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqOrderAction(pInputOrderAction, nRequestID);
}

int ReqQueryMaxOrderVolume(void* phandler, CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQueryMaxOrderVolume(pQueryMaxOrderVolume, nRequestID);
}

int ReqSettlementInfoConfirm(void* phandler, CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqSettlementInfoConfirm(pSettlementInfoConfirm, nRequestID);
}

int ReqRemoveParkedOrder(void* phandler, CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqRemoveParkedOrder(pRemoveParkedOrder, nRequestID);
}

int ReqRemoveParkedOrderAction(void* phandler, CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction, nRequestID);
}

int ReqExecOrderInsert(void* phandler, CThostFtdcInputExecOrderField* pInputExecOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqExecOrderInsert(pInputExecOrder, nRequestID);
}

int ReqExecOrderAction(void* phandler, CThostFtdcInputExecOrderActionField* pInputExecOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqExecOrderAction(pInputExecOrderAction, nRequestID);
}

int ReqForQuoteInsert(void* phandler, CThostFtdcInputForQuoteField* pInputForQuote, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqForQuoteInsert(pInputForQuote, nRequestID);
}

int ReqQuoteInsert(void* phandler, CThostFtdcInputQuoteField* pInputQuote, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQuoteInsert(pInputQuote, nRequestID);
}

int ReqQuoteAction(void* phandler, CThostFtdcInputQuoteActionField* pInputQuoteAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQuoteAction(pInputQuoteAction, nRequestID);
}

int ReqBatchOrderAction(void* phandler, CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqBatchOrderAction(pInputBatchOrderAction, nRequestID);
}

int ReqOptionSelfCloseInsert(void* phandler, CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqOptionSelfCloseInsert(pInputOptionSelfClose, nRequestID);
}

int ReqOptionSelfCloseAction(void* phandler, CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction, nRequestID);
}

int ReqCombActionInsert(void* phandler, CThostFtdcInputCombActionField* pInputCombAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqCombActionInsert(pInputCombAction, nRequestID);
}

int ReqQryOrder(void* phandler, CThostFtdcQryOrderField* pQryOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryOrder(pQryOrder, nRequestID);
}

int ReqQryTrade(void* phandler, CThostFtdcQryTradeField* pQryTrade, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTrade(pQryTrade, nRequestID);
}

int ReqQryInvestorPosition(void* phandler, CThostFtdcQryInvestorPositionField* pQryInvestorPosition, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestorPosition(pQryInvestorPosition, nRequestID);
}

int ReqQryTradingAccount(void* phandler, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTradingAccount(pQryTradingAccount, nRequestID);
}

int ReqQryInvestor(void* phandler, CThostFtdcQryInvestorField* pQryInvestor, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestor(pQryInvestor, nRequestID);
}

int ReqQryTradingCode(void* phandler, CThostFtdcQryTradingCodeField* pQryTradingCode, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTradingCode(pQryTradingCode, nRequestID);
}

int ReqQryInstrumentMarginRate(void* phandler, CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate, nRequestID);
}

int ReqQryInstrumentCommissionRate(void* phandler, CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate, nRequestID);
}

int ReqQryExchange(void* phandler, CThostFtdcQryExchangeField* pQryExchange, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryExchange(pQryExchange, nRequestID);
}

int ReqQryProduct(void* phandler, CThostFtdcQryProductField* pQryProduct, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryProduct(pQryProduct, nRequestID);
}

int ReqQryInstrument(void* phandler, CThostFtdcQryInstrumentField* pQryInstrument, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInstrument(pQryInstrument, nRequestID);
}

int ReqQryDepthMarketData(void* phandler, CThostFtdcQryDepthMarketDataField* pQryDepthMarketData, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryDepthMarketData(pQryDepthMarketData, nRequestID);
}

int ReqQrySettlementInfo(void* phandler, CThostFtdcQrySettlementInfoField* pQrySettlementInfo, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySettlementInfo(pQrySettlementInfo, nRequestID);
}

int ReqQryTransferBank(void* phandler, CThostFtdcQryTransferBankField* pQryTransferBank, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTransferBank(pQryTransferBank, nRequestID);
}

int ReqQryInvestorPositionDetail(void* phandler, CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail, nRequestID);
}

int ReqQryNotice(void* phandler, CThostFtdcQryNoticeField* pQryNotice, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryNotice(pQryNotice, nRequestID);
}

int ReqQrySettlementInfoConfirm(void* phandler, CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm, nRequestID);
}

int ReqQryInvestorPositionCombineDetail(void* phandler, CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail, nRequestID);
}

int ReqQryCFMMCTradingAccountKey(void* phandler, CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey, nRequestID);
}

int ReqQryEWarrantOffset(void* phandler, CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryEWarrantOffset(pQryEWarrantOffset, nRequestID);
}

int ReqQryInvestorProductGroupMargin(void* phandler, CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin, nRequestID);
}

int ReqQryExchangeMarginRate(void* phandler, CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryExchangeMarginRate(pQryExchangeMarginRate, nRequestID);
}

int ReqQryExchangeMarginRateAdjust(void* phandler, CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust, nRequestID);
}

int ReqQryExchangeRate(void* phandler, CThostFtdcQryExchangeRateField* pQryExchangeRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryExchangeRate(pQryExchangeRate, nRequestID);
}

int ReqQrySecAgentACIDMap(void* phandler, CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap, nRequestID);
}

int ReqQryProductExchRate(void* phandler, CThostFtdcQryProductExchRateField* pQryProductExchRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryProductExchRate(pQryProductExchRate, nRequestID);
}

int ReqQryProductGroup(void* phandler, CThostFtdcQryProductGroupField* pQryProductGroup, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryProductGroup(pQryProductGroup, nRequestID);
}

int ReqQryMMInstrumentCommissionRate(void* phandler, CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate, nRequestID);
}

int ReqQryMMOptionInstrCommRate(void* phandler, CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate, nRequestID);
}

int ReqQryInstrumentOrderCommRate(void* phandler, CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate, nRequestID);
}

int ReqQrySecAgentTradingAccount(void* phandler, CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySecAgentTradingAccount(pQryTradingAccount, nRequestID);
}

int ReqQrySecAgentCheckMode(void* phandler, CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode, nRequestID);
}

int ReqQrySecAgentTradeInfo(void* phandler, CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo, nRequestID);
}

int ReqQryOptionInstrTradeCost(void* phandler, CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost, nRequestID);
}

int ReqQryOptionInstrCommRate(void* phandler, CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate, nRequestID);
}

int ReqQryExecOrder(void* phandler, CThostFtdcQryExecOrderField* pQryExecOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryExecOrder(pQryExecOrder, nRequestID);
}

int ReqQryForQuote(void* phandler, CThostFtdcQryForQuoteField* pQryForQuote, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryForQuote(pQryForQuote, nRequestID);
}

int ReqQryQuote(void* phandler, CThostFtdcQryQuoteField* pQryQuote, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryQuote(pQryQuote, nRequestID);
}

int ReqQryOptionSelfClose(void* phandler, CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryOptionSelfClose(pQryOptionSelfClose, nRequestID);
}

int ReqQryInvestUnit(void* phandler, CThostFtdcQryInvestUnitField* pQryInvestUnit, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryInvestUnit(pQryInvestUnit, nRequestID);
}

int ReqQryCombInstrumentGuard(void* phandler, CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard, nRequestID);
}

int ReqQryCombAction(void* phandler, CThostFtdcQryCombActionField* pQryCombAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryCombAction(pQryCombAction, nRequestID);
}

int ReqQryTransferSerial(void* phandler, CThostFtdcQryTransferSerialField* pQryTransferSerial, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTransferSerial(pQryTransferSerial, nRequestID);
}

int ReqQryAccountregister(void* phandler, CThostFtdcQryAccountregisterField* pQryAccountregister, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryAccountregister(pQryAccountregister, nRequestID);
}

int ReqQryContractBank(void* phandler, CThostFtdcQryContractBankField* pQryContractBank, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryContractBank(pQryContractBank, nRequestID);
}

int ReqQryParkedOrder(void* phandler, CThostFtdcQryParkedOrderField* pQryParkedOrder, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryParkedOrder(pQryParkedOrder, nRequestID);
}

int ReqQryParkedOrderAction(void* phandler, CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryParkedOrderAction(pQryParkedOrderAction, nRequestID);
}

int ReqQryTradingNotice(void* phandler, CThostFtdcQryTradingNoticeField* pQryTradingNotice, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryTradingNotice(pQryTradingNotice, nRequestID);
}

int ReqQryBrokerTradingParams(void* phandler, CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryBrokerTradingParams(pQryBrokerTradingParams, nRequestID);
}

int ReqQryBrokerTradingAlgos(void* phandler, CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos, nRequestID);
}

int ReqQueryCFMMCTradingAccountToken(void* phandler, CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, nRequestID);
}

int ReqFromBankToFutureByFuture(void* phandler, CThostFtdcReqTransferField* pReqTransfer, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqFromBankToFutureByFuture(pReqTransfer, nRequestID);
}

int ReqFromFutureToBankByFuture(void* phandler, CThostFtdcReqTransferField* pReqTransfer, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqFromFutureToBankByFuture(pReqTransfer, nRequestID);
}

int ReqQueryBankAccountMoneyByFuture(void* phandler, CThostFtdcReqQueryAccountField* pReqQueryAccount, int nRequestID)
{
    CTrader* pTrader = (CTrader*)phandler;
    return pTrader->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount, nRequestID);
}


void RegisterTradeFPOnFrontConnected(void* phandler, FuncPtrTradeOnFrontConnected fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnFrontConnected(fp);
}

void RegisterTradeFPOnFrontDisconnected(void* phandler, FuncPtrTradeOnFrontDisconnected fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnFrontDisconnected(fp);
}

void RegisterTradeFPOnHeartBeatWarning(void* phandler, FuncPtrTradeOnHeartBeatWarning fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnHeartBeatWarning(fp);
}

void RegisterTradeFPOnRspAuthenticate(void* phandler, FuncPtrTradeOnRspAuthenticate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspAuthenticate(fp);
}

void RegisterTradeFPOnRspUserLogin(void* phandler, FuncPtrTradeOnRspUserLogin fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspUserLogin(fp);
}

void RegisterTradeFPOnRspUserLogout(void* phandler, FuncPtrTradeOnRspUserLogout fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspUserLogout(fp);
}

void RegisterTradeFPOnRspUserPasswordUpdate(void* phandler, FuncPtrTradeOnRspUserPasswordUpdate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspUserPasswordUpdate(fp);
}

void RegisterTradeFPOnRspTradingAccountPasswordUpdate(void* phandler, FuncPtrTradeOnRspTradingAccountPasswordUpdate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspTradingAccountPasswordUpdate(fp);
}

void RegisterTradeFPOnRspUserAuthMethod(void* phandler, FuncPtrTradeOnRspUserAuthMethod fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspUserAuthMethod(fp);
}

void RegisterTradeFPOnRspGenUserCaptcha(void* phandler, FuncPtrTradeOnRspGenUserCaptcha fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspGenUserCaptcha(fp);
}

void RegisterTradeFPOnRspGenUserText(void* phandler, FuncPtrTradeOnRspGenUserText fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspGenUserText(fp);
}

void RegisterTradeFPOnRspOrderInsert(void* phandler, FuncPtrTradeOnRspOrderInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspOrderInsert(fp);
}

void RegisterTradeFPOnRspParkedOrderInsert(void* phandler, FuncPtrTradeOnRspParkedOrderInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspParkedOrderInsert(fp);
}

void RegisterTradeFPOnRspParkedOrderAction(void* phandler, FuncPtrTradeOnRspParkedOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspParkedOrderAction(fp);
}

void RegisterTradeFPOnRspOrderAction(void* phandler, FuncPtrTradeOnRspOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspOrderAction(fp);
}

void RegisterTradeFPOnRspQueryMaxOrderVolume(void* phandler, FuncPtrTradeOnRspQueryMaxOrderVolume fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQueryMaxOrderVolume(fp);
}

void RegisterTradeFPOnRspSettlementInfoConfirm(void* phandler, FuncPtrTradeOnRspSettlementInfoConfirm fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspSettlementInfoConfirm(fp);
}

void RegisterTradeFPOnRspRemoveParkedOrder(void* phandler, FuncPtrTradeOnRspRemoveParkedOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspRemoveParkedOrder(fp);
}

void RegisterTradeFPOnRspRemoveParkedOrderAction(void* phandler, FuncPtrTradeOnRspRemoveParkedOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspRemoveParkedOrderAction(fp);
}

void RegisterTradeFPOnRspExecOrderInsert(void* phandler, FuncPtrTradeOnRspExecOrderInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspExecOrderInsert(fp);
}

void RegisterTradeFPOnRspExecOrderAction(void* phandler, FuncPtrTradeOnRspExecOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspExecOrderAction(fp);
}

void RegisterTradeFPOnRspForQuoteInsert(void* phandler, FuncPtrTradeOnRspForQuoteInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspForQuoteInsert(fp);
}

void RegisterTradeFPOnRspQuoteInsert(void* phandler, FuncPtrTradeOnRspQuoteInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQuoteInsert(fp);
}

void RegisterTradeFPOnRspQuoteAction(void* phandler, FuncPtrTradeOnRspQuoteAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQuoteAction(fp);
}

void RegisterTradeFPOnRspBatchOrderAction(void* phandler, FuncPtrTradeOnRspBatchOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspBatchOrderAction(fp);
}

void RegisterTradeFPOnRspOptionSelfCloseInsert(void* phandler, FuncPtrTradeOnRspOptionSelfCloseInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspOptionSelfCloseInsert(fp);
}

void RegisterTradeFPOnRspOptionSelfCloseAction(void* phandler, FuncPtrTradeOnRspOptionSelfCloseAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspOptionSelfCloseAction(fp);
}

void RegisterTradeFPOnRspCombActionInsert(void* phandler, FuncPtrTradeOnRspCombActionInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspCombActionInsert(fp);
}

void RegisterTradeFPOnRspQryOrder(void* phandler, FuncPtrTradeOnRspQryOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryOrder(fp);
}

void RegisterTradeFPOnRspQryTrade(void* phandler, FuncPtrTradeOnRspQryTrade fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTrade(fp);
}

void RegisterTradeFPOnRspQryInvestorPosition(void* phandler, FuncPtrTradeOnRspQryInvestorPosition fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestorPosition(fp);
}

void RegisterTradeFPOnRspQryTradingAccount(void* phandler, FuncPtrTradeOnRspQryTradingAccount fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTradingAccount(fp);
}

void RegisterTradeFPOnRspQryInvestor(void* phandler, FuncPtrTradeOnRspQryInvestor fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestor(fp);
}

void RegisterTradeFPOnRspQryTradingCode(void* phandler, FuncPtrTradeOnRspQryTradingCode fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTradingCode(fp);
}

void RegisterTradeFPOnRspQryInstrumentMarginRate(void* phandler, FuncPtrTradeOnRspQryInstrumentMarginRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInstrumentMarginRate(fp);
}

void RegisterTradeFPOnRspQryInstrumentCommissionRate(void* phandler, FuncPtrTradeOnRspQryInstrumentCommissionRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInstrumentCommissionRate(fp);
}

void RegisterTradeFPOnRspQryExchange(void* phandler, FuncPtrTradeOnRspQryExchange fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryExchange(fp);
}

void RegisterTradeFPOnRspQryProduct(void* phandler, FuncPtrTradeOnRspQryProduct fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryProduct(fp);
}

void RegisterTradeFPOnRspQryInstrument(void* phandler, FuncPtrTradeOnRspQryInstrument fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInstrument(fp);
}

void RegisterTradeFPOnRspQryDepthMarketData(void* phandler, FuncPtrTradeOnRspQryDepthMarketData fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryDepthMarketData(fp);
}

void RegisterTradeFPOnRspQrySettlementInfo(void* phandler, FuncPtrTradeOnRspQrySettlementInfo fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySettlementInfo(fp);
}

void RegisterTradeFPOnRspQryTransferBank(void* phandler, FuncPtrTradeOnRspQryTransferBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTransferBank(fp);
}

void RegisterTradeFPOnRspQryInvestorPositionDetail(void* phandler, FuncPtrTradeOnRspQryInvestorPositionDetail fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestorPositionDetail(fp);
}

void RegisterTradeFPOnRspQryNotice(void* phandler, FuncPtrTradeOnRspQryNotice fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryNotice(fp);
}

void RegisterTradeFPOnRspQrySettlementInfoConfirm(void* phandler, FuncPtrTradeOnRspQrySettlementInfoConfirm fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySettlementInfoConfirm(fp);
}

void RegisterTradeFPOnRspQryInvestorPositionCombineDetail(void* phandler, FuncPtrTradeOnRspQryInvestorPositionCombineDetail fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestorPositionCombineDetail(fp);
}

void RegisterTradeFPOnRspQryCFMMCTradingAccountKey(void* phandler, FuncPtrTradeOnRspQryCFMMCTradingAccountKey fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryCFMMCTradingAccountKey(fp);
}

void RegisterTradeFPOnRspQryEWarrantOffset(void* phandler, FuncPtrTradeOnRspQryEWarrantOffset fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryEWarrantOffset(fp);
}

void RegisterTradeFPOnRspQryInvestorProductGroupMargin(void* phandler, FuncPtrTradeOnRspQryInvestorProductGroupMargin fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestorProductGroupMargin(fp);
}

void RegisterTradeFPOnRspQryExchangeMarginRate(void* phandler, FuncPtrTradeOnRspQryExchangeMarginRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryExchangeMarginRate(fp);
}

void RegisterTradeFPOnRspQryExchangeMarginRateAdjust(void* phandler, FuncPtrTradeOnRspQryExchangeMarginRateAdjust fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryExchangeMarginRateAdjust(fp);
}

void RegisterTradeFPOnRspQryExchangeRate(void* phandler, FuncPtrTradeOnRspQryExchangeRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryExchangeRate(fp);
}

void RegisterTradeFPOnRspQrySecAgentACIDMap(void* phandler, FuncPtrTradeOnRspQrySecAgentACIDMap fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySecAgentACIDMap(fp);
}

void RegisterTradeFPOnRspQryProductExchRate(void* phandler, FuncPtrTradeOnRspQryProductExchRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryProductExchRate(fp);
}

void RegisterTradeFPOnRspQryProductGroup(void* phandler, FuncPtrTradeOnRspQryProductGroup fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryProductGroup(fp);
}

void RegisterTradeFPOnRspQryMMInstrumentCommissionRate(void* phandler, FuncPtrTradeOnRspQryMMInstrumentCommissionRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryMMInstrumentCommissionRate(fp);
}

void RegisterTradeFPOnRspQryMMOptionInstrCommRate(void* phandler, FuncPtrTradeOnRspQryMMOptionInstrCommRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryMMOptionInstrCommRate(fp);
}

void RegisterTradeFPOnRspQryInstrumentOrderCommRate(void* phandler, FuncPtrTradeOnRspQryInstrumentOrderCommRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInstrumentOrderCommRate(fp);
}

void RegisterTradeFPOnRspQrySecAgentTradingAccount(void* phandler, FuncPtrTradeOnRspQrySecAgentTradingAccount fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySecAgentTradingAccount(fp);
}

void RegisterTradeFPOnRspQrySecAgentCheckMode(void* phandler, FuncPtrTradeOnRspQrySecAgentCheckMode fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySecAgentCheckMode(fp);
}

void RegisterTradeFPOnRspQrySecAgentTradeInfo(void* phandler, FuncPtrTradeOnRspQrySecAgentTradeInfo fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQrySecAgentTradeInfo(fp);
}

void RegisterTradeFPOnRspQryOptionInstrTradeCost(void* phandler, FuncPtrTradeOnRspQryOptionInstrTradeCost fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryOptionInstrTradeCost(fp);
}

void RegisterTradeFPOnRspQryOptionInstrCommRate(void* phandler, FuncPtrTradeOnRspQryOptionInstrCommRate fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryOptionInstrCommRate(fp);
}

void RegisterTradeFPOnRspQryExecOrder(void* phandler, FuncPtrTradeOnRspQryExecOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryExecOrder(fp);
}

void RegisterTradeFPOnRspQryForQuote(void* phandler, FuncPtrTradeOnRspQryForQuote fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryForQuote(fp);
}

void RegisterTradeFPOnRspQryQuote(void* phandler, FuncPtrTradeOnRspQryQuote fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryQuote(fp);
}

void RegisterTradeFPOnRspQryOptionSelfClose(void* phandler, FuncPtrTradeOnRspQryOptionSelfClose fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryOptionSelfClose(fp);
}

void RegisterTradeFPOnRspQryInvestUnit(void* phandler, FuncPtrTradeOnRspQryInvestUnit fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryInvestUnit(fp);
}

void RegisterTradeFPOnRspQryCombInstrumentGuard(void* phandler, FuncPtrTradeOnRspQryCombInstrumentGuard fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryCombInstrumentGuard(fp);
}

void RegisterTradeFPOnRspQryCombAction(void* phandler, FuncPtrTradeOnRspQryCombAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryCombAction(fp);
}

void RegisterTradeFPOnRspQryTransferSerial(void* phandler, FuncPtrTradeOnRspQryTransferSerial fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTransferSerial(fp);
}

void RegisterTradeFPOnRspQryAccountregister(void* phandler, FuncPtrTradeOnRspQryAccountregister fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryAccountregister(fp);
}

void RegisterTradeFPOnRspError(void* phandler, FuncPtrTradeOnRspError fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspError(fp);
}

void RegisterTradeFPOnRtnOrder(void* phandler, FuncPtrTradeOnRtnOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnOrder(fp);
}

void RegisterTradeFPOnRtnTrade(void* phandler, FuncPtrTradeOnRtnTrade fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnTrade(fp);
}

void RegisterTradeFPOnErrRtnOrderInsert(void* phandler, FuncPtrTradeOnErrRtnOrderInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnOrderInsert(fp);
}

void RegisterTradeFPOnErrRtnOrderAction(void* phandler, FuncPtrTradeOnErrRtnOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnOrderAction(fp);
}

void RegisterTradeFPOnRtnInstrumentStatus(void* phandler, FuncPtrTradeOnRtnInstrumentStatus fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnInstrumentStatus(fp);
}

void RegisterTradeFPOnRtnBulletin(void* phandler, FuncPtrTradeOnRtnBulletin fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnBulletin(fp);
}

void RegisterTradeFPOnRtnTradingNotice(void* phandler, FuncPtrTradeOnRtnTradingNotice fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnTradingNotice(fp);
}

void RegisterTradeFPOnRtnErrorConditionalOrder(void* phandler, FuncPtrTradeOnRtnErrorConditionalOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnErrorConditionalOrder(fp);
}

void RegisterTradeFPOnRtnExecOrder(void* phandler, FuncPtrTradeOnRtnExecOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnExecOrder(fp);
}

void RegisterTradeFPOnErrRtnExecOrderInsert(void* phandler, FuncPtrTradeOnErrRtnExecOrderInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnExecOrderInsert(fp);
}

void RegisterTradeFPOnErrRtnExecOrderAction(void* phandler, FuncPtrTradeOnErrRtnExecOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnExecOrderAction(fp);
}

void RegisterTradeFPOnErrRtnForQuoteInsert(void* phandler, FuncPtrTradeOnErrRtnForQuoteInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnForQuoteInsert(fp);
}

void RegisterTradeFPOnRtnQuote(void* phandler, FuncPtrTradeOnRtnQuote fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnQuote(fp);
}

void RegisterTradeFPOnErrRtnQuoteInsert(void* phandler, FuncPtrTradeOnErrRtnQuoteInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnQuoteInsert(fp);
}

void RegisterTradeFPOnErrRtnQuoteAction(void* phandler, FuncPtrTradeOnErrRtnQuoteAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnQuoteAction(fp);
}

void RegisterTradeFPOnRtnForQuoteRsp(void* phandler, FuncPtrTradeOnRtnForQuoteRsp fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnForQuoteRsp(fp);
}

void RegisterTradeFPOnRtnCFMMCTradingAccountToken(void* phandler, FuncPtrTradeOnRtnCFMMCTradingAccountToken fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnCFMMCTradingAccountToken(fp);
}

void RegisterTradeFPOnErrRtnBatchOrderAction(void* phandler, FuncPtrTradeOnErrRtnBatchOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnBatchOrderAction(fp);
}

void RegisterTradeFPOnRtnOptionSelfClose(void* phandler, FuncPtrTradeOnRtnOptionSelfClose fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnOptionSelfClose(fp);
}

void RegisterTradeFPOnErrRtnOptionSelfCloseInsert(void* phandler, FuncPtrTradeOnErrRtnOptionSelfCloseInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnOptionSelfCloseInsert(fp);
}

void RegisterTradeFPOnErrRtnOptionSelfCloseAction(void* phandler, FuncPtrTradeOnErrRtnOptionSelfCloseAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnOptionSelfCloseAction(fp);
}

void RegisterTradeFPOnRtnCombAction(void* phandler, FuncPtrTradeOnRtnCombAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnCombAction(fp);
}

void RegisterTradeFPOnErrRtnCombActionInsert(void* phandler, FuncPtrTradeOnErrRtnCombActionInsert fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnCombActionInsert(fp);
}

void RegisterTradeFPOnRspQryContractBank(void* phandler, FuncPtrTradeOnRspQryContractBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryContractBank(fp);
}

void RegisterTradeFPOnRspQryParkedOrder(void* phandler, FuncPtrTradeOnRspQryParkedOrder fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryParkedOrder(fp);
}

void RegisterTradeFPOnRspQryParkedOrderAction(void* phandler, FuncPtrTradeOnRspQryParkedOrderAction fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryParkedOrderAction(fp);
}

void RegisterTradeFPOnRspQryTradingNotice(void* phandler, FuncPtrTradeOnRspQryTradingNotice fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryTradingNotice(fp);
}

void RegisterTradeFPOnRspQryBrokerTradingParams(void* phandler, FuncPtrTradeOnRspQryBrokerTradingParams fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryBrokerTradingParams(fp);
}

void RegisterTradeFPOnRspQryBrokerTradingAlgos(void* phandler, FuncPtrTradeOnRspQryBrokerTradingAlgos fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQryBrokerTradingAlgos(fp);
}

void RegisterTradeFPOnRspQueryCFMMCTradingAccountToken(void* phandler, FuncPtrTradeOnRspQueryCFMMCTradingAccountToken fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQueryCFMMCTradingAccountToken(fp);
}

void RegisterTradeFPOnRtnFromBankToFutureByBank(void* phandler, FuncPtrTradeOnRtnFromBankToFutureByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnFromBankToFutureByBank(fp);
}

void RegisterTradeFPOnRtnFromFutureToBankByBank(void* phandler, FuncPtrTradeOnRtnFromFutureToBankByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnFromFutureToBankByBank(fp);
}

void RegisterTradeFPOnRtnRepealFromBankToFutureByBank(void* phandler, FuncPtrTradeOnRtnRepealFromBankToFutureByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromBankToFutureByBank(fp);
}

void RegisterTradeFPOnRtnRepealFromFutureToBankByBank(void* phandler, FuncPtrTradeOnRtnRepealFromFutureToBankByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromFutureToBankByBank(fp);
}

void RegisterTradeFPOnRtnFromBankToFutureByFuture(void* phandler, FuncPtrTradeOnRtnFromBankToFutureByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnFromBankToFutureByFuture(fp);
}

void RegisterTradeFPOnRtnFromFutureToBankByFuture(void* phandler, FuncPtrTradeOnRtnFromFutureToBankByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnFromFutureToBankByFuture(fp);
}

void RegisterTradeFPOnRtnRepealFromBankToFutureByFutureManual(void* phandler, FuncPtrTradeOnRtnRepealFromBankToFutureByFutureManual fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromBankToFutureByFutureManual(fp);
}

void RegisterTradeFPOnRtnRepealFromFutureToBankByFutureManual(void* phandler, FuncPtrTradeOnRtnRepealFromFutureToBankByFutureManual fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromFutureToBankByFutureManual(fp);
}

void RegisterTradeFPOnRtnQueryBankBalanceByFuture(void* phandler, FuncPtrTradeOnRtnQueryBankBalanceByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnQueryBankBalanceByFuture(fp);
}

void RegisterTradeFPOnErrRtnBankToFutureByFuture(void* phandler, FuncPtrTradeOnErrRtnBankToFutureByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnBankToFutureByFuture(fp);
}

void RegisterTradeFPOnErrRtnFutureToBankByFuture(void* phandler, FuncPtrTradeOnErrRtnFutureToBankByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnFutureToBankByFuture(fp);
}

void RegisterTradeFPOnErrRtnRepealBankToFutureByFutureManual(void* phandler, FuncPtrTradeOnErrRtnRepealBankToFutureByFutureManual fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnRepealBankToFutureByFutureManual(fp);
}

void RegisterTradeFPOnErrRtnRepealFutureToBankByFutureManual(void* phandler, FuncPtrTradeOnErrRtnRepealFutureToBankByFutureManual fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnRepealFutureToBankByFutureManual(fp);
}

void RegisterTradeFPOnErrRtnQueryBankBalanceByFuture(void* phandler, FuncPtrTradeOnErrRtnQueryBankBalanceByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnErrRtnQueryBankBalanceByFuture(fp);
}

void RegisterTradeFPOnRtnRepealFromBankToFutureByFuture(void* phandler, FuncPtrTradeOnRtnRepealFromBankToFutureByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromBankToFutureByFuture(fp);
}

void RegisterTradeFPOnRtnRepealFromFutureToBankByFuture(void* phandler, FuncPtrTradeOnRtnRepealFromFutureToBankByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnRepealFromFutureToBankByFuture(fp);
}

void RegisterTradeFPOnRspFromBankToFutureByFuture(void* phandler, FuncPtrTradeOnRspFromBankToFutureByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspFromBankToFutureByFuture(fp);
}

void RegisterTradeFPOnRspFromFutureToBankByFuture(void* phandler, FuncPtrTradeOnRspFromFutureToBankByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspFromFutureToBankByFuture(fp);
}

void RegisterTradeFPOnRspQueryBankAccountMoneyByFuture(void* phandler, FuncPtrTradeOnRspQueryBankAccountMoneyByFuture fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRspQueryBankAccountMoneyByFuture(fp);
}

void RegisterTradeFPOnRtnOpenAccountByBank(void* phandler, FuncPtrTradeOnRtnOpenAccountByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnOpenAccountByBank(fp);
}

void RegisterTradeFPOnRtnCancelAccountByBank(void* phandler, FuncPtrTradeOnRtnCancelAccountByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnCancelAccountByBank(fp);
}

void RegisterTradeFPOnRtnChangeAccountByBank(void* phandler, FuncPtrTradeOnRtnChangeAccountByBank fp)
{
    CTrader* pTrader = (CTrader*)phandler;
    pTrader->registerFP_OnRtnChangeAccountByBank(fp);
}
