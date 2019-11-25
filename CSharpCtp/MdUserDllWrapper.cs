using System;
using System.Runtime.InteropServices;


namespace CSharpCtp.MdUser
{
    public class MdUserDllWrapper
	{
		[DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "CreateMdUser",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void CreateMdUser(ref MdUserInfo userInfo, out IntPtr phandler);        

        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "DestroyMdUser",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void DestroyMdUser(out IntPtr phandler);

		[DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "ConnectMdUser",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ConnectMdUser(IntPtr phandler);

        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "DisconnectMdUser",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int DisconnectMdUser(IntPtr phandler);

		[DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "SubscribeMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubscribeMarketData(IntPtr phandler, [MarshalAs(UnmanagedType.LPArray,  ArraySubType=UnmanagedType.LPStr, SizeParamIndex = 2)] [In] string[] ppInstrumentID, int nCount);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "UnSubscribeMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int UnSubscribeMarketData(IntPtr phandler, [MarshalAs(UnmanagedType.LPArray,ArraySubType=UnmanagedType.LPStr, SizeParamIndex = 2)] [In] string[] ppInstrumentID, int nCount);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "SubscribeForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubscribeForQuoteRsp(IntPtr phandler, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr,SizeParamIndex = 2)] [In] string[] ppInstrumentID, int nCount);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "UnSubscribeForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int UnSubscribeForQuoteRsp(IntPtr phandler, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr,SizeParamIndex = 2)] [In] string[] ppInstrumentID, int nCount);

        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLogin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLogin(IntPtr phandler, ref CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "ReqUserLogout",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern int ReqUserLogout(IntPtr phandler, ref CThostFtdcUserLogoutField pUserLogout, int nRequestID);
        

        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnFrontConnected",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnFrontConnectedCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnFrontConnectedDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnFrontDisconnected",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnFrontDisconnectedCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnFrontDisconnectedDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnHeartBeatWarning",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnHeartBeatWarningCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnHeartBeatWarningDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspUserLogin",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserLoginCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserLoginDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspUserLogout",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUserLogoutCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUserLogoutDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspError",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspErrorCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspErrorDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspSubMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspSubMarketDataCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspSubMarketDataDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspUnSubMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUnSubMarketDataCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUnSubMarketDataDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspSubForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspSubForQuoteRspCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspSubForQuoteRspDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRspUnSubForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRspUnSubForQuoteRspCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRspUnSubForQuoteRspDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRtnDepthMarketData",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnDepthMarketDataCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnDepthMarketDataDelegate callback);
        
        [DllImport("cctp_mduser.dll", CharSet = CharSet.Auto, EntryPoint = "RegisterMdFPOnRtnForQuoteRsp",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern void RegisterOnRtnForQuoteRspCallback(IntPtr phandler,  [MarshalAs(UnmanagedType.FunctionPtr)]OnRtnForQuoteRspDelegate callback);
        
	}
}
