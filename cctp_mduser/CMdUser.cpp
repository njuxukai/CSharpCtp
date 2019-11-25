#include "CMdUser.h"

CMdUser::CMdUser(MdUserInfo* user_info)
{
	memcpy(&m_userInfo, user_info, sizeof(MdUserInfo));
	m_pApi = nullptr;
    InitFlags();

}


CMdUser::~CMdUser()
{
	Disconnect();
}

int CMdUser::Connect()
{
	m_pApi = CThostFtdcMdApi::CreateFtdcMdApi(m_userInfo.FlowPath);
	m_pApi->RegisterSpi(this);
	m_pApi->RegisterFront(m_userInfo.FrontID);
	m_pApi->Init();
	return 0;

}

int CMdUser::Disconnect()
{
	if(m_pApi)
	{
		m_pApi->RegisterSpi(NULL);
		m_pApi->Release();
		m_pApi = nullptr;
	}
	return 0;
}

void CMdUser::OnFrontConnected()
{

	ReqUserLogin();
	if (m_onFrontConnectedRegistered)
    {
        m_fpOnFrontConnected();
    }
	
}

void CMdUser::ReqUserLogin()
{
	CThostFtdcReqUserLoginField userLoginField = { 0 };
	strcpy_s(userLoginField.BrokerID, m_userInfo.BrokerID);
	strcpy_s(userLoginField.UserID, m_userInfo.UserID);
	strcpy_s(userLoginField.Password, m_userInfo.Password);
	m_pApi->ReqUserLogin(&userLoginField, 0);
}


void CMdUser::OnRspUserLogin(CThostFtdcRspUserLoginField *pRspUserLogin,
	CThostFtdcRspInfoField *pRspInfo, int nRequestID, bool bIsLast)
{

	if (m_onRspUserLoginRegistered)
	{
		m_fpOnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
	}
}

