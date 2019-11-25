using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace CSharpCtp.MdUser
{
    public class MdUserWrapper : IDisposable
	{

        public MdUserWrapper(MdUserInfo userInfo)
        {
            InitDelegates();
            
            MdUserDllWrapper.CreateMdUser(ref userInfo,out m_handler);
            RegisterDelegatesToHandler();
        }

        ~MdUserWrapper()
        {
            Dispose(false);
        }

        private IntPtr m_handler;

        public int Connect()
        {
            return MdUserDllWrapper.ConnectMdUser(m_handler);
        }

        public int Disconnect()
        {
            if (m_handler != IntPtr.Zero)
            {
                MdUserDllWrapper.DisconnectMdUser(m_handler);
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
                MdUserDllWrapper.DisconnectMdUser(m_handler);
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
            onRspUserLoginDelegate = RaiseOnRspUserLogin;
            onRspUserLogoutDelegate = RaiseOnRspUserLogout;
            onRspErrorDelegate = RaiseOnRspError;
            onRspSubMarketDataDelegate = RaiseOnRspSubMarketData;
            onRspUnSubMarketDataDelegate = RaiseOnRspUnSubMarketData;
            onRspSubForQuoteRspDelegate = RaiseOnRspSubForQuoteRsp;
            onRspUnSubForQuoteRspDelegate = RaiseOnRspUnSubForQuoteRsp;
            onRtnDepthMarketDataDelegate = RaiseOnRtnDepthMarketData;
            onRtnForQuoteRspDelegate = RaiseOnRtnForQuoteRsp;
        }

        private void RegisterDelegatesToHandler()
        {
            if(m_handler != IntPtr.Zero)
            {
                MdUserDllWrapper.RegisterOnFrontConnectedCallback(m_handler, onFrontConnectedDelegate);
                MdUserDllWrapper.RegisterOnFrontDisconnectedCallback(m_handler, onFrontDisconnectedDelegate);
                MdUserDllWrapper.RegisterOnHeartBeatWarningCallback(m_handler, onHeartBeatWarningDelegate);
                MdUserDllWrapper.RegisterOnRspUserLoginCallback(m_handler, onRspUserLoginDelegate);
                MdUserDllWrapper.RegisterOnRspUserLogoutCallback(m_handler, onRspUserLogoutDelegate);
                MdUserDllWrapper.RegisterOnRspErrorCallback(m_handler, onRspErrorDelegate);
                MdUserDllWrapper.RegisterOnRspSubMarketDataCallback(m_handler, onRspSubMarketDataDelegate);
                MdUserDllWrapper.RegisterOnRspUnSubMarketDataCallback(m_handler, onRspUnSubMarketDataDelegate);
                MdUserDllWrapper.RegisterOnRspSubForQuoteRspCallback(m_handler, onRspSubForQuoteRspDelegate);
                MdUserDllWrapper.RegisterOnRspUnSubForQuoteRspCallback(m_handler, onRspUnSubForQuoteRspDelegate);
                MdUserDllWrapper.RegisterOnRtnDepthMarketDataCallback(m_handler, onRtnDepthMarketDataDelegate);
                MdUserDllWrapper.RegisterOnRtnForQuoteRspCallback(m_handler, onRtnForQuoteRspDelegate);
            }
        }

        #region event
        public event EventHandler<EventArgs> OnFrontConnected;
        public event EventHandler<OnFrontDisconnectedEventArgs> OnFrontDisconnected;
        public event EventHandler<OnHeartBeatWarningEventArgs> OnHeartBeatWarning;
        public event EventHandler<OnRspUserLoginEventArgs> OnRspUserLogin;
        public event EventHandler<OnRspUserLogoutEventArgs> OnRspUserLogout;
        public event EventHandler<OnRspErrorEventArgs> OnRspError;
        public event EventHandler<OnRspSubMarketDataEventArgs> OnRspSubMarketData;
        public event EventHandler<OnRspUnSubMarketDataEventArgs> OnRspUnSubMarketData;
        public event EventHandler<OnRspSubForQuoteRspEventArgs> OnRspSubForQuoteRsp;
        public event EventHandler<OnRspUnSubForQuoteRspEventArgs> OnRspUnSubForQuoteRsp;
        public event EventHandler<OnRtnDepthMarketDataEventArgs> OnRtnDepthMarketData;
        public event EventHandler<OnRtnForQuoteRspEventArgs> OnRtnForQuoteRsp;
        #endregion

        #region MdUserApi

		public int SubscribeMarketData(string[] pReqUserLoginField, int nCount)
        {
            return MdUserDllWrapper.SubscribeMarketData(m_handler, pReqUserLoginField, nCount);
        }

        public int UnSubscribeMarketData(string[] pReqUserLoginField, int nCount)
        {
                return MdUserDllWrapper.SubscribeMarketData(m_handler, pReqUserLoginField, nCount);
        }

        public int SubscribeForQuoteRsp(string[] pReqUserLoginField, int nCount)
        {
                return MdUserDllWrapper.SubscribeMarketData(m_handler, pReqUserLoginField, nCount);
        }

        public int UnSubscribeForQuoteRsp(string[] pReqUserLoginField, int nCount)
        {
                return MdUserDllWrapper.SubscribeMarketData(m_handler, pReqUserLoginField, nCount);
        }

        public int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
                return MdUserDllWrapper.ReqUserLogin(m_handler, ref pReqUserLoginField, nRequestID);
        }
        
        public int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
                return MdUserDllWrapper.ReqUserLogout(m_handler, ref pUserLogout, nRequestID);
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
        
        private void RaiseOnRspError(IntPtr ptr0, int nRequestID, bool bIsLast)
        {
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr0 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr0);
            OnRspErrorEventArgs eventArgs = new OnRspErrorEventArgs(pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspError)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspSubMarketData(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSpecificInstrumentField? pSpecificInstrument = null;
            if (ptr0 != IntPtr.Zero)
                pSpecificInstrument = Marshal.PtrToStructure<CThostFtdcSpecificInstrumentField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspSubMarketDataEventArgs eventArgs = new OnRspSubMarketDataEventArgs(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspSubMarketData)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUnSubMarketData(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSpecificInstrumentField? pSpecificInstrument = null;
            if (ptr0 != IntPtr.Zero)
                pSpecificInstrument = Marshal.PtrToStructure<CThostFtdcSpecificInstrumentField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUnSubMarketDataEventArgs eventArgs = new OnRspUnSubMarketDataEventArgs(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUnSubMarketData)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspSubForQuoteRsp(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSpecificInstrumentField? pSpecificInstrument = null;
            if (ptr0 != IntPtr.Zero)
                pSpecificInstrument = Marshal.PtrToStructure<CThostFtdcSpecificInstrumentField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspSubForQuoteRspEventArgs eventArgs = new OnRspSubForQuoteRspEventArgs(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspSubForQuoteRsp)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRspUnSubForQuoteRsp(IntPtr ptr0, IntPtr ptr1, int nRequestID, bool bIsLast)
        {
            CThostFtdcSpecificInstrumentField? pSpecificInstrument = null;
            if (ptr0 != IntPtr.Zero)
                pSpecificInstrument = Marshal.PtrToStructure<CThostFtdcSpecificInstrumentField>(ptr0);
            CThostFtdcRspInfoField? pRspInfo = null;
            if (ptr1 != IntPtr.Zero)
                pRspInfo = Marshal.PtrToStructure<CThostFtdcRspInfoField>(ptr1);
            OnRspUnSubForQuoteRspEventArgs eventArgs = new OnRspUnSubForQuoteRspEventArgs(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
            Volatile.Read(ref OnRspUnSubForQuoteRsp)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnDepthMarketData(IntPtr ptr0)
        {
            CThostFtdcDepthMarketDataField? pDepthMarketData = null;
            if (ptr0 != IntPtr.Zero)
                pDepthMarketData = Marshal.PtrToStructure<CThostFtdcDepthMarketDataField>(ptr0);
            OnRtnDepthMarketDataEventArgs eventArgs = new OnRtnDepthMarketDataEventArgs(pDepthMarketData);
            Volatile.Read(ref OnRtnDepthMarketData)?.Invoke(this, eventArgs);
        }
        
        private void RaiseOnRtnForQuoteRsp(IntPtr ptr0)
        {
            CThostFtdcForQuoteRspField? pForQuoteRsp = null;
            if (ptr0 != IntPtr.Zero)
                pForQuoteRsp = Marshal.PtrToStructure<CThostFtdcForQuoteRspField>(ptr0);
            OnRtnForQuoteRspEventArgs eventArgs = new OnRtnForQuoteRspEventArgs(pForQuoteRsp);
            Volatile.Read(ref OnRtnForQuoteRsp)?.Invoke(this, eventArgs);
        }
         
        #endregion

        #region delegate variables
        OnFrontConnectedDelegate onFrontConnectedDelegate;
        OnFrontDisconnectedDelegate onFrontDisconnectedDelegate;
        OnHeartBeatWarningDelegate onHeartBeatWarningDelegate;
        OnRspUserLoginDelegate onRspUserLoginDelegate;
        OnRspUserLogoutDelegate onRspUserLogoutDelegate;
        OnRspErrorDelegate onRspErrorDelegate;
        OnRspSubMarketDataDelegate onRspSubMarketDataDelegate;
        OnRspUnSubMarketDataDelegate onRspUnSubMarketDataDelegate;
        OnRspSubForQuoteRspDelegate onRspSubForQuoteRspDelegate;
        OnRspUnSubForQuoteRspDelegate onRspUnSubForQuoteRspDelegate;
        OnRtnDepthMarketDataDelegate onRtnDepthMarketDataDelegate;
        OnRtnForQuoteRspDelegate onRtnForQuoteRspDelegate;
        #endregion




	}
}
