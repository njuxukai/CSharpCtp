using System;
using System.Runtime.InteropServices;

namespace CSharpCtp.MdUser
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnFrontConnectedDelegate ();
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnFrontDisconnectedDelegate (int nReason);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnHeartBeatWarningDelegate (int nTimeLapse);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserLoginDelegate (IntPtr pRspUserLogin, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUserLogoutDelegate (IntPtr pUserLogout, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspErrorDelegate (IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspSubMarketDataDelegate (IntPtr pSpecificInstrument, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUnSubMarketDataDelegate (IntPtr pSpecificInstrument, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspSubForQuoteRspDelegate (IntPtr pSpecificInstrument, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRspUnSubForQuoteRspDelegate (IntPtr pSpecificInstrument, IntPtr pRspInfo, int nRequestID, [MarshalAs(UnmanagedType.U1)]bool bIsLast);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnDepthMarketDataDelegate (IntPtr pDepthMarketData);
    
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void OnRtnForQuoteRspDelegate (IntPtr pForQuoteRsp);
    
}
