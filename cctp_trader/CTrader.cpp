#include "CTrader.h"

CTrader::CTrader(TraderInfo* trader_info)
{

	memcpy(&m_trader_info, trader_info, sizeof(TraderInfo));
	m_pApi = nullptr;
    InitFlags();

}


CTrader::~CTrader()
{
	Disconnect();
}

int CTrader::Connect()
{
	m_pApi = CThostFtdcTraderApi::CreateFtdcTraderApi(m_trader_info.FlowPath);
	m_pApi->RegisterSpi(this);
	m_pApi->RegisterFront(m_trader_info.FrontID);
	m_pApi->SubscribePrivateTopic(THOST_TERT_RESTART);
	m_pApi->SubscribePublicTopic(THOST_TERT_RESTART);
	m_pApi->Init();
	return 0;

}

int CTrader::Disconnect()
{
	if(m_pApi)
	{
		m_pApi->RegisterSpi(NULL);
		m_pApi->Release();
		m_pApi = nullptr;
	}
	return 0;
}

void CTrader::OnFrontConnected()
{
	if (m_trader_info.AuthKind == NO_AUTH)
	{
		ReqUserLogin();
	}
	else
	{
		ReqAuthenticate();
	}

	if (m_onFrontConnectedRegistered)
	{
		m_fpOnFrontConnected();
	}
}

void CTrader::ReqUserLogin()
{
	CThostFtdcReqUserLoginField userLoginField = { 0 };
	strcpy_s(userLoginField.BrokerID, m_trader_info.BrokerID);
	strcpy_s(userLoginField.UserID, m_trader_info.UserID);
	strcpy_s(userLoginField.Password, m_trader_info.Password);
	m_pApi->ReqUserLogin(&userLoginField, 1);
}

void CTrader::ReqAuthenticate()
{
	CThostFtdcReqAuthenticateField field = { 0 };
	strcpy_s(field.BrokerID, m_trader_info.BrokerID);
	strcpy_s(field.UserID, m_trader_info.UserID);
	strcpy_s(field.AppID, m_trader_info.AppID);
	strcpy_s(field.AuthCode, m_trader_info.AuthCode);
	m_pApi->ReqAuthenticate(&field, 0);
}