int CMdUser::SubscribeMarketData(char* ppInstrumentID[], int nCount)
{
    if(m_pApi)
    {
        return m_pApi->SubscribeMarketData(ppInstrumentID, nCount);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CMdUser::UnSubscribeMarketData(char* ppInstrumentID[], int nCount)
{
    if(m_pApi)
    {
        return m_pApi->UnSubscribeMarketData(ppInstrumentID, nCount);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CMdUser::SubscribeForQuoteRsp(char* ppInstrumentID[], int nCount)
{
    if(m_pApi)
    {
        return m_pApi->SubscribeForQuoteRsp(ppInstrumentID, nCount);
    }
    else
    {
        return API_NULLPTR;
    }
}


int CMdUser::UnSubscribeForQuoteRsp(char* ppInstrumentID[], int nCount)
{
    if(m_pApi)
    {
        return m_pApi->UnSubscribeForQuoteRsp(ppInstrumentID, nCount);
    }
    else
    {
        return API_NULLPTR;
    }
}

void CMdUser::InitFlags()
{
    m_onFrontConnectedRegistered = false;
    m_onFrontDisconnectedRegistered = false;
    m_onHeartBeatWarningRegistered = false;
    m_onRspUserLoginRegistered = false;
    m_onRspUserLogoutRegistered = false;
    m_onRspErrorRegistered = false;
    m_onRspSubMarketDataRegistered = false;
    m_onRspUnSubMarketDataRegistered = false;
    m_onRspSubForQuoteRspRegistered = false;
    m_onRspUnSubForQuoteRspRegistered = false;
    m_onRtnDepthMarketDataRegistered = false;
    m_onRtnForQuoteRspRegistered = false;
}

//call api functions
const char* CMdUser::GetTradingDay()
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


void CMdUser::RegisterFront(char* pszFrontAddress)
{
    if(m_pApi)
    {
        m_pApi->RegisterFront(pszFrontAddress);
    }
}


void CMdUser::RegisterNameServer(char* pszNsAddress)
{
    if(m_pApi)
    {
        m_pApi->RegisterNameServer(pszNsAddress);
    }
}


void CMdUser::RegisterFensUserInfo(CThostFtdcFensUserInfoField * pFensUserInfo)
{
    if(m_pApi)
    {
        m_pApi->RegisterFensUserInfo(pFensUserInfo);
    }
}


int CMdUser::ReqUserLogout(CThostFtdcUserLogoutField* pUserLogout, int nRequestID)
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



//spi call callbacks
void CMdUser::OnFrontDisconnected(int nReason)
{
    if (m_onFrontDisconnectedRegistered)
    {
        m_fpOnFrontDisconnected(nReason);
    }
}


void CMdUser::OnHeartBeatWarning(int nTimeLapse)
{
    if (m_onHeartBeatWarningRegistered)
    {
        m_fpOnHeartBeatWarning(nTimeLapse);
    }
}


void CMdUser::OnRspUserLogout(CThostFtdcUserLogoutField* pUserLogout, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUserLogoutRegistered)
    {
        m_fpOnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRspError(CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspErrorRegistered)
    {
        m_fpOnRspError(pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRspSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspSubMarketDataRegistered)
    {
        m_fpOnRspSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUnSubMarketDataRegistered)
    {
        m_fpOnRspUnSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspSubForQuoteRspRegistered)
    {
        m_fpOnRspSubForQuoteRsp(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast)
{
    if (m_onRspUnSubForQuoteRspRegistered)
    {
        m_fpOnRspUnSubForQuoteRsp(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }
}


void CMdUser::OnRtnDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData)
{
    if (m_onRtnDepthMarketDataRegistered)
    {
        m_fpOnRtnDepthMarketData(pDepthMarketData);
    }
}


void CMdUser::OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp)
{
    if (m_onRtnForQuoteRspRegistered)
    {
        m_fpOnRtnForQuoteRsp(pForQuoteRsp);
    }
}



//register callbacks
void CMdUser::registerFP_OnFrontConnected(FuncPtrMdOnFrontConnected fp)
{
    m_fpOnFrontConnected = fp;
    m_onFrontConnectedRegistered = true;
}


void CMdUser::registerFP_OnFrontDisconnected(FuncPtrMdOnFrontDisconnected fp)
{
    m_fpOnFrontDisconnected = fp;
    m_onFrontDisconnectedRegistered = true;
}


void CMdUser::registerFP_OnHeartBeatWarning(FuncPtrMdOnHeartBeatWarning fp)
{
    m_fpOnHeartBeatWarning = fp;
    m_onHeartBeatWarningRegistered = true;
}


void CMdUser::registerFP_OnRspUserLogin(FuncPtrMdOnRspUserLogin fp)
{
    m_fpOnRspUserLogin = fp;
    m_onRspUserLoginRegistered = true;
}


void CMdUser::registerFP_OnRspUserLogout(FuncPtrMdOnRspUserLogout fp)
{
    m_fpOnRspUserLogout = fp;
    m_onRspUserLogoutRegistered = true;
}


void CMdUser::registerFP_OnRspError(FuncPtrMdOnRspError fp)
{
    m_fpOnRspError = fp;
    m_onRspErrorRegistered = true;
}


void CMdUser::registerFP_OnRspSubMarketData(FuncPtrMdOnRspSubMarketData fp)
{
    m_fpOnRspSubMarketData = fp;
    m_onRspSubMarketDataRegistered = true;
}


void CMdUser::registerFP_OnRspUnSubMarketData(FuncPtrMdOnRspUnSubMarketData fp)
{
    m_fpOnRspUnSubMarketData = fp;
    m_onRspUnSubMarketDataRegistered = true;
}


void CMdUser::registerFP_OnRspSubForQuoteRsp(FuncPtrMdOnRspSubForQuoteRsp fp)
{
    m_fpOnRspSubForQuoteRsp = fp;
    m_onRspSubForQuoteRspRegistered = true;
}


void CMdUser::registerFP_OnRspUnSubForQuoteRsp(FuncPtrMdOnRspUnSubForQuoteRsp fp)
{
    m_fpOnRspUnSubForQuoteRsp = fp;
    m_onRspUnSubForQuoteRspRegistered = true;
}


void CMdUser::registerFP_OnRtnDepthMarketData(FuncPtrMdOnRtnDepthMarketData fp)
{
    m_fpOnRtnDepthMarketData = fp;
    m_onRtnDepthMarketDataRegistered = true;
}


void CMdUser::registerFP_OnRtnForQuoteRsp(FuncPtrMdOnRtnForQuoteRsp fp)
{
    m_fpOnRtnForQuoteRsp = fp;
    m_onRtnForQuoteRspRegistered = true;
}

