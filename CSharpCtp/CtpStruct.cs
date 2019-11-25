using System;
using System.Runtime.InteropServices;

namespace CSharpCtp
{

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct TraderInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string InvestorID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string FrontID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string FlowPath;
		[MarshalAs(UnmanagedType.I4)]
        public Int32 AuthKind;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;
		[MarshalAs(UnmanagedType.I4)]
        public Int32 PrivateTopicResumeType;
		[MarshalAs(UnmanagedType.I4)]
        public Int32 PublicTopicResumeType;
    }

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct MdUserInfo
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string InvestorID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string FrontID;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string FlowPath;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDisseminationField
    {
        [MarshalAs(UnmanagedType.I2)]
        public Int16 SequenceSeries;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqUserLoginField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientIPPort;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspUserLoginField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserLogoutField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcForceUserLogoutField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqAuthenticateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string AuthCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspAuthenticateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;
        [MarshalAs(UnmanagedType.U1)]
        public byte AppType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcAuthenticationInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string AuthInfo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string AppID;
        [MarshalAs(UnmanagedType.U1)]
        public byte AppType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspUserLogin2Field
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string RandomString;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferHeaderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string Version;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string RecordNum;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferBankToFutureReqField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FuturePwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferBankToFutureRspField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferFutureToBankReqField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FuturePwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferFutureToBankRspField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferQryBankReqField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FuturePwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string FutureAccPwd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferQryBankRspField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string RetCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string RetInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double UseAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double FetchAmt;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferQryDetailReqField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string FutureAccount;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferQryDetailRspField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string FutureID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 22)]
        public string FutureAccount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CertCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyCode;
        [MarshalAs(UnmanagedType.R8)]
        public double TxAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte Flag;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspInfoField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 61)]
        public string ExchangeName;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExchangeProperty;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcProductField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ProductName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ProductClass;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeMultiple;
        [MarshalAs(UnmanagedType.R8)]
        public double PriceTick;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxMarketOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinMarketOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxLimitOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinLimitOrderVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionDateType;
        [MarshalAs(UnmanagedType.U1)]
        public byte CloseDealType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string TradeCurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte MortgageFundUseRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeProductID;
        [MarshalAs(UnmanagedType.R8)]
        public double UnderlyingMultiple;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string InstrumentName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ProductClass;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DeliveryYear;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DeliveryMonth;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxMarketOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinMarketOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxLimitOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinLimitOrderVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeMultiple;
        [MarshalAs(UnmanagedType.R8)]
        public double PriceTick;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDelivDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EndDelivDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte InstLifePhase;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsTrading;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionDateType;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatio;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatio;
        [MarshalAs(UnmanagedType.U1)]
        public byte MaxMarginSideAlgorithm;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string UnderlyingInstrID;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikePrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptionsType;
        [MarshalAs(UnmanagedType.R8)]
        public double UnderlyingMultiple;
        [MarshalAs(UnmanagedType.U1)]
        public byte CombinationType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BrokerAbbr;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string BrokerName;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTraderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallCount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdentifiedCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingCodeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.U1)]
        public byte ClientIDType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BizType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcPartBrokerField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSuperUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSuperUserFunctionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte FunctionCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorGroupField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMortgage;
        [MarshalAs(UnmanagedType.R8)]
        public double PreCredit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreDeposit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreBalance;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double InterestBase;
        [MarshalAs(UnmanagedType.R8)]
        public double Interest;
        [MarshalAs(UnmanagedType.R8)]
        public double Deposit;
        [MarshalAs(UnmanagedType.R8)]
        public double Withdraw;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCash;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double CashIn;
        [MarshalAs(UnmanagedType.R8)]
        public double Commission;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double Balance;
        [MarshalAs(UnmanagedType.R8)]
        public double Available;
        [MarshalAs(UnmanagedType.R8)]
        public double WithdrawQuota;
        [MarshalAs(UnmanagedType.R8)]
        public double Reserve;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.R8)]
        public double Credit;
        [MarshalAs(UnmanagedType.R8)]
        public double Mortgage;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double DeliveryMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeDeliveryMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ReserveBalance;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double PreFundMortgageIn;
        [MarshalAs(UnmanagedType.R8)]
        public double PreFundMortgageOut;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageIn;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageOut;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageAvailable;
        [MarshalAs(UnmanagedType.R8)]
        public double MortgageableFund;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductFrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductFrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductPositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductCloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductPositionProfitByAlg;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductExchangeMargin;
        [MarshalAs(UnmanagedType.U1)]
        public byte BizType;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenSwap;
        [MarshalAs(UnmanagedType.R8)]
        public double RemainSwap;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorPositionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionDate;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 YdPosition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Position;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LongFrozen;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ShortFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double LongFrozenAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortFrozenAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OpenVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CloseVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionCost;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double UseMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCash;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double CashIn;
        [MarshalAs(UnmanagedType.R8)]
        public double Commission;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenCost;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeMargin;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombPosition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombLongFrozen;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombShortFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByDate;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByTrade;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TodayPosition;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 StrikeFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeFrozenAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AbandonFrozen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 YdStrikeFrozen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionCostOffset;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentMarginRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsRelative;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentCommissionRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BizType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDepthMarketDataField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.R8)]
        public double LastPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreOpenInterest;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double HighestPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowestPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.R8)]
        public double Turnover;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenInterest;
        [MarshalAs(UnmanagedType.R8)]
        public double ClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double UpperLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowerLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreDelta;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrDelta;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UpdateMillisec;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice1;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume1;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice1;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume1;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice2;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume2;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice2;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume2;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice3;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume3;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice3;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume3;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice4;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume4;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice4;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume4;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice5;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume5;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice5;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume5;
        [MarshalAs(UnmanagedType.R8)]
        public double AveragePrice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentTradingRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradingRight;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string UserName;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsUsingOTP;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAuthForce;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserPasswordField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string LastUpdateTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string LastLoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExpireDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string WeakExpireDate;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserFunctionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BrokerFunctionCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTraderOfferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TraderConnectStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSettlementInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentMarginRateAdjustField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsRelative;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeMarginRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeMarginRateAdjustField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchLongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchLongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double NoLongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double NoLongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double NoShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double NoShortMarginRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double FromCurrencyUnit;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeRate;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSettlementRefField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCurrentTimeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CurrTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CurrMillisec;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCommPhaseField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I2)]
        public Int16 CommPhaseNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string SystemID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLoginInfoField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string PasswordDeprecated;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MaxOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SHFETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string DCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CZCETime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string FFEXTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OneTimePassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string INETime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsQryControl;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLogoutAllField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SystemName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcFrontStatusField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserPasswordUpdateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserForceClose;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsSwapOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSource;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderStatus;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTraded;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserForceClose;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerOrderSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ZCETotalTradedVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsSwapOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOrderField
    {
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSource;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderStatus;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTraded;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOrderInsertErrorField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeChange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeChange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeChange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOrderActionErrorField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeTradeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradingRole;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double Price;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PriceSource;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeSource;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradingRole;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double Price;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PriceSource;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerOrderSeq;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeSource;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserSessionField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQueryMaxOrderVolumeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSettlementInfoConfirmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConfirmTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncDepositField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double Deposit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsForce;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncFundMortgageField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string MortgageSeqNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double MortgageAmount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerSyncField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInvestorField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdentifiedCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Mobile;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingTradingCodeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.U1)]
        public byte ClientIDType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInvestorGroupField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string InvestorGroupName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingTradingAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMortgage;
        [MarshalAs(UnmanagedType.R8)]
        public double PreCredit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreDeposit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreBalance;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double InterestBase;
        [MarshalAs(UnmanagedType.R8)]
        public double Interest;
        [MarshalAs(UnmanagedType.R8)]
        public double Deposit;
        [MarshalAs(UnmanagedType.R8)]
        public double Withdraw;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCash;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double CashIn;
        [MarshalAs(UnmanagedType.R8)]
        public double Commission;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double Balance;
        [MarshalAs(UnmanagedType.R8)]
        public double Available;
        [MarshalAs(UnmanagedType.R8)]
        public double WithdrawQuota;
        [MarshalAs(UnmanagedType.R8)]
        public double Reserve;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.R8)]
        public double Credit;
        [MarshalAs(UnmanagedType.R8)]
        public double Mortgage;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double DeliveryMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeDeliveryMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ReserveBalance;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double PreFundMortgageIn;
        [MarshalAs(UnmanagedType.R8)]
        public double PreFundMortgageOut;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageIn;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageOut;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageAvailable;
        [MarshalAs(UnmanagedType.R8)]
        public double MortgageableFund;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductFrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductFrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductPositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductCloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductPositionProfitByAlg;
        [MarshalAs(UnmanagedType.R8)]
        public double SpecProductExchangeMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenSwap;
        [MarshalAs(UnmanagedType.R8)]
        public double RemainSwap;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInvestorPositionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte PositionDate;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 YdPosition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Position;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LongFrozen;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ShortFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double LongFrozenAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortFrozenAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OpenVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CloseVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionCost;
        [MarshalAs(UnmanagedType.R8)]
        public double PreMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double UseMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCash;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double CashIn;
        [MarshalAs(UnmanagedType.R8)]
        public double Commission;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double PreSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenCost;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeMargin;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombPosition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombLongFrozen;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CombShortFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByDate;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByTrade;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TodayPosition;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 StrikeFrozen;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeFrozenAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AbandonFrozen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 YdStrikeFrozen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionCostOffset;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInstrumentMarginRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsRelative;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInstrumentCommissionRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncingInstrumentTradingRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradingRight;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTradeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTimeEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorPositionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTradingAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BizType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTradingCodeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ClientIDType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorGroupField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentMarginRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentCommissionRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentTradingRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTraderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySuperUserFunctionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryUserSessionField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryPartBrokerField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryFrontStatusField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySuperUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryProductField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ProductClass;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryDepthMarketDataField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerUserFunctionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTraderOfferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySyncDepositField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySettlementInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeMarginRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeMarginRateAdjustField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySyncFundMortgageField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string MortgageSeqNo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryHisOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrMiniMarginField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double MinMargin;
        [MarshalAs(UnmanagedType.U1)]
        public byte ValueMethod;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsRelative;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrMarginAdjustField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double SShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double SShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double HShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double HShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double AShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double AShortMarginRatioByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsRelative;
        [MarshalAs(UnmanagedType.R8)]
        public double MShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double MShortMarginRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeRatioByVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrTradeCostField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double FixedMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double MiniMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double Royalty;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchFixedMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchMiniMargin;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOptionInstrTradeCostField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double InputPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double UnderlyingPrice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOptionInstrCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcIndexPriceField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.R8)]
        public double ClosePrice;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte ReservePositionFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte CloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ExecOrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte ReservePositionFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte CloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExecResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerExecOrderSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ExecOrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeExecOrderField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte ReservePositionFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte CloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExecResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcErrExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionType;
        [MarshalAs(UnmanagedType.U1)]
        public byte PosiDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte ReservePositionFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte CloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryErrExecOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcErrExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ExecOrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ExecOrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ExecOrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryErrExecOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrTradingRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradingRight;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOptionInstrTradingRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputForQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcForQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForQuoteStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerForQutoSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryForQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeForQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ForQuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForQuoteStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeForQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskHedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidHedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AskOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BidOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputQuoteActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 QuoteActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskHedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidHedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte QuoteStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidOrderSysID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerQuoteSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AskOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BidOrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQuoteActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 QuoteActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeQuoteField
    {
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidOffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte AskHedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BidHedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte QuoteStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string AskOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BidOrderSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeQuoteField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryQuoteActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeQuoteActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string QuoteSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string QuoteLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeQuoteActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionInstrDeltaField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double Delta;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcForQuoteRspField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ForQuoteSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ForQuoteTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcStrikeOffsetField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double Offset;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryStrikeOffsetField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputBatchOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBatchOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeBatchOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBatchOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCombInstrumentGuardField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.R8)]
        public double GuarantRatio;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCombInstrumentGuardField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputCombActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.U1)]
        public byte CombDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCombActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CombActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.U1)]
        public byte CombDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCombActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeCombActionField
    {
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.U1)]
        public byte CombDirection;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeCombActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcProductExchRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string QuoteCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchangeRate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryProductExchRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryForQuoteParamField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcForQuoteParamField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.R8)]
        public double LastPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PriceInterval;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMMOptionInstrCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double StrikeRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryMMOptionInstrCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMMInstrumentCommissionRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseTodayRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryMMInstrumentCommissionRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentOrderCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double OrderCommByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double OrderActionCommByVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentOrderCommRateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradeParamField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeParamID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
        public string TradeParamValue;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentMarginRateULField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double LongMarginRatioByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortMarginRatioByVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcFutureLimitPosiParamField
    {
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SpecOpenVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ArbiOpenVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OpenVolume;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLoginForbiddenIPField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcIPListField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsWhite;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputOptionSelfCloseField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptSelfCloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInputOptionSelfCloseActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OptionSelfCloseActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionSelfCloseField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptSelfCloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExecResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerOptionSelfCloseSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOptionSelfCloseActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OptionSelfCloseActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOptionSelfCloseField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeStart;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTimeEnd;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOptionSelfCloseField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptSelfCloseFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte ExecResult;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryOptionSelfCloseActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeOptionSelfCloseActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OptionSelfCloseSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OptionSelfCloseLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptSelfCloseFlag;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncDelaySwapField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DelaySwapSeqNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string FromCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double FromAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double FromFrozenSwap;
        [MarshalAs(UnmanagedType.R8)]
        public double FromRemainSwap;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string ToCurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double ToAmount;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySyncDelaySwapField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DelaySwapSeqNo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestUnitField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string InvestorUnitName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestUnitField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSecAgentCheckModeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CheckSelfAccount;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSecAgentTradeInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.R8)]
        public double LastPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreOpenInterest;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double HighestPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowestPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.R8)]
        public double Turnover;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenInterest;
        [MarshalAs(UnmanagedType.R8)]
        public double ClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double UpperLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowerLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreDelta;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrDelta;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UpdateMillisec;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataBaseField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.R8)]
        public double PreSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double PreOpenInterest;
        [MarshalAs(UnmanagedType.R8)]
        public double PreDelta;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataStaticField
    {
        [MarshalAs(UnmanagedType.R8)]
        public double OpenPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double HighestPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowestPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double ClosePrice;
        [MarshalAs(UnmanagedType.R8)]
        public double UpperLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double LowerLimitPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrDelta;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataLastMatchField
    {
        [MarshalAs(UnmanagedType.R8)]
        public double LastPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.R8)]
        public double Turnover;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenInterest;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataBestPriceField
    {
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice1;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume1;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice1;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume1;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataBid23Field
    {
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice2;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume2;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice3;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume3;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataAsk23Field
    {
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice2;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume2;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice3;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume3;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataBid45Field
    {
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice4;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume4;
        [MarshalAs(UnmanagedType.R8)]
        public double BidPrice5;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BidVolume5;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataAsk45Field
    {
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice4;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume4;
        [MarshalAs(UnmanagedType.R8)]
        public double AskPrice5;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 AskVolume5;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataUpdateTimeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UpdateMillisec;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDay;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataExchangeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSpecificInstrumentField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInstrumentStatusField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SettlementGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InstrumentStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TradingSegmentSN;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EnterTime;
        [MarshalAs(UnmanagedType.U1)]
        public byte EnterReason;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInstrumentStatusField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcPositionProfitAlgorithmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Algorithm;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string Memo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDiscountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double Discount;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTransferBankField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferBankField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorPositionDetailField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorPositionDetailField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.R8)]
        public double OpenPrice;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TradeType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByDate;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfitByTrade;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfitByDate;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfitByTrade;
        [MarshalAs(UnmanagedType.R8)]
        public double Margin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double LastSettlementPrice;
        [MarshalAs(UnmanagedType.R8)]
        public double SettlementPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CloseVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TimeFirstVolume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingAccountPasswordField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMDTraderOfferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TraderConnectStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectRequestTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string LastReportTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ConnectTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string StartTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MaxTradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string MaxOrderMessageReference;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryMDTraderOfferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryNoticeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcNoticeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string SequenceLabel;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserRightField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserRightType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsForbidden;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySettlementInfoConfirmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLoadSettlementInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerWithdrawAlgorithmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.U1)]
        public byte WithdrawAlgorithm;
        [MarshalAs(UnmanagedType.R8)]
        public double UsingRatio;
        [MarshalAs(UnmanagedType.U1)]
        public byte IncludeCloseProfit;
        [MarshalAs(UnmanagedType.U1)]
        public byte AllWithoutTrade;
        [MarshalAs(UnmanagedType.U1)]
        public byte AvailIncludeCloseProfit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsBrokerUserEvent;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageRatio;
        [MarshalAs(UnmanagedType.U1)]
        public byte BalanceAlgorithm;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingAccountPasswordUpdateV1Field
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingAccountPasswordUpdateField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OldPassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewPassword;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCombinationLegField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LegID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySyncStatusField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCombinationLegField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LegID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string LegInstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LegMultiple;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ImplyLevel;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSyncStatusField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.U1)]
        public byte DataSyncStatus;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryLinkManField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLinkManField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte PersonType;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdentifiedCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string PersonName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Priority;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UOAZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string PersonFullName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerUserEventField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserEventType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserEventField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserEventType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 EventSequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string EventTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
        public string UserEventInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryContractBankField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcContractBankField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBrchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string BankName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorPositionCombineDetailField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComTradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TradeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TotalAmt;
        [MarshalAs(UnmanagedType.R8)]
        public double Margin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByMoney;
        [MarshalAs(UnmanagedType.R8)]
        public double MarginRateByVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LegID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LegMultiple;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TradeGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcParkedOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserForceClose;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Status;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsSwapOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcParkedOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeChange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
        [MarshalAs(UnmanagedType.U1)]
        public byte UserType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Status;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryParkedOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryParkedOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRemoveParkedOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRemoveParkedOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ParkedOrderActionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorWithdrawAlgorithmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double UsingRatio;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double FundMortgageRatio;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorPositionCombineDetailField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CombInstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarketDataAveragePriceField
    {
        [MarshalAs(UnmanagedType.R8)]
        public double AveragePrice;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcVerifyInvestorPasswordField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserIPField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPMask;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingNoticeInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
        [MarshalAs(UnmanagedType.I2)]
        public Int16 SequenceSeries;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingNoticeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I2)]
        public Int16 SequenceSeries;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string FieldContent;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTradingNoticeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryErrOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcErrOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserForceClose;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsSwapOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcErrorConditionalOrderField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombOffsetFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string CombHedgeFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotalOriginal;
        [MarshalAs(UnmanagedType.U1)]
        public byte TimeCondition;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string GTDDate;
        [MarshalAs(UnmanagedType.U1)]
        public byte VolumeCondition;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MinVolume;
        [MarshalAs(UnmanagedType.U1)]
        public byte ContingentCondition;
        [MarshalAs(UnmanagedType.R8)]
        public double StopPrice;
        [MarshalAs(UnmanagedType.U1)]
        public byte ForceCloseReason;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsAutoSuspend;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ExchangeInstID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSubmitStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 NotifySequence;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderSource;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderStatus;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTraded;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeTotal;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string InsertTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActiveTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SuspendTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string UpdateTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ActiveTraderID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClearingPartID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserForceClose;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ActiveUserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BrokerOrderSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string RelativeOrderSysID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ZCETotalTradedVolume;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsSwapOrder;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryErrOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcErrOrderActionField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrderActionRef;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderRef;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string OrderSysID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ActionFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double LimitPrice;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 VolumeChange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ActionTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string TraderID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string OrderLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string ActionLocalID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ClientID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string BusinessUnit;
        [MarshalAs(UnmanagedType.U1)]
        public byte OrderActionStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string StatusMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryExchangeSequenceField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcExchangeSequenceField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte MarketStatus;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQueryMaxOrderVolumeWithPriceField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.U1)]
        public byte OffsetFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 MaxVolume;
        [MarshalAs(UnmanagedType.R8)]
        public double Price;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerTradingParamsField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerTradingParamsField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.U1)]
        public byte MarginPriceType;
        [MarshalAs(UnmanagedType.U1)]
        public byte Algorithm;
        [MarshalAs(UnmanagedType.U1)]
        public byte AvailIncludeCloseProfit;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OptionRoyaltyPriceType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBrokerTradingAlgosField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerTradingAlgosField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HandlePositionAlgoID;
        [MarshalAs(UnmanagedType.U1)]
        public byte FindMarginRateAlgoID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HandleTradingAccountAlgoID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQueryBrokerDepositField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerDepositField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.R8)]
        public double PreBalance;
        [MarshalAs(UnmanagedType.R8)]
        public double CurrMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double Balance;
        [MarshalAs(UnmanagedType.R8)]
        public double Deposit;
        [MarshalAs(UnmanagedType.R8)]
        public double Withdraw;
        [MarshalAs(UnmanagedType.R8)]
        public double Available;
        [MarshalAs(UnmanagedType.R8)]
        public double Reserve;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCFMMCBrokerKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCFMMCBrokerKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CreateTime;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 KeyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
        [MarshalAs(UnmanagedType.U1)]
        public byte KeyKind;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCFMMCTradingAccountKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 KeyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CurrentKey;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCFMMCTradingAccountKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserOTPParamField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        public string OTPVendorsID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string SerialNumber;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string AuthKey;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LastDrift;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 LastSuccess;
        [MarshalAs(UnmanagedType.U1)]
        public byte OTPType;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcManualSyncBrokerUserOTPField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OTPType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string FirstOTP;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string SecondOTP;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCommRateModelField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CommModelName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCommRateModelField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string CommModelID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMarginModelField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string MarginModelName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryMarginModelField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string MarginModelID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcEWarrantOffsetField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.U1)]
        public byte Direction;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Volume;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryEWarrantOffsetField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string InstrumentID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryInvestorProductGroupMarginField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcInvestorProductGroupMarginField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SettlementID;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double LongFrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortFrozenMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double UseMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double LongUseMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortUseMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double LongExchMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortExchMargin;
        [MarshalAs(UnmanagedType.R8)]
        public double CloseProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCommission;
        [MarshalAs(UnmanagedType.R8)]
        public double Commission;
        [MarshalAs(UnmanagedType.R8)]
        public double FrozenCash;
        [MarshalAs(UnmanagedType.R8)]
        public double CashIn;
        [MarshalAs(UnmanagedType.R8)]
        public double PositionProfit;
        [MarshalAs(UnmanagedType.R8)]
        public double OffsetAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double LongOffsetAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortOffsetAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double ExchOffsetAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double LongExchOffsetAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double ShortExchOffsetAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte HedgeFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQueryCFMMCTradingAccountTokenField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string InvestUnitID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCFMMCTradingAccountTokenField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ParticipantID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 KeyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string Token;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryProductGroupField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcProductGroupField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string ProductGroupID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBulletinField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BulletinID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string NewsType;
        [MarshalAs(UnmanagedType.U1)]
        public byte NewsUrgency;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string SendTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string Abstract;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string ComeFrom;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 501)]
        public string Content;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 201)]
        public string URLLink;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string MarketID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryBulletinField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ExchangeID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 BulletinID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SequenceNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string NewsType;
        [MarshalAs(UnmanagedType.U1)]
        public byte NewsUrgency;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqOpenAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte CashExchangeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqCancelAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte CashExchangeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqChangeAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqTransferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double FutureFetchAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FeePayFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.R8)]
        public double BrokerFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TransferStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspTransferField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double FutureFetchAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FeePayFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.R8)]
        public double BrokerFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TransferStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqRepealField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RepealTimeInterval;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RepealedTimes;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankRepealFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BrokerRepealFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateRepealSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureRepealSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double FutureFetchAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FeePayFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.R8)]
        public double BrokerFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TransferStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspRepealField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RepealTimeInterval;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RepealedTimes;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankRepealFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte BrokerRepealFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateRepealSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankRepealSerial;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureRepealSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double FutureFetchAmount;
        [MarshalAs(UnmanagedType.U1)]
        public byte FeePayFlag;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.R8)]
        public double BrokerFee;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte TransferStatus;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqQueryAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspQueryAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.R8)]
        public double BankUseAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double BankFetchAmount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcFutureSignIOField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspFutureSignInField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqFutureSignOutField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspFutureSignOutField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqQueryTradeResultBySerialField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Reference;
        [MarshalAs(UnmanagedType.U1)]
        public byte RefrenceIssureType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspQueryTradeResultBySerialField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Reference;
        [MarshalAs(UnmanagedType.U1)]
        public byte RefrenceIssureType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string RefrenceIssure;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string OriginReturnCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string OriginDescrInfoForReturnCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqDayEndFileReadyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.U1)]
        public byte FileBusinessCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReturnResultField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcVerifyFuturePasswordField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcVerifyCustInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcVerifyFuturePasswordAndCustInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDepositResultInformField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string DepositSeqNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.R8)]
        public double Deposit;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ReturnCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string DescrInfoForReturnCode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqSyncKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspSyncKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcNotifyQueryAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.R8)]
        public double BankUseAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double BankFetchAmount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTransferSerialField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.U1)]
        public byte FutureAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FutureSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.R8)]
        public double TradeAmount;
        [MarshalAs(UnmanagedType.R8)]
        public double CustFee;
        [MarshalAs(UnmanagedType.R8)]
        public double BrokerFee;
        [MarshalAs(UnmanagedType.U1)]
        public byte AvailabilityFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperatorCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankNewAccount;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryTransferSerialField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcNotifyFutureSignInField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string PinKey;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string MacKey;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcNotifyFutureSignOutField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcNotifySyncKeyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
        public string Message;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 RequestID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryAccountregisterField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcAccountregisterField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte OpenOrDestroy;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string RegDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OutDate;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcOpenAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte CashExchangeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCancelAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.U1)]
        public byte CashExchangeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankSecuAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankSecuAcc;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
        public string OperNo;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcChangeAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string NewBankPassWord;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankPwdFlag;
        [MarshalAs(UnmanagedType.U1)]
        public byte SecuPwdFlag;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string LongCustomerName;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcSecAgentACIDMapField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySecAgentACIDMapField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserRightsAssignField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DRIdentityID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcBrokerUserRightAssignField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DRIdentityID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 Tradeable;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDRTransferField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 OrigDRIdentityID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DestDRIdentityID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string OrigBrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string DestBrokerID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcFensUserInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte LoginMode;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCurrTransferIdentityField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IdentityID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcLoginForbiddenUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryLoginForbiddenUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcMulticastGroupInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string GroupIP;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 GroupPort;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string SourceIP;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcTradingAccountReserveField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.R8)]
        public double Reserve;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryLoginForbiddenIPField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryIPListField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string IPAddress;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryUserRightsAssignField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReserveOpenAccountConfirmField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankReserveOpenSeq;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string BookDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BookPsw;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReserveOpenAccountField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string TradeCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        public string BankBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string BrokerBranchID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradeTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BankSerial;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 PlateSerial;
        [MarshalAs(UnmanagedType.U1)]
        public byte LastFragment;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 SessionID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 161)]
        public string CustomerName;
        [MarshalAs(UnmanagedType.U1)]
        public byte IdCardType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
        public string IdentifiedCardNo;
        [MarshalAs(UnmanagedType.U1)]
        public byte Gender;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string CountryCode;
        [MarshalAs(UnmanagedType.U1)]
        public byte CustType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string Address;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 7)]
        public string ZipCode;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Telephone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MobilePhone;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Fax;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string EMail;
        [MarshalAs(UnmanagedType.U1)]
        public byte MoneyAccountStatus;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankPassWord;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 InstallID;
        [MarshalAs(UnmanagedType.U1)]
        public byte VerifyCertNoFlag;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string Digest;
        [MarshalAs(UnmanagedType.U1)]
        public byte BankAccType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string BrokerIDByBank;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 TID;
        [MarshalAs(UnmanagedType.U1)]
        public byte ReserveOpenAccStas;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ErrorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
        public string ErrorMsg;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcAccountPropertyField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string AccountID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string BankID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string BankAccount;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string OpenName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
        public string OpenBank;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsActive;
        [MarshalAs(UnmanagedType.U1)]
        public byte AccountSourceType;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OpenDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string CancelDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65)]
        public string OperatorID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateDate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string OperateTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
        public string CurrencyID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQryCurrDRIdentityField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DRIdentityID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcCurrDRIdentityField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 DRIdentityID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySecAgentCheckModeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQrySecAgentTradeInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string BrokerSecAgentID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcUserSystemInfoField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientSystemInfoLen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 273)]
        public string ClientSystemInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientPublicIP;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientIPPort;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string ClientLoginTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string ClientAppID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqUserAuthMethodField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspUserAuthMethodField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UsableAuthMethod;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqGenUserCaptchaField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspGenUserCaptchaField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 CaptchaInfoLen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2561)]
        public string CaptchaInfo;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqGenUserTextField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspGenUserTextField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 UserTextSeq;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqUserLoginWithCaptchaField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Captcha;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientIPPort;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqUserLoginWithTextField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Text;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientIPPort;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqUserLoginWithOTPField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
        public string TradingDay;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string Password;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string UserProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string InterfaceProductInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string ProtocolInfo;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
        public string MacAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string ClientIPAddress;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
        public string LoginRemark;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 41)]
        public string OTPPassword;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ClientIPPort;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqApiHandshakeField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 31)]
        public string CryptoKeyVersion;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcRspApiHandshakeField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 FrontHandshakeDataLen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
        public string FrontHandshakeData;
        [MarshalAs(UnmanagedType.I4)]
        public Int32 IsApiAuthEnabled;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcReqVerifyApiKeyField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 ApiHandshakeDataLen;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 301)]
        public string ApiHandshakeData;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcDepartmentUserField
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        public string BrokerID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
        public string UserID;
        [MarshalAs(UnmanagedType.U1)]
        public byte InvestorRange;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
        public string InvestorID;
    }
    
    
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    [Serializable]
    public struct CThostFtdcQueryFreqField
    {
        [MarshalAs(UnmanagedType.I4)]
        public Int32 QueryFreq;
    }
    
    
}