void CTrader::OnRspAuthenticate(CThostFtdcRspAuthenticateField* pRspAuthenticateField,
	CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{

	if (pRspInfo != nullptr && pRspInfo->ErrorID == 0)
	{
		ReqUserLogin();
	}

	if (m_onRspAuthenticateRegistered)
	{
		m_fpOnRspAuthenticate(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
	}
}

void CTrader::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin,
	CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{
	if (pRspInfo != nullptr && pRspInfo->ErrorID == 0)
	{
		CThostFtdcSettlementInfoConfirmField confirmField = { 0 };
		strcpy_s(confirmField.BrokerID, m_trader_info.BrokerID);
		strcpy_s(confirmField.InvestorID, m_trader_info.InvestorID);
		m_pApi->ReqSettlementInfoConfirm(&confirmField, 0);
	}

	if (m_onRspUserLoginRegistered)
	{
		m_fpOnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
	}
}

void CTrader::InitFlags()
{
    m_onFrontConnectedRegistered = false;
    m_onFrontDisconnectedRegistered = false;
    m_onHeartBeatWarningRegistered = false;
    m_onRspAuthenticateRegistered = false;
    m_onRspUserLoginRegistered = false;
    m_onRspUserLogoutRegistered = false;
    m_onRspUserPasswordUpdateRegistered = false;
    m_onRspTradingAccountPasswordUpdateRegistered = false;
    m_onRspUserAuthMethodRegistered = false;
    m_onRspGenUserCaptchaRegistered = false;
    m_onRspGenUserTextRegistered = false;
    m_onRspOrderInsertRegistered = false;
    m_onRspParkedOrderInsertRegistered = false;
    m_onRspParkedOrderActionRegistered = false;
    m_onRspOrderActionRegistered = false;
    m_onRspQueryMaxOrderVolumeRegistered = false;
    m_onRspSettlementInfoConfirmRegistered = false;
    m_onRspRemoveParkedOrderRegistered = false;
    m_onRspRemoveParkedOrderActionRegistered = false;
    m_onRspExecOrderInsertRegistered = false;
    m_onRspExecOrderActionRegistered = false;
    m_onRspForQuoteInsertRegistered = false;
    m_onRspQuoteInsertRegistered = false;
    m_onRspQuoteActionRegistered = false;
    m_onRspBatchOrderActionRegistered = false;
    m_onRspOptionSelfCloseInsertRegistered = false;
    m_onRspOptionSelfCloseActionRegistered = false;
    m_onRspCombActionInsertRegistered = false;
    m_onRspQryOrderRegistered = false;
    m_onRspQryTradeRegistered = false;
    m_onRspQryInvestorPositionRegistered = false;
    m_onRspQryTradingAccountRegistered = false;
    m_onRspQryInvestorRegistered = false;
    m_onRspQryTradingCodeRegistered = false;
    m_onRspQryInstrumentMarginRateRegistered = false;
    m_onRspQryInstrumentCommissionRateRegistered = false;
    m_onRspQryExchangeRegistered = false;
    m_onRspQryProductRegistered = false;
    m_onRspQryInstrumentRegistered = false;
    m_onRspQryDepthMarketDataRegistered = false;
    m_onRspQrySettlementInfoRegistered = false;
    m_onRspQryTransferBankRegistered = false;
    m_onRspQryInvestorPositionDetailRegistered = false;
    m_onRspQryNoticeRegistered = false;
    m_onRspQrySettlementInfoConfirmRegistered = false;
    m_onRspQryInvestorPositionCombineDetailRegistered = false;
    m_onRspQryCFMMCTradingAccountKeyRegistered = false;
    m_onRspQryEWarrantOffsetRegistered = false;
    m_onRspQryInvestorProductGroupMarginRegistered = false;
    m_onRspQryExchangeMarginRateRegistered = false;
    m_onRspQryExchangeMarginRateAdjustRegistered = false;
    m_onRspQryExchangeRateRegistered = false;
    m_onRspQrySecAgentACIDMapRegistered = false;
    m_onRspQryProductExchRateRegistered = false;
    m_onRspQryProductGroupRegistered = false;
    m_onRspQryMMInstrumentCommissionRateRegistered = false;
    m_onRspQryMMOptionInstrCommRateRegistered = false;
    m_onRspQryInstrumentOrderCommRateRegistered = false;
    m_onRspQrySecAgentTradingAccountRegistered = false;
    m_onRspQrySecAgentCheckModeRegistered = false;
    m_onRspQrySecAgentTradeInfoRegistered = false;
    m_onRspQryOptionInstrTradeCostRegistered = false;
    m_onRspQryOptionInstrCommRateRegistered = false;
    m_onRspQryExecOrderRegistered = false;
    m_onRspQryForQuoteRegistered = false;
    m_onRspQryQuoteRegistered = false;
    m_onRspQryOptionSelfCloseRegistered = false;
    m_onRspQryInvestUnitRegistered = false;
    m_onRspQryCombInstrumentGuardRegistered = false;
    m_onRspQryCombActionRegistered = false;
    m_onRspQryTransferSerialRegistered = false;
    m_onRspQryAccountregisterRegistered = false;
    m_onRspErrorRegistered = false;
    m_onRtnOrderRegistered = false;
    m_onRtnTradeRegistered = false;
    m_onErrRtnOrderInsertRegistered = false;
    m_onErrRtnOrderActionRegistered = false;
    m_onRtnInstrumentStatusRegistered = false;
    m_onRtnBulletinRegistered = false;
    m_onRtnTradingNoticeRegistered = false;
    m_onRtnErrorConditionalOrderRegistered = false;
    m_onRtnExecOrderRegistered = false;
    m_onErrRtnExecOrderInsertRegistered = false;
    m_onErrRtnExecOrderActionRegistered = false;
    m_onErrRtnForQuoteInsertRegistered = false;
    m_onRtnQuoteRegistered = false;
    m_onErrRtnQuoteInsertRegistered = false;
    m_onErrRtnQuoteActionRegistered = false;
    m_onRtnForQuoteRspRegistered = false;
    m_onRtnCFMMCTradingAccountTokenRegistered = false;
    m_onErrRtnBatchOrderActionRegistered = false;
    m_onRtnOptionSelfCloseRegistered = false;
    m_onErrRtnOptionSelfCloseInsertRegistered = false;
    m_onErrRtnOptionSelfCloseActionRegistered = false;
    m_onRtnCombActionRegistered = false;
    m_onErrRtnCombActionInsertRegistered = false;
    m_onRspQryContractBankRegistered = false;
    m_onRspQryParkedOrderRegistered = false;
    m_onRspQryParkedOrderActionRegistered = false;
    m_onRspQryTradingNoticeRegistered = false;
    m_onRspQryBrokerTradingParamsRegistered = false;
    m_onRspQryBrokerTradingAlgosRegistered = false;
    m_onRspQueryCFMMCTradingAccountTokenRegistered = false;
    m_onRtnFromBankToFutureByBankRegistered = false;
    m_onRtnFromFutureToBankByBankRegistered = false;
    m_onRtnRepealFromBankToFutureByBankRegistered = false;
    m_onRtnRepealFromFutureToBankByBankRegistered = false;
    m_onRtnFromBankToFutureByFutureRegistered = false;
    m_onRtnFromFutureToBankByFutureRegistered = false;
    m_onRtnRepealFromBankToFutureByFutureManualRegistered = false;
    m_onRtnRepealFromFutureToBankByFutureManualRegistered = false;
    m_onRtnQueryBankBalanceByFutureRegistered = false;
    m_onErrRtnBankToFutureByFutureRegistered = false;
    m_onErrRtnFutureToBankByFutureRegistered = false;
    m_onErrRtnRepealBankToFutureByFutureManualRegistered = false;
    m_onErrRtnRepealFutureToBankByFutureManualRegistered = false;
    m_onErrRtnQueryBankBalanceByFutureRegistered = false;
    m_onRtnRepealFromBankToFutureByFutureRegistered = false;
    m_onRtnRepealFromFutureToBankByFutureRegistered = false;
    m_onRspFromBankToFutureByFutureRegistered = false;
    m_onRspFromFutureToBankByFutureRegistered = false;
    m_onRspQueryBankAccountMoneyByFutureRegistered = false;
    m_onRtnOpenAccountByBankRegistered = false;
    m_onRtnCancelAccountByBankRegistered = false;
    m_onRtnChangeAccountByBankRegistered = false;
}

//call api functions
const char* CTrader::GetTradingDay()
{
    if(m_pApi)
    {
        return m_pApi->GetTradingDay();
    }
    else
    {
        return "";
    }
}


void CTrader::RegisterFront(char* pszFrontAddress)
{
    if(m_pApi)
    {
        m_pApi->RegisterFront(pszFrontAddress);
    }
}


void CTrader::RegisterNameServer(char* pszNsAddress)
{
    if(m_pApi)
    {
        m_pApi->RegisterNameServer(pszNsAddress);
    }
}


void CTrader::RegisterFensUserInfo(CThostFtdcFensUserInfoField * pFensUserInfo)
{
    if(m_pApi)
    {
        m_pApi->RegisterFensUserInfo(pFensUserInfo);
    }
}


int CTrader::RegisterUserSystemInfo(CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    if(m_pApi)
    {
        return m_pApi->RegisterUserSystemInfo(pUserSystemInfo);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::SubmitUserSystemInfo(CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    if(m_pApi)
    {
        return m_pApi->SubmitUserSystemInfo(pUserSystemInfo);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserLogout(CThostFtdcUserLogoutField* pUserLogout, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserLogout(pUserLogout, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserPasswordUpdate(CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserPasswordUpdate(pUserPasswordUpdate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserAuthMethod(CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserAuthMethod(pReqUserAuthMethod, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqGenUserCaptcha(CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqGenUserCaptcha(pReqGenUserCaptcha, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqGenUserText(CThostFtdcReqGenUserTextField* pReqGenUserText, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqGenUserText(pReqGenUserText, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserLoginWithCaptcha(CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserLoginWithText(CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserLoginWithText(pReqUserLoginWithText, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqUserLoginWithOTP(CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqUserLoginWithOTP(pReqUserLoginWithOTP, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqOrderInsert(CThostFtdcInputOrderField* pInputOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqOrderInsert(pInputOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqParkedOrderInsert(CThostFtdcParkedOrderField* pParkedOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqParkedOrderInsert(pParkedOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqParkedOrderAction(pParkedOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqOrderAction(CThostFtdcInputOrderActionField* pInputOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqOrderAction(pInputOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQueryMaxOrderVolume(pQueryMaxOrderVolume, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqSettlementInfoConfirm(pSettlementInfoConfirm, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqRemoveParkedOrder(CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqRemoveParkedOrder(pRemoveParkedOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqExecOrderInsert(pInputExecOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqExecOrderAction(CThostFtdcInputExecOrderActionField* pInputExecOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqExecOrderAction(pInputExecOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqForQuoteInsert(pInputForQuote, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQuoteInsert(CThostFtdcInputQuoteField* pInputQuote, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQuoteInsert(pInputQuote, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQuoteAction(CThostFtdcInputQuoteActionField* pInputQuoteAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQuoteAction(pInputQuoteAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqBatchOrderAction(CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqBatchOrderAction(pInputBatchOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqOptionSelfCloseInsert(pInputOptionSelfClose, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqCombActionInsert(pInputCombAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryOrder(CThostFtdcQryOrderField* pQryOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryOrder(pQryOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTrade(CThostFtdcQryTradeField* pQryTrade, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTrade(pQryTrade, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField* pQryInvestorPosition, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestorPosition(pQryInvestorPosition, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTradingAccount(CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTradingAccount(pQryTradingAccount, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestor(CThostFtdcQryInvestorField* pQryInvestor, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestor(pQryInvestor, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTradingCode(CThostFtdcQryTradingCodeField* pQryTradingCode, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTradingCode(pQryTradingCode, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInstrumentMarginRate(CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInstrumentCommissionRate(CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryExchange(CThostFtdcQryExchangeField* pQryExchange, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryExchange(pQryExchange, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryProduct(CThostFtdcQryProductField* pQryProduct, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryProduct(pQryProduct, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInstrument(CThostFtdcQryInstrumentField* pQryInstrument, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInstrument(pQryInstrument, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryDepthMarketData(CThostFtdcQryDepthMarketDataField* pQryDepthMarketData, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryDepthMarketData(pQryDepthMarketData, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySettlementInfo(CThostFtdcQrySettlementInfoField* pQrySettlementInfo, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySettlementInfo(pQrySettlementInfo, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTransferBank(CThostFtdcQryTransferBankField* pQryTransferBank, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTransferBank(pQryTransferBank, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryNotice(CThostFtdcQryNoticeField* pQryNotice, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryNotice(pQryNotice, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySettlementInfoConfirm(CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestorPositionCombineDetail(CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryCFMMCTradingAccountKey(CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryEWarrantOffset(CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryEWarrantOffset(pQryEWarrantOffset, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestorProductGroupMargin(CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryExchangeMarginRate(CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryExchangeMarginRate(pQryExchangeMarginRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryExchangeMarginRateAdjust(CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryExchangeRate(CThostFtdcQryExchangeRateField* pQryExchangeRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryExchangeRate(pQryExchangeRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySecAgentACIDMap(CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryProductExchRate(CThostFtdcQryProductExchRateField* pQryProductExchRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryProductExchRate(pQryProductExchRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryProductGroup(CThostFtdcQryProductGroupField* pQryProductGroup, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryProductGroup(pQryProductGroup, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryMMInstrumentCommissionRate(CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryMMOptionInstrCommRate(CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInstrumentOrderCommRate(CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySecAgentTradingAccount(CThostFtdcQryTradingAccountField* pQryTradingAccount, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySecAgentTradingAccount(pQryTradingAccount, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySecAgentCheckMode(CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQrySecAgentTradeInfo(CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryOptionInstrTradeCost(CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryOptionInstrCommRate(CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryExecOrder(CThostFtdcQryExecOrderField* pQryExecOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryExecOrder(pQryExecOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryForQuote(CThostFtdcQryForQuoteField* pQryForQuote, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryForQuote(pQryForQuote, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryQuote(CThostFtdcQryQuoteField* pQryQuote, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryQuote(pQryQuote, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryOptionSelfClose(CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryOptionSelfClose(pQryOptionSelfClose, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryInvestUnit(CThostFtdcQryInvestUnitField* pQryInvestUnit, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryInvestUnit(pQryInvestUnit, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryCombInstrumentGuard(CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryCombAction(CThostFtdcQryCombActionField* pQryCombAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryCombAction(pQryCombAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTransferSerial(CThostFtdcQryTransferSerialField* pQryTransferSerial, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTransferSerial(pQryTransferSerial, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryAccountregister(CThostFtdcQryAccountregisterField* pQryAccountregister, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryAccountregister(pQryAccountregister, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryContractBank(CThostFtdcQryContractBankField* pQryContractBank, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryContractBank(pQryContractBank, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryParkedOrder(CThostFtdcQryParkedOrderField* pQryParkedOrder, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryParkedOrder(pQryParkedOrder, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryParkedOrderAction(CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryParkedOrderAction(pQryParkedOrderAction, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryTradingNotice(CThostFtdcQryTradingNoticeField* pQryTradingNotice, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryTradingNotice(pQryTradingNotice, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryBrokerTradingParams(CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryBrokerTradingParams(pQryBrokerTradingParams, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQryBrokerTradingAlgos(CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqFromBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqFromBankToFutureByFuture(pReqTransfer, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqFromFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqFromFutureToBankByFuture(pReqTransfer, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CTrader::ReqQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount, int nRequestID)
{
    if(m_pApi)
    {
        return m_pApi->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount, nRequestID);
    }
    else
    {
        return API_NULLPTR;
    }
}



//spi call callbacks
void CTrader::OnFrontDisconnected(int nReason)
{
    if (m_onFrontDisconnectedRegistered)
    {
        m_fpOnFrontDisconnected(nReason);
    }
}


void CTrader::OnHeartBeatWarning(int nTimeLapse)
{
    if (m_onHeartBeatWarningRegistered)
    {
        m_fpOnHeartBeatWarning(nTimeLapse);
    }
}


void CTrader::OnRspUserLogout(CThostFtdcUserLogoutField* pUserLogout, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUserLogoutRegistered)
    {
        m_fpOnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUserPasswordUpdateRegistered)
    {
        m_fpOnRspUserPasswordUpdate(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspTradingAccountPasswordUpdateRegistered)
    {
        m_fpOnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspUserAuthMethod(CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUserAuthMethodRegistered)
    {
        m_fpOnRspUserAuthMethod(pRspUserAuthMethod, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspGenUserCaptcha(CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspGenUserCaptchaRegistered)
    {
        m_fpOnRspGenUserCaptcha(pRspGenUserCaptcha, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspGenUserText(CThostFtdcRspGenUserTextField* pRspGenUserText, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspGenUserTextRegistered)
    {
        m_fpOnRspGenUserText(pRspGenUserText, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspOrderInsert(CThostFtdcInputOrderField* pInputOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspOrderInsertRegistered)
    {
        m_fpOnRspOrderInsert(pInputOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspParkedOrderInsert(CThostFtdcParkedOrderField* pParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspParkedOrderInsertRegistered)
    {
        m_fpOnRspParkedOrderInsert(pParkedOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspParkedOrderActionRegistered)
    {
        m_fpOnRspParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspOrderAction(CThostFtdcInputOrderActionField* pInputOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspOrderActionRegistered)
    {
        m_fpOnRspOrderAction(pInputOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField* pQueryMaxOrderVolume, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQueryMaxOrderVolumeRegistered)
    {
        m_fpOnRspQueryMaxOrderVolume(pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspSettlementInfoConfirmRegistered)
    {
        m_fpOnRspSettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspRemoveParkedOrderRegistered)
    {
        m_fpOnRspRemoveParkedOrder(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspRemoveParkedOrderActionRegistered)
    {
        m_fpOnRspRemoveParkedOrderAction(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspExecOrderInsertRegistered)
    {
        m_fpOnRspExecOrderInsert(pInputExecOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspExecOrderAction(CThostFtdcInputExecOrderActionField* pInputExecOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspExecOrderActionRegistered)
    {
        m_fpOnRspExecOrderAction(pInputExecOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspForQuoteInsertRegistered)
    {
        m_fpOnRspForQuoteInsert(pInputForQuote, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQuoteInsert(CThostFtdcInputQuoteField* pInputQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQuoteInsertRegistered)
    {
        m_fpOnRspQuoteInsert(pInputQuote, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQuoteAction(CThostFtdcInputQuoteActionField* pInputQuoteAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQuoteActionRegistered)
    {
        m_fpOnRspQuoteAction(pInputQuoteAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspBatchOrderAction(CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspBatchOrderActionRegistered)
    {
        m_fpOnRspBatchOrderAction(pInputBatchOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspOptionSelfCloseInsertRegistered)
    {
        m_fpOnRspOptionSelfCloseInsert(pInputOptionSelfClose, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspOptionSelfCloseActionRegistered)
    {
        m_fpOnRspOptionSelfCloseAction(pInputOptionSelfCloseAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspCombActionInsertRegistered)
    {
        m_fpOnRspCombActionInsert(pInputCombAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryOrder(CThostFtdcOrderField* pOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryOrderRegistered)
    {
        m_fpOnRspQryOrder(pOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTrade(CThostFtdcTradeField* pTrade, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTradeRegistered)
    {
        m_fpOnRspQryTrade(pTrade, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestorPosition(CThostFtdcInvestorPositionField* pInvestorPosition, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestorPositionRegistered)
    {
        m_fpOnRspQryInvestorPosition(pInvestorPosition, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTradingAccount(CThostFtdcTradingAccountField* pTradingAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTradingAccountRegistered)
    {
        m_fpOnRspQryTradingAccount(pTradingAccount, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestor(CThostFtdcInvestorField* pInvestor, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestorRegistered)
    {
        m_fpOnRspQryInvestor(pInvestor, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTradingCode(CThostFtdcTradingCodeField* pTradingCode, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTradingCodeRegistered)
    {
        m_fpOnRspQryTradingCode(pTradingCode, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInstrumentMarginRateRegistered)
    {
        m_fpOnRspQryInstrumentMarginRate(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInstrumentCommissionRateRegistered)
    {
        m_fpOnRspQryInstrumentCommissionRate(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryExchange(CThostFtdcExchangeField* pExchange, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryExchangeRegistered)
    {
        m_fpOnRspQryExchange(pExchange, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryProduct(CThostFtdcProductField* pProduct, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryProductRegistered)
    {
        m_fpOnRspQryProduct(pProduct, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInstrument(CThostFtdcInstrumentField* pInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInstrumentRegistered)
    {
        m_fpOnRspQryInstrument(pInstrument, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryDepthMarketDataRegistered)
    {
        m_fpOnRspQryDepthMarketData(pDepthMarketData, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySettlementInfo(CThostFtdcSettlementInfoField* pSettlementInfo, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySettlementInfoRegistered)
    {
        m_fpOnRspQrySettlementInfo(pSettlementInfo, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTransferBank(CThostFtdcTransferBankField* pTransferBank, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTransferBankRegistered)
    {
        m_fpOnRspQryTransferBank(pTransferBank, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestorPositionDetailRegistered)
    {
        m_fpOnRspQryInvestorPositionDetail(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryNotice(CThostFtdcNoticeField* pNotice, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryNoticeRegistered)
    {
        m_fpOnRspQryNotice(pNotice, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySettlementInfoConfirmRegistered)
    {
        m_fpOnRspQrySettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestorPositionCombineDetailRegistered)
    {
        m_fpOnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryCFMMCTradingAccountKeyRegistered)
    {
        m_fpOnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField* pEWarrantOffset, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryEWarrantOffsetRegistered)
    {
        m_fpOnRspQryEWarrantOffset(pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestorProductGroupMarginRegistered)
    {
        m_fpOnRspQryInvestorProductGroupMargin(pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField* pExchangeMarginRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryExchangeMarginRateRegistered)
    {
        m_fpOnRspQryExchangeMarginRate(pExchangeMarginRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryExchangeMarginRateAdjustRegistered)
    {
        m_fpOnRspQryExchangeMarginRateAdjust(pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryExchangeRate(CThostFtdcExchangeRateField* pExchangeRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryExchangeRateRegistered)
    {
        m_fpOnRspQryExchangeRate(pExchangeRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySecAgentACIDMapRegistered)
    {
        m_fpOnRspQrySecAgentACIDMap(pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryProductExchRate(CThostFtdcProductExchRateField* pProductExchRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryProductExchRateRegistered)
    {
        m_fpOnRspQryProductExchRate(pProductExchRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryProductGroup(CThostFtdcProductGroupField* pProductGroup, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryProductGroupRegistered)
    {
        m_fpOnRspQryProductGroup(pProductGroup, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryMMInstrumentCommissionRate(CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryMMInstrumentCommissionRateRegistered)
    {
        m_fpOnRspQryMMInstrumentCommissionRate(pMMInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryMMOptionInstrCommRate(CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryMMOptionInstrCommRateRegistered)
    {
        m_fpOnRspQryMMOptionInstrCommRate(pMMOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInstrumentOrderCommRate(CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInstrumentOrderCommRateRegistered)
    {
        m_fpOnRspQryInstrumentOrderCommRate(pInstrumentOrderCommRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySecAgentTradingAccount(CThostFtdcTradingAccountField* pTradingAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySecAgentTradingAccountRegistered)
    {
        m_fpOnRspQrySecAgentTradingAccount(pTradingAccount, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySecAgentCheckMode(CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySecAgentCheckModeRegistered)
    {
        m_fpOnRspQrySecAgentCheckMode(pSecAgentCheckMode, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQrySecAgentTradeInfo(CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQrySecAgentTradeInfoRegistered)
    {
        m_fpOnRspQrySecAgentTradeInfo(pSecAgentTradeInfo, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryOptionInstrTradeCostRegistered)
    {
        m_fpOnRspQryOptionInstrTradeCost(pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryOptionInstrCommRateRegistered)
    {
        m_fpOnRspQryOptionInstrCommRate(pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryExecOrder(CThostFtdcExecOrderField* pExecOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryExecOrderRegistered)
    {
        m_fpOnRspQryExecOrder(pExecOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryForQuote(CThostFtdcForQuoteField* pForQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryForQuoteRegistered)
    {
        m_fpOnRspQryForQuote(pForQuote, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryQuote(CThostFtdcQuoteField* pQuote, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryQuoteRegistered)
    {
        m_fpOnRspQryQuote(pQuote, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryOptionSelfCloseRegistered)
    {
        m_fpOnRspQryOptionSelfClose(pOptionSelfClose, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryInvestUnit(CThostFtdcInvestUnitField* pInvestUnit, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryInvestUnitRegistered)
    {
        m_fpOnRspQryInvestUnit(pInvestUnit, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryCombInstrumentGuardRegistered)
    {
        m_fpOnRspQryCombInstrumentGuard(pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryCombAction(CThostFtdcCombActionField* pCombAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryCombActionRegistered)
    {
        m_fpOnRspQryCombAction(pCombAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTransferSerial(CThostFtdcTransferSerialField* pTransferSerial, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTransferSerialRegistered)
    {
        m_fpOnRspQryTransferSerial(pTransferSerial, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryAccountregister(CThostFtdcAccountregisterField* pAccountregister, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryAccountregisterRegistered)
    {
        m_fpOnRspQryAccountregister(pAccountregister, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspError(CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspErrorRegistered)
    {
        m_fpOnRspError(pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRtnOrder(CThostFtdcOrderField* pOrder)
{
    if (m_onRtnOrderRegistered)
    {
        m_fpOnRtnOrder(pOrder);
    }
}


void CTrader::OnRtnTrade(CThostFtdcTradeField* pTrade)
{
    if (m_onRtnTradeRegistered)
    {
        m_fpOnRtnTrade(pTrade);
    }
}


void CTrader::OnErrRtnOrderInsert(CThostFtdcInputOrderField* pInputOrder, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnOrderInsertRegistered)
    {
        m_fpOnErrRtnOrderInsert(pInputOrder, pRspInfo);
    }
}


void CTrader::OnErrRtnOrderAction(CThostFtdcOrderActionField* pOrderAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnOrderActionRegistered)
    {
        m_fpOnErrRtnOrderAction(pOrderAction, pRspInfo);
    }
}


void CTrader::OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField* pInstrumentStatus)
{
    if (m_onRtnInstrumentStatusRegistered)
    {
        m_fpOnRtnInstrumentStatus(pInstrumentStatus);
    }
}


void CTrader::OnRtnBulletin(CThostFtdcBulletinField* pBulletin)
{
    if (m_onRtnBulletinRegistered)
    {
        m_fpOnRtnBulletin(pBulletin);
    }
}


void CTrader::OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo)
{
    if (m_onRtnTradingNoticeRegistered)
    {
        m_fpOnRtnTradingNotice(pTradingNoticeInfo);
    }
}


void CTrader::OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder)
{
    if (m_onRtnErrorConditionalOrderRegistered)
    {
        m_fpOnRtnErrorConditionalOrder(pErrorConditionalOrder);
    }
}


void CTrader::OnRtnExecOrder(CThostFtdcExecOrderField* pExecOrder)
{
    if (m_onRtnExecOrderRegistered)
    {
        m_fpOnRtnExecOrder(pExecOrder);
    }
}


void CTrader::OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnExecOrderInsertRegistered)
    {
        m_fpOnErrRtnExecOrderInsert(pInputExecOrder, pRspInfo);
    }
}


void CTrader::OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField* pExecOrderAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnExecOrderActionRegistered)
    {
        m_fpOnErrRtnExecOrderAction(pExecOrderAction, pRspInfo);
    }
}


void CTrader::OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnForQuoteInsertRegistered)
    {
        m_fpOnErrRtnForQuoteInsert(pInputForQuote, pRspInfo);
    }
}


void CTrader::OnRtnQuote(CThostFtdcQuoteField* pQuote)
{
    if (m_onRtnQuoteRegistered)
    {
        m_fpOnRtnQuote(pQuote);
    }
}


void CTrader::OnErrRtnQuoteInsert(CThostFtdcInputQuoteField* pInputQuote, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnQuoteInsertRegistered)
    {
        m_fpOnErrRtnQuoteInsert(pInputQuote, pRspInfo);
    }
}


void CTrader::OnErrRtnQuoteAction(CThostFtdcQuoteActionField* pQuoteAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnQuoteActionRegistered)
    {
        m_fpOnErrRtnQuoteAction(pQuoteAction, pRspInfo);
    }
}


void CTrader::OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp)
{
    if (m_onRtnForQuoteRspRegistered)
    {
        m_fpOnRtnForQuoteRsp(pForQuoteRsp);
    }
}


void CTrader::OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken)
{
    if (m_onRtnCFMMCTradingAccountTokenRegistered)
    {
        m_fpOnRtnCFMMCTradingAccountToken(pCFMMCTradingAccountToken);
    }
}


void CTrader::OnErrRtnBatchOrderAction(CThostFtdcBatchOrderActionField* pBatchOrderAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnBatchOrderActionRegistered)
    {
        m_fpOnErrRtnBatchOrderAction(pBatchOrderAction, pRspInfo);
    }
}


void CTrader::OnRtnOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose)
{
    if (m_onRtnOptionSelfCloseRegistered)
    {
        m_fpOnRtnOptionSelfClose(pOptionSelfClose);
    }
}


void CTrader::OnErrRtnOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnOptionSelfCloseInsertRegistered)
    {
        m_fpOnErrRtnOptionSelfCloseInsert(pInputOptionSelfClose, pRspInfo);
    }
}


void CTrader::OnErrRtnOptionSelfCloseAction(CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnOptionSelfCloseActionRegistered)
    {
        m_fpOnErrRtnOptionSelfCloseAction(pOptionSelfCloseAction, pRspInfo);
    }
}


void CTrader::OnRtnCombAction(CThostFtdcCombActionField* pCombAction)
{
    if (m_onRtnCombActionRegistered)
    {
        m_fpOnRtnCombAction(pCombAction);
    }
}


void CTrader::OnErrRtnCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnCombActionInsertRegistered)
    {
        m_fpOnErrRtnCombActionInsert(pInputCombAction, pRspInfo);
    }
}


void CTrader::OnRspQryContractBank(CThostFtdcContractBankField* pContractBank, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryContractBankRegistered)
    {
        m_fpOnRspQryContractBank(pContractBank, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryParkedOrder(CThostFtdcParkedOrderField* pParkedOrder, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryParkedOrderRegistered)
    {
        m_fpOnRspQryParkedOrder(pParkedOrder, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryParkedOrderActionRegistered)
    {
        m_fpOnRspQryParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryTradingNotice(CThostFtdcTradingNoticeField* pTradingNotice, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryTradingNoticeRegistered)
    {
        m_fpOnRspQryTradingNotice(pTradingNotice, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField* pBrokerTradingParams, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryBrokerTradingParamsRegistered)
    {
        m_fpOnRspQryBrokerTradingParams(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQryBrokerTradingAlgosRegistered)
    {
        m_fpOnRspQryBrokerTradingAlgos(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQueryCFMMCTradingAccountTokenRegistered)
    {
        m_fpOnRspQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField* pRspTransfer)
{
    if (m_onRtnFromBankToFutureByBankRegistered)
    {
        m_fpOnRtnFromBankToFutureByBank(pRspTransfer);
    }
}


void CTrader::OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField* pRspTransfer)
{
    if (m_onRtnFromFutureToBankByBankRegistered)
    {
        m_fpOnRtnFromFutureToBankByBank(pRspTransfer);
    }
}


void CTrader::OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromBankToFutureByBankRegistered)
    {
        m_fpOnRtnRepealFromBankToFutureByBank(pRspRepeal);
    }
}


void CTrader::OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromFutureToBankByBankRegistered)
    {
        m_fpOnRtnRepealFromFutureToBankByBank(pRspRepeal);
    }
}


void CTrader::OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField* pRspTransfer)
{
    if (m_onRtnFromBankToFutureByFutureRegistered)
    {
        m_fpOnRtnFromBankToFutureByFuture(pRspTransfer);
    }
}


void CTrader::OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField* pRspTransfer)
{
    if (m_onRtnFromFutureToBankByFutureRegistered)
    {
        m_fpOnRtnFromFutureToBankByFuture(pRspTransfer);
    }
}


void CTrader::OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromBankToFutureByFutureManualRegistered)
    {
        m_fpOnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
    }
}


void CTrader::OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromFutureToBankByFutureManualRegistered)
    {
        m_fpOnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
    }
}


void CTrader::OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount)
{
    if (m_onRtnQueryBankBalanceByFutureRegistered)
    {
        m_fpOnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
    }
}


void CTrader::OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnBankToFutureByFutureRegistered)
    {
        m_fpOnErrRtnBankToFutureByFuture(pReqTransfer, pRspInfo);
    }
}


void CTrader::OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnFutureToBankByFutureRegistered)
    {
        m_fpOnErrRtnFutureToBankByFuture(pReqTransfer, pRspInfo);
    }
}


void CTrader::OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField* pReqRepeal, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnRepealBankToFutureByFutureManualRegistered)
    {
        m_fpOnErrRtnRepealBankToFutureByFutureManual(pReqRepeal, pRspInfo);
    }
}


void CTrader::OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField* pReqRepeal, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnRepealFutureToBankByFutureManualRegistered)
    {
        m_fpOnErrRtnRepealFutureToBankByFutureManual(pReqRepeal, pRspInfo);
    }
}


void CTrader::OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount, CThostFtdcRspInfoField* pRspInfo)
{
    if (m_onErrRtnQueryBankBalanceByFutureRegistered)
    {
        m_fpOnErrRtnQueryBankBalanceByFuture(pReqQueryAccount, pRspInfo);
    }
}


void CTrader::OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromBankToFutureByFutureRegistered)
    {
        m_fpOnRtnRepealFromBankToFutureByFuture(pRspRepeal);
    }
}


void CTrader::OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField* pRspRepeal)
{
    if (m_onRtnRepealFromFutureToBankByFutureRegistered)
    {
        m_fpOnRtnRepealFromFutureToBankByFuture(pRspRepeal);
    }
}


void CTrader::OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspFromBankToFutureByFutureRegistered)
    {
        m_fpOnRspFromBankToFutureByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspFromFutureToBankByFutureRegistered)
    {
        m_fpOnRspFromFutureToBankByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspQueryBankAccountMoneyByFutureRegistered)
    {
        m_fpOnRspQueryBankAccountMoneyByFuture(pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
    }
}


void CTrader::OnRtnOpenAccountByBank(CThostFtdcOpenAccountField* pOpenAccount)
{
    if (m_onRtnOpenAccountByBankRegistered)
    {
        m_fpOnRtnOpenAccountByBank(pOpenAccount);
    }
}


void CTrader::OnRtnCancelAccountByBank(CThostFtdcCancelAccountField* pCancelAccount)
{
    if (m_onRtnCancelAccountByBankRegistered)
    {
        m_fpOnRtnCancelAccountByBank(pCancelAccount);
    }
}


void CTrader::OnRtnChangeAccountByBank(CThostFtdcChangeAccountField* pChangeAccount)
{
    if (m_onRtnChangeAccountByBankRegistered)
    {
        m_fpOnRtnChangeAccountByBank(pChangeAccount);
    }
}



//register callbacks
void CTrader::registerFP_OnFrontConnected(FuncPtrTradeOnFrontConnected fp)
{
    m_fpOnFrontConnected = fp;
    m_onFrontConnectedRegistered = true;
}


void CTrader::registerFP_OnFrontDisconnected(FuncPtrTradeOnFrontDisconnected fp)
{
    m_fpOnFrontDisconnected = fp;
    m_onFrontDisconnectedRegistered = true;
}


void CTrader::registerFP_OnHeartBeatWarning(FuncPtrTradeOnHeartBeatWarning fp)
{
    m_fpOnHeartBeatWarning = fp;
    m_onHeartBeatWarningRegistered = true;
}


void CTrader::registerFP_OnRspAuthenticate(FuncPtrTradeOnRspAuthenticate fp)
{
    m_fpOnRspAuthenticate = fp;
    m_onRspAuthenticateRegistered = true;
}


void CTrader::registerFP_OnRspUserLogin(FuncPtrTradeOnRspUserLogin fp)
{
    m_fpOnRspUserLogin = fp;
    m_onRspUserLoginRegistered = true;
}


void CTrader::registerFP_OnRspUserLogout(FuncPtrTradeOnRspUserLogout fp)
{
    m_fpOnRspUserLogout = fp;
    m_onRspUserLogoutRegistered = true;
}


void CTrader::registerFP_OnRspUserPasswordUpdate(FuncPtrTradeOnRspUserPasswordUpdate fp)
{
    m_fpOnRspUserPasswordUpdate = fp;
    m_onRspUserPasswordUpdateRegistered = true;
}


void CTrader::registerFP_OnRspTradingAccountPasswordUpdate(FuncPtrTradeOnRspTradingAccountPasswordUpdate fp)
{
    m_fpOnRspTradingAccountPasswordUpdate = fp;
    m_onRspTradingAccountPasswordUpdateRegistered = true;
}


void CTrader::registerFP_OnRspUserAuthMethod(FuncPtrTradeOnRspUserAuthMethod fp)
{
    m_fpOnRspUserAuthMethod = fp;
    m_onRspUserAuthMethodRegistered = true;
}


void CTrader::registerFP_OnRspGenUserCaptcha(FuncPtrTradeOnRspGenUserCaptcha fp)
{
    m_fpOnRspGenUserCaptcha = fp;
    m_onRspGenUserCaptchaRegistered = true;
}


void CTrader::registerFP_OnRspGenUserText(FuncPtrTradeOnRspGenUserText fp)
{
    m_fpOnRspGenUserText = fp;
    m_onRspGenUserTextRegistered = true;
}


void CTrader::registerFP_OnRspOrderInsert(FuncPtrTradeOnRspOrderInsert fp)
{
    m_fpOnRspOrderInsert = fp;
    m_onRspOrderInsertRegistered = true;
}


void CTrader::registerFP_OnRspParkedOrderInsert(FuncPtrTradeOnRspParkedOrderInsert fp)
{
    m_fpOnRspParkedOrderInsert = fp;
    m_onRspParkedOrderInsertRegistered = true;
}


void CTrader::registerFP_OnRspParkedOrderAction(FuncPtrTradeOnRspParkedOrderAction fp)
{
    m_fpOnRspParkedOrderAction = fp;
    m_onRspParkedOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspOrderAction(FuncPtrTradeOnRspOrderAction fp)
{
    m_fpOnRspOrderAction = fp;
    m_onRspOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspQueryMaxOrderVolume(FuncPtrTradeOnRspQueryMaxOrderVolume fp)
{
    m_fpOnRspQueryMaxOrderVolume = fp;
    m_onRspQueryMaxOrderVolumeRegistered = true;
}


void CTrader::registerFP_OnRspSettlementInfoConfirm(FuncPtrTradeOnRspSettlementInfoConfirm fp)
{
    m_fpOnRspSettlementInfoConfirm = fp;
    m_onRspSettlementInfoConfirmRegistered = true;
}


void CTrader::registerFP_OnRspRemoveParkedOrder(FuncPtrTradeOnRspRemoveParkedOrder fp)
{
    m_fpOnRspRemoveParkedOrder = fp;
    m_onRspRemoveParkedOrderRegistered = true;
}


void CTrader::registerFP_OnRspRemoveParkedOrderAction(FuncPtrTradeOnRspRemoveParkedOrderAction fp)
{
    m_fpOnRspRemoveParkedOrderAction = fp;
    m_onRspRemoveParkedOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspExecOrderInsert(FuncPtrTradeOnRspExecOrderInsert fp)
{
    m_fpOnRspExecOrderInsert = fp;
    m_onRspExecOrderInsertRegistered = true;
}


void CTrader::registerFP_OnRspExecOrderAction(FuncPtrTradeOnRspExecOrderAction fp)
{
    m_fpOnRspExecOrderAction = fp;
    m_onRspExecOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspForQuoteInsert(FuncPtrTradeOnRspForQuoteInsert fp)
{
    m_fpOnRspForQuoteInsert = fp;
    m_onRspForQuoteInsertRegistered = true;
}


void CTrader::registerFP_OnRspQuoteInsert(FuncPtrTradeOnRspQuoteInsert fp)
{
    m_fpOnRspQuoteInsert = fp;
    m_onRspQuoteInsertRegistered = true;
}


void CTrader::registerFP_OnRspQuoteAction(FuncPtrTradeOnRspQuoteAction fp)
{
    m_fpOnRspQuoteAction = fp;
    m_onRspQuoteActionRegistered = true;
}


void CTrader::registerFP_OnRspBatchOrderAction(FuncPtrTradeOnRspBatchOrderAction fp)
{
    m_fpOnRspBatchOrderAction = fp;
    m_onRspBatchOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspOptionSelfCloseInsert(FuncPtrTradeOnRspOptionSelfCloseInsert fp)
{
    m_fpOnRspOptionSelfCloseInsert = fp;
    m_onRspOptionSelfCloseInsertRegistered = true;
}


void CTrader::registerFP_OnRspOptionSelfCloseAction(FuncPtrTradeOnRspOptionSelfCloseAction fp)
{
    m_fpOnRspOptionSelfCloseAction = fp;
    m_onRspOptionSelfCloseActionRegistered = true;
}


void CTrader::registerFP_OnRspCombActionInsert(FuncPtrTradeOnRspCombActionInsert fp)
{
    m_fpOnRspCombActionInsert = fp;
    m_onRspCombActionInsertRegistered = true;
}


void CTrader::registerFP_OnRspQryOrder(FuncPtrTradeOnRspQryOrder fp)
{
    m_fpOnRspQryOrder = fp;
    m_onRspQryOrderRegistered = true;
}


void CTrader::registerFP_OnRspQryTrade(FuncPtrTradeOnRspQryTrade fp)
{
    m_fpOnRspQryTrade = fp;
    m_onRspQryTradeRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestorPosition(FuncPtrTradeOnRspQryInvestorPosition fp)
{
    m_fpOnRspQryInvestorPosition = fp;
    m_onRspQryInvestorPositionRegistered = true;
}


void CTrader::registerFP_OnRspQryTradingAccount(FuncPtrTradeOnRspQryTradingAccount fp)
{
    m_fpOnRspQryTradingAccount = fp;
    m_onRspQryTradingAccountRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestor(FuncPtrTradeOnRspQryInvestor fp)
{
    m_fpOnRspQryInvestor = fp;
    m_onRspQryInvestorRegistered = true;
}


void CTrader::registerFP_OnRspQryTradingCode(FuncPtrTradeOnRspQryTradingCode fp)
{
    m_fpOnRspQryTradingCode = fp;
    m_onRspQryTradingCodeRegistered = true;
}


void CTrader::registerFP_OnRspQryInstrumentMarginRate(FuncPtrTradeOnRspQryInstrumentMarginRate fp)
{
    m_fpOnRspQryInstrumentMarginRate = fp;
    m_onRspQryInstrumentMarginRateRegistered = true;
}


void CTrader::registerFP_OnRspQryInstrumentCommissionRate(FuncPtrTradeOnRspQryInstrumentCommissionRate fp)
{
    m_fpOnRspQryInstrumentCommissionRate = fp;
    m_onRspQryInstrumentCommissionRateRegistered = true;
}


void CTrader::registerFP_OnRspQryExchange(FuncPtrTradeOnRspQryExchange fp)
{
    m_fpOnRspQryExchange = fp;
    m_onRspQryExchangeRegistered = true;
}


void CTrader::registerFP_OnRspQryProduct(FuncPtrTradeOnRspQryProduct fp)
{
    m_fpOnRspQryProduct = fp;
    m_onRspQryProductRegistered = true;
}


void CTrader::registerFP_OnRspQryInstrument(FuncPtrTradeOnRspQryInstrument fp)
{
    m_fpOnRspQryInstrument = fp;
    m_onRspQryInstrumentRegistered = true;
}


void CTrader::registerFP_OnRspQryDepthMarketData(FuncPtrTradeOnRspQryDepthMarketData fp)
{
    m_fpOnRspQryDepthMarketData = fp;
    m_onRspQryDepthMarketDataRegistered = true;
}


void CTrader::registerFP_OnRspQrySettlementInfo(FuncPtrTradeOnRspQrySettlementInfo fp)
{
    m_fpOnRspQrySettlementInfo = fp;
    m_onRspQrySettlementInfoRegistered = true;
}


void CTrader::registerFP_OnRspQryTransferBank(FuncPtrTradeOnRspQryTransferBank fp)
{
    m_fpOnRspQryTransferBank = fp;
    m_onRspQryTransferBankRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestorPositionDetail(FuncPtrTradeOnRspQryInvestorPositionDetail fp)
{
    m_fpOnRspQryInvestorPositionDetail = fp;
    m_onRspQryInvestorPositionDetailRegistered = true;
}


void CTrader::registerFP_OnRspQryNotice(FuncPtrTradeOnRspQryNotice fp)
{
    m_fpOnRspQryNotice = fp;
    m_onRspQryNoticeRegistered = true;
}


void CTrader::registerFP_OnRspQrySettlementInfoConfirm(FuncPtrTradeOnRspQrySettlementInfoConfirm fp)
{
    m_fpOnRspQrySettlementInfoConfirm = fp;
    m_onRspQrySettlementInfoConfirmRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestorPositionCombineDetail(FuncPtrTradeOnRspQryInvestorPositionCombineDetail fp)
{
    m_fpOnRspQryInvestorPositionCombineDetail = fp;
    m_onRspQryInvestorPositionCombineDetailRegistered = true;
}


void CTrader::registerFP_OnRspQryCFMMCTradingAccountKey(FuncPtrTradeOnRspQryCFMMCTradingAccountKey fp)
{
    m_fpOnRspQryCFMMCTradingAccountKey = fp;
    m_onRspQryCFMMCTradingAccountKeyRegistered = true;
}


void CTrader::registerFP_OnRspQryEWarrantOffset(FuncPtrTradeOnRspQryEWarrantOffset fp)
{
    m_fpOnRspQryEWarrantOffset = fp;
    m_onRspQryEWarrantOffsetRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestorProductGroupMargin(FuncPtrTradeOnRspQryInvestorProductGroupMargin fp)
{
    m_fpOnRspQryInvestorProductGroupMargin = fp;
    m_onRspQryInvestorProductGroupMarginRegistered = true;
}


void CTrader::registerFP_OnRspQryExchangeMarginRate(FuncPtrTradeOnRspQryExchangeMarginRate fp)
{
    m_fpOnRspQryExchangeMarginRate = fp;
    m_onRspQryExchangeMarginRateRegistered = true;
}


void CTrader::registerFP_OnRspQryExchangeMarginRateAdjust(FuncPtrTradeOnRspQryExchangeMarginRateAdjust fp)
{
    m_fpOnRspQryExchangeMarginRateAdjust = fp;
    m_onRspQryExchangeMarginRateAdjustRegistered = true;
}


void CTrader::registerFP_OnRspQryExchangeRate(FuncPtrTradeOnRspQryExchangeRate fp)
{
    m_fpOnRspQryExchangeRate = fp;
    m_onRspQryExchangeRateRegistered = true;
}


void CTrader::registerFP_OnRspQrySecAgentACIDMap(FuncPtrTradeOnRspQrySecAgentACIDMap fp)
{
    m_fpOnRspQrySecAgentACIDMap = fp;
    m_onRspQrySecAgentACIDMapRegistered = true;
}


void CTrader::registerFP_OnRspQryProductExchRate(FuncPtrTradeOnRspQryProductExchRate fp)
{
    m_fpOnRspQryProductExchRate = fp;
    m_onRspQryProductExchRateRegistered = true;
}


void CTrader::registerFP_OnRspQryProductGroup(FuncPtrTradeOnRspQryProductGroup fp)
{
    m_fpOnRspQryProductGroup = fp;
    m_onRspQryProductGroupRegistered = true;
}


void CTrader::registerFP_OnRspQryMMInstrumentCommissionRate(FuncPtrTradeOnRspQryMMInstrumentCommissionRate fp)
{
    m_fpOnRspQryMMInstrumentCommissionRate = fp;
    m_onRspQryMMInstrumentCommissionRateRegistered = true;
}


void CTrader::registerFP_OnRspQryMMOptionInstrCommRate(FuncPtrTradeOnRspQryMMOptionInstrCommRate fp)
{
    m_fpOnRspQryMMOptionInstrCommRate = fp;
    m_onRspQryMMOptionInstrCommRateRegistered = true;
}


void CTrader::registerFP_OnRspQryInstrumentOrderCommRate(FuncPtrTradeOnRspQryInstrumentOrderCommRate fp)
{
    m_fpOnRspQryInstrumentOrderCommRate = fp;
    m_onRspQryInstrumentOrderCommRateRegistered = true;
}


void CTrader::registerFP_OnRspQrySecAgentTradingAccount(FuncPtrTradeOnRspQrySecAgentTradingAccount fp)
{
    m_fpOnRspQrySecAgentTradingAccount = fp;
    m_onRspQrySecAgentTradingAccountRegistered = true;
}


void CTrader::registerFP_OnRspQrySecAgentCheckMode(FuncPtrTradeOnRspQrySecAgentCheckMode fp)
{
    m_fpOnRspQrySecAgentCheckMode = fp;
    m_onRspQrySecAgentCheckModeRegistered = true;
}


void CTrader::registerFP_OnRspQrySecAgentTradeInfo(FuncPtrTradeOnRspQrySecAgentTradeInfo fp)
{
    m_fpOnRspQrySecAgentTradeInfo = fp;
    m_onRspQrySecAgentTradeInfoRegistered = true;
}


void CTrader::registerFP_OnRspQryOptionInstrTradeCost(FuncPtrTradeOnRspQryOptionInstrTradeCost fp)
{
    m_fpOnRspQryOptionInstrTradeCost = fp;
    m_onRspQryOptionInstrTradeCostRegistered = true;
}


void CTrader::registerFP_OnRspQryOptionInstrCommRate(FuncPtrTradeOnRspQryOptionInstrCommRate fp)
{
    m_fpOnRspQryOptionInstrCommRate = fp;
    m_onRspQryOptionInstrCommRateRegistered = true;
}


void CTrader::registerFP_OnRspQryExecOrder(FuncPtrTradeOnRspQryExecOrder fp)
{
    m_fpOnRspQryExecOrder = fp;
    m_onRspQryExecOrderRegistered = true;
}


void CTrader::registerFP_OnRspQryForQuote(FuncPtrTradeOnRspQryForQuote fp)
{
    m_fpOnRspQryForQuote = fp;
    m_onRspQryForQuoteRegistered = true;
}


void CTrader::registerFP_OnRspQryQuote(FuncPtrTradeOnRspQryQuote fp)
{
    m_fpOnRspQryQuote = fp;
    m_onRspQryQuoteRegistered = true;
}


void CTrader::registerFP_OnRspQryOptionSelfClose(FuncPtrTradeOnRspQryOptionSelfClose fp)
{
    m_fpOnRspQryOptionSelfClose = fp;
    m_onRspQryOptionSelfCloseRegistered = true;
}


void CTrader::registerFP_OnRspQryInvestUnit(FuncPtrTradeOnRspQryInvestUnit fp)
{
    m_fpOnRspQryInvestUnit = fp;
    m_onRspQryInvestUnitRegistered = true;
}


void CTrader::registerFP_OnRspQryCombInstrumentGuard(FuncPtrTradeOnRspQryCombInstrumentGuard fp)
{
    m_fpOnRspQryCombInstrumentGuard = fp;
    m_onRspQryCombInstrumentGuardRegistered = true;
}


void CTrader::registerFP_OnRspQryCombAction(FuncPtrTradeOnRspQryCombAction fp)
{
    m_fpOnRspQryCombAction = fp;
    m_onRspQryCombActionRegistered = true;
}


void CTrader::registerFP_OnRspQryTransferSerial(FuncPtrTradeOnRspQryTransferSerial fp)
{
    m_fpOnRspQryTransferSerial = fp;
    m_onRspQryTransferSerialRegistered = true;
}


void CTrader::registerFP_OnRspQryAccountregister(FuncPtrTradeOnRspQryAccountregister fp)
{
    m_fpOnRspQryAccountregister = fp;
    m_onRspQryAccountregisterRegistered = true;
}


void CTrader::registerFP_OnRspError(FuncPtrTradeOnRspError fp)
{
    m_fpOnRspError = fp;
    m_onRspErrorRegistered = true;
}


void CTrader::registerFP_OnRtnOrder(FuncPtrTradeOnRtnOrder fp)
{
    m_fpOnRtnOrder = fp;
    m_onRtnOrderRegistered = true;
}


void CTrader::registerFP_OnRtnTrade(FuncPtrTradeOnRtnTrade fp)
{
    m_fpOnRtnTrade = fp;
    m_onRtnTradeRegistered = true;
}


void CTrader::registerFP_OnErrRtnOrderInsert(FuncPtrTradeOnErrRtnOrderInsert fp)
{
    m_fpOnErrRtnOrderInsert = fp;
    m_onErrRtnOrderInsertRegistered = true;
}


void CTrader::registerFP_OnErrRtnOrderAction(FuncPtrTradeOnErrRtnOrderAction fp)
{
    m_fpOnErrRtnOrderAction = fp;
    m_onErrRtnOrderActionRegistered = true;
}


void CTrader::registerFP_OnRtnInstrumentStatus(FuncPtrTradeOnRtnInstrumentStatus fp)
{
    m_fpOnRtnInstrumentStatus = fp;
    m_onRtnInstrumentStatusRegistered = true;
}


void CTrader::registerFP_OnRtnBulletin(FuncPtrTradeOnRtnBulletin fp)
{
    m_fpOnRtnBulletin = fp;
    m_onRtnBulletinRegistered = true;
}


void CTrader::registerFP_OnRtnTradingNotice(FuncPtrTradeOnRtnTradingNotice fp)
{
    m_fpOnRtnTradingNotice = fp;
    m_onRtnTradingNoticeRegistered = true;
}


void CTrader::registerFP_OnRtnErrorConditionalOrder(FuncPtrTradeOnRtnErrorConditionalOrder fp)
{
    m_fpOnRtnErrorConditionalOrder = fp;
    m_onRtnErrorConditionalOrderRegistered = true;
}


void CTrader::registerFP_OnRtnExecOrder(FuncPtrTradeOnRtnExecOrder fp)
{
    m_fpOnRtnExecOrder = fp;
    m_onRtnExecOrderRegistered = true;
}


void CTrader::registerFP_OnErrRtnExecOrderInsert(FuncPtrTradeOnErrRtnExecOrderInsert fp)
{
    m_fpOnErrRtnExecOrderInsert = fp;
    m_onErrRtnExecOrderInsertRegistered = true;
}


void CTrader::registerFP_OnErrRtnExecOrderAction(FuncPtrTradeOnErrRtnExecOrderAction fp)
{
    m_fpOnErrRtnExecOrderAction = fp;
    m_onErrRtnExecOrderActionRegistered = true;
}


void CTrader::registerFP_OnErrRtnForQuoteInsert(FuncPtrTradeOnErrRtnForQuoteInsert fp)
{
    m_fpOnErrRtnForQuoteInsert = fp;
    m_onErrRtnForQuoteInsertRegistered = true;
}


void CTrader::registerFP_OnRtnQuote(FuncPtrTradeOnRtnQuote fp)
{
    m_fpOnRtnQuote = fp;
    m_onRtnQuoteRegistered = true;
}


void CTrader::registerFP_OnErrRtnQuoteInsert(FuncPtrTradeOnErrRtnQuoteInsert fp)
{
    m_fpOnErrRtnQuoteInsert = fp;
    m_onErrRtnQuoteInsertRegistered = true;
}


void CTrader::registerFP_OnErrRtnQuoteAction(FuncPtrTradeOnErrRtnQuoteAction fp)
{
    m_fpOnErrRtnQuoteAction = fp;
    m_onErrRtnQuoteActionRegistered = true;
}


void CTrader::registerFP_OnRtnForQuoteRsp(FuncPtrTradeOnRtnForQuoteRsp fp)
{
    m_fpOnRtnForQuoteRsp = fp;
    m_onRtnForQuoteRspRegistered = true;
}


void CTrader::registerFP_OnRtnCFMMCTradingAccountToken(FuncPtrTradeOnRtnCFMMCTradingAccountToken fp)
{
    m_fpOnRtnCFMMCTradingAccountToken = fp;
    m_onRtnCFMMCTradingAccountTokenRegistered = true;
}


void CTrader::registerFP_OnErrRtnBatchOrderAction(FuncPtrTradeOnErrRtnBatchOrderAction fp)
{
    m_fpOnErrRtnBatchOrderAction = fp;
    m_onErrRtnBatchOrderActionRegistered = true;
}


void CTrader::registerFP_OnRtnOptionSelfClose(FuncPtrTradeOnRtnOptionSelfClose fp)
{
    m_fpOnRtnOptionSelfClose = fp;
    m_onRtnOptionSelfCloseRegistered = true;
}


void CTrader::registerFP_OnErrRtnOptionSelfCloseInsert(FuncPtrTradeOnErrRtnOptionSelfCloseInsert fp)
{
    m_fpOnErrRtnOptionSelfCloseInsert = fp;
    m_onErrRtnOptionSelfCloseInsertRegistered = true;
}


void CTrader::registerFP_OnErrRtnOptionSelfCloseAction(FuncPtrTradeOnErrRtnOptionSelfCloseAction fp)
{
    m_fpOnErrRtnOptionSelfCloseAction = fp;
    m_onErrRtnOptionSelfCloseActionRegistered = true;
}


void CTrader::registerFP_OnRtnCombAction(FuncPtrTradeOnRtnCombAction fp)
{
    m_fpOnRtnCombAction = fp;
    m_onRtnCombActionRegistered = true;
}


void CTrader::registerFP_OnErrRtnCombActionInsert(FuncPtrTradeOnErrRtnCombActionInsert fp)
{
    m_fpOnErrRtnCombActionInsert = fp;
    m_onErrRtnCombActionInsertRegistered = true;
}


void CTrader::registerFP_OnRspQryContractBank(FuncPtrTradeOnRspQryContractBank fp)
{
    m_fpOnRspQryContractBank = fp;
    m_onRspQryContractBankRegistered = true;
}


void CTrader::registerFP_OnRspQryParkedOrder(FuncPtrTradeOnRspQryParkedOrder fp)
{
    m_fpOnRspQryParkedOrder = fp;
    m_onRspQryParkedOrderRegistered = true;
}


void CTrader::registerFP_OnRspQryParkedOrderAction(FuncPtrTradeOnRspQryParkedOrderAction fp)
{
    m_fpOnRspQryParkedOrderAction = fp;
    m_onRspQryParkedOrderActionRegistered = true;
}


void CTrader::registerFP_OnRspQryTradingNotice(FuncPtrTradeOnRspQryTradingNotice fp)
{
    m_fpOnRspQryTradingNotice = fp;
    m_onRspQryTradingNoticeRegistered = true;
}


void CTrader::registerFP_OnRspQryBrokerTradingParams(FuncPtrTradeOnRspQryBrokerTradingParams fp)
{
    m_fpOnRspQryBrokerTradingParams = fp;
    m_onRspQryBrokerTradingParamsRegistered = true;
}


void CTrader::registerFP_OnRspQryBrokerTradingAlgos(FuncPtrTradeOnRspQryBrokerTradingAlgos fp)
{
    m_fpOnRspQryBrokerTradingAlgos = fp;
    m_onRspQryBrokerTradingAlgosRegistered = true;
}


void CTrader::registerFP_OnRspQueryCFMMCTradingAccountToken(FuncPtrTradeOnRspQueryCFMMCTradingAccountToken fp)
{
    m_fpOnRspQueryCFMMCTradingAccountToken = fp;
    m_onRspQueryCFMMCTradingAccountTokenRegistered = true;
}


void CTrader::registerFP_OnRtnFromBankToFutureByBank(FuncPtrTradeOnRtnFromBankToFutureByBank fp)
{
    m_fpOnRtnFromBankToFutureByBank = fp;
    m_onRtnFromBankToFutureByBankRegistered = true;
}


void CTrader::registerFP_OnRtnFromFutureToBankByBank(FuncPtrTradeOnRtnFromFutureToBankByBank fp)
{
    m_fpOnRtnFromFutureToBankByBank = fp;
    m_onRtnFromFutureToBankByBankRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromBankToFutureByBank(FuncPtrTradeOnRtnRepealFromBankToFutureByBank fp)
{
    m_fpOnRtnRepealFromBankToFutureByBank = fp;
    m_onRtnRepealFromBankToFutureByBankRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromFutureToBankByBank(FuncPtrTradeOnRtnRepealFromFutureToBankByBank fp)
{
    m_fpOnRtnRepealFromFutureToBankByBank = fp;
    m_onRtnRepealFromFutureToBankByBankRegistered = true;
}


void CTrader::registerFP_OnRtnFromBankToFutureByFuture(FuncPtrTradeOnRtnFromBankToFutureByFuture fp)
{
    m_fpOnRtnFromBankToFutureByFuture = fp;
    m_onRtnFromBankToFutureByFutureRegistered = true;
}


void CTrader::registerFP_OnRtnFromFutureToBankByFuture(FuncPtrTradeOnRtnFromFutureToBankByFuture fp)
{
    m_fpOnRtnFromFutureToBankByFuture = fp;
    m_onRtnFromFutureToBankByFutureRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromBankToFutureByFutureManual(FuncPtrTradeOnRtnRepealFromBankToFutureByFutureManual fp)
{
    m_fpOnRtnRepealFromBankToFutureByFutureManual = fp;
    m_onRtnRepealFromBankToFutureByFutureManualRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromFutureToBankByFutureManual(FuncPtrTradeOnRtnRepealFromFutureToBankByFutureManual fp)
{
    m_fpOnRtnRepealFromFutureToBankByFutureManual = fp;
    m_onRtnRepealFromFutureToBankByFutureManualRegistered = true;
}


void CTrader::registerFP_OnRtnQueryBankBalanceByFuture(FuncPtrTradeOnRtnQueryBankBalanceByFuture fp)
{
    m_fpOnRtnQueryBankBalanceByFuture = fp;
    m_onRtnQueryBankBalanceByFutureRegistered = true;
}


void CTrader::registerFP_OnErrRtnBankToFutureByFuture(FuncPtrTradeOnErrRtnBankToFutureByFuture fp)
{
    m_fpOnErrRtnBankToFutureByFuture = fp;
    m_onErrRtnBankToFutureByFutureRegistered = true;
}


void CTrader::registerFP_OnErrRtnFutureToBankByFuture(FuncPtrTradeOnErrRtnFutureToBankByFuture fp)
{
    m_fpOnErrRtnFutureToBankByFuture = fp;
    m_onErrRtnFutureToBankByFutureRegistered = true;
}


void CTrader::registerFP_OnErrRtnRepealBankToFutureByFutureManual(FuncPtrTradeOnErrRtnRepealBankToFutureByFutureManual fp)
{
    m_fpOnErrRtnRepealBankToFutureByFutureManual = fp;
    m_onErrRtnRepealBankToFutureByFutureManualRegistered = true;
}


void CTrader::registerFP_OnErrRtnRepealFutureToBankByFutureManual(FuncPtrTradeOnErrRtnRepealFutureToBankByFutureManual fp)
{
    m_fpOnErrRtnRepealFutureToBankByFutureManual = fp;
    m_onErrRtnRepealFutureToBankByFutureManualRegistered = true;
}


void CTrader::registerFP_OnErrRtnQueryBankBalanceByFuture(FuncPtrTradeOnErrRtnQueryBankBalanceByFuture fp)
{
    m_fpOnErrRtnQueryBankBalanceByFuture = fp;
    m_onErrRtnQueryBankBalanceByFutureRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromBankToFutureByFuture(FuncPtrTradeOnRtnRepealFromBankToFutureByFuture fp)
{
    m_fpOnRtnRepealFromBankToFutureByFuture = fp;
    m_onRtnRepealFromBankToFutureByFutureRegistered = true;
}


void CTrader::registerFP_OnRtnRepealFromFutureToBankByFuture(FuncPtrTradeOnRtnRepealFromFutureToBankByFuture fp)
{
    m_fpOnRtnRepealFromFutureToBankByFuture = fp;
    m_onRtnRepealFromFutureToBankByFutureRegistered = true;
}


void CTrader::registerFP_OnRspFromBankToFutureByFuture(FuncPtrTradeOnRspFromBankToFutureByFuture fp)
{
    m_fpOnRspFromBankToFutureByFuture = fp;
    m_onRspFromBankToFutureByFutureRegistered = true;
}


void CTrader::registerFP_OnRspFromFutureToBankByFuture(FuncPtrTradeOnRspFromFutureToBankByFuture fp)
{
    m_fpOnRspFromFutureToBankByFuture = fp;
    m_onRspFromFutureToBankByFutureRegistered = true;
}


void CTrader::registerFP_OnRspQueryBankAccountMoneyByFuture(FuncPtrTradeOnRspQueryBankAccountMoneyByFuture fp)
{
    m_fpOnRspQueryBankAccountMoneyByFuture = fp;
    m_onRspQueryBankAccountMoneyByFutureRegistered = true;
}


void CTrader::registerFP_OnRtnOpenAccountByBank(FuncPtrTradeOnRtnOpenAccountByBank fp)
{
    m_fpOnRtnOpenAccountByBank = fp;
    m_onRtnOpenAccountByBankRegistered = true;
}


void CTrader::registerFP_OnRtnCancelAccountByBank(FuncPtrTradeOnRtnCancelAccountByBank fp)
{
    m_fpOnRtnCancelAccountByBank = fp;
    m_onRtnCancelAccountByBankRegistered = true;
}


void CTrader::registerFP_OnRtnChangeAccountByBank(FuncPtrTradeOnRtnChangeAccountByBank fp)
{
    m_fpOnRtnChangeAccountByBank = fp;
    m_onRtnChangeAccountByBankRegistered = true;
}

