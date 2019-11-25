#pragma once

#include <cstring>
#include "ThostFtdcMdApi.h"
#include "cctp_mduser.h"

class CMdUser : public CThostFtdcMdSpi
{
public:
	CMdUser(MdUserInfo* trader_info);
	~CMdUser();

	int Connect();
	int Disconnect();

private:
	void ReqUserLogin();
	void InitFlags();

public:

	int SubscribeMarketData(char* ppInstrumentID[], int nCount);

	int UnSubscribeMarketData(char* ppInstrumentID[], int nCount);

	int SubscribeForQuoteRsp(char* ppInstrumentID[], int nCount);

	int UnSubscribeForQuoteRsp(char* ppInstrumentID[], int nCount);

	//api
    const char* GetTradingDay() ;
    void RegisterFront(char* pszFrontAddress) ;
    void RegisterNameServer(char* pszNsAddress) ;
    void RegisterFensUserInfo(CThostFtdcFensUserInfoField * pFensUserInfo) ;
    int ReqUserLogout(CThostFtdcUserLogoutField* pUserLogout, int nRequestID) ;

	//spi
    virtual void OnFrontConnected() ;
    virtual void OnFrontDisconnected(int nReason) ;
    virtual void OnHeartBeatWarning(int nTimeLapse) ;
    virtual void OnRspUserLogin(CThostFtdcRspUserLoginField* pRspUserLogin, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspUserLogout(CThostFtdcUserLogoutField* pUserLogout, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspError(CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument, CThostFtdcRspInfoField* pRspInfo, int nRequestID, bool bIsLast) ;
    virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData) ;
    virtual void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp) ;

    //registered flags
    void registerFP_OnFrontConnected(FuncPtrMdOnFrontConnected fp);
    void registerFP_OnFrontDisconnected(FuncPtrMdOnFrontDisconnected fp);
    void registerFP_OnHeartBeatWarning(FuncPtrMdOnHeartBeatWarning fp);
    void registerFP_OnRspUserLogin(FuncPtrMdOnRspUserLogin fp);
    void registerFP_OnRspUserLogout(FuncPtrMdOnRspUserLogout fp);
    void registerFP_OnRspError(FuncPtrMdOnRspError fp);
    void registerFP_OnRspSubMarketData(FuncPtrMdOnRspSubMarketData fp);
    void registerFP_OnRspUnSubMarketData(FuncPtrMdOnRspUnSubMarketData fp);
    void registerFP_OnRspSubForQuoteRsp(FuncPtrMdOnRspSubForQuoteRsp fp);
    void registerFP_OnRspUnSubForQuoteRsp(FuncPtrMdOnRspUnSubForQuoteRsp fp);
    void registerFP_OnRtnDepthMarketData(FuncPtrMdOnRtnDepthMarketData fp);
    void registerFP_OnRtnForQuoteRsp(FuncPtrMdOnRtnForQuoteRsp fp);

private:
	CThostFtdcMdApi *m_pApi;
	MdUserInfo m_userInfo;

	//registered flags
    bool m_onFrontConnectedRegistered;
    bool m_onFrontDisconnectedRegistered;
    bool m_onHeartBeatWarningRegistered;
    bool m_onRspUserLoginRegistered;
    bool m_onRspUserLogoutRegistered;
    bool m_onRspErrorRegistered;
    bool m_onRspSubMarketDataRegistered;
    bool m_onRspUnSubMarketDataRegistered;
    bool m_onRspSubForQuoteRspRegistered;
    bool m_onRspUnSubForQuoteRspRegistered;
    bool m_onRtnDepthMarketDataRegistered;
    bool m_onRtnForQuoteRspRegistered;

	//function pointers
    FuncPtrMdOnFrontConnected m_fpOnFrontConnected;
    FuncPtrMdOnFrontDisconnected m_fpOnFrontDisconnected;
    FuncPtrMdOnHeartBeatWarning m_fpOnHeartBeatWarning;
    FuncPtrMdOnRspUserLogin m_fpOnRspUserLogin;
    FuncPtrMdOnRspUserLogout m_fpOnRspUserLogout;
    FuncPtrMdOnRspError m_fpOnRspError;
    FuncPtrMdOnRspSubMarketData m_fpOnRspSubMarketData;
    FuncPtrMdOnRspUnSubMarketData m_fpOnRspUnSubMarketData;
    FuncPtrMdOnRspSubForQuoteRsp m_fpOnRspSubForQuoteRsp;
    FuncPtrMdOnRspUnSubForQuoteRsp m_fpOnRspUnSubForQuoteRsp;
    FuncPtrMdOnRtnDepthMarketData m_fpOnRtnDepthMarketData;
    FuncPtrMdOnRtnForQuoteRsp m_fpOnRtnForQuoteRsp;

};