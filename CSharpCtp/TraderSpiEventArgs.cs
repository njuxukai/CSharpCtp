using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCtp.Trader
{
   
        public class OnFrontDisconnectedEventArgs : EventArgs
    {
        public OnFrontDisconnectedEventArgs(int nReason)
        {
            m_nReason = nReason;
        }
    
        public int NReason {get {return m_nReason; }}
    
        public readonly int m_nReason ;
    }
    
    public class OnHeartBeatWarningEventArgs : EventArgs
    {
        public OnHeartBeatWarningEventArgs(int nTimeLapse)
        {
            m_nTimeLapse = nTimeLapse;
        }
    
        public int NTimeLapse {get {return m_nTimeLapse; }}
    
        public readonly int m_nTimeLapse ;
    }
    
    public class OnRspAuthenticateEventArgs : EventArgs
    {
        public OnRspAuthenticateEventArgs(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspAuthenticateField = pRspAuthenticateField;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspAuthenticateField? PRspAuthenticateField {get {return m_pRspAuthenticateField; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspAuthenticateField? m_pRspAuthenticateField ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUserLoginEventArgs : EventArgs
    {
        public OnRspUserLoginEventArgs(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspUserLogin = pRspUserLogin;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspUserLoginField? PRspUserLogin {get {return m_pRspUserLogin; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspUserLoginField? m_pRspUserLogin ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUserLogoutEventArgs : EventArgs
    {
        public OnRspUserLogoutEventArgs(CThostFtdcUserLogoutField? pUserLogout, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pUserLogout = pUserLogout;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcUserLogoutField? PUserLogout {get {return m_pUserLogout; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcUserLogoutField? m_pUserLogout ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUserPasswordUpdateEventArgs : EventArgs
    {
        public OnRspUserPasswordUpdateEventArgs(CThostFtdcUserPasswordUpdateField? pUserPasswordUpdate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pUserPasswordUpdate = pUserPasswordUpdate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcUserPasswordUpdateField? PUserPasswordUpdate {get {return m_pUserPasswordUpdate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcUserPasswordUpdateField? m_pUserPasswordUpdate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspTradingAccountPasswordUpdateEventArgs : EventArgs
    {
        public OnRspTradingAccountPasswordUpdateEventArgs(CThostFtdcTradingAccountPasswordUpdateField? pTradingAccountPasswordUpdate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTradingAccountPasswordUpdate = pTradingAccountPasswordUpdate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradingAccountPasswordUpdateField? PTradingAccountPasswordUpdate {get {return m_pTradingAccountPasswordUpdate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradingAccountPasswordUpdateField? m_pTradingAccountPasswordUpdate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUserAuthMethodEventArgs : EventArgs
    {
        public OnRspUserAuthMethodEventArgs(CThostFtdcRspUserAuthMethodField? pRspUserAuthMethod, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspUserAuthMethod = pRspUserAuthMethod;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspUserAuthMethodField? PRspUserAuthMethod {get {return m_pRspUserAuthMethod; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspUserAuthMethodField? m_pRspUserAuthMethod ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspGenUserCaptchaEventArgs : EventArgs
    {
        public OnRspGenUserCaptchaEventArgs(CThostFtdcRspGenUserCaptchaField? pRspGenUserCaptcha, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspGenUserCaptcha = pRspGenUserCaptcha;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspGenUserCaptchaField? PRspGenUserCaptcha {get {return m_pRspGenUserCaptcha; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspGenUserCaptchaField? m_pRspGenUserCaptcha ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspGenUserTextEventArgs : EventArgs
    {
        public OnRspGenUserTextEventArgs(CThostFtdcRspGenUserTextField? pRspGenUserText, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspGenUserText = pRspGenUserText;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspGenUserTextField? PRspGenUserText {get {return m_pRspGenUserText; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspGenUserTextField? m_pRspGenUserText ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspOrderInsertEventArgs : EventArgs
    {
        public OnRspOrderInsertEventArgs(CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputOrder = pInputOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputOrderField? PInputOrder {get {return m_pInputOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputOrderField? m_pInputOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspParkedOrderInsertEventArgs : EventArgs
    {
        public OnRspParkedOrderInsertEventArgs(CThostFtdcParkedOrderField? pParkedOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pParkedOrder = pParkedOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcParkedOrderField? PParkedOrder {get {return m_pParkedOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcParkedOrderField? m_pParkedOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspParkedOrderActionEventArgs : EventArgs
    {
        public OnRspParkedOrderActionEventArgs(CThostFtdcParkedOrderActionField? pParkedOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pParkedOrderAction = pParkedOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcParkedOrderActionField? PParkedOrderAction {get {return m_pParkedOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcParkedOrderActionField? m_pParkedOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspOrderActionEventArgs : EventArgs
    {
        public OnRspOrderActionEventArgs(CThostFtdcInputOrderActionField? pInputOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputOrderAction = pInputOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputOrderActionField? PInputOrderAction {get {return m_pInputOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputOrderActionField? m_pInputOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQueryMaxOrderVolumeEventArgs : EventArgs
    {
        public OnRspQueryMaxOrderVolumeEventArgs(CThostFtdcQueryMaxOrderVolumeField? pQueryMaxOrderVolume, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pQueryMaxOrderVolume = pQueryMaxOrderVolume;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcQueryMaxOrderVolumeField? PQueryMaxOrderVolume {get {return m_pQueryMaxOrderVolume; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcQueryMaxOrderVolumeField? m_pQueryMaxOrderVolume ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspSettlementInfoConfirmEventArgs : EventArgs
    {
        public OnRspSettlementInfoConfirmEventArgs(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSettlementInfoConfirm = pSettlementInfoConfirm;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSettlementInfoConfirmField? PSettlementInfoConfirm {get {return m_pSettlementInfoConfirm; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSettlementInfoConfirmField? m_pSettlementInfoConfirm ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspRemoveParkedOrderEventArgs : EventArgs
    {
        public OnRspRemoveParkedOrderEventArgs(CThostFtdcRemoveParkedOrderField? pRemoveParkedOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRemoveParkedOrder = pRemoveParkedOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRemoveParkedOrderField? PRemoveParkedOrder {get {return m_pRemoveParkedOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRemoveParkedOrderField? m_pRemoveParkedOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspRemoveParkedOrderActionEventArgs : EventArgs
    {
        public OnRspRemoveParkedOrderActionEventArgs(CThostFtdcRemoveParkedOrderActionField? pRemoveParkedOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRemoveParkedOrderAction = pRemoveParkedOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRemoveParkedOrderActionField? PRemoveParkedOrderAction {get {return m_pRemoveParkedOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRemoveParkedOrderActionField? m_pRemoveParkedOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspExecOrderInsertEventArgs : EventArgs
    {
        public OnRspExecOrderInsertEventArgs(CThostFtdcInputExecOrderField? pInputExecOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputExecOrder = pInputExecOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputExecOrderField? PInputExecOrder {get {return m_pInputExecOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputExecOrderField? m_pInputExecOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspExecOrderActionEventArgs : EventArgs
    {
        public OnRspExecOrderActionEventArgs(CThostFtdcInputExecOrderActionField? pInputExecOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputExecOrderAction = pInputExecOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputExecOrderActionField? PInputExecOrderAction {get {return m_pInputExecOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputExecOrderActionField? m_pInputExecOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspForQuoteInsertEventArgs : EventArgs
    {
        public OnRspForQuoteInsertEventArgs(CThostFtdcInputForQuoteField? pInputForQuote, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputForQuote = pInputForQuote;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputForQuoteField? PInputForQuote {get {return m_pInputForQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputForQuoteField? m_pInputForQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQuoteInsertEventArgs : EventArgs
    {
        public OnRspQuoteInsertEventArgs(CThostFtdcInputQuoteField? pInputQuote, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputQuote = pInputQuote;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputQuoteField? PInputQuote {get {return m_pInputQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputQuoteField? m_pInputQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQuoteActionEventArgs : EventArgs
    {
        public OnRspQuoteActionEventArgs(CThostFtdcInputQuoteActionField? pInputQuoteAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputQuoteAction = pInputQuoteAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputQuoteActionField? PInputQuoteAction {get {return m_pInputQuoteAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputQuoteActionField? m_pInputQuoteAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspBatchOrderActionEventArgs : EventArgs
    {
        public OnRspBatchOrderActionEventArgs(CThostFtdcInputBatchOrderActionField? pInputBatchOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputBatchOrderAction = pInputBatchOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputBatchOrderActionField? PInputBatchOrderAction {get {return m_pInputBatchOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputBatchOrderActionField? m_pInputBatchOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspOptionSelfCloseInsertEventArgs : EventArgs
    {
        public OnRspOptionSelfCloseInsertEventArgs(CThostFtdcInputOptionSelfCloseField? pInputOptionSelfClose, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputOptionSelfClose = pInputOptionSelfClose;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputOptionSelfCloseField? PInputOptionSelfClose {get {return m_pInputOptionSelfClose; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputOptionSelfCloseField? m_pInputOptionSelfClose ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspOptionSelfCloseActionEventArgs : EventArgs
    {
        public OnRspOptionSelfCloseActionEventArgs(CThostFtdcInputOptionSelfCloseActionField? pInputOptionSelfCloseAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputOptionSelfCloseAction = pInputOptionSelfCloseAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputOptionSelfCloseActionField? PInputOptionSelfCloseAction {get {return m_pInputOptionSelfCloseAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputOptionSelfCloseActionField? m_pInputOptionSelfCloseAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspCombActionInsertEventArgs : EventArgs
    {
        public OnRspCombActionInsertEventArgs(CThostFtdcInputCombActionField? pInputCombAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInputCombAction = pInputCombAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInputCombActionField? PInputCombAction {get {return m_pInputCombAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInputCombActionField? m_pInputCombAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryOrderEventArgs : EventArgs
    {
        public OnRspQryOrderEventArgs(CThostFtdcOrderField? pOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pOrder = pOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcOrderField? POrder {get {return m_pOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcOrderField? m_pOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTradeEventArgs : EventArgs
    {
        public OnRspQryTradeEventArgs(CThostFtdcTradeField? pTrade, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTrade = pTrade;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradeField? PTrade {get {return m_pTrade; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradeField? m_pTrade ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestorPositionEventArgs : EventArgs
    {
        public OnRspQryInvestorPositionEventArgs(CThostFtdcInvestorPositionField? pInvestorPosition, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestorPosition = pInvestorPosition;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestorPositionField? PInvestorPosition {get {return m_pInvestorPosition; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestorPositionField? m_pInvestorPosition ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTradingAccountEventArgs : EventArgs
    {
        public OnRspQryTradingAccountEventArgs(CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTradingAccount = pTradingAccount;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradingAccountField? PTradingAccount {get {return m_pTradingAccount; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradingAccountField? m_pTradingAccount ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestorEventArgs : EventArgs
    {
        public OnRspQryInvestorEventArgs(CThostFtdcInvestorField? pInvestor, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestor = pInvestor;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestorField? PInvestor {get {return m_pInvestor; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestorField? m_pInvestor ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTradingCodeEventArgs : EventArgs
    {
        public OnRspQryTradingCodeEventArgs(CThostFtdcTradingCodeField? pTradingCode, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTradingCode = pTradingCode;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradingCodeField? PTradingCode {get {return m_pTradingCode; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradingCodeField? m_pTradingCode ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInstrumentMarginRateEventArgs : EventArgs
    {
        public OnRspQryInstrumentMarginRateEventArgs(CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInstrumentMarginRate = pInstrumentMarginRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInstrumentMarginRateField? PInstrumentMarginRate {get {return m_pInstrumentMarginRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInstrumentMarginRateField? m_pInstrumentMarginRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInstrumentCommissionRateEventArgs : EventArgs
    {
        public OnRspQryInstrumentCommissionRateEventArgs(CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInstrumentCommissionRate = pInstrumentCommissionRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInstrumentCommissionRateField? PInstrumentCommissionRate {get {return m_pInstrumentCommissionRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInstrumentCommissionRateField? m_pInstrumentCommissionRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryExchangeEventArgs : EventArgs
    {
        public OnRspQryExchangeEventArgs(CThostFtdcExchangeField? pExchange, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pExchange = pExchange;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcExchangeField? PExchange {get {return m_pExchange; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcExchangeField? m_pExchange ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryProductEventArgs : EventArgs
    {
        public OnRspQryProductEventArgs(CThostFtdcProductField? pProduct, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pProduct = pProduct;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcProductField? PProduct {get {return m_pProduct; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcProductField? m_pProduct ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInstrumentEventArgs : EventArgs
    {
        public OnRspQryInstrumentEventArgs(CThostFtdcInstrumentField? pInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInstrument = pInstrument;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInstrumentField? PInstrument {get {return m_pInstrument; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInstrumentField? m_pInstrument ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryDepthMarketDataEventArgs : EventArgs
    {
        public OnRspQryDepthMarketDataEventArgs(CThostFtdcDepthMarketDataField? pDepthMarketData, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pDepthMarketData = pDepthMarketData;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcDepthMarketDataField? PDepthMarketData {get {return m_pDepthMarketData; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcDepthMarketDataField? m_pDepthMarketData ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySettlementInfoEventArgs : EventArgs
    {
        public OnRspQrySettlementInfoEventArgs(CThostFtdcSettlementInfoField? pSettlementInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSettlementInfo = pSettlementInfo;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSettlementInfoField? PSettlementInfo {get {return m_pSettlementInfo; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSettlementInfoField? m_pSettlementInfo ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTransferBankEventArgs : EventArgs
    {
        public OnRspQryTransferBankEventArgs(CThostFtdcTransferBankField? pTransferBank, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTransferBank = pTransferBank;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTransferBankField? PTransferBank {get {return m_pTransferBank; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTransferBankField? m_pTransferBank ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestorPositionDetailEventArgs : EventArgs
    {
        public OnRspQryInvestorPositionDetailEventArgs(CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestorPositionDetail = pInvestorPositionDetail;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestorPositionDetailField? PInvestorPositionDetail {get {return m_pInvestorPositionDetail; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestorPositionDetailField? m_pInvestorPositionDetail ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryNoticeEventArgs : EventArgs
    {
        public OnRspQryNoticeEventArgs(CThostFtdcNoticeField? pNotice, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pNotice = pNotice;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcNoticeField? PNotice {get {return m_pNotice; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcNoticeField? m_pNotice ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySettlementInfoConfirmEventArgs : EventArgs
    {
        public OnRspQrySettlementInfoConfirmEventArgs(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSettlementInfoConfirm = pSettlementInfoConfirm;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSettlementInfoConfirmField? PSettlementInfoConfirm {get {return m_pSettlementInfoConfirm; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSettlementInfoConfirmField? m_pSettlementInfoConfirm ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestorPositionCombineDetailEventArgs : EventArgs
    {
        public OnRspQryInvestorPositionCombineDetailEventArgs(CThostFtdcInvestorPositionCombineDetailField? pInvestorPositionCombineDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestorPositionCombineDetail = pInvestorPositionCombineDetail;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestorPositionCombineDetailField? PInvestorPositionCombineDetail {get {return m_pInvestorPositionCombineDetail; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestorPositionCombineDetailField? m_pInvestorPositionCombineDetail ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryCFMMCTradingAccountKeyEventArgs : EventArgs
    {
        public OnRspQryCFMMCTradingAccountKeyEventArgs(CThostFtdcCFMMCTradingAccountKeyField? pCFMMCTradingAccountKey, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pCFMMCTradingAccountKey = pCFMMCTradingAccountKey;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcCFMMCTradingAccountKeyField? PCFMMCTradingAccountKey {get {return m_pCFMMCTradingAccountKey; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcCFMMCTradingAccountKeyField? m_pCFMMCTradingAccountKey ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryEWarrantOffsetEventArgs : EventArgs
    {
        public OnRspQryEWarrantOffsetEventArgs(CThostFtdcEWarrantOffsetField? pEWarrantOffset, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pEWarrantOffset = pEWarrantOffset;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcEWarrantOffsetField? PEWarrantOffset {get {return m_pEWarrantOffset; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcEWarrantOffsetField? m_pEWarrantOffset ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestorProductGroupMarginEventArgs : EventArgs
    {
        public OnRspQryInvestorProductGroupMarginEventArgs(CThostFtdcInvestorProductGroupMarginField? pInvestorProductGroupMargin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestorProductGroupMargin = pInvestorProductGroupMargin;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestorProductGroupMarginField? PInvestorProductGroupMargin {get {return m_pInvestorProductGroupMargin; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestorProductGroupMarginField? m_pInvestorProductGroupMargin ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryExchangeMarginRateEventArgs : EventArgs
    {
        public OnRspQryExchangeMarginRateEventArgs(CThostFtdcExchangeMarginRateField? pExchangeMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pExchangeMarginRate = pExchangeMarginRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcExchangeMarginRateField? PExchangeMarginRate {get {return m_pExchangeMarginRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcExchangeMarginRateField? m_pExchangeMarginRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryExchangeMarginRateAdjustEventArgs : EventArgs
    {
        public OnRspQryExchangeMarginRateAdjustEventArgs(CThostFtdcExchangeMarginRateAdjustField? pExchangeMarginRateAdjust, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pExchangeMarginRateAdjust = pExchangeMarginRateAdjust;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcExchangeMarginRateAdjustField? PExchangeMarginRateAdjust {get {return m_pExchangeMarginRateAdjust; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcExchangeMarginRateAdjustField? m_pExchangeMarginRateAdjust ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryExchangeRateEventArgs : EventArgs
    {
        public OnRspQryExchangeRateEventArgs(CThostFtdcExchangeRateField? pExchangeRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pExchangeRate = pExchangeRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcExchangeRateField? PExchangeRate {get {return m_pExchangeRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcExchangeRateField? m_pExchangeRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySecAgentACIDMapEventArgs : EventArgs
    {
        public OnRspQrySecAgentACIDMapEventArgs(CThostFtdcSecAgentACIDMapField? pSecAgentACIDMap, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSecAgentACIDMap = pSecAgentACIDMap;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSecAgentACIDMapField? PSecAgentACIDMap {get {return m_pSecAgentACIDMap; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSecAgentACIDMapField? m_pSecAgentACIDMap ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryProductExchRateEventArgs : EventArgs
    {
        public OnRspQryProductExchRateEventArgs(CThostFtdcProductExchRateField? pProductExchRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pProductExchRate = pProductExchRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcProductExchRateField? PProductExchRate {get {return m_pProductExchRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcProductExchRateField? m_pProductExchRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryProductGroupEventArgs : EventArgs
    {
        public OnRspQryProductGroupEventArgs(CThostFtdcProductGroupField? pProductGroup, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pProductGroup = pProductGroup;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcProductGroupField? PProductGroup {get {return m_pProductGroup; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcProductGroupField? m_pProductGroup ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryMMInstrumentCommissionRateEventArgs : EventArgs
    {
        public OnRspQryMMInstrumentCommissionRateEventArgs(CThostFtdcMMInstrumentCommissionRateField? pMMInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pMMInstrumentCommissionRate = pMMInstrumentCommissionRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcMMInstrumentCommissionRateField? PMMInstrumentCommissionRate {get {return m_pMMInstrumentCommissionRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcMMInstrumentCommissionRateField? m_pMMInstrumentCommissionRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryMMOptionInstrCommRateEventArgs : EventArgs
    {
        public OnRspQryMMOptionInstrCommRateEventArgs(CThostFtdcMMOptionInstrCommRateField? pMMOptionInstrCommRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pMMOptionInstrCommRate = pMMOptionInstrCommRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcMMOptionInstrCommRateField? PMMOptionInstrCommRate {get {return m_pMMOptionInstrCommRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcMMOptionInstrCommRateField? m_pMMOptionInstrCommRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInstrumentOrderCommRateEventArgs : EventArgs
    {
        public OnRspQryInstrumentOrderCommRateEventArgs(CThostFtdcInstrumentOrderCommRateField? pInstrumentOrderCommRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInstrumentOrderCommRate = pInstrumentOrderCommRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInstrumentOrderCommRateField? PInstrumentOrderCommRate {get {return m_pInstrumentOrderCommRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInstrumentOrderCommRateField? m_pInstrumentOrderCommRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySecAgentTradingAccountEventArgs : EventArgs
    {
        public OnRspQrySecAgentTradingAccountEventArgs(CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTradingAccount = pTradingAccount;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradingAccountField? PTradingAccount {get {return m_pTradingAccount; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradingAccountField? m_pTradingAccount ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySecAgentCheckModeEventArgs : EventArgs
    {
        public OnRspQrySecAgentCheckModeEventArgs(CThostFtdcSecAgentCheckModeField? pSecAgentCheckMode, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSecAgentCheckMode = pSecAgentCheckMode;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSecAgentCheckModeField? PSecAgentCheckMode {get {return m_pSecAgentCheckMode; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSecAgentCheckModeField? m_pSecAgentCheckMode ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQrySecAgentTradeInfoEventArgs : EventArgs
    {
        public OnRspQrySecAgentTradeInfoEventArgs(CThostFtdcSecAgentTradeInfoField? pSecAgentTradeInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSecAgentTradeInfo = pSecAgentTradeInfo;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSecAgentTradeInfoField? PSecAgentTradeInfo {get {return m_pSecAgentTradeInfo; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSecAgentTradeInfoField? m_pSecAgentTradeInfo ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryOptionInstrTradeCostEventArgs : EventArgs
    {
        public OnRspQryOptionInstrTradeCostEventArgs(CThostFtdcOptionInstrTradeCostField? pOptionInstrTradeCost, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pOptionInstrTradeCost = pOptionInstrTradeCost;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcOptionInstrTradeCostField? POptionInstrTradeCost {get {return m_pOptionInstrTradeCost; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcOptionInstrTradeCostField? m_pOptionInstrTradeCost ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryOptionInstrCommRateEventArgs : EventArgs
    {
        public OnRspQryOptionInstrCommRateEventArgs(CThostFtdcOptionInstrCommRateField? pOptionInstrCommRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pOptionInstrCommRate = pOptionInstrCommRate;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcOptionInstrCommRateField? POptionInstrCommRate {get {return m_pOptionInstrCommRate; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcOptionInstrCommRateField? m_pOptionInstrCommRate ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryExecOrderEventArgs : EventArgs
    {
        public OnRspQryExecOrderEventArgs(CThostFtdcExecOrderField? pExecOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pExecOrder = pExecOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcExecOrderField? PExecOrder {get {return m_pExecOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcExecOrderField? m_pExecOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryForQuoteEventArgs : EventArgs
    {
        public OnRspQryForQuoteEventArgs(CThostFtdcForQuoteField? pForQuote, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pForQuote = pForQuote;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcForQuoteField? PForQuote {get {return m_pForQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcForQuoteField? m_pForQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryQuoteEventArgs : EventArgs
    {
        public OnRspQryQuoteEventArgs(CThostFtdcQuoteField? pQuote, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pQuote = pQuote;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcQuoteField? PQuote {get {return m_pQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcQuoteField? m_pQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryOptionSelfCloseEventArgs : EventArgs
    {
        public OnRspQryOptionSelfCloseEventArgs(CThostFtdcOptionSelfCloseField? pOptionSelfClose, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pOptionSelfClose = pOptionSelfClose;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcOptionSelfCloseField? POptionSelfClose {get {return m_pOptionSelfClose; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcOptionSelfCloseField? m_pOptionSelfClose ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryInvestUnitEventArgs : EventArgs
    {
        public OnRspQryInvestUnitEventArgs(CThostFtdcInvestUnitField? pInvestUnit, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pInvestUnit = pInvestUnit;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcInvestUnitField? PInvestUnit {get {return m_pInvestUnit; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcInvestUnitField? m_pInvestUnit ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryCombInstrumentGuardEventArgs : EventArgs
    {
        public OnRspQryCombInstrumentGuardEventArgs(CThostFtdcCombInstrumentGuardField? pCombInstrumentGuard, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pCombInstrumentGuard = pCombInstrumentGuard;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcCombInstrumentGuardField? PCombInstrumentGuard {get {return m_pCombInstrumentGuard; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcCombInstrumentGuardField? m_pCombInstrumentGuard ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryCombActionEventArgs : EventArgs
    {
        public OnRspQryCombActionEventArgs(CThostFtdcCombActionField? pCombAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pCombAction = pCombAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcCombActionField? PCombAction {get {return m_pCombAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcCombActionField? m_pCombAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTransferSerialEventArgs : EventArgs
    {
        public OnRspQryTransferSerialEventArgs(CThostFtdcTransferSerialField? pTransferSerial, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTransferSerial = pTransferSerial;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTransferSerialField? PTransferSerial {get {return m_pTransferSerial; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTransferSerialField? m_pTransferSerial ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryAccountregisterEventArgs : EventArgs
    {
        public OnRspQryAccountregisterEventArgs(CThostFtdcAccountregisterField? pAccountregister, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pAccountregister = pAccountregister;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcAccountregisterField? PAccountregister {get {return m_pAccountregister; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcAccountregisterField? m_pAccountregister ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspErrorEventArgs : EventArgs
    {
        public OnRspErrorEventArgs(CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRtnOrderEventArgs : EventArgs
    {
        public OnRtnOrderEventArgs(CThostFtdcOrderField? pOrder)
        {
            m_pOrder = pOrder;
        }
    
        public CThostFtdcOrderField? POrder {get {return m_pOrder; }}
    
        public readonly CThostFtdcOrderField? m_pOrder ;
    }
    
    public class OnRtnTradeEventArgs : EventArgs
    {
        public OnRtnTradeEventArgs(CThostFtdcTradeField? pTrade)
        {
            m_pTrade = pTrade;
        }
    
        public CThostFtdcTradeField? PTrade {get {return m_pTrade; }}
    
        public readonly CThostFtdcTradeField? m_pTrade ;
    }
    
    public class OnErrRtnOrderInsertEventArgs : EventArgs
    {
        public OnErrRtnOrderInsertEventArgs(CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputOrder = pInputOrder;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputOrderField? PInputOrder {get {return m_pInputOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputOrderField? m_pInputOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnOrderActionEventArgs : EventArgs
    {
        public OnErrRtnOrderActionEventArgs(CThostFtdcOrderActionField? pOrderAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pOrderAction = pOrderAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcOrderActionField? POrderAction {get {return m_pOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcOrderActionField? m_pOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnInstrumentStatusEventArgs : EventArgs
    {
        public OnRtnInstrumentStatusEventArgs(CThostFtdcInstrumentStatusField? pInstrumentStatus)
        {
            m_pInstrumentStatus = pInstrumentStatus;
        }
    
        public CThostFtdcInstrumentStatusField? PInstrumentStatus {get {return m_pInstrumentStatus; }}
    
        public readonly CThostFtdcInstrumentStatusField? m_pInstrumentStatus ;
    }
    
    public class OnRtnBulletinEventArgs : EventArgs
    {
        public OnRtnBulletinEventArgs(CThostFtdcBulletinField? pBulletin)
        {
            m_pBulletin = pBulletin;
        }
    
        public CThostFtdcBulletinField? PBulletin {get {return m_pBulletin; }}
    
        public readonly CThostFtdcBulletinField? m_pBulletin ;
    }
    
    public class OnRtnTradingNoticeEventArgs : EventArgs
    {
        public OnRtnTradingNoticeEventArgs(CThostFtdcTradingNoticeInfoField? pTradingNoticeInfo)
        {
            m_pTradingNoticeInfo = pTradingNoticeInfo;
        }
    
        public CThostFtdcTradingNoticeInfoField? PTradingNoticeInfo {get {return m_pTradingNoticeInfo; }}
    
        public readonly CThostFtdcTradingNoticeInfoField? m_pTradingNoticeInfo ;
    }
    
    public class OnRtnErrorConditionalOrderEventArgs : EventArgs
    {
        public OnRtnErrorConditionalOrderEventArgs(CThostFtdcErrorConditionalOrderField? pErrorConditionalOrder)
        {
            m_pErrorConditionalOrder = pErrorConditionalOrder;
        }
    
        public CThostFtdcErrorConditionalOrderField? PErrorConditionalOrder {get {return m_pErrorConditionalOrder; }}
    
        public readonly CThostFtdcErrorConditionalOrderField? m_pErrorConditionalOrder ;
    }
    
    public class OnRtnExecOrderEventArgs : EventArgs
    {
        public OnRtnExecOrderEventArgs(CThostFtdcExecOrderField? pExecOrder)
        {
            m_pExecOrder = pExecOrder;
        }
    
        public CThostFtdcExecOrderField? PExecOrder {get {return m_pExecOrder; }}
    
        public readonly CThostFtdcExecOrderField? m_pExecOrder ;
    }
    
    public class OnErrRtnExecOrderInsertEventArgs : EventArgs
    {
        public OnErrRtnExecOrderInsertEventArgs(CThostFtdcInputExecOrderField? pInputExecOrder, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputExecOrder = pInputExecOrder;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputExecOrderField? PInputExecOrder {get {return m_pInputExecOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputExecOrderField? m_pInputExecOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnExecOrderActionEventArgs : EventArgs
    {
        public OnErrRtnExecOrderActionEventArgs(CThostFtdcExecOrderActionField? pExecOrderAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pExecOrderAction = pExecOrderAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcExecOrderActionField? PExecOrderAction {get {return m_pExecOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcExecOrderActionField? m_pExecOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnForQuoteInsertEventArgs : EventArgs
    {
        public OnErrRtnForQuoteInsertEventArgs(CThostFtdcInputForQuoteField? pInputForQuote, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputForQuote = pInputForQuote;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputForQuoteField? PInputForQuote {get {return m_pInputForQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputForQuoteField? m_pInputForQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnQuoteEventArgs : EventArgs
    {
        public OnRtnQuoteEventArgs(CThostFtdcQuoteField? pQuote)
        {
            m_pQuote = pQuote;
        }
    
        public CThostFtdcQuoteField? PQuote {get {return m_pQuote; }}
    
        public readonly CThostFtdcQuoteField? m_pQuote ;
    }
    
    public class OnErrRtnQuoteInsertEventArgs : EventArgs
    {
        public OnErrRtnQuoteInsertEventArgs(CThostFtdcInputQuoteField? pInputQuote, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputQuote = pInputQuote;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputQuoteField? PInputQuote {get {return m_pInputQuote; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputQuoteField? m_pInputQuote ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnQuoteActionEventArgs : EventArgs
    {
        public OnErrRtnQuoteActionEventArgs(CThostFtdcQuoteActionField? pQuoteAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pQuoteAction = pQuoteAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcQuoteActionField? PQuoteAction {get {return m_pQuoteAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcQuoteActionField? m_pQuoteAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnForQuoteRspEventArgs : EventArgs
    {
        public OnRtnForQuoteRspEventArgs(CThostFtdcForQuoteRspField? pForQuoteRsp)
        {
            m_pForQuoteRsp = pForQuoteRsp;
        }
    
        public CThostFtdcForQuoteRspField? PForQuoteRsp {get {return m_pForQuoteRsp; }}
    
        public readonly CThostFtdcForQuoteRspField? m_pForQuoteRsp ;
    }
    
    public class OnRtnCFMMCTradingAccountTokenEventArgs : EventArgs
    {
        public OnRtnCFMMCTradingAccountTokenEventArgs(CThostFtdcCFMMCTradingAccountTokenField? pCFMMCTradingAccountToken)
        {
            m_pCFMMCTradingAccountToken = pCFMMCTradingAccountToken;
        }
    
        public CThostFtdcCFMMCTradingAccountTokenField? PCFMMCTradingAccountToken {get {return m_pCFMMCTradingAccountToken; }}
    
        public readonly CThostFtdcCFMMCTradingAccountTokenField? m_pCFMMCTradingAccountToken ;
    }
    
    public class OnErrRtnBatchOrderActionEventArgs : EventArgs
    {
        public OnErrRtnBatchOrderActionEventArgs(CThostFtdcBatchOrderActionField? pBatchOrderAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pBatchOrderAction = pBatchOrderAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcBatchOrderActionField? PBatchOrderAction {get {return m_pBatchOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcBatchOrderActionField? m_pBatchOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnOptionSelfCloseEventArgs : EventArgs
    {
        public OnRtnOptionSelfCloseEventArgs(CThostFtdcOptionSelfCloseField? pOptionSelfClose)
        {
            m_pOptionSelfClose = pOptionSelfClose;
        }
    
        public CThostFtdcOptionSelfCloseField? POptionSelfClose {get {return m_pOptionSelfClose; }}
    
        public readonly CThostFtdcOptionSelfCloseField? m_pOptionSelfClose ;
    }
    
    public class OnErrRtnOptionSelfCloseInsertEventArgs : EventArgs
    {
        public OnErrRtnOptionSelfCloseInsertEventArgs(CThostFtdcInputOptionSelfCloseField? pInputOptionSelfClose, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputOptionSelfClose = pInputOptionSelfClose;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputOptionSelfCloseField? PInputOptionSelfClose {get {return m_pInputOptionSelfClose; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputOptionSelfCloseField? m_pInputOptionSelfClose ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnOptionSelfCloseActionEventArgs : EventArgs
    {
        public OnErrRtnOptionSelfCloseActionEventArgs(CThostFtdcOptionSelfCloseActionField? pOptionSelfCloseAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pOptionSelfCloseAction = pOptionSelfCloseAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcOptionSelfCloseActionField? POptionSelfCloseAction {get {return m_pOptionSelfCloseAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcOptionSelfCloseActionField? m_pOptionSelfCloseAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnCombActionEventArgs : EventArgs
    {
        public OnRtnCombActionEventArgs(CThostFtdcCombActionField? pCombAction)
        {
            m_pCombAction = pCombAction;
        }
    
        public CThostFtdcCombActionField? PCombAction {get {return m_pCombAction; }}
    
        public readonly CThostFtdcCombActionField? m_pCombAction ;
    }
    
    public class OnErrRtnCombActionInsertEventArgs : EventArgs
    {
        public OnErrRtnCombActionInsertEventArgs(CThostFtdcInputCombActionField? pInputCombAction, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pInputCombAction = pInputCombAction;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcInputCombActionField? PInputCombAction {get {return m_pInputCombAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcInputCombActionField? m_pInputCombAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRspQryContractBankEventArgs : EventArgs
    {
        public OnRspQryContractBankEventArgs(CThostFtdcContractBankField? pContractBank, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pContractBank = pContractBank;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcContractBankField? PContractBank {get {return m_pContractBank; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcContractBankField? m_pContractBank ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryParkedOrderEventArgs : EventArgs
    {
        public OnRspQryParkedOrderEventArgs(CThostFtdcParkedOrderField? pParkedOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pParkedOrder = pParkedOrder;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcParkedOrderField? PParkedOrder {get {return m_pParkedOrder; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcParkedOrderField? m_pParkedOrder ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryParkedOrderActionEventArgs : EventArgs
    {
        public OnRspQryParkedOrderActionEventArgs(CThostFtdcParkedOrderActionField? pParkedOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pParkedOrderAction = pParkedOrderAction;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcParkedOrderActionField? PParkedOrderAction {get {return m_pParkedOrderAction; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcParkedOrderActionField? m_pParkedOrderAction ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryTradingNoticeEventArgs : EventArgs
    {
        public OnRspQryTradingNoticeEventArgs(CThostFtdcTradingNoticeField? pTradingNotice, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pTradingNotice = pTradingNotice;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcTradingNoticeField? PTradingNotice {get {return m_pTradingNotice; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcTradingNoticeField? m_pTradingNotice ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryBrokerTradingParamsEventArgs : EventArgs
    {
        public OnRspQryBrokerTradingParamsEventArgs(CThostFtdcBrokerTradingParamsField? pBrokerTradingParams, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pBrokerTradingParams = pBrokerTradingParams;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcBrokerTradingParamsField? PBrokerTradingParams {get {return m_pBrokerTradingParams; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcBrokerTradingParamsField? m_pBrokerTradingParams ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQryBrokerTradingAlgosEventArgs : EventArgs
    {
        public OnRspQryBrokerTradingAlgosEventArgs(CThostFtdcBrokerTradingAlgosField? pBrokerTradingAlgos, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pBrokerTradingAlgos = pBrokerTradingAlgos;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcBrokerTradingAlgosField? PBrokerTradingAlgos {get {return m_pBrokerTradingAlgos; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcBrokerTradingAlgosField? m_pBrokerTradingAlgos ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQueryCFMMCTradingAccountTokenEventArgs : EventArgs
    {
        public OnRspQueryCFMMCTradingAccountTokenEventArgs(CThostFtdcQueryCFMMCTradingAccountTokenField? pQueryCFMMCTradingAccountToken, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pQueryCFMMCTradingAccountToken = pQueryCFMMCTradingAccountToken;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcQueryCFMMCTradingAccountTokenField? PQueryCFMMCTradingAccountToken {get {return m_pQueryCFMMCTradingAccountToken; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcQueryCFMMCTradingAccountTokenField? m_pQueryCFMMCTradingAccountToken ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRtnFromBankToFutureByBankEventArgs : EventArgs
    {
        public OnRtnFromBankToFutureByBankEventArgs(CThostFtdcRspTransferField? pRspTransfer)
        {
            m_pRspTransfer = pRspTransfer;
        }
    
        public CThostFtdcRspTransferField? PRspTransfer {get {return m_pRspTransfer; }}
    
        public readonly CThostFtdcRspTransferField? m_pRspTransfer ;
    }
    
    public class OnRtnFromFutureToBankByBankEventArgs : EventArgs
    {
        public OnRtnFromFutureToBankByBankEventArgs(CThostFtdcRspTransferField? pRspTransfer)
        {
            m_pRspTransfer = pRspTransfer;
        }
    
        public CThostFtdcRspTransferField? PRspTransfer {get {return m_pRspTransfer; }}
    
        public readonly CThostFtdcRspTransferField? m_pRspTransfer ;
    }
    
    public class OnRtnRepealFromBankToFutureByBankEventArgs : EventArgs
    {
        public OnRtnRepealFromBankToFutureByBankEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRtnRepealFromFutureToBankByBankEventArgs : EventArgs
    {
        public OnRtnRepealFromFutureToBankByBankEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRtnFromBankToFutureByFutureEventArgs : EventArgs
    {
        public OnRtnFromBankToFutureByFutureEventArgs(CThostFtdcRspTransferField? pRspTransfer)
        {
            m_pRspTransfer = pRspTransfer;
        }
    
        public CThostFtdcRspTransferField? PRspTransfer {get {return m_pRspTransfer; }}
    
        public readonly CThostFtdcRspTransferField? m_pRspTransfer ;
    }
    
    public class OnRtnFromFutureToBankByFutureEventArgs : EventArgs
    {
        public OnRtnFromFutureToBankByFutureEventArgs(CThostFtdcRspTransferField? pRspTransfer)
        {
            m_pRspTransfer = pRspTransfer;
        }
    
        public CThostFtdcRspTransferField? PRspTransfer {get {return m_pRspTransfer; }}
    
        public readonly CThostFtdcRspTransferField? m_pRspTransfer ;
    }
    
    public class OnRtnRepealFromBankToFutureByFutureManualEventArgs : EventArgs
    {
        public OnRtnRepealFromBankToFutureByFutureManualEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRtnRepealFromFutureToBankByFutureManualEventArgs : EventArgs
    {
        public OnRtnRepealFromFutureToBankByFutureManualEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRtnQueryBankBalanceByFutureEventArgs : EventArgs
    {
        public OnRtnQueryBankBalanceByFutureEventArgs(CThostFtdcNotifyQueryAccountField? pNotifyQueryAccount)
        {
            m_pNotifyQueryAccount = pNotifyQueryAccount;
        }
    
        public CThostFtdcNotifyQueryAccountField? PNotifyQueryAccount {get {return m_pNotifyQueryAccount; }}
    
        public readonly CThostFtdcNotifyQueryAccountField? m_pNotifyQueryAccount ;
    }
    
    public class OnErrRtnBankToFutureByFutureEventArgs : EventArgs
    {
        public OnErrRtnBankToFutureByFutureEventArgs(CThostFtdcReqTransferField? pReqTransfer, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pReqTransfer = pReqTransfer;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcReqTransferField? PReqTransfer {get {return m_pReqTransfer; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcReqTransferField? m_pReqTransfer ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnFutureToBankByFutureEventArgs : EventArgs
    {
        public OnErrRtnFutureToBankByFutureEventArgs(CThostFtdcReqTransferField? pReqTransfer, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pReqTransfer = pReqTransfer;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcReqTransferField? PReqTransfer {get {return m_pReqTransfer; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcReqTransferField? m_pReqTransfer ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnRepealBankToFutureByFutureManualEventArgs : EventArgs
    {
        public OnErrRtnRepealBankToFutureByFutureManualEventArgs(CThostFtdcReqRepealField? pReqRepeal, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pReqRepeal = pReqRepeal;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcReqRepealField? PReqRepeal {get {return m_pReqRepeal; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcReqRepealField? m_pReqRepeal ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnRepealFutureToBankByFutureManualEventArgs : EventArgs
    {
        public OnErrRtnRepealFutureToBankByFutureManualEventArgs(CThostFtdcReqRepealField? pReqRepeal, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pReqRepeal = pReqRepeal;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcReqRepealField? PReqRepeal {get {return m_pReqRepeal; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcReqRepealField? m_pReqRepeal ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnErrRtnQueryBankBalanceByFutureEventArgs : EventArgs
    {
        public OnErrRtnQueryBankBalanceByFutureEventArgs(CThostFtdcReqQueryAccountField? pReqQueryAccount, CThostFtdcRspInfoField? pRspInfo)
        {
            m_pReqQueryAccount = pReqQueryAccount;
            m_pRspInfo = pRspInfo;
        }
    
        public CThostFtdcReqQueryAccountField? PReqQueryAccount {get {return m_pReqQueryAccount; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
    
        public readonly CThostFtdcReqQueryAccountField? m_pReqQueryAccount ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
    }
    
    public class OnRtnRepealFromBankToFutureByFutureEventArgs : EventArgs
    {
        public OnRtnRepealFromBankToFutureByFutureEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRtnRepealFromFutureToBankByFutureEventArgs : EventArgs
    {
        public OnRtnRepealFromFutureToBankByFutureEventArgs(CThostFtdcRspRepealField? pRspRepeal)
        {
            m_pRspRepeal = pRspRepeal;
        }
    
        public CThostFtdcRspRepealField? PRspRepeal {get {return m_pRspRepeal; }}
    
        public readonly CThostFtdcRspRepealField? m_pRspRepeal ;
    }
    
    public class OnRspFromBankToFutureByFutureEventArgs : EventArgs
    {
        public OnRspFromBankToFutureByFutureEventArgs(CThostFtdcReqTransferField? pReqTransfer, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pReqTransfer = pReqTransfer;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcReqTransferField? PReqTransfer {get {return m_pReqTransfer; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcReqTransferField? m_pReqTransfer ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspFromFutureToBankByFutureEventArgs : EventArgs
    {
        public OnRspFromFutureToBankByFutureEventArgs(CThostFtdcReqTransferField? pReqTransfer, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pReqTransfer = pReqTransfer;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcReqTransferField? PReqTransfer {get {return m_pReqTransfer; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcReqTransferField? m_pReqTransfer ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspQueryBankAccountMoneyByFutureEventArgs : EventArgs
    {
        public OnRspQueryBankAccountMoneyByFutureEventArgs(CThostFtdcReqQueryAccountField? pReqQueryAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pReqQueryAccount = pReqQueryAccount;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcReqQueryAccountField? PReqQueryAccount {get {return m_pReqQueryAccount; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcReqQueryAccountField? m_pReqQueryAccount ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRtnOpenAccountByBankEventArgs : EventArgs
    {
        public OnRtnOpenAccountByBankEventArgs(CThostFtdcOpenAccountField? pOpenAccount)
        {
            m_pOpenAccount = pOpenAccount;
        }
    
        public CThostFtdcOpenAccountField? POpenAccount {get {return m_pOpenAccount; }}
    
        public readonly CThostFtdcOpenAccountField? m_pOpenAccount ;
    }
    
    public class OnRtnCancelAccountByBankEventArgs : EventArgs
    {
        public OnRtnCancelAccountByBankEventArgs(CThostFtdcCancelAccountField? pCancelAccount)
        {
            m_pCancelAccount = pCancelAccount;
        }
    
        public CThostFtdcCancelAccountField? PCancelAccount {get {return m_pCancelAccount; }}
    
        public readonly CThostFtdcCancelAccountField? m_pCancelAccount ;
    }
    
    public class OnRtnChangeAccountByBankEventArgs : EventArgs
    {
        public OnRtnChangeAccountByBankEventArgs(CThostFtdcChangeAccountField? pChangeAccount)
        {
            m_pChangeAccount = pChangeAccount;
        }
    
        public CThostFtdcChangeAccountField? PChangeAccount {get {return m_pChangeAccount; }}
    
        public readonly CThostFtdcChangeAccountField? m_pChangeAccount ;
    }
    
}
