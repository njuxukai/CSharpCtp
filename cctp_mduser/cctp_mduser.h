#ifndef CCTP_MDUSER_H
#define CCTP_MDUSER_H


#ifdef CCTP_EXPORT
#define API_EXPORT __declspec(dllexport)
#else
#define API_EXPORT __declspec(dllimport)
#endif


#include "ThostFtdcMdApi.h"

#define API_NULLPTR -8888
#define NO_AUTH 0
#define DIRECT_AUTH 1

typedef struct MdUserInfo
{
char BrokerID[11];
char UserID[16];
char InvestorID[16];
char Password[41];
char FrontID[101];
char FlowPath[101];
}MdUserInfo;

typedef void(__cdecl *FuncPtrMdOnFrontConnected)() ;
typedef void(__cdecl *FuncPtrMdOnFrontDisconnected)(int nReason) ;
typedef void(__cdecl *FuncPtrMdOnHeartBeatWarning)(int nTimeLapse) ;
typedef void(__cdecl *FuncPtrMdOnRspUserLogin)(CThostFtdcRspUserLoginField* pRspUserLogin, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspUserLogout)(CThostFtdcUserLogoutField* pUserLogout, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspError)(CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspSubMarketData)(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspUnSubMarketData)(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspSubForQuoteRsp)(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRspUnSubForQuoteRsp)(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
typedef void(__cdecl *FuncPtrMdOnRtnDepthMarketData)(CThostFtdcDepthMarketDataField* pDepthMarketData) ;
typedef void(__cdecl *FuncPtrMdOnRtnForQuoteRsp)(CThostFtdcForQuoteRspField* pForQuoteRsp) ;


#ifdef __cplusplus
extern "C"
{
#endif

	API_EXPORT int CreateMdUser(MdUserInfo* mduser_info, void** phandler);
	API_EXPORT int ConnectMdUser(void* handler);
	API_EXPORT int DisconnectMdUser(void* handler);
	API_EXPORT int DestroyMdUser(void** phandler);
	API_EXPORT int SubscribeMarketData(void* handler, char* ppInstrumentID[], int nCount);
	API_EXPORT int UnSubscribeMarketData(void* handler, char* ppInstrumentID[], int nCount);
	API_EXPORT int SubscribeForQuoteRsp(void* handler, char* ppInstrumentID[], int nCount);
	API_EXPORT int UnSubscribeForQuoteRsp(void* handler, char* ppInstrumentID[], int nCount);


    API_EXPORT const char* GetTradingDay(void* mduser);
    API_EXPORT int ReqUserLogout(void* mduser, CThostFtdcUserLogoutField* pUserLogout, int nRequestID);

    API_EXPORT void RegisterMdFPOnFrontConnected(void* mduser, FuncPtrMdOnFrontConnected fp);
    API_EXPORT void RegisterMdFPOnFrontDisconnected(void* mduser, FuncPtrMdOnFrontDisconnected fp);
    API_EXPORT void RegisterMdFPOnHeartBeatWarning(void* mduser, FuncPtrMdOnHeartBeatWarning fp);
    API_EXPORT void RegisterMdFPOnRspUserLogin(void* mduser, FuncPtrMdOnRspUserLogin fp);
    API_EXPORT void RegisterMdFPOnRspUserLogout(void* mduser, FuncPtrMdOnRspUserLogout fp);
    API_EXPORT void RegisterMdFPOnRspError(void* mduser, FuncPtrMdOnRspError fp);
    API_EXPORT void RegisterMdFPOnRspSubMarketData(void* mduser, FuncPtrMdOnRspSubMarketData fp);
    API_EXPORT void RegisterMdFPOnRspUnSubMarketData(void* mduser, FuncPtrMdOnRspUnSubMarketData fp);
    API_EXPORT void RegisterMdFPOnRspSubForQuoteRsp(void* mduser, FuncPtrMdOnRspSubForQuoteRsp fp);
    API_EXPORT void RegisterMdFPOnRspUnSubForQuoteRsp(void* mduser, FuncPtrMdOnRspUnSubForQuoteRsp fp);
    API_EXPORT void RegisterMdFPOnRtnDepthMarketData(void* mduser, FuncPtrMdOnRtnDepthMarketData fp);
    API_EXPORT void RegisterMdFPOnRtnForQuoteRsp(void* mduser, FuncPtrMdOnRtnForQuoteRsp fp);

#ifdef __cplusplus
}
#endif

#endif
