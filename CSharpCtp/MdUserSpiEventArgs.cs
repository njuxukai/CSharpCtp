using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCtp.MdUser
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
    
    public class OnRspSubMarketDataEventArgs : EventArgs
    {
        public OnRspSubMarketDataEventArgs(CThostFtdcSpecificInstrumentField? pSpecificInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSpecificInstrument = pSpecificInstrument;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSpecificInstrumentField? PSpecificInstrument {get {return m_pSpecificInstrument; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSpecificInstrumentField? m_pSpecificInstrument ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUnSubMarketDataEventArgs : EventArgs
    {
        public OnRspUnSubMarketDataEventArgs(CThostFtdcSpecificInstrumentField? pSpecificInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSpecificInstrument = pSpecificInstrument;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSpecificInstrumentField? PSpecificInstrument {get {return m_pSpecificInstrument; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSpecificInstrumentField? m_pSpecificInstrument ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspSubForQuoteRspEventArgs : EventArgs
    {
        public OnRspSubForQuoteRspEventArgs(CThostFtdcSpecificInstrumentField? pSpecificInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSpecificInstrument = pSpecificInstrument;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSpecificInstrumentField? PSpecificInstrument {get {return m_pSpecificInstrument; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSpecificInstrumentField? m_pSpecificInstrument ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRspUnSubForQuoteRspEventArgs : EventArgs
    {
        public OnRspUnSubForQuoteRspEventArgs(CThostFtdcSpecificInstrumentField? pSpecificInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
        {
            m_pSpecificInstrument = pSpecificInstrument;
            m_pRspInfo = pRspInfo;
            m_nRequestID = nRequestID;
            m_bIsLast = bIsLast;
        }
    
        public CThostFtdcSpecificInstrumentField? PSpecificInstrument {get {return m_pSpecificInstrument; }}
        public CThostFtdcRspInfoField? PRspInfo {get {return m_pRspInfo; }}
        public int NRequestID {get {return m_nRequestID; }}
        public bool BIsLast {get {return m_bIsLast; }}
    
        public readonly CThostFtdcSpecificInstrumentField? m_pSpecificInstrument ;
        public readonly CThostFtdcRspInfoField? m_pRspInfo ;
        public readonly int m_nRequestID ;
        public readonly bool m_bIsLast ;
    }
    
    public class OnRtnDepthMarketDataEventArgs : EventArgs
    {
        public OnRtnDepthMarketDataEventArgs(CThostFtdcDepthMarketDataField? pDepthMarketData)
        {
            m_pDepthMarketData = pDepthMarketData;
        }
    
        public CThostFtdcDepthMarketDataField? PDepthMarketData {get {return m_pDepthMarketData; }}
    
        public readonly CThostFtdcDepthMarketDataField? m_pDepthMarketData ;
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
    
}
