#include "cctp_mduser.h"
#include "CMdUser.h"

int CreateMdUser(MdUserInfo* userInfo, void** phandler)
{
	*phandler = (void*)(new CMdUser(userInfo));
	return 0;
}

int ConnectMdUser(void* handler)
{
	CMdUser* pTrader = (CMdUser*)handler;
	return pTrader->Connect();
}

int DisconnectTrader(void* handler)
{
	CMdUser* pMdUser = (CMdUser*)handler;
	return pMdUser->Disconnect();
}

int DestroyTrader(void** phandler)
{
	CMdUser* pMdUser = (CMdUser*)(*phandler);
	if (pMdUser != nullptr)
		delete pMdUser;
	*phandler = nullptr;
	return 0;
}


int SubscribeMarketData(void* handler, char* ppInstrumentID[], int nCount)
{
    CMdUser* pMdUser = (CMdUser*)handler;
    return pMdUser->SubscribeMarketData(ppInstrumentID, nCount);
}


int UnSubscribeMarketData(void* handler, char* ppInstrumentID[], int nCount)
{
    CMdUser* pMdUser = (CMdUser*)handler;
    return pMdUser->UnSubscribeMarketData(ppInstrumentID, nCount);
}


int SubscribeForQuoteRsp(void* handler, char* ppInstrumentID[], int nCount)
{
    CMdUser* pMdUser = (CMdUser*)handler;
    return pMdUser->SubscribeForQuoteRsp(ppInstrumentID, nCount);
}


int UnSubscribeForQuoteRsp(void* handler, char* ppInstrumentID[], int nCount)
{
    CMdUser* pMdUser = (CMdUser*)handler;
    return pMdUser->UnSubscribeForQuoteRsp(ppInstrumentID, nCount);
}

const char* GetTradingDay(void* phandler)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    return pMdUser->GetTradingDay();
}

int ReqUserLogout(void* phandler, CThostFtdcUserLogoutField* pUserLogout, int nRequestID)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    return pMdUser->ReqUserLogout(pUserLogout, nRequestID);
}


void RegisterMdFPOnFrontConnected(void* phandler, FuncPtrMdOnFrontConnected fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnFrontConnected(fp);
}

void RegisterMdFPOnFrontDisconnected(void* phandler, FuncPtrMdOnFrontDisconnected fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnFrontDisconnected(fp);
}

void RegisterMdFPOnHeartBeatWarning(void* phandler, FuncPtrMdOnHeartBeatWarning fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnHeartBeatWarning(fp);
}

void RegisterMdFPOnRspUserLogin(void* phandler, FuncPtrMdOnRspUserLogin fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspUserLogin(fp);
}

void RegisterMdFPOnRspUserLogout(void* phandler, FuncPtrMdOnRspUserLogout fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspUserLogout(fp);
}

void RegisterMdFPOnRspError(void* phandler, FuncPtrMdOnRspError fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspError(fp);
}

void RegisterMdFPOnRspSubMarketData(void* phandler, FuncPtrMdOnRspSubMarketData fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspSubMarketData(fp);
}

void RegisterMdFPOnRspUnSubMarketData(void* phandler, FuncPtrMdOnRspUnSubMarketData fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspUnSubMarketData(fp);
}

void RegisterMdFPOnRspSubForQuoteRsp(void* phandler, FuncPtrMdOnRspSubForQuoteRsp fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspSubForQuoteRsp(fp);
}

void RegisterMdFPOnRspUnSubForQuoteRsp(void* phandler, FuncPtrMdOnRspUnSubForQuoteRsp fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRspUnSubForQuoteRsp(fp);
}

void RegisterMdFPOnRtnDepthMarketData(void* phandler, FuncPtrMdOnRtnDepthMarketData fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRtnDepthMarketData(fp);
}

void RegisterMdFPOnRtnForQuoteRsp(void* phandler, FuncPtrMdOnRtnForQuoteRsp fp)
{
    CMdUser* pMdUser = (CMdUser*)phandler;
    pMdUser->registerFP_OnRtnForQuoteRsp(fp);
}
