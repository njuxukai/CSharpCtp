using System;
using System.ComponentModel;
using System.Reflection;


namespace CSharpCtp
{

	public class EnumDescriptionTypeConverter : EnumConverter
	{
		public EnumDescriptionTypeConverter(Type type)
			: base(type)
		{
		}

		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string))
			{
				if (value != null)
				{
					FieldInfo fi = value.GetType().GetField(value.ToString());
					if (fi != null)
					{
						var attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
						return ((attributes.Length > 0) && (!String.IsNullOrEmpty(attributes[0].Description))) ? attributes[0].Description : value.ToString();
					}
				}

				return string.Empty;
			}

			return base.ConvertTo(context, culture, value, destinationType);
		}
	}

	public enum THOST_TE_RESUME_TYPE
	{
		THOST_TERT_RESTART = 0,
		THOST_TERT_RESUME,
		THOST_TERT_QUICK
	}

	[TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTEncryModeTEnum : byte
    {
        [Description("不加密")]
        NoEncry = (byte)'0',
        [Description("DES")]
        DES = (byte)'1',
        [Description("3DES")]
        ThreeDES = (byte)'2',
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCZCEUploadFileNameEnum : byte
    {
        [Description("其他")]
        O = (byte)'O',
        [Description("成交表")]
        T = (byte)'T',
        [Description("单腿持仓表new")]
        P = (byte)'P',
        [Description("非平仓了结表")]
        N = (byte)'N',
        [Description("平仓表")]
        L = (byte)'L',
        [Description("资金表")]
        F = (byte)'F',
        [Description("组合持仓表")]
        C = (byte)'C',
        [Description("保证金参数表")]
        M = (byte)'M',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDCEUploadFileNameEnum : byte
    {
        [Description("其他")]
        O = (byte)'O',
        [Description("成交表")]
        T = (byte)'T',
        [Description("持仓表")]
        P = (byte)'P',
        [Description("资金结算表")]
        F = (byte)'F',
        [Description("优惠组合持仓明细表")]
        C = (byte)'C',
        [Description("持仓明细表")]
        D = (byte)'D',
        [Description("保证金参数表")]
        M = (byte)'M',
        [Description("期权执行表")]
        S = (byte)'S',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSHFEUploadFileNameEnum : byte
    {
        [Description("DailyFundChg")]
        O = (byte)'O',
        [Description("Trade")]
        T = (byte)'T',
        [Description("SettlementDetail")]
        P = (byte)'P',
        [Description("Capital")]
        F = (byte)'F',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCFFEXUploadFileNameEnum : byte
    {
        [Description("Trade")]
        T = (byte)'T',
        [Description("SettlementDetail")]
        P = (byte)'P',
        [Description("Capital")]
        F = (byte)'F',
        [Description("OptionExec")]
        S = (byte)'S',
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangePropertyEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("根据成交生成报单")]
        GenOrderByTrade = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcIdCardTypeEnum : byte
    {
        [Description("组织机构代码")]
        EID = (byte)'0',
        [Description("中国公民身份证")]
        IDCard = (byte)'1',
        [Description("军官证")]
        OfficerIDCard = (byte)'2',
        [Description("警官证")]
        PoliceIDCard = (byte)'3',
        [Description("士兵证")]
        SoldierIDCard = (byte)'4',
        [Description("户口簿")]
        HouseholdRegister = (byte)'5',
        [Description("护照")]
        Passport = (byte)'6',
        [Description("台胞证")]
        TaiwanCompatriotIDCard = (byte)'7',
        [Description("回乡证")]
        HomeComingCard = (byte)'8',
        [Description("营业执照号")]
        LicenseNo = (byte)'9',
        [Description("税务登记号/当地纳税ID")]
        TaxNo = (byte)'A',
        [Description("港澳居民来往内地通行证")]
        HMMainlandTravelPermit = (byte)'B',
        [Description("台湾居民来往大陆通行证")]
        TwMainlandTravelPermit = (byte)'C',
        [Description("驾照")]
        DrivingLicense = (byte)'D',
        [Description("当地社保ID")]
        SocialID = (byte)'F',
        [Description("当地身份证")]
        LocalID = (byte)'G',
        [Description("商业登记证")]
        BusinessRegistration = (byte)'H',
        [Description("港澳永久性居民身份证")]
        HKMCIDCard = (byte)'I',
        [Description("人行开户许可证")]
        AccountsPermits = (byte)'J',
        [Description("外国人永久居留证")]
        FrgPrmtRdCard = (byte)'K',
        [Description("资管产品备案函")]
        CptMngPrdLetter = (byte)'L',
        [Description("其他证件")]
        OtherCard = (byte)'x',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorRangeEnum : byte
    {
        [Description("所有")]
        All = (byte)'1',
        [Description("投资者组")]
        Group = (byte)'2',
        [Description("单一投资者")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDepartmentRangeEnum : byte
    {
        [Description("所有")]
        All = (byte)'1',
        [Description("组织架构")]
        Group = (byte)'2',
        [Description("单一投资者")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataSyncStatusEnum : byte
    {
        [Description("未同步")]
        Asynchronous = (byte)'1',
        [Description("同步中")]
        Synchronizing = (byte)'2',
        [Description("已同步")]
        Synchronized = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerDataSyncStatusEnum : byte
    {
        [Description("已同步")]
        Synchronized = (byte)'1',
        [Description("同步中")]
        Synchronizing = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeConnectStatusEnum : byte
    {
        [Description("没有任何连接")]
        NoConnection = (byte)'1',
        [Description("已经发出合约查询请求")]
        QryInstrumentSent = (byte)'2',
        [Description("已经获取信息")]
        GotInformation = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTraderConnectStatusEnum : byte
    {
        [Description("没有任何连接")]
        NotConnected = (byte)'1',
        [Description("已经连接")]
        Connected = (byte)'2',
        [Description("已经发出合约查询请求")]
        QryInstrumentSent = (byte)'3',
        [Description("订阅私有流")]
        SubPrivateFlow = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFunctionCodeEnum : byte
    {
        [Description("数据异步化")]
        DataAsync = (byte)'1',
        [Description("强制用户登出")]
        ForceUserLogout = (byte)'2',
        [Description("变更管理用户口令")]
        UserPasswordUpdate = (byte)'3',
        [Description("变更经纪公司口令")]
        BrokerPasswordUpdate = (byte)'4',
        [Description("变更投资者口令")]
        InvestorPasswordUpdate = (byte)'5',
        [Description("报单插入")]
        OrderInsert = (byte)'6',
        [Description("报单操作")]
        OrderAction = (byte)'7',
        [Description("同步系统数据")]
        SyncSystemData = (byte)'8',
        [Description("同步经纪公司数据")]
        SyncBrokerData = (byte)'9',
        [Description("批量同步经纪公司数据")]
        BachSyncBrokerData = (byte)'A',
        [Description("超级查询")]
        SuperQuery = (byte)'B',
        [Description("预埋报单插入")]
        ParkedOrderInsert = (byte)'C',
        [Description("预埋报单操作")]
        ParkedOrderAction = (byte)'D',
        [Description("同步动态令牌")]
        SyncOTP = (byte)'E',
        [Description("删除未知单")]
        DeleteOrder = (byte)'F',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerFunctionCodeEnum : byte
    {
        [Description("强制用户登出")]
        ForceUserLogout = (byte)'1',
        [Description("变更用户口令")]
        UserPasswordUpdate = (byte)'2',
        [Description("同步经纪公司数据")]
        SyncBrokerData = (byte)'3',
        [Description("批量同步经纪公司数据")]
        BachSyncBrokerData = (byte)'4',
        [Description("报单插入")]
        OrderInsert = (byte)'5',
        [Description("报单操作")]
        OrderAction = (byte)'6',
        [Description("全部查询")]
        AllQuery = (byte)'7',
        [Description("系统功能：登入/登出/修改密码等")]
        log = (byte)'a',
        [Description("基本查询：查询基础数据，如合约，交易所等常量")]
        BaseQry = (byte)'b',
        [Description("交易查询：如查成交，委托")]
        TradeQry = (byte)'c',
        [Description("交易功能：报单，撤单")]
        Trade = (byte)'d',
        [Description("银期转账")]
        Virement = (byte)'e',
        [Description("风险监控")]
        Risk = (byte)'f',
        [Description("查询/管理：查询会话，踢人等")]
        Session = (byte)'g',
        [Description("风控通知控制")]
        RiskNoticeCtl = (byte)'h',
        [Description("风控通知发送")]
        RiskNotice = (byte)'i',
        [Description("察看经纪公司资金权限")]
        BrokerDeposit = (byte)'j',
        [Description("资金查询")]
        QueryFund = (byte)'k',
        [Description("报单查询")]
        QueryOrder = (byte)'l',
        [Description("成交查询")]
        QueryTrade = (byte)'m',
        [Description("持仓查询")]
        QueryPosition = (byte)'n',
        [Description("行情查询")]
        QueryMarketData = (byte)'o',
        [Description("用户事件查询")]
        QueryUserEvent = (byte)'p',
        [Description("风险通知查询")]
        QueryRiskNotify = (byte)'q',
        [Description("出入金查询")]
        QueryFundChange = (byte)'r',
        [Description("投资者信息查询")]
        QueryInvestor = (byte)'s',
        [Description("交易编码查询")]
        QueryTradingCode = (byte)'t',
        [Description("强平")]
        ForceClose = (byte)'u',
        [Description("压力测试")]
        PressTest = (byte)'v',
        [Description("权益反算")]
        RemainCalc = (byte)'w',
        [Description("净持仓保证金指标")]
        NetPositionInd = (byte)'x',
        [Description("风险预算")]
        RiskPredict = (byte)'y',
        [Description("数据导出")]
        DataExport = (byte)'z',
        [Description("风控指标设置")]
        RiskTargetSetup = (byte)'A',
        [Description("行情预警")]
        MarketDataWarn = (byte)'B',
        [Description("业务通知查询")]
        QryBizNotice = (byte)'C',
        [Description("业务通知模板设置")]
        CfgBizNotice = (byte)'D',
        [Description("同步动态令牌")]
        SyncOTP = (byte)'E',
        [Description("发送业务通知")]
        SendBizNotice = (byte)'F',
        [Description("风险级别标准设置")]
        CfgRiskLevelStd = (byte)'G',
        [Description("交易终端应急功能")]
        TbCommand = (byte)'H',
        [Description("删除未知单")]
        DeleteOrder = (byte)'J',
        [Description("预埋报单插入")]
        ParkedOrderInsert = (byte)'K',
        [Description("预埋报单操作")]
        ParkedOrderAction = (byte)'L',
        [Description("资金不够仍允许行权")]
        ExecOrderNoCheck = (byte)'M',
        [Description("指定")]
        Designate = (byte)'N',
        [Description("证券处置")]
        StockDisposal = (byte)'O',
        [Description("席位资金预警")]
        BrokerDepositWarn = (byte)'Q',
        [Description("备兑不足预警")]
        CoverWarn = (byte)'S',
        [Description("行权试算")]
        PreExecOrder = (byte)'T',
        [Description("行权交收风险")]
        ExecOrderRisk = (byte)'P',
        [Description("持仓限额预警")]
        PosiLimitWarn = (byte)'U',
        [Description("持仓限额查询")]
        QryPosiLimit = (byte)'V',
        [Description("银期签到签退")]
        FBSign = (byte)'W',
        [Description("银期签约解约")]
        FBAccount = (byte)'X',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderActionStatusEnum : byte
    {
        [Description("已经提交")]
        Submitted = (byte)'a',
        [Description("已经接受")]
        Accepted = (byte)'b',
        [Description("已经被拒绝")]
        Rejected = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderStatusEnum : byte
    {
        [Description("全部成交")]
        AllTraded = (byte)'0',
        [Description("部分成交还在队列中")]
        PartTradedQueueing = (byte)'1',
        [Description("部分成交不在队列中")]
        PartTradedNotQueueing = (byte)'2',
        [Description("未成交还在队列中")]
        NoTradeQueueing = (byte)'3',
        [Description("未成交不在队列中")]
        NoTradeNotQueueing = (byte)'4',
        [Description("撤单")]
        Canceled = (byte)'5',
        [Description("未知")]
        Unknown = (byte)'a',
        [Description("尚未触发")]
        NotTouched = (byte)'b',
        [Description("已触发")]
        Touched = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderSubmitStatusEnum : byte
    {
        [Description("已经提交")]
        InsertSubmitted = (byte)'0',
        [Description("撤单已经提交")]
        CancelSubmitted = (byte)'1',
        [Description("修改已经提交")]
        ModifySubmitted = (byte)'2',
        [Description("已经接受")]
        Accepted = (byte)'3',
        [Description("报单已经被拒绝")]
        InsertRejected = (byte)'4',
        [Description("撤单已经被拒绝")]
        CancelRejected = (byte)'5',
        [Description("改单已经被拒绝")]
        ModifyRejected = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionDateEnum : byte
    {
        [Description("今日持仓")]
        Today = (byte)'1',
        [Description("历史持仓")]
        History = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionDateTypeEnum : byte
    {
        [Description("使用历史持仓")]
        UseHistory = (byte)'1',
        [Description("不使用历史持仓")]
        NoUseHistory = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradingRoleEnum : byte
    {
        [Description("代理")]
        Broker = (byte)'1',
        [Description("自营")]
        Host = (byte)'2',
        [Description("做市商")]
        Maker = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductClassEnum : byte
    {
        [Description("期货")]
        Futures = (byte)'1',
        [Description("期货期权")]
        Options = (byte)'2',
        [Description("组合")]
        Combination = (byte)'3',
        [Description("即期")]
        Spot = (byte)'4',
        [Description("期转现")]
        EFP = (byte)'5',
        [Description("现货期权")]
        SpotOption = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstLifePhaseEnum : byte
    {
        [Description("未上市")]
        NotStart = (byte)'0',
        [Description("上市")]
        Started = (byte)'1',
        [Description("停牌")]
        Pause = (byte)'2',
        [Description("到期")]
        Expired = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDirectionEnum : byte
    {
        [Description("买")]
        Buy = (byte)'0',
        [Description("卖")]
        Sell = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionTypeEnum : byte
    {
        [Description("净持仓")]
        Net = (byte)'1',
        [Description("综合持仓")]
        Gross = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPosiDirectionEnum : byte
    {
        [Description("净")]
        Net = (byte)'1',
        [Description("多头")]
        Long = (byte)'2',
        [Description("空头")]
        Short = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysSettlementStatusEnum : byte
    {
        [Description("不活跃")]
        NonActive = (byte)'1',
        [Description("启动")]
        Startup = (byte)'2',
        [Description("操作")]
        Operating = (byte)'3',
        [Description("结算")]
        Settlement = (byte)'4',
        [Description("结算完成")]
        SettlementFinished = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRatioAttrEnum : byte
    {
        [Description("交易费率")]
        Trade = (byte)'0',
        [Description("结算费率")]
        Settlement = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHedgeFlagEnum : byte
    {
        [Description("投机")]
        Speculation = (byte)'1',
        [Description("套利")]
        Arbitrage = (byte)'2',
        [Description("套保")]
        Hedge = (byte)'3',
        [Description("做市商")]
        MarketMaker = (byte)'5',
        [Description("第一腿投机第二腿套保 大商所专用")]
        SpecHedge = (byte)'6',
        [Description("第一腿套保第二腿投机  大商所专用")]
        HedgeSpec = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBillHedgeFlagEnum : byte
    {
        [Description("投机")]
        Speculation = (byte)'1',
        [Description("套利")]
        Arbitrage = (byte)'2',
        [Description("套保")]
        Hedge = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientIDTypeEnum : byte
    {
        [Description("投机")]
        Speculation = (byte)'1',
        [Description("套利")]
        Arbitrage = (byte)'2',
        [Description("套保")]
        Hedge = (byte)'3',
        [Description("做市商")]
        MarketMaker = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderPriceTypeEnum : byte
    {
        [Description("任意价")]
        AnyPrice = (byte)'1',
        [Description("限价")]
        LimitPrice = (byte)'2',
        [Description("最优价")]
        BestPrice = (byte)'3',
        [Description("最新价")]
        LastPrice = (byte)'4',
        [Description("最新价浮动上浮1个ticks")]
        LastPricePlusOneTicks = (byte)'5',
        [Description("最新价浮动上浮2个ticks")]
        LastPricePlusTwoTicks = (byte)'6',
        [Description("最新价浮动上浮3个ticks")]
        LastPricePlusThreeTicks = (byte)'7',
        [Description("卖一价")]
        AskPrice1 = (byte)'8',
        [Description("卖一价浮动上浮1个ticks")]
        AskPrice1PlusOneTicks = (byte)'9',
        [Description("卖一价浮动上浮2个ticks")]
        AskPrice1PlusTwoTicks = (byte)'A',
        [Description("卖一价浮动上浮3个ticks")]
        AskPrice1PlusThreeTicks = (byte)'B',
        [Description("买一价")]
        BidPrice1 = (byte)'C',
        [Description("买一价浮动上浮1个ticks")]
        BidPrice1PlusOneTicks = (byte)'D',
        [Description("买一价浮动上浮2个ticks")]
        BidPrice1PlusTwoTicks = (byte)'E',
        [Description("买一价浮动上浮3个ticks")]
        BidPrice1PlusThreeTicks = (byte)'F',
        [Description("五档价")]
        FiveLevelPrice = (byte)'G',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOffsetFlagEnum : byte
    {
        [Description("开仓")]
        Open = (byte)'0',
        [Description("平仓")]
        Close = (byte)'1',
        [Description("强平")]
        ForceClose = (byte)'2',
        [Description("平今")]
        CloseToday = (byte)'3',
        [Description("平昨")]
        CloseYesterday = (byte)'4',
        [Description("强减")]
        ForceOff = (byte)'5',
        [Description("本地强平")]
        LocalForceClose = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForceCloseReasonEnum : byte
    {
        [Description("非强平")]
        NotForceClose = (byte)'0',
        [Description("资金不足")]
        LackDeposit = (byte)'1',
        [Description("客户超仓")]
        ClientOverPositionLimit = (byte)'2',
        [Description("会员超仓")]
        MemberOverPositionLimit = (byte)'3',
        [Description("持仓非整数倍")]
        NotMultiple = (byte)'4',
        [Description("违规")]
        Violation = (byte)'5',
        [Description("其它")]
        Other = (byte)'6',
        [Description("自然人临近交割")]
        PersonDeliv = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderTypeEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("报价衍生")]
        DeriveFromQuote = (byte)'1',
        [Description("组合衍生")]
        DeriveFromCombination = (byte)'2',
        [Description("组合报单")]
        Combination = (byte)'3',
        [Description("条件单")]
        ConditionalOrder = (byte)'4',
        [Description("互换单")]
        Swap = (byte)'5',
        [Description("大宗交易成交衍生")]
        DeriveFromBlockTrade = (byte)'6',
        [Description("期转现成交衍生")]
        DeriveFromEFPTrade = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTimeConditionEnum : byte
    {
        [Description("立即完成，否则撤销")]
        IOC = (byte)'1',
        [Description("本节有效")]
        GFS = (byte)'2',
        [Description("当日有效")]
        GFD = (byte)'3',
        [Description("指定日期前有效")]
        GTD = (byte)'4',
        [Description("撤销前有效")]
        GTC = (byte)'5',
        [Description("集合竞价有效")]
        GFA = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVolumeConditionEnum : byte
    {
        [Description("任何数量")]
        AV = (byte)'1',
        [Description("最小数量")]
        MV = (byte)'2',
        [Description("全部数量")]
        CV = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcContingentConditionEnum : byte
    {
        [Description("立即")]
        Immediately = (byte)'1',
        [Description("止损")]
        Touch = (byte)'2',
        [Description("止赢")]
        TouchProfit = (byte)'3',
        [Description("预埋单")]
        ParkedOrder = (byte)'4',
        [Description("最新价大于条件价")]
        LastPriceGreaterThanStopPrice = (byte)'5',
        [Description("最新价大于等于条件价")]
        LastPriceGreaterEqualStopPrice = (byte)'6',
        [Description("最新价小于条件价")]
        LastPriceLesserThanStopPrice = (byte)'7',
        [Description("最新价小于等于条件价")]
        LastPriceLesserEqualStopPrice = (byte)'8',
        [Description("卖一价大于条件价")]
        AskPriceGreaterThanStopPrice = (byte)'9',
        [Description("卖一价大于等于条件价")]
        AskPriceGreaterEqualStopPrice = (byte)'A',
        [Description("卖一价小于条件价")]
        AskPriceLesserThanStopPrice = (byte)'B',
        [Description("卖一价小于等于条件价")]
        AskPriceLesserEqualStopPrice = (byte)'C',
        [Description("买一价大于条件价")]
        BidPriceGreaterThanStopPrice = (byte)'D',
        [Description("买一价大于等于条件价")]
        BidPriceGreaterEqualStopPrice = (byte)'E',
        [Description("买一价小于条件价")]
        BidPriceLesserThanStopPrice = (byte)'F',
        [Description("买一价小于等于条件价")]
        BidPriceLesserEqualStopPrice = (byte)'H',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActionFlagEnum : byte
    {
        [Description("删除")]
        Delete = (byte)'0',
        [Description("修改")]
        Modify = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradingRightEnum : byte
    {
        [Description("可以交易")]
        Allow = (byte)'0',
        [Description("只能平仓")]
        CloseOnly = (byte)'1',
        [Description("不能交易")]
        Forbidden = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderSourceEnum : byte
    {
        [Description("来自参与者")]
        Participant = (byte)'0',
        [Description("来自管理员")]
        Administrator = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeTypeEnum : byte
    {
        [Description("组合持仓拆分为单一持仓,初始化不应包含该类型的持仓")]
        SplitCombination = (byte)'#',
        [Description("普通成交")]
        Common = (byte)'0',
        [Description("期权执行")]
        OptionsExecution = (byte)'1',
        [Description("OTC成交")]
        OTC = (byte)'2',
        [Description("期转现衍生成交")]
        EFPDerived = (byte)'3',
        [Description("组合衍生成交")]
        CombinationDerived = (byte)'4',
        [Description("大宗交易成交")]
        BlockTrade = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPriceSourceEnum : byte
    {
        [Description("前成交价")]
        LastPrice = (byte)'0',
        [Description("买委托价")]
        Buy = (byte)'1',
        [Description("卖委托价")]
        Sell = (byte)'2',
        [Description("场外成交价")]
        OTC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstrumentStatusEnum : byte
    {
        [Description("开盘前")]
        BeforeTrading = (byte)'0',
        [Description("非交易")]
        NoTrading = (byte)'1',
        [Description("连续交易")]
        Continous = (byte)'2',
        [Description("集合竞价报单")]
        AuctionOrdering = (byte)'3',
        [Description("集合竞价价格平衡")]
        AuctionBalance = (byte)'4',
        [Description("集合竞价撮合")]
        AuctionMatch = (byte)'5',
        [Description("收盘")]
        Closed = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstStatusEnterReasonEnum : byte
    {
        [Description("自动切换")]
        Automatic = (byte)'1',
        [Description("手动切换")]
        Manual = (byte)'2',
        [Description("熔断")]
        Fuse = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBatchStatusEnum : byte
    {
        [Description("未上传")]
        NoUpload = (byte)'1',
        [Description("已上传")]
        Uploaded = (byte)'2',
        [Description("审核失败")]
        Failed = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnStyleEnum : byte
    {
        [Description("按所有品种")]
        All = (byte)'1',
        [Description("按品种")]
        ByProduct = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnPatternEnum : byte
    {
        [Description("按成交手数")]
        ByVolume = (byte)'1',
        [Description("按留存手续费")]
        ByFeeOnHand = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnLevelEnum : byte
    {
        [Description("级别1")]
        Level1 = (byte)'1',
        [Description("级别2")]
        Level2 = (byte)'2',
        [Description("级别3")]
        Level3 = (byte)'3',
        [Description("级别4")]
        Level4 = (byte)'4',
        [Description("级别5")]
        Level5 = (byte)'5',
        [Description("级别6")]
        Level6 = (byte)'6',
        [Description("级别7")]
        Level7 = (byte)'7',
        [Description("级别8")]
        Level8 = (byte)'8',
        [Description("级别9")]
        Level9 = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnStandardEnum : byte
    {
        [Description("分阶段返还")]
        ByPeriod = (byte)'1',
        [Description("按某一标准")]
        ByStandard = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMortgageTypeEnum : byte
    {
        [Description("质出")]
        Out = (byte)'0',
        [Description("质入")]
        In = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorSettlementParamIDEnum : byte
    {
        [Description("质押比例")]
        MortgageRatio = (byte)'4',
        [Description("保证金算法")]
        MarginWay = (byte)'5',
        [Description("结算单结存是否包含质押")]
        BillDeposit = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeSettlementParamIDEnum : byte
    {
        [Description("质押比例")]
        MortgageRatio = (byte)'1',
        [Description("分项资金导入项")]
        OtherFundItem = (byte)'2',
        [Description("分项资金入交易所出入金")]
        OtherFundImport = (byte)'3',
        [Description("中金所开户最低可用金额")]
        CFFEXMinPrepa = (byte)'6',
        [Description("郑商所结算方式")]
        CZCESettlementType = (byte)'7',
        [Description("交易所交割手续费收取方式")]
        ExchDelivFeeMode = (byte)'9',
        [Description("投资者交割手续费收取方式")]
        DelivFeeMode = (byte)'0',
        [Description("郑商所组合持仓保证金收取方式")]
        CZCEComMarginType = (byte)'A',
        [Description("大商所套利保证金是否优惠")]
        DceComMarginType = (byte)'B',
        [Description("虚值期权保证金优惠比率")]
        OptOutDisCountRate = (byte)'a',
        [Description("最低保障系数")]
        OptMiniGuarantee = (byte)'b',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemParamIDEnum : byte
    {
        [Description("投资者代码最小长度")]
        InvestorIDMinLength = (byte)'1',
        [Description("投资者帐号代码最小长度")]
        AccountIDMinLength = (byte)'2',
        [Description("投资者开户默认登录权限")]
        UserRightLogon = (byte)'3',
        [Description("投资者交易结算单成交汇总方式")]
        SettlementBillTrade = (byte)'4',
        [Description("统一开户更新交易编码方式")]
        TradingCode = (byte)'5',
        [Description("结算是否判断存在未复核的出入金和分项资金")]
        CheckFund = (byte)'6',
        [Description("是否启用手续费模板数据权限")]
        CommModelRight = (byte)'7',
        [Description("是否启用保证金率模板数据权限")]
        MarginModelRight = (byte)'9',
        [Description("是否规范用户才能激活")]
        IsStandardActive = (byte)'8',
        [Description("上传的交易所结算文件路径")]
        UploadSettlementFile = (byte)'U',
        [Description("上报保证金监控中心文件路径")]
        DownloadCSRCFile = (byte)'D',
        [Description("生成的结算单文件路径")]
        SettlementBillFile = (byte)'S',
        [Description("证监会文件标识")]
        CSRCOthersFile = (byte)'C',
        [Description("投资者照片路径")]
        InvestorPhoto = (byte)'P',
        [Description("全结经纪公司上传文件路径")]
        CSRCData = (byte)'R',
        [Description("开户密码录入方式")]
        InvestorPwdModel = (byte)'I',
        [Description("投资者中金所结算文件下载路径")]
        CFFEXInvestorSettleFile = (byte)'F',
        [Description("投资者代码编码方式")]
        InvestorIDType = (byte)'a',
        [Description("休眠户最高权益")]
        FreezeMaxReMain = (byte)'r',
        [Description("手续费相关操作实时上场开关")]
        IsSync = (byte)'A',
        [Description("解除开仓权限限制")]
        RelieveOpenLimit = (byte)'O',
        [Description("是否规范用户才能休眠")]
        IsStandardFreeze = (byte)'X',
        [Description("郑商所是否开放所有品种套保交易")]
        CZCENormalProductHedge = (byte)'B',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeParamIDEnum : byte
    {
        [Description("系统加密算法")]
        EncryptionStandard = (byte)'E',
        [Description("系统风险算法")]
        RiskMode = (byte)'R',
        [Description("系统风险算法是否全局 0-否 1-是")]
        RiskModeGlobal = (byte)'G',
        [Description("密码加密算法")]
        modeEncode = (byte)'P',
        [Description("价格小数位数参数")]
        tickMode = (byte)'T',
        [Description("用户最大会话数")]
        SingleUserSessionMaxNum = (byte)'S',
        [Description("最大连续登录失败数")]
        LoginFailMaxNum = (byte)'L',
        [Description("是否强制认证")]
        IsAuthForce = (byte)'A',
        [Description("是否冻结证券持仓")]
        IsPosiFreeze = (byte)'F',
        [Description("是否限仓")]
        IsPosiLimit = (byte)'M',
        [Description("郑商所询价时间间隔")]
        ForQuoteTimeInterval = (byte)'Q',
        [Description("是否期货限仓")]
        IsFuturePosiLimit = (byte)'B',
        [Description("是否期货下单频率限制")]
        IsFutureOrderFreq = (byte)'C',
        [Description("行权冻结是否计算盈利")]
        IsExecOrderProfit = (byte)'H',
        [Description("银期开户是否验证开户银行卡号是否是预留银行账户")]
        IsCheckBankAcc = (byte)'I',
        [Description("弱密码最后修改日期")]
        PasswordDeadLine = (byte)'J',
        [Description("强密码校验")]
        IsStrongPassword = (byte)'K',
        [Description("自有资金质押比")]
        BalanceMorgage = (byte)'a',
        [Description("最小密码长度")]
        MinPwdLen = (byte)'O',
        [Description("IP当日最大登陆失败次数")]
        LoginFailMaxNumForIP = (byte)'U',
        [Description("密码有效期")]
        PasswordPeriod = (byte)'V',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileIDEnum : byte
    {
        [Description("资金数据")]
        SettlementFund = (byte)'F',
        [Description("成交数据")]
        Trade = (byte)'T',
        [Description("投资者持仓数据")]
        InvestorPosition = (byte)'P',
        [Description("投资者分项资金数据")]
        SubEntryFund = (byte)'O',
        [Description("组合持仓数据")]
        CZCECombinationPos = (byte)'C',
        [Description("上报保证金监控中心数据")]
        CSRCData = (byte)'R',
        [Description("郑商所平仓了结数据")]
        CZCEClose = (byte)'L',
        [Description("郑商所非平仓了结数据")]
        CZCENoClose = (byte)'N',
        [Description("持仓明细数据")]
        PositionDtl = (byte)'D',
        [Description("期权执行文件")]
        OptionStrike = (byte)'S',
        [Description("结算价比对文件")]
        SettlementPriceComparison = (byte)'M',
        [Description("上期所非持仓变动明细")]
        NonTradePosChange = (byte)'B',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileTypeEnum : byte
    {
        [Description("结算")]
        Settlement = (byte)'0',
        [Description("核对")]
        Check = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileFormatEnum : byte
    {
        [Description("文本文件(.txt)")]
        Txt = (byte)'0',
        [Description("压缩文件(.zip)")]
        Zip = (byte)'1',
        [Description("DBF文件(.dbf)")]
        DBF = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileUploadStatusEnum : byte
    {
        [Description("上传成功")]
        SucceedUpload = (byte)'1',
        [Description("上传失败")]
        FailedUpload = (byte)'2',
        [Description("导入成功")]
        SucceedLoad = (byte)'3',
        [Description("导入部分成功")]
        PartSucceedLoad = (byte)'4',
        [Description("导入失败")]
        FailedLoad = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferDirectionEnum : byte
    {
        [Description("移出")]
        Out = (byte)'0',
        [Description("移入")]
        In = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSpecialCreateRuleEnum : byte
    {
        [Description("没有特殊创建规则")]
        NoSpecialRule = (byte)'0',
        [Description("不包含春节")]
        NoSpringFestival = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBasisPriceTypeEnum : byte
    {
        [Description("上一合约结算价")]
        LastSettlement = (byte)'1',
        [Description("上一合约收盘价")]
        LaseClose = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductLifePhaseEnum : byte
    {
        [Description("活跃")]
        Active = (byte)'1',
        [Description("不活跃")]
        NonActive = (byte)'2',
        [Description("注销")]
        Canceled = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDeliveryModeEnum : byte
    {
        [Description("现金交割")]
        CashDeliv = (byte)'1',
        [Description("实物交割")]
        CommodityDeliv = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundIOTypeEnum : byte
    {
        [Description("出入金")]
        FundIO = (byte)'1',
        [Description("银期转帐")]
        Transfer = (byte)'2',
        [Description("银期换汇")]
        SwapCurrency = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundTypeEnum : byte
    {
        [Description("银行存款")]
        Deposite = (byte)'1',
        [Description("分项资金")]
        ItemFund = (byte)'2',
        [Description("公司调整")]
        Company = (byte)'3',
        [Description("资金内转")]
        InnerTransfer = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundDirectionEnum : byte
    {
        [Description("入金")]
        In = (byte)'1',
        [Description("出金")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundStatusEnum : byte
    {
        [Description("已录入")]
        Record = (byte)'1',
        [Description("已复核")]
        Check = (byte)'2',
        [Description("已冲销")]
        Charge = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPublishStatusEnum : byte
    {
        [Description("未发布")]
        None = (byte)'1',
        [Description("正在发布")]
        Publishing = (byte)'2',
        [Description("已发布")]
        Published = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemStatusEnum : byte
    {
        [Description("不活跃")]
        NonActive = (byte)'1',
        [Description("启动")]
        Startup = (byte)'2',
        [Description("交易开始初始化")]
        Initialize = (byte)'3',
        [Description("交易完成初始化")]
        Initialized = (byte)'4',
        [Description("收市开始")]
        Close = (byte)'5',
        [Description("收市完成")]
        Closed = (byte)'6',
        [Description("结算")]
        Settlement = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementStatusEnum : byte
    {
        [Description("初始")]
        Initialize = (byte)'0',
        [Description("结算中")]
        Settlementing = (byte)'1',
        [Description("已结算")]
        Settlemented = (byte)'2',
        [Description("结算完成")]
        Finished = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorTypeEnum : byte
    {
        [Description("自然人")]
        Person = (byte)'0',
        [Description("法人")]
        Company = (byte)'1',
        [Description("投资基金")]
        Fund = (byte)'2',
        [Description("特殊法人")]
        SpecialOrgan = (byte)'3',
        [Description("资管户")]
        Asset = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerTypeEnum : byte
    {
        [Description("交易会员")]
        Trade = (byte)'0',
        [Description("交易结算会员")]
        TradeSettle = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskLevelEnum : byte
    {
        [Description("低风险客户")]
        Low = (byte)'1',
        [Description("普通客户")]
        Normal = (byte)'2',
        [Description("关注客户")]
        Focus = (byte)'3',
        [Description("风险客户")]
        Risk = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFeeAcceptStyleEnum : byte
    {
        [Description("按交易收取")]
        ByTrade = (byte)'1',
        [Description("按交割收取")]
        ByDeliv = (byte)'2',
        [Description("不收")]
        None = (byte)'3',
        [Description("按指定手续费收取")]
        FixFee = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPasswordTypeEnum : byte
    {
        [Description("交易密码")]
        Trade = (byte)'1',
        [Description("资金密码")]
        Account = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAlgorithmEnum : byte
    {
        [Description("浮盈浮亏都计算")]
        All = (byte)'1',
        [Description("浮盈不计，浮亏计")]
        OnlyLost = (byte)'2',
        [Description("浮盈计，浮亏不计")]
        OnlyGain = (byte)'3',
        [Description("浮盈浮亏都不计算")]
        None = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcIncludeCloseProfitEnum : byte
    {
        [Description("包含平仓盈利")]
        Include = (byte)'0',
        [Description("不包含平仓盈利")]
        NotInclude = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAllWithoutTradeEnum : byte
    {
        [Description("无仓无成交不受可提比例限制")]
        Enable = (byte)'0',
        [Description("受可提比例限制")]
        Disable = (byte)'2',
        [Description("无仓不受可提比例限制")]
        NoHoldEnable = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFuturePwdFlagEnum : byte
    {
        [Description("不核对")]
        UnCheck = (byte)'0',
        [Description("核对")]
        Check = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferTypeEnum : byte
    {
        [Description("银行转期货")]
        BankToFuture = (byte)'0',
        [Description("期货转银行")]
        FutureToBank = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferValidFlagEnum : byte
    {
        [Description("无效或失败")]
        Invalid = (byte)'0',
        [Description("有效")]
        Valid = (byte)'1',
        [Description("冲正")]
        Reverse = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReasonEnum : byte
    {
        [Description("错单")]
        CD = (byte)'0',
        [Description("资金在途")]
        ZT = (byte)'1',
        [Description("其它")]
        QT = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSexEnum : byte
    {
        [Description("未知")]
        None = (byte)'0',
        [Description("男")]
        Man = (byte)'1',
        [Description("女")]
        Woman = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserTypeEnum : byte
    {
        [Description("投资者")]
        Investor = (byte)'0',
        [Description("操作员")]
        Operator = (byte)'1',
        [Description("管理员")]
        SuperUser = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRateTypeEnum : byte
    {
        [Description("保证金率")]
        MarginRate = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcNoteTypeEnum : byte
    {
        [Description("交易结算单")]
        TradeSettleBill = (byte)'1',
        [Description("交易结算月报")]
        TradeSettleMonth = (byte)'2',
        [Description("追加保证金通知书")]
        CallMarginNotes = (byte)'3',
        [Description("强行平仓通知书")]
        ForceCloseNotes = (byte)'4',
        [Description("成交通知书")]
        TradeNotes = (byte)'5',
        [Description("交割通知书")]
        DelivNotes = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementStyleEnum : byte
    {
        [Description("逐日盯市")]
        Day = (byte)'1',
        [Description("逐笔对冲")]
        Volume = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementBillTypeEnum : byte
    {
        [Description("日报")]
        Day = (byte)'0',
        [Description("月报")]
        Month = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserRightTypeEnum : byte
    {
        [Description("登录")]
        Logon = (byte)'1',
        [Description("银期转帐")]
        Transfer = (byte)'2',
        [Description("邮寄结算单")]
        EMail = (byte)'3',
        [Description("传真结算单")]
        Fax = (byte)'4',
        [Description("条件单")]
        ConditionOrder = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginPriceTypeEnum : byte
    {
        [Description("昨结算价")]
        PreSettlementPrice = (byte)'1',
        [Description("最新价")]
        SettlementPrice = (byte)'2',
        [Description("成交均价")]
        AveragePrice = (byte)'3',
        [Description("开仓价")]
        OpenPrice = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBillGenStatusEnum : byte
    {
        [Description("未生成")]
        None = (byte)'0',
        [Description("生成中")]
        NoGenerated = (byte)'1',
        [Description("已生成")]
        Generated = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAlgoTypeEnum : byte
    {
        [Description("持仓处理算法")]
        HandlePositionAlgo = (byte)'1',
        [Description("寻找保证金率算法")]
        FindMarginRateAlgo = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHandlePositionAlgoIDEnum : byte
    {
        [Description("基本")]
        Base = (byte)'1',
        [Description("大连商品交易所")]
        DCE = (byte)'2',
        [Description("郑州商品交易所")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFindMarginRateAlgoIDEnum : byte
    {
        [Description("基本")]
        Base = (byte)'1',
        [Description("大连商品交易所")]
        DCE = (byte)'2',
        [Description("郑州商品交易所")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHandleTradingAccountAlgoIDEnum : byte
    {
        [Description("基本")]
        Base = (byte)'1',
        [Description("大连商品交易所")]
        DCE = (byte)'2',
        [Description("郑州商品交易所")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPersonTypeEnum : byte
    {
        [Description("指定下单人")]
        Order = (byte)'1',
        [Description("开户授权人")]
        Open = (byte)'2',
        [Description("资金调拨人")]
        Fund = (byte)'3',
        [Description("结算单确认人")]
        Settlement = (byte)'4',
        [Description("法人")]
        Company = (byte)'5',
        [Description("法人代表")]
        Corporation = (byte)'6',
        [Description("投资者联系人")]
        LinkMan = (byte)'7',
        [Description("分户管理资产负责人")]
        Ledger = (byte)'8',
        [Description("托（保）管人")]
        Trustee = (byte)'9',
        [Description("托（保）管机构法人代表")]
        TrusteeCorporation = (byte)'A',
        [Description("托（保）管机构开户授权人")]
        TrusteeOpen = (byte)'B',
        [Description("托（保）管机构联系人")]
        TrusteeContact = (byte)'C',
        [Description("境外自然人参考证件")]
        ForeignerRefer = (byte)'D',
        [Description("法人代表参考证件")]
        CorporationRefer = (byte)'E',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcQueryInvestorRangeEnum : byte
    {
        [Description("所有")]
        All = (byte)'1',
        [Description("查询分类")]
        Group = (byte)'2',
        [Description("单一投资者")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorRiskStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'1',
        [Description("警告")]
        Warn = (byte)'2',
        [Description("追保")]
        Call = (byte)'3',
        [Description("强平")]
        Force = (byte)'4',
        [Description("异常")]
        Exception = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserEventTypeEnum : byte
    {
        [Description("登录")]
        Login = (byte)'1',
        [Description("登出")]
        Logout = (byte)'2',
        [Description("交易成功")]
        Trading = (byte)'3',
        [Description("交易失败")]
        TradingError = (byte)'4',
        [Description("修改密码")]
        UpdatePassword = (byte)'5',
        [Description("客户端认证")]
        Authenticate = (byte)'6',
        [Description("其他")]
        Other = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCloseStyleEnum : byte
    {
        [Description("先开先平")]
        Close = (byte)'0',
        [Description("先平今再平昨")]
        CloseToday = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStatModeEnum : byte
    {
        [Description("----")]
        Non = (byte)'0',
        [Description("按合约统计")]
        Instrument = (byte)'1',
        [Description("按产品统计")]
        Product = (byte)'2',
        [Description("按投资者统计")]
        Investor = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcParkedOrderStatusEnum : byte
    {
        [Description("未发送")]
        NotSend = (byte)'1',
        [Description("已发送")]
        Send = (byte)'2',
        [Description("已删除")]
        Deleted = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirDealStatusEnum : byte
    {
        [Description("正在处理")]
        Dealing = (byte)'1',
        [Description("处理成功")]
        DeaclSucceed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrgSystemIDEnum : byte
    {
        [Description("综合交易平台")]
        Standard = (byte)'0',
        [Description("易盛系统")]
        ESunny = (byte)'1',
        [Description("金仕达V6系统")]
        KingStarV6 = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirTradeStatusEnum : byte
    {
        [Description("正常处理中")]
        NaturalDeal = (byte)'0',
        [Description("成功结束")]
        SucceedEnd = (byte)'1',
        [Description("失败结束")]
        FailedEND = (byte)'2',
        [Description("异常中")]
        Exception = (byte)'3',
        [Description("已人工异常处理")]
        ManualDeal = (byte)'4',
        [Description("通讯异常 ，请人工处理")]
        MesException = (byte)'5',
        [Description("系统出错，请人工处理")]
        SysException = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirBankAccTypeEnum : byte
    {
        [Description("存折")]
        BankBook = (byte)'1',
        [Description("储蓄卡")]
        BankCard = (byte)'2',
        [Description("信用卡")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirementStatusEnum : byte
    {
        [Description("正常")]
        Natural = (byte)'0',
        [Description("销户")]
        Canceled = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirementAvailAbilityEnum : byte
    {
        [Description("未确认")]
        NoAvailAbility = (byte)'0',
        [Description("有效")]
        AvailAbility = (byte)'1',
        [Description("冲正")]
        Repeal = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAMLGenStatusEnum : byte
    {
        [Description("程序生成")]
        Program = (byte)'0',
        [Description("人工生成")]
        HandWork = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCFMMCKeyKindEnum : byte
    {
        [Description("主动请求更新")]
        REQUEST = (byte)'R',
        [Description("CFMMC自动更新")]
        AUTO = (byte)'A',
        [Description("CFMMC手动更新")]
        MANUAL = (byte)'M',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCertificationTypeEnum : byte
    {
        [Description("身份证")]
        IDCard = (byte)'0',
        [Description("护照")]
        Passport = (byte)'1',
        [Description("军官证")]
        OfficerIDCard = (byte)'2',
        [Description("士兵证")]
        SoldierIDCard = (byte)'3',
        [Description("回乡证")]
        HomeComingCard = (byte)'4',
        [Description("户口簿")]
        HouseholdRegister = (byte)'5',
        [Description("营业执照号")]
        LicenseNo = (byte)'6',
        [Description("组织机构代码证")]
        InstitutionCodeCard = (byte)'7',
        [Description("临时营业执照号")]
        TempLicenseNo = (byte)'8',
        [Description("民办非企业登记证书")]
        NoEnterpriseLicenseNo = (byte)'9',
        [Description("其他证件")]
        OtherCard = (byte)'x',
        [Description("主管部门批文")]
        SuperDepAgree = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileBusinessCodeEnum : byte
    {
        [Description("其他")]
        Others = (byte)'0',
        [Description("转账交易明细对账")]
        TransferDetails = (byte)'1',
        [Description("客户账户状态对账")]
        CustAccStatus = (byte)'2',
        [Description("账户类交易明细对账")]
        AccountTradeDetails = (byte)'3',
        [Description("期货账户信息变更明细对账")]
        FutureAccountChangeInfoDetails = (byte)'4',
        [Description("客户资金台账余额明细对账")]
        CustMoneyDetail = (byte)'5',
        [Description("客户销户结息明细对账")]
        CustCancelAccountInfo = (byte)'6',
        [Description("客户资金余额对账结果")]
        CustMoneyResult = (byte)'7',
        [Description("其它对账异常结果文件")]
        OthersExceptionResult = (byte)'8',
        [Description("客户结息净额明细")]
        CustInterestNetMoneyDetails = (byte)'9',
        [Description("客户资金交收明细")]
        CustMoneySendAndReceiveDetails = (byte)'a',
        [Description("法人存管银行资金交收汇总")]
        CorporationMoneyTotal = (byte)'b',
        [Description("主体间资金交收汇总")]
        MainbodyMoneyTotal = (byte)'c',
        [Description("总分平衡监管数据")]
        MainPartMonitorData = (byte)'d',
        [Description("存管银行备付金余额")]
        PreparationMoney = (byte)'e',
        [Description("协办存管银行资金监管数据")]
        BankMoneyMonitorData = (byte)'f',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCashExchangeCodeEnum : byte
    {
        [Description("汇")]
        Exchange = (byte)'1',
        [Description("钞")]
        Cash = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcYesNoIndicatorEnum : byte
    {
        [Description("是")]
        Yes = (byte)'0',
        [Description("否")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBanlanceTypeEnum : byte
    {
        [Description("当前余额")]
        CurrentMoney = (byte)'0',
        [Description("可用余额")]
        UsableMoney = (byte)'1',
        [Description("可取余额")]
        FetchableMoney = (byte)'2',
        [Description("冻结余额")]
        FreezeMoney = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcGenderEnum : byte
    {
        [Description("未知状态")]
        Unknown = (byte)'0',
        [Description("男")]
        Male = (byte)'1',
        [Description("女")]
        Female = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFeePayFlagEnum : byte
    {
        [Description("由受益方支付费用")]
        BEN = (byte)'0',
        [Description("由发送方支付费用")]
        OUR = (byte)'1',
        [Description("由发送方支付发起的费用，受益方支付接受的费用")]
        SHA = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPassWordKeyTypeEnum : byte
    {
        [Description("交换密钥")]
        ExchangeKey = (byte)'0',
        [Description("密码密钥")]
        PassWordKey = (byte)'1',
        [Description("MAC密钥")]
        MACKey = (byte)'2',
        [Description("报文密钥")]
        MessageKey = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTPassWordTypeEnum : byte
    {
        [Description("查询")]
        Query = (byte)'0',
        [Description("取款")]
        Fetch = (byte)'1',
        [Description("转帐")]
        Transfer = (byte)'2',
        [Description("交易")]
        Trade = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankRepealFlagEnum : byte
    {
        [Description("银行无需自动冲正")]
        BankNotNeedRepeal = (byte)'0',
        [Description("银行待自动冲正")]
        BankWaitingRepeal = (byte)'1',
        [Description("银行已自动冲正")]
        BankBeenRepealed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerRepealFlagEnum : byte
    {
        [Description("期商无需自动冲正")]
        BrokerNotNeedRepeal = (byte)'0',
        [Description("期商待自动冲正")]
        BrokerWaitingRepeal = (byte)'1',
        [Description("期商已自动冲正")]
        BrokerBeenRepealed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstitutionTypeEnum : byte
    {
        [Description("银行")]
        Bank = (byte)'0',
        [Description("期商")]
        Future = (byte)'1',
        [Description("券商")]
        Store = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLastFragmentEnum : byte
    {
        [Description("是最后分片")]
        Yes = (byte)'0',
        [Description("不是最后分片")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAccStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("冻结")]
        Freeze = (byte)'1',
        [Description("挂失")]
        ReportLoss = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMoneyAccountStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("销户")]
        Cancel = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcManageStatusEnum : byte
    {
        [Description("指定存管")]
        Point = (byte)'0',
        [Description("预指定")]
        PrePoint = (byte)'1',
        [Description("撤销指定")]
        CancelPoint = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemTypeEnum : byte
    {
        [Description("银期转帐")]
        FutureBankTransfer = (byte)'0',
        [Description("银证转帐")]
        StockBankTransfer = (byte)'1',
        [Description("第三方存管")]
        TheThirdPartStore = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTxnEndFlagEnum : byte
    {
        [Description("正常处理中")]
        NormalProcessing = (byte)'0',
        [Description("成功结束")]
        Success = (byte)'1',
        [Description("失败结束")]
        Failed = (byte)'2',
        [Description("异常中")]
        Abnormal = (byte)'3',
        [Description("已人工异常处理")]
        ManualProcessedForException = (byte)'4',
        [Description("通讯异常 ，请人工处理")]
        CommuFailedNeedManualProcess = (byte)'5',
        [Description("系统出错，请人工处理")]
        SysErrorNeedManualProcess = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProcessStatusEnum : byte
    {
        [Description("未处理")]
        NotProcess = (byte)'0',
        [Description("开始处理")]
        StartProcess = (byte)'1',
        [Description("处理完成")]
        Finished = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCustTypeEnum : byte
    {
        [Description("自然人")]
        Person = (byte)'0',
        [Description("机构户")]
        Institution = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTTransferDirectionEnum : byte
    {
        [Description("入金，银行转期货")]
        FromBankToFuture = (byte)'1',
        [Description("出金，期货转银行")]
        FromFutureToBank = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOpenOrDestroyEnum : byte
    {
        [Description("开户")]
        Open = (byte)'1',
        [Description("销户")]
        Destroy = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAvailabilityFlagEnum : byte
    {
        [Description("未确认")]
        Invalid = (byte)'0',
        [Description("有效")]
        Valid = (byte)'1',
        [Description("冲正")]
        Repeal = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganTypeEnum : byte
    {
        [Description("银行代理")]
        Bank = (byte)'1',
        [Description("交易前置")]
        Future = (byte)'2',
        [Description("银期转帐平台管理")]
        PlateForm = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganLevelEnum : byte
    {
        [Description("银行总行或期商总部")]
        HeadQuarters = (byte)'1',
        [Description("银行分中心或期货公司营业部")]
        Branch = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProtocalIDEnum : byte
    {
        [Description("期商协议")]
        FutureProtocal = (byte)'0',
        [Description("工行协议")]
        ICBCProtocal = (byte)'1',
        [Description("农行协议")]
        ABCProtocal = (byte)'2',
        [Description("中国银行协议")]
        CBCProtocal = (byte)'3',
        [Description("建行协议")]
        CCBProtocal = (byte)'4',
        [Description("交行协议")]
        BOCOMProtocal = (byte)'5',
        [Description("银期转帐平台协议")]
        FBTPlateFormProtocal = (byte)'X',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcConnectModeEnum : byte
    {
        [Description("短连接")]
        ShortConnect = (byte)'0',
        [Description("长连接")]
        LongConnect = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncModeEnum : byte
    {
        [Description("异步")]
        ASync = (byte)'0',
        [Description("同步")]
        Sync = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAccTypeEnum : byte
    {
        [Description("银行存折")]
        BankBook = (byte)'1',
        [Description("储蓄卡")]
        SavingCard = (byte)'2',
        [Description("信用卡")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFutureAccTypeEnum : byte
    {
        [Description("银行存折")]
        BankBook = (byte)'1',
        [Description("储蓄卡")]
        SavingCard = (byte)'2',
        [Description("信用卡")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganStatusEnum : byte
    {
        [Description("启用")]
        Ready = (byte)'0',
        [Description("签到")]
        CheckIn = (byte)'1',
        [Description("签退")]
        CheckOut = (byte)'2',
        [Description("对帐文件到达")]
        CheckFileArrived = (byte)'3',
        [Description("对帐")]
        CheckDetail = (byte)'4',
        [Description("日终清理")]
        DayEndClean = (byte)'5',
        [Description("注销")]
        Invalid = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCCBFeeModeEnum : byte
    {
        [Description("按金额扣收")]
        ByAmount = (byte)'1',
        [Description("按月扣收")]
        ByMonth = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCommApiTypeEnum : byte
    {
        [Description("客户端")]
        Client = (byte)'1',
        [Description("服务端")]
        Server = (byte)'2',
        [Description("交易系统的UserApi")]
        UserApi = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLinkStatusEnum : byte
    {
        [Description("已经连接")]
        Connected = (byte)'1',
        [Description("没有连接")]
        Disconnected = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPwdFlagEnum : byte
    {
        [Description("不核对")]
        NoCheck = (byte)'0',
        [Description("明文核对")]
        BlankCheck = (byte)'1',
        [Description("密文核对")]
        EncryptCheck = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSecuAccTypeEnum : byte
    {
        [Description("资金帐号")]
        AccountID = (byte)'1',
        [Description("资金卡号")]
        CardID = (byte)'2',
        [Description("上海股东帐号")]
        SHStockholderID = (byte)'3',
        [Description("深圳股东帐号")]
        SZStockholderID = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("被冲正")]
        Repealed = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSponsorTypeEnum : byte
    {
        [Description("期商")]
        Broker = (byte)'0',
        [Description("银行")]
        Bank = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReqRspTypeEnum : byte
    {
        [Description("请求")]
        Request = (byte)'0',
        [Description("响应")]
        Response = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTUserEventTypeEnum : byte
    {
        [Description("签到")]
        SignIn = (byte)'0',
        [Description("银行转期货")]
        FromBankToFuture = (byte)'1',
        [Description("期货转银行")]
        FromFutureToBank = (byte)'2',
        [Description("开户")]
        OpenAccount = (byte)'3',
        [Description("销户")]
        CancelAccount = (byte)'4',
        [Description("变更银行账户")]
        ChangeAccount = (byte)'5',
        [Description("冲正银行转期货")]
        RepealFromBankToFuture = (byte)'6',
        [Description("冲正期货转银行")]
        RepealFromFutureToBank = (byte)'7',
        [Description("查询银行账户")]
        QueryBankAccount = (byte)'8',
        [Description("查询期货账户")]
        QueryFutureAccount = (byte)'9',
        [Description("签退")]
        SignOut = (byte)'A',
        [Description("密钥同步")]
        SyncKey = (byte)'B',
        [Description("预约开户")]
        ReserveOpenAccount = (byte)'C',
        [Description("撤销预约开户")]
        CancelReserveOpenAccount = (byte)'D',
        [Description("预约开户确认")]
        ReserveOpenAccountConfirm = (byte)'E',
        [Description("其他")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDBOperationEnum : byte
    {
        [Description("插入")]
        Insert = (byte)'0',
        [Description("更新")]
        Update = (byte)'1',
        [Description("删除")]
        Delete = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncFlagEnum : byte
    {
        [Description("已同步")]
        Yes = (byte)'0',
        [Description("未同步")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncTypeEnum : byte
    {
        [Description("一次同步")]
        OneOffSync = (byte)'0',
        [Description("定时同步")]
        TimerSync = (byte)'1',
        [Description("定时完全同步")]
        TimerFullSync = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExDirectionEnum : byte
    {
        [Description("结汇")]
        Settlement = (byte)'0',
        [Description("售汇")]
        Sale = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEResultFlagEnum : byte
    {
        [Description("成功")]
        Success = (byte)'0',
        [Description("账户余额不足")]
        InsufficientBalance = (byte)'1',
        [Description("交易结果未知")]
        UnknownTrading = (byte)'8',
        [Description("失败")]
        Fail = (byte)'x',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEExchStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("交易重发")]
        ReExchange = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEFileFlagEnum : byte
    {
        [Description("数据包")]
        DataPackage = (byte)'0',
        [Description("文件")]
        File = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEAlreadyTradeEnum : byte
    {
        [Description("未交易")]
        NotTrade = (byte)'0',
        [Description("已交易")]
        Trade = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEUserEventTypeEnum : byte
    {
        [Description("签到")]
        SignIn = (byte)'0',
        [Description("换汇")]
        Exchange = (byte)'1',
        [Description("换汇重发")]
        ReExchange = (byte)'2',
        [Description("银行账户查询")]
        QueryBankAccount = (byte)'3',
        [Description("换汇明细查询")]
        QueryExchDetial = (byte)'4',
        [Description("换汇汇总查询")]
        QueryExchSummary = (byte)'5',
        [Description("换汇汇率查询")]
        QueryExchRate = (byte)'6',
        [Description("对账文件通知")]
        CheckBankAccount = (byte)'7',
        [Description("签退")]
        SignOut = (byte)'8',
        [Description("其他")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEReqFlagEnum : byte
    {
        [Description("未处理")]
        UnProcessed = (byte)'0',
        [Description("等待发送")]
        WaitSend = (byte)'1',
        [Description("发送成功")]
        SendSuccess = (byte)'2',
        [Description("发送失败")]
        SendFailed = (byte)'3',
        [Description("等待重发")]
        WaitReSend = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcNotifyClassEnum : byte
    {
        [Description("正常")]
        NOERROR = (byte)'0',
        [Description("警示")]
        Warn = (byte)'1',
        [Description("追保")]
        Call = (byte)'2',
        [Description("强平")]
        Force = (byte)'3',
        [Description("穿仓")]
        CHUANCANG = (byte)'4',
        [Description("异常")]
        Exception = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForceCloseTypeEnum : byte
    {
        [Description("手工强平")]
        Manual = (byte)'0',
        [Description("单一投资者辅助强平")]
        Single = (byte)'1',
        [Description("批量投资者辅助强平")]
        Group = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskNotifyMethodEnum : byte
    {
        [Description("系统通知")]
        System = (byte)'0',
        [Description("短信通知")]
        SMS = (byte)'1',
        [Description("邮件通知")]
        EMail = (byte)'2',
        [Description("人工通知")]
        Manual = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskNotifyStatusEnum : byte
    {
        [Description("未生成")]
        NotGen = (byte)'0',
        [Description("已生成未发送")]
        Generated = (byte)'1',
        [Description("发送失败")]
        SendError = (byte)'2',
        [Description("已发送未接收")]
        SendOk = (byte)'3',
        [Description("已接收未确认")]
        Received = (byte)'4',
        [Description("已确认")]
        Confirmed = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskUserEventEnum : byte
    {
        [Description("导出数据")]
        ExportData = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcConditionalOrderSortTypeEnum : byte
    {
        [Description("使用最新价升序")]
        LastPriceAsc = (byte)'0',
        [Description("使用最新价降序")]
        LastPriceDesc = (byte)'1',
        [Description("使用卖价升序")]
        AskPriceAsc = (byte)'2',
        [Description("使用卖价降序")]
        AskPriceDesc = (byte)'3',
        [Description("使用买价升序")]
        BidPriceAsc = (byte)'4',
        [Description("使用买价降序")]
        BidPriceDesc = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSendTypeEnum : byte
    {
        [Description("未发送")]
        NoSend = (byte)'0',
        [Description("已发送")]
        Sended = (byte)'1',
        [Description("已生成")]
        Generated = (byte)'2',
        [Description("报送失败")]
        SendFail = (byte)'3',
        [Description("接收成功")]
        Success = (byte)'4',
        [Description("接收失败")]
        Fail = (byte)'5',
        [Description("取消报送")]
        Cancel = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientIDStatusEnum : byte
    {
        [Description("未申请")]
        NoApply = (byte)'1',
        [Description("已提交申请")]
        Submited = (byte)'2',
        [Description("已发送申请")]
        Sended = (byte)'3',
        [Description("完成")]
        Success = (byte)'4',
        [Description("拒绝")]
        Refuse = (byte)'5',
        [Description("已撤销编码")]
        Cancel = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcQuestionTypeEnum : byte
    {
        [Description("单选")]
        Radio = (byte)'1',
        [Description("多选")]
        Option = (byte)'2',
        [Description("填空")]
        Blank = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBusinessTypeEnum : byte
    {
        [Description("请求")]
        Request = (byte)'1',
        [Description("应答")]
        Response = (byte)'2',
        [Description("通知")]
        Notice = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCfmmcReturnCodeEnum : byte
    {
        [Description("成功")]
        Success = (byte)'0',
        [Description("该客户已经有流程在处理中")]
        Working = (byte)'1',
        [Description("监控中客户资料检查失败")]
        InfoFail = (byte)'2',
        [Description("监控中实名制检查失败")]
        IDCardFail = (byte)'3',
        [Description("其他错误")]
        OtherFail = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientTypeEnum : byte
    {
        [Description("所有")]
        All = (byte)'0',
        [Description("个人")]
        Person = (byte)'1',
        [Description("单位")]
        Company = (byte)'2',
        [Description("其他")]
        Other = (byte)'3',
        [Description("特殊法人")]
        SpecialOrgan = (byte)'4',
        [Description("资管户")]
        Asset = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeIDTypeEnum : byte
    {
        [Description("上海期货交易所")]
        SHFE = (byte)'S',
        [Description("郑州商品交易所")]
        CZCE = (byte)'Z',
        [Description("大连商品交易所")]
        DCE = (byte)'D',
        [Description("中国金融期货交易所")]
        CFFEX = (byte)'J',
        [Description("上海国际能源交易中心股份有限公司")]
        INE = (byte)'N',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExClientIDTypeEnum : byte
    {
        [Description("套保")]
        Hedge = (byte)'1',
        [Description("套利")]
        Arbitrage = (byte)'2',
        [Description("投机")]
        Speculation = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUpdateFlagEnum : byte
    {
        [Description("未更新")]
        NoUpdate = (byte)'0',
        [Description("更新全部信息成功")]
        Success = (byte)'1',
        [Description("更新全部信息失败")]
        Fail = (byte)'2',
        [Description("更新交易编码成功")]
        TCSuccess = (byte)'3',
        [Description("更新交易编码失败")]
        TCFail = (byte)'4',
        [Description("已丢弃")]
        Cancel = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyOperateIDEnum : byte
    {
        [Description("开户")]
        OpenInvestor = (byte)'1',
        [Description("修改身份信息")]
        ModifyIDCard = (byte)'2',
        [Description("修改一般信息")]
        ModifyNoIDCard = (byte)'3',
        [Description("申请交易编码")]
        ApplyTradingCode = (byte)'4',
        [Description("撤销交易编码")]
        CancelTradingCode = (byte)'5',
        [Description("销户")]
        CancelInvestor = (byte)'6',
        [Description("账户休眠")]
        FreezeAccount = (byte)'8',
        [Description("激活休眠账户")]
        ActiveFreezeAccount = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyStatusIDEnum : byte
    {
        [Description("未补全")]
        NoComplete = (byte)'1',
        [Description("已提交")]
        Submited = (byte)'2',
        [Description("已审核")]
        Checked = (byte)'3',
        [Description("已拒绝")]
        Refused = (byte)'4',
        [Description("已删除")]
        Deleted = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSendMethodEnum : byte
    {
        [Description("文件发送")]
        ByAPI = (byte)'1',
        [Description("电子发送")]
        ByFile = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcEventModeEnum : byte
    {
        [Description("增加")]
        ADD = (byte)'1',
        [Description("修改")]
        UPDATE = (byte)'2',
        [Description("删除")]
        DELETE = (byte)'3',
        [Description("复核")]
        CHECK = (byte)'4',
        [Description("复制")]
        COPY = (byte)'5',
        [Description("注销")]
        CANCEL = (byte)'6',
        [Description("冲销")]
        Reverse = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUOAAutoSendEnum : byte
    {
        [Description("自动发送并接收")]
        ASR = (byte)'1',
        [Description("自动发送，不自动接收")]
        ASNR = (byte)'2',
        [Description("不自动发送，自动接收")]
        NSAR = (byte)'3',
        [Description("不自动发送，也不自动接收")]
        NSR = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFlowIDEnum : byte
    {
        [Description("投资者对应投资者组设置")]
        InvestorGroupFlow = (byte)'1',
        [Description("投资者手续费率设置")]
        InvestorRate = (byte)'2',
        [Description("投资者手续费率模板关系设置")]
        InvestorCommRateModel = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckLevelEnum : byte
    {
        [Description("零级复核")]
        Zero = (byte)'0',
        [Description("一级复核")]
        One = (byte)'1',
        [Description("二级复核")]
        Two = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckStatusEnum : byte
    {
        [Description("未复核")]
        Init = (byte)'0',
        [Description("复核中")]
        Checking = (byte)'1',
        [Description("已复核")]
        Checked = (byte)'2',
        [Description("拒绝")]
        Refuse = (byte)'3',
        [Description("作废")]
        Cancel = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUsedStatusEnum : byte
    {
        [Description("未生效")]
        Unused = (byte)'0',
        [Description("已生效")]
        Used = (byte)'1',
        [Description("生效失败")]
        Fail = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAcountOriginEnum : byte
    {
        [Description("手工录入")]
        ByAccProperty = (byte)'0',
        [Description("银期转账")]
        ByFBTransfer = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMonthBillTradeSumEnum : byte
    {
        [Description("同日同合约")]
        ByInstrument = (byte)'0',
        [Description("同日同合约同价格")]
        ByDayInsPrc = (byte)'1',
        [Description("同合约")]
        ByDayIns = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTPTypeEnum : byte
    {
        [Description("无动态令牌")]
        NONE = (byte)'0',
        [Description("时间令牌")]
        TOTP = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTPStatusEnum : byte
    {
        [Description("未使用")]
        Unused = (byte)'0',
        [Description("已使用")]
        Used = (byte)'1',
        [Description("注销")]
        Disuse = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerUserTypeEnum : byte
    {
        [Description("投资者")]
        Investor = (byte)'1',
        [Description("操作员")]
        BrokerUser = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFutureTypeEnum : byte
    {
        [Description("商品期货")]
        Commodity = (byte)'1',
        [Description("金融期货")]
        Financial = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundEventTypeEnum : byte
    {
        [Description("转账限额")]
        Restriction = (byte)'0',
        [Description("当日转账限额")]
        TodayRestriction = (byte)'1',
        [Description("期商流水")]
        Transfer = (byte)'2',
        [Description("资金冻结")]
        Credit = (byte)'3',
        [Description("投资者可提资金比例")]
        InvestorWithdrawAlm = (byte)'4',
        [Description("单个银行帐户转账限额")]
        BankRestriction = (byte)'5',
        [Description("银期签约账户")]
        Accountregister = (byte)'6',
        [Description("交易所出入金")]
        ExchangeFundIO = (byte)'7',
        [Description("投资者出入金")]
        InvestorFundIO = (byte)'8',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAccountSourceTypeEnum : byte
    {
        [Description("银期同步")]
        FBTransfer = (byte)'0',
        [Description("手工录入")]
        ManualEntry = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCodeSourceTypeEnum : byte
    {
        [Description("统一开户(已规范)")]
        UnifyAccount = (byte)'0',
        [Description("手工录入(未规范)")]
        ManualEntry = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserRangeEnum : byte
    {
        [Description("所有")]
        All = (byte)'0',
        [Description("单一操作员")]
        Single = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcByGroupEnum : byte
    {
        [Description("按投资者统计")]
        Investor = (byte)'2',
        [Description("按类统计")]
        Group = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeSumStatModeEnum : byte
    {
        [Description("按合约统计")]
        Instrument = (byte)'1',
        [Description("按产品统计")]
        Product = (byte)'2',
        [Description("按交易所统计")]
        Exchange = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExprSetModeEnum : byte
    {
        [Description("相对已有规则设置")]
        Relative = (byte)'1',
        [Description("典型设置")]
        Typical = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRateInvestorRangeEnum : byte
    {
        [Description("公司标准")]
        All = (byte)'1',
        [Description("模板")]
        Model = (byte)'2',
        [Description("单一投资者")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncDataStatusEnum : byte
    {
        [Description("未同步")]
        Initialize = (byte)'0',
        [Description("同步中")]
        Settlementing = (byte)'1',
        [Description("已同步")]
        Settlemented = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeSourceEnum : byte
    {
        [Description("来自交易所普通回报")]
        NORMAL = (byte)'0',
        [Description("来自查询")]
        QUERY = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFlexStatModeEnum : byte
    {
        [Description("产品统计")]
        Product = (byte)'1',
        [Description("交易所统计")]
        Exchange = (byte)'2',
        [Description("统计所有")]
        All = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcByInvestorRangeEnum : byte
    {
        [Description("属性统计")]
        Property = (byte)'1',
        [Description("统计所有")]
        All = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPropertyInvestorRangeEnum : byte
    {
        [Description("所有")]
        All = (byte)'1',
        [Description("投资者属性")]
        Property = (byte)'2',
        [Description("单一投资者")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileStatusEnum : byte
    {
        [Description("未生成")]
        NoCreate = (byte)'0',
        [Description("已生成")]
        Created = (byte)'1',
        [Description("生成失败")]
        Failed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileGenStyleEnum : byte
    {
        [Description("下发")]
        FileTransmit = (byte)'0',
        [Description("生成")]
        FileGen = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysOperModeEnum : byte
    {
        [Description("增加")]
        Add = (byte)'1',
        [Description("修改")]
        Update = (byte)'2',
        [Description("删除")]
        Delete = (byte)'3',
        [Description("复制")]
        Copy = (byte)'4',
        [Description("激活")]
        AcTive = (byte)'5',
        [Description("注销")]
        CanCel = (byte)'6',
        [Description("重置")]
        ReSet = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysOperTypeEnum : byte
    {
        [Description("修改操作员密码")]
        UpdatePassword = (byte)'0',
        [Description("操作员组织架构关系")]
        UserDepartment = (byte)'1',
        [Description("角色管理")]
        RoleManager = (byte)'2',
        [Description("角色功能设置")]
        RoleFunction = (byte)'3',
        [Description("基础参数设置")]
        BaseParam = (byte)'4',
        [Description("设置操作员")]
        SetUserID = (byte)'5',
        [Description("用户角色设置")]
        SetUserRole = (byte)'6',
        [Description("用户IP限制")]
        UserIpRestriction = (byte)'7',
        [Description("组织架构管理")]
        DepartmentManager = (byte)'8',
        [Description("组织架构向查询分类复制")]
        DepartmentCopy = (byte)'9',
        [Description("交易编码管理")]
        Tradingcode = (byte)'A',
        [Description("投资者状态维护")]
        InvestorStatus = (byte)'B',
        [Description("投资者权限管理")]
        InvestorAuthority = (byte)'C',
        [Description("属性设置")]
        PropertySet = (byte)'D',
        [Description("重置投资者密码")]
        ReSetInvestorPasswd = (byte)'E',
        [Description("投资者个性信息维护")]
        InvestorPersonalityInfo = (byte)'F',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCSRCDataQueyTypeEnum : byte
    {
        [Description("查询当前交易日报送的数据")]
        Current = (byte)'0',
        [Description("查询历史报送的代理经纪公司的数据")]
        History = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFreezeStatusEnum : byte
    {
        [Description("活跃")]
        Normal = (byte)'1',
        [Description("休眠")]
        Freeze = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStandardStatusEnum : byte
    {
        [Description("已规范")]
        Standard = (byte)'0',
        [Description("未规范")]
        NonStandard = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRightParamTypeEnum : byte
    {
        [Description("休眠户")]
        Freeze = (byte)'1',
        [Description("激活休眠户")]
        FreezeActive = (byte)'2',
        [Description("开仓权限限制")]
        OpenLimit = (byte)'3',
        [Description("解除开仓权限限制")]
        RelieveOpenLimit = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataStatusEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("已删除")]
        Deleted = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAMLCheckStatusEnum : byte
    {
        [Description("未复核")]
        Init = (byte)'0',
        [Description("复核中")]
        Checking = (byte)'1',
        [Description("已复核")]
        Checked = (byte)'2',
        [Description("拒绝上报")]
        RefuseReport = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmlDateTypeEnum : byte
    {
        [Description("检查日期")]
        DrawDay = (byte)'0',
        [Description("发生日期")]
        TouchDay = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmlCheckLevelEnum : byte
    {
        [Description("零级审核")]
        CheckLevel0 = (byte)'0',
        [Description("一级审核")]
        CheckLevel1 = (byte)'1',
        [Description("二级审核")]
        CheckLevel2 = (byte)'2',
        [Description("三级审核")]
        CheckLevel3 = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExportFileTypeEnum : byte
    {
        [Description("CSV")]
        CSV = (byte)'0',
        [Description("Excel")]
        EXCEL = (byte)'1',
        [Description("DBF")]
        DBF = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettleManagerTypeEnum : byte
    {
        [Description("结算前准备")]
        Before = (byte)'1',
        [Description("结算")]
        Settlement = (byte)'2',
        [Description("结算后核对")]
        After = (byte)'3',
        [Description("结算后处理")]
        Settlemented = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettleManagerLevelEnum : byte
    {
        [Description("必要")]
        Must = (byte)'1',
        [Description("警告")]
        Alarm = (byte)'2',
        [Description("提示")]
        Prompt = (byte)'3',
        [Description("不检查")]
        Ignore = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettleManagerGroupEnum : byte
    {
        [Description("交易所核对")]
        Exhcange = (byte)'1',
        [Description("内部核对")]
        ASP = (byte)'2',
        [Description("上报数据核对")]
        CSRC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLimitUseTypeEnum : byte
    {
        [Description("可重复使用")]
        Repeatable = (byte)'1',
        [Description("不可重复使用")]
        Unrepeatable = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataResourceEnum : byte
    {
        [Description("本系统")]
        Settle = (byte)'1',
        [Description("交易所")]
        Exchange = (byte)'2',
        [Description("报送数据")]
        CSRC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginTypeEnum : byte
    {
        [Description("交易所保证金率")]
        ExchMarginRate = (byte)'0',
        [Description("投资者保证金率")]
        InstrMarginRate = (byte)'1',
        [Description("投资者交易保证金率")]
        InstrMarginRateTrade = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActiveTypeEnum : byte
    {
        [Description("仅当日生效")]
        Intraday = (byte)'1',
        [Description("长期生效")]
        Long = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginRateTypeEnum : byte
    {
        [Description("交易所保证金率")]
        Exchange = (byte)'1',
        [Description("投资者保证金率")]
        Investor = (byte)'2',
        [Description("投资者交易保证金率")]
        InvestorTrade = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBackUpStatusEnum : byte
    {
        [Description("未生成备份数据")]
        UnBak = (byte)'0',
        [Description("备份数据生成中")]
        BakUp = (byte)'1',
        [Description("已生成备份数据")]
        BakUped = (byte)'2',
        [Description("备份数据失败")]
        BakFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInitSettlementEnum : byte
    {
        [Description("结算初始化未开始")]
        UnInitialize = (byte)'0',
        [Description("结算初始化中")]
        Initialize = (byte)'1',
        [Description("结算初始化完成")]
        Initialized = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReportStatusEnum : byte
    {
        [Description("未生成报表数据")]
        NoCreate = (byte)'0',
        [Description("报表数据生成中")]
        Create = (byte)'1',
        [Description("已生成报表数据")]
        Created = (byte)'2',
        [Description("生成报表数据失败")]
        CreateFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSaveStatusEnum : byte
    {
        [Description("归档未完成")]
        UnSaveData = (byte)'0',
        [Description("归档完成")]
        SaveDatad = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettArchiveStatusEnum : byte
    {
        [Description("未归档数据")]
        UnArchived = (byte)'0',
        [Description("数据归档中")]
        Archiving = (byte)'1',
        [Description("已归档数据")]
        Archived = (byte)'2',
        [Description("归档数据失败")]
        ArchiveFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCTPTypeEnum : byte
    {
        [Description("未知类型")]
        Unkown = (byte)'0',
        [Description("主中心")]
        MainCenter = (byte)'1',
        [Description("备中心")]
        BackUp = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCloseDealTypeEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'0',
        [Description("投机平仓优先")]
        SpecFirst = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMortgageFundUseRangeEnum : byte
    {
        [Description("不能使用")]
        None = (byte)'0',
        [Description("用于保证金")]
        Margin = (byte)'1',
        [Description("用于手续费、盈亏、保证金")]
        All = (byte)'2',
        [Description("人民币方案3")]
        CNY3 = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSpecProductTypeEnum : byte
    {
        [Description("郑商所套保产品")]
        CzceHedge = (byte)'1',
        [Description("货币质押产品")]
        IneForeignCurrency = (byte)'2',
        [Description("大连短线开平仓产品")]
        DceOpenClose = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundMortgageTypeEnum : byte
    {
        [Description("质押")]
        Mortgage = (byte)'1',
        [Description("解质")]
        Redemption = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAccountSettlementParamIDEnum : byte
    {
        [Description("基础保证金")]
        BaseMargin = (byte)'1',
        [Description("最低权益标准")]
        LowestInterest = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundMortDirectionEnum : byte
    {
        [Description("货币质入")]
        In = (byte)'1',
        [Description("货币质出")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBusinessClassEnum : byte
    {
        [Description("盈利")]
        Profit = (byte)'0',
        [Description("亏损")]
        Loss = (byte)'1',
        [Description("其他")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSwapSourceTypeEnum : byte
    {
        [Description("手工")]
        Manual = (byte)'0',
        [Description("自动生成")]
        Automatic = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCurrExDirectionEnum : byte
    {
        [Description("结汇")]
        Settlement = (byte)'0',
        [Description("售汇")]
        Sale = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCurrencySwapStatusEnum : byte
    {
        [Description("已录入")]
        Entry = (byte)'1',
        [Description("已审核")]
        Approve = (byte)'2',
        [Description("已拒绝")]
        Refuse = (byte)'3',
        [Description("已撤销")]
        Revoke = (byte)'4',
        [Description("已发送")]
        Send = (byte)'5',
        [Description("换汇成功")]
        Success = (byte)'6',
        [Description("换汇失败")]
        Failure = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReqFlagEnum : byte
    {
        [Description("未发送")]
        NoSend = (byte)'0',
        [Description("发送成功")]
        SendSuccess = (byte)'1',
        [Description("发送失败")]
        SendFailed = (byte)'2',
        [Description("等待重发")]
        WaitReSend = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcResFlagEnum : byte
    {
        [Description("成功")]
        Success = (byte)'0',
        [Description("账户余额不足")]
        InsuffiCient = (byte)'1',
        [Description("交易结果未知")]
        UnKnown = (byte)'8',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExStatusEnum : byte
    {
        [Description("修改前")]
        Before = (byte)'0',
        [Description("修改后")]
        After = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientRegionEnum : byte
    {
        [Description("国内客户")]
        Domestic = (byte)'1',
        [Description("港澳台客户")]
        GMT = (byte)'2',
        [Description("国外客户")]
        Foreign = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHasBoardEnum : byte
    {
        [Description("没有")]
        No = (byte)'0',
        [Description("有")]
        Yes = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStartModeEnum : byte
    {
        [Description("正常")]
        Normal = (byte)'1',
        [Description("应急")]
        Emerge = (byte)'2',
        [Description("恢复")]
        Restore = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTemplateTypeEnum : byte
    {
        [Description("全量")]
        Full = (byte)'1',
        [Description("增量")]
        Increment = (byte)'2',
        [Description("备份")]
        BackUp = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLoginModeEnum : byte
    {
        [Description("交易")]
        Trade = (byte)'0',
        [Description("转账")]
        Transfer = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPromptTypeEnum : byte
    {
        [Description("合约上下市")]
        Instrument = (byte)'1',
        [Description("保证金分段生效")]
        Margin = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHasTrusteeEnum : byte
    {
        [Description("有")]
        Yes = (byte)'1',
        [Description("没有")]
        No = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmTypeEnum : byte
    {
        [Description("银行")]
        Bank = (byte)'1',
        [Description("证券公司")]
        Securities = (byte)'2',
        [Description("基金公司")]
        Fund = (byte)'3',
        [Description("保险公司")]
        Insurance = (byte)'4',
        [Description("信托公司")]
        Trust = (byte)'5',
        [Description("其他")]
        Other = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCSRCFundIOTypeEnum : byte
    {
        [Description("出入金")]
        FundIO = (byte)'0',
        [Description("银期换汇")]
        SwapCurrency = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCusAccountTypeEnum : byte
    {
        [Description("期货结算账户")]
        Futures = (byte)'1',
        [Description("纯期货资管业务下的资管结算账户")]
        AssetmgrFuture = (byte)'2',
        [Description("综合类资管业务下的期货资管托管账户")]
        AssetmgrTrustee = (byte)'3',
        [Description("综合类资管业务下的资金中转账户")]
        AssetmgrTransfer = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLanguageTypeEnum : byte
    {
        [Description("中文")]
        Chinese = (byte)'1',
        [Description("英文")]
        English = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAssetmgrClientTypeEnum : byte
    {
        [Description("个人资管客户")]
        Person = (byte)'1',
        [Description("单位资管客户")]
        Organ = (byte)'2',
        [Description("特殊单位资管客户")]
        SpecialOrgan = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAssetmgrTypeEnum : byte
    {
        [Description("期货类")]
        Futures = (byte)'3',
        [Description("综合类")]
        SpecialOrgan = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckInstrTypeEnum : byte
    {
        [Description("合约交易所不存在")]
        HasExch = (byte)'0',
        [Description("合约本系统不存在")]
        HasATP = (byte)'1',
        [Description("合约比较不一致")]
        HasDiff = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDeliveryTypeEnum : byte
    {
        [Description("手工交割")]
        HandDeliv = (byte)'1',
        [Description("到期交割")]
        PersonDeliv = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMaxMarginSideAlgorithmEnum : byte
    {
        [Description("不使用大额单边保证金算法")]
        NO = (byte)'0',
        [Description("使用大额单边保证金算法")]
        YES = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDAClientTypeEnum : byte
    {
        [Description("自然人")]
        Person = (byte)'0',
        [Description("法人")]
        Company = (byte)'1',
        [Description("其他")]
        Other = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUOAAssetmgrTypeEnum : byte
    {
        [Description("期货类")]
        Futures = (byte)'1',
        [Description("综合类")]
        SpecialOrgan = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDirectionEnEnum : byte
    {
        [Description("Buy")]
        Buy = (byte)'0',
        [Description("Sell")]
        Sell = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOffsetFlagEnEnum : byte
    {
        [Description("Position Opening")]
        Open = (byte)'0',
        [Description("Position Close")]
        Close = (byte)'1',
        [Description("Forced Liquidation")]
        ForceClose = (byte)'2',
        [Description("Close Today")]
        CloseToday = (byte)'3',
        [Description("Close Prev.")]
        CloseYesterday = (byte)'4',
        [Description("Forced Reduction")]
        ForceOff = (byte)'5',
        [Description("Local Forced Liquidation")]
        LocalForceClose = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHedgeFlagEnEnum : byte
    {
        [Description("Speculation")]
        Speculation = (byte)'1',
        [Description("Arbitrage")]
        Arbitrage = (byte)'2',
        [Description("Hedge")]
        Hedge = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundIOTypeEnEnum : byte
    {
        [Description("Deposit/Withdrawal")]
        FundIO = (byte)'1',
        [Description("Bank-Futures Transfer")]
        Transfer = (byte)'2',
        [Description("Bank-Futures FX Exchange")]
        SwapCurrency = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundTypeEnEnum : byte
    {
        [Description("Bank Deposit")]
        Deposite = (byte)'1',
        [Description("Payment/Fee")]
        ItemFund = (byte)'2',
        [Description("Brokerage Adj")]
        Company = (byte)'3',
        [Description("Internal Transfer")]
        InnerTransfer = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundDirectionEnEnum : byte
    {
        [Description("Deposit")]
        In = (byte)'1',
        [Description("Withdrawal")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundMortDirectionEnEnum : byte
    {
        [Description("Pledge")]
        In = (byte)'1',
        [Description("Redemption")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOptionsTypeEnum : byte
    {
        [Description("看涨")]
        CallOptions = (byte)'1',
        [Description("看跌")]
        PutOptions = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeModeEnum : byte
    {
        [Description("欧式")]
        Continental = (byte)'0',
        [Description("美式")]
        American = (byte)'1',
        [Description("百慕大")]
        Bermuda = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeTypeEnum : byte
    {
        [Description("自身对冲")]
        Hedge = (byte)'0',
        [Description("匹配执行")]
        Match = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyTypeEnum : byte
    {
        [Description("不执行数量")]
        NotStrikeNum = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcGiveUpDataSourceEnum : byte
    {
        [Description("系统生成")]
        Gen = (byte)'0',
        [Description("手工添加")]
        Hand = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecResultEnum : byte
    {
        [Description("没有执行")]
        NoExec = (byte)'n',
        [Description("已经取消")]
        Canceled = (byte)'c',
        [Description("执行成功")]
        OK = (byte)'0',
        [Description("期权持仓不够")]
        NoPosition = (byte)'1',
        [Description("资金不够")]
        NoDeposit = (byte)'2',
        [Description("会员不存在")]
        NoParticipant = (byte)'3',
        [Description("客户不存在")]
        NoClient = (byte)'4',
        [Description("合约不存在")]
        NoInstrument = (byte)'6',
        [Description("没有执行权限")]
        NoRight = (byte)'7',
        [Description("不合理的数量")]
        InvalidVolume = (byte)'8',
        [Description("没有足够的历史成交")]
        NoEnoughHistoryTrade = (byte)'9',
        [Description("未知")]
        Unknown = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCombinationTypeEnum : byte
    {
        [Description("期货组合")]
        Future = (byte)'0',
        [Description("垂直价差BUL")]
        BUL = (byte)'1',
        [Description("垂直价差BER")]
        BER = (byte)'2',
        [Description("跨式组合")]
        STD = (byte)'3',
        [Description("宽跨式组合")]
        STG = (byte)'4',
        [Description("备兑组合")]
        PRT = (byte)'5',
        [Description("时间价差组合")]
        CLD = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDceCombinationTypeEnum : byte
    {
        [Description("期货对锁组合")]
        SPL = (byte)'0',
        [Description("期权对锁组合")]
        OPL = (byte)'1',
        [Description("期货跨期组合")]
        SP = (byte)'2',
        [Description("期货跨品种组合")]
        SPC = (byte)'3',
        [Description("买入期权垂直价差组合")]
        BLS = (byte)'4',
        [Description("卖出期权垂直价差组合")]
        BES = (byte)'5',
        [Description("期权日历价差组合")]
        CAS = (byte)'6',
        [Description("期权跨式组合")]
        STD = (byte)'7',
        [Description("期权宽跨式组合")]
        STG = (byte)'8',
        [Description("买入期货期权组合")]
        BFO = (byte)'9',
        [Description("卖出期货期权组合")]
        SFO = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOptionRoyaltyPriceTypeEnum : byte
    {
        [Description("昨结算价")]
        PreSettlementPrice = (byte)'1',
        [Description("开仓价")]
        OpenPrice = (byte)'4',
        [Description("最新价与昨结算价较大值")]
        MaxPreSettlementPrice = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBalanceAlgorithmEnum : byte
    {
        [Description("不计算期权市值盈亏")]
        Default = (byte)'1',
        [Description("计算期权市值亏损")]
        IncludeOptValLost = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActionTypeEnum : byte
    {
        [Description("执行")]
        Exec = (byte)'1',
        [Description("放弃")]
        Abandon = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForQuoteStatusEnum : byte
    {
        [Description("已经提交")]
        Submitted = (byte)'a',
        [Description("已经接受")]
        Accepted = (byte)'b',
        [Description("已经被拒绝")]
        Rejected = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcValueMethodEnum : byte
    {
        [Description("按绝对值")]
        Absolute = (byte)'0',
        [Description("按比率")]
        Ratio = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecOrderPositionFlagEnum : byte
    {
        [Description("保留")]
        Reserve = (byte)'0',
        [Description("不保留")]
        UnReserve = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecOrderCloseFlagEnum : byte
    {
        [Description("自动平仓")]
        AutoClose = (byte)'0',
        [Description("免于自动平仓")]
        NotToClose = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductTypeEnum : byte
    {
        [Description("期货")]
        Futures = (byte)'1',
        [Description("期权")]
        Options = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCombDirectionEnum : byte
    {
        [Description("申请组合")]
        Comb = (byte)'0',
        [Description("申请拆分")]
        UnComb = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeOffsetTypeEnum : byte
    {
        [Description("实值额")]
        RealValue = (byte)'1',
        [Description("盈利额")]
        ProfitValue = (byte)'2',
        [Description("实值比例")]
        RealRatio = (byte)'3',
        [Description("盈利比例")]
        ProfitRatio = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReserveOpenAccStasEnum : byte
    {
        [Description("等待处理中")]
        Processing = (byte)'0',
        [Description("已撤销")]
        Cancelled = (byte)'1',
        [Description("已开户")]
        Opened = (byte)'2',
        [Description("无效请求")]
        Invalid = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcWeakPasswordSourceEnum : byte
    {
        [Description("弱密码库")]
        Lib = (byte)'1',
        [Description("手工录入")]
        Manual = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOptSelfCloseFlagEnum : byte
    {
        [Description("自对冲期权仓位")]
        CloseSelfOptionPosition = (byte)'1',
        [Description("保留期权仓位")]
        ReserveOptionPosition = (byte)'2',
        [Description("自对冲卖方履约后的期货仓位")]
        SellCloseSelfFuturePosition = (byte)'3',
        [Description("保留卖方履约后的期货仓位")]
        ReserveFuturePosition = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBizTypeEnum : byte
    {
        [Description("期货")]
        Future = (byte)'1',
        [Description("证券")]
        Stock = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAppTypeEnum : byte
    {
        [Description("直连的投资者")]
        Investor = (byte)'1',
        [Description("为每个投资者都创建连接的中继")]
        InvestorRelay = (byte)'2',
        [Description("所有投资者共享一个操作员连接的中继")]
        OperatorRelay = (byte)'3',
        [Description("未知")]
        UnKnown = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcResponseValueEnum : byte
    {
        [Description("检查成功")]
        Right = (byte)'0',
        [Description("检查失败")]
        Refuse = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTCTradeTypeEnum : byte
    {
        [Description("大宗交易")]
        Block = (byte)'0',
        [Description("期转现")]
        EFP = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMatchTypeEnum : byte
    {
        [Description("基点价值")]
        DV01 = (byte)'1',
        [Description("面值")]
        ParValue = (byte)'2',
    }
    
    



}
