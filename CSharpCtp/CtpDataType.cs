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
        [Description("������")]
        NoEncry = (byte)'0',
        [Description("DES")]
        DES = (byte)'1',
        [Description("3DES")]
        ThreeDES = (byte)'2',
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCZCEUploadFileNameEnum : byte
    {
        [Description("����")]
        O = (byte)'O',
        [Description("�ɽ���")]
        T = (byte)'T',
        [Description("���ȳֱֲ�new")]
        P = (byte)'P',
        [Description("��ƽ���˽��")]
        N = (byte)'N',
        [Description("ƽ�ֱ�")]
        L = (byte)'L',
        [Description("�ʽ��")]
        F = (byte)'F',
        [Description("��ϳֱֲ�")]
        C = (byte)'C',
        [Description("��֤�������")]
        M = (byte)'M',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDCEUploadFileNameEnum : byte
    {
        [Description("����")]
        O = (byte)'O',
        [Description("�ɽ���")]
        T = (byte)'T',
        [Description("�ֱֲ�")]
        P = (byte)'P',
        [Description("�ʽ�����")]
        F = (byte)'F',
        [Description("�Ż���ϳֲ���ϸ��")]
        C = (byte)'C',
        [Description("�ֲ���ϸ��")]
        D = (byte)'D',
        [Description("��֤�������")]
        M = (byte)'M',
        [Description("��Ȩִ�б�")]
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
        [Description("����")]
        Normal = (byte)'0',
        [Description("���ݳɽ����ɱ���")]
        GenOrderByTrade = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcIdCardTypeEnum : byte
    {
        [Description("��֯��������")]
        EID = (byte)'0',
        [Description("�й��������֤")]
        IDCard = (byte)'1',
        [Description("����֤")]
        OfficerIDCard = (byte)'2',
        [Description("����֤")]
        PoliceIDCard = (byte)'3',
        [Description("ʿ��֤")]
        SoldierIDCard = (byte)'4',
        [Description("���ڲ�")]
        HouseholdRegister = (byte)'5',
        [Description("����")]
        Passport = (byte)'6',
        [Description("̨��֤")]
        TaiwanCompatriotIDCard = (byte)'7',
        [Description("����֤")]
        HomeComingCard = (byte)'8',
        [Description("Ӫҵִ�պ�")]
        LicenseNo = (byte)'9',
        [Description("˰��ǼǺ�/������˰ID")]
        TaxNo = (byte)'A',
        [Description("�۰ľ��������ڵ�ͨ��֤")]
        HMMainlandTravelPermit = (byte)'B',
        [Description("̨�����������½ͨ��֤")]
        TwMainlandTravelPermit = (byte)'C',
        [Description("����")]
        DrivingLicense = (byte)'D',
        [Description("�����籣ID")]
        SocialID = (byte)'F',
        [Description("�������֤")]
        LocalID = (byte)'G',
        [Description("��ҵ�Ǽ�֤")]
        BusinessRegistration = (byte)'H',
        [Description("�۰������Ծ������֤")]
        HKMCIDCard = (byte)'I',
        [Description("���п������֤")]
        AccountsPermits = (byte)'J',
        [Description("��������þ���֤")]
        FrgPrmtRdCard = (byte)'K',
        [Description("�ʹܲ�Ʒ������")]
        CptMngPrdLetter = (byte)'L',
        [Description("����֤��")]
        OtherCard = (byte)'x',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorRangeEnum : byte
    {
        [Description("����")]
        All = (byte)'1',
        [Description("Ͷ������")]
        Group = (byte)'2',
        [Description("��һͶ����")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDepartmentRangeEnum : byte
    {
        [Description("����")]
        All = (byte)'1',
        [Description("��֯�ܹ�")]
        Group = (byte)'2',
        [Description("��һͶ����")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataSyncStatusEnum : byte
    {
        [Description("δͬ��")]
        Asynchronous = (byte)'1',
        [Description("ͬ����")]
        Synchronizing = (byte)'2',
        [Description("��ͬ��")]
        Synchronized = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerDataSyncStatusEnum : byte
    {
        [Description("��ͬ��")]
        Synchronized = (byte)'1',
        [Description("ͬ����")]
        Synchronizing = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeConnectStatusEnum : byte
    {
        [Description("û���κ�����")]
        NoConnection = (byte)'1',
        [Description("�Ѿ�������Լ��ѯ����")]
        QryInstrumentSent = (byte)'2',
        [Description("�Ѿ���ȡ��Ϣ")]
        GotInformation = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTraderConnectStatusEnum : byte
    {
        [Description("û���κ�����")]
        NotConnected = (byte)'1',
        [Description("�Ѿ�����")]
        Connected = (byte)'2',
        [Description("�Ѿ�������Լ��ѯ����")]
        QryInstrumentSent = (byte)'3',
        [Description("����˽����")]
        SubPrivateFlow = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFunctionCodeEnum : byte
    {
        [Description("�����첽��")]
        DataAsync = (byte)'1',
        [Description("ǿ���û��ǳ�")]
        ForceUserLogout = (byte)'2',
        [Description("��������û�����")]
        UserPasswordUpdate = (byte)'3',
        [Description("������͹�˾����")]
        BrokerPasswordUpdate = (byte)'4',
        [Description("���Ͷ���߿���")]
        InvestorPasswordUpdate = (byte)'5',
        [Description("��������")]
        OrderInsert = (byte)'6',
        [Description("��������")]
        OrderAction = (byte)'7',
        [Description("ͬ��ϵͳ����")]
        SyncSystemData = (byte)'8',
        [Description("ͬ�����͹�˾����")]
        SyncBrokerData = (byte)'9',
        [Description("����ͬ�����͹�˾����")]
        BachSyncBrokerData = (byte)'A',
        [Description("������ѯ")]
        SuperQuery = (byte)'B',
        [Description("Ԥ�񱨵�����")]
        ParkedOrderInsert = (byte)'C',
        [Description("Ԥ�񱨵�����")]
        ParkedOrderAction = (byte)'D',
        [Description("ͬ����̬����")]
        SyncOTP = (byte)'E',
        [Description("ɾ��δ֪��")]
        DeleteOrder = (byte)'F',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerFunctionCodeEnum : byte
    {
        [Description("ǿ���û��ǳ�")]
        ForceUserLogout = (byte)'1',
        [Description("����û�����")]
        UserPasswordUpdate = (byte)'2',
        [Description("ͬ�����͹�˾����")]
        SyncBrokerData = (byte)'3',
        [Description("����ͬ�����͹�˾����")]
        BachSyncBrokerData = (byte)'4',
        [Description("��������")]
        OrderInsert = (byte)'5',
        [Description("��������")]
        OrderAction = (byte)'6',
        [Description("ȫ����ѯ")]
        AllQuery = (byte)'7',
        [Description("ϵͳ���ܣ�����/�ǳ�/�޸������")]
        log = (byte)'a',
        [Description("������ѯ����ѯ�������ݣ����Լ���������ȳ���")]
        BaseQry = (byte)'b',
        [Description("���ײ�ѯ�����ɽ���ί��")]
        TradeQry = (byte)'c',
        [Description("���׹��ܣ�����������")]
        Trade = (byte)'d',
        [Description("����ת��")]
        Virement = (byte)'e',
        [Description("���ռ��")]
        Risk = (byte)'f',
        [Description("��ѯ/������ѯ�Ự�����˵�")]
        Session = (byte)'g',
        [Description("���֪ͨ����")]
        RiskNoticeCtl = (byte)'h',
        [Description("���֪ͨ����")]
        RiskNotice = (byte)'i',
        [Description("�쿴���͹�˾�ʽ�Ȩ��")]
        BrokerDeposit = (byte)'j',
        [Description("�ʽ��ѯ")]
        QueryFund = (byte)'k',
        [Description("������ѯ")]
        QueryOrder = (byte)'l',
        [Description("�ɽ���ѯ")]
        QueryTrade = (byte)'m',
        [Description("�ֲֲ�ѯ")]
        QueryPosition = (byte)'n',
        [Description("�����ѯ")]
        QueryMarketData = (byte)'o',
        [Description("�û��¼���ѯ")]
        QueryUserEvent = (byte)'p',
        [Description("����֪ͨ��ѯ")]
        QueryRiskNotify = (byte)'q',
        [Description("������ѯ")]
        QueryFundChange = (byte)'r',
        [Description("Ͷ������Ϣ��ѯ")]
        QueryInvestor = (byte)'s',
        [Description("���ױ����ѯ")]
        QueryTradingCode = (byte)'t',
        [Description("ǿƽ")]
        ForceClose = (byte)'u',
        [Description("ѹ������")]
        PressTest = (byte)'v',
        [Description("Ȩ�淴��")]
        RemainCalc = (byte)'w',
        [Description("���ֱֲ�֤��ָ��")]
        NetPositionInd = (byte)'x',
        [Description("����Ԥ��")]
        RiskPredict = (byte)'y',
        [Description("���ݵ���")]
        DataExport = (byte)'z',
        [Description("���ָ������")]
        RiskTargetSetup = (byte)'A',
        [Description("����Ԥ��")]
        MarketDataWarn = (byte)'B',
        [Description("ҵ��֪ͨ��ѯ")]
        QryBizNotice = (byte)'C',
        [Description("ҵ��֪ͨģ������")]
        CfgBizNotice = (byte)'D',
        [Description("ͬ����̬����")]
        SyncOTP = (byte)'E',
        [Description("����ҵ��֪ͨ")]
        SendBizNotice = (byte)'F',
        [Description("���ռ����׼����")]
        CfgRiskLevelStd = (byte)'G',
        [Description("�����ն�Ӧ������")]
        TbCommand = (byte)'H',
        [Description("ɾ��δ֪��")]
        DeleteOrder = (byte)'J',
        [Description("Ԥ�񱨵�����")]
        ParkedOrderInsert = (byte)'K',
        [Description("Ԥ�񱨵�����")]
        ParkedOrderAction = (byte)'L',
        [Description("�ʽ𲻹���������Ȩ")]
        ExecOrderNoCheck = (byte)'M',
        [Description("ָ��")]
        Designate = (byte)'N',
        [Description("֤ȯ����")]
        StockDisposal = (byte)'O',
        [Description("ϯλ�ʽ�Ԥ��")]
        BrokerDepositWarn = (byte)'Q',
        [Description("���Ҳ���Ԥ��")]
        CoverWarn = (byte)'S',
        [Description("��Ȩ����")]
        PreExecOrder = (byte)'T',
        [Description("��Ȩ���շ���")]
        ExecOrderRisk = (byte)'P',
        [Description("�ֲ��޶�Ԥ��")]
        PosiLimitWarn = (byte)'U',
        [Description("�ֲ��޶��ѯ")]
        QryPosiLimit = (byte)'V',
        [Description("����ǩ��ǩ��")]
        FBSign = (byte)'W',
        [Description("����ǩԼ��Լ")]
        FBAccount = (byte)'X',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderActionStatusEnum : byte
    {
        [Description("�Ѿ��ύ")]
        Submitted = (byte)'a',
        [Description("�Ѿ�����")]
        Accepted = (byte)'b',
        [Description("�Ѿ����ܾ�")]
        Rejected = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderStatusEnum : byte
    {
        [Description("ȫ���ɽ�")]
        AllTraded = (byte)'0',
        [Description("���ֳɽ����ڶ�����")]
        PartTradedQueueing = (byte)'1',
        [Description("���ֳɽ����ڶ�����")]
        PartTradedNotQueueing = (byte)'2',
        [Description("δ�ɽ����ڶ�����")]
        NoTradeQueueing = (byte)'3',
        [Description("δ�ɽ����ڶ�����")]
        NoTradeNotQueueing = (byte)'4',
        [Description("����")]
        Canceled = (byte)'5',
        [Description("δ֪")]
        Unknown = (byte)'a',
        [Description("��δ����")]
        NotTouched = (byte)'b',
        [Description("�Ѵ���")]
        Touched = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderSubmitStatusEnum : byte
    {
        [Description("�Ѿ��ύ")]
        InsertSubmitted = (byte)'0',
        [Description("�����Ѿ��ύ")]
        CancelSubmitted = (byte)'1',
        [Description("�޸��Ѿ��ύ")]
        ModifySubmitted = (byte)'2',
        [Description("�Ѿ�����")]
        Accepted = (byte)'3',
        [Description("�����Ѿ����ܾ�")]
        InsertRejected = (byte)'4',
        [Description("�����Ѿ����ܾ�")]
        CancelRejected = (byte)'5',
        [Description("�ĵ��Ѿ����ܾ�")]
        ModifyRejected = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionDateEnum : byte
    {
        [Description("���ճֲ�")]
        Today = (byte)'1',
        [Description("��ʷ�ֲ�")]
        History = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionDateTypeEnum : byte
    {
        [Description("ʹ����ʷ�ֲ�")]
        UseHistory = (byte)'1',
        [Description("��ʹ����ʷ�ֲ�")]
        NoUseHistory = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradingRoleEnum : byte
    {
        [Description("����")]
        Broker = (byte)'1',
        [Description("��Ӫ")]
        Host = (byte)'2',
        [Description("������")]
        Maker = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductClassEnum : byte
    {
        [Description("�ڻ�")]
        Futures = (byte)'1',
        [Description("�ڻ���Ȩ")]
        Options = (byte)'2',
        [Description("���")]
        Combination = (byte)'3',
        [Description("����")]
        Spot = (byte)'4',
        [Description("��ת��")]
        EFP = (byte)'5',
        [Description("�ֻ���Ȩ")]
        SpotOption = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstLifePhaseEnum : byte
    {
        [Description("δ����")]
        NotStart = (byte)'0',
        [Description("����")]
        Started = (byte)'1',
        [Description("ͣ��")]
        Pause = (byte)'2',
        [Description("����")]
        Expired = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDirectionEnum : byte
    {
        [Description("��")]
        Buy = (byte)'0',
        [Description("��")]
        Sell = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPositionTypeEnum : byte
    {
        [Description("���ֲ�")]
        Net = (byte)'1',
        [Description("�ۺϳֲ�")]
        Gross = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPosiDirectionEnum : byte
    {
        [Description("��")]
        Net = (byte)'1',
        [Description("��ͷ")]
        Long = (byte)'2',
        [Description("��ͷ")]
        Short = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysSettlementStatusEnum : byte
    {
        [Description("����Ծ")]
        NonActive = (byte)'1',
        [Description("����")]
        Startup = (byte)'2',
        [Description("����")]
        Operating = (byte)'3',
        [Description("����")]
        Settlement = (byte)'4',
        [Description("�������")]
        SettlementFinished = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRatioAttrEnum : byte
    {
        [Description("���׷���")]
        Trade = (byte)'0',
        [Description("�������")]
        Settlement = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHedgeFlagEnum : byte
    {
        [Description("Ͷ��")]
        Speculation = (byte)'1',
        [Description("����")]
        Arbitrage = (byte)'2',
        [Description("�ױ�")]
        Hedge = (byte)'3',
        [Description("������")]
        MarketMaker = (byte)'5',
        [Description("��һ��Ͷ���ڶ����ױ� ������ר��")]
        SpecHedge = (byte)'6',
        [Description("��һ���ױ��ڶ���Ͷ��  ������ר��")]
        HedgeSpec = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBillHedgeFlagEnum : byte
    {
        [Description("Ͷ��")]
        Speculation = (byte)'1',
        [Description("����")]
        Arbitrage = (byte)'2',
        [Description("�ױ�")]
        Hedge = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientIDTypeEnum : byte
    {
        [Description("Ͷ��")]
        Speculation = (byte)'1',
        [Description("����")]
        Arbitrage = (byte)'2',
        [Description("�ױ�")]
        Hedge = (byte)'3',
        [Description("������")]
        MarketMaker = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderPriceTypeEnum : byte
    {
        [Description("�����")]
        AnyPrice = (byte)'1',
        [Description("�޼�")]
        LimitPrice = (byte)'2',
        [Description("���ż�")]
        BestPrice = (byte)'3',
        [Description("���¼�")]
        LastPrice = (byte)'4',
        [Description("���¼۸����ϸ�1��ticks")]
        LastPricePlusOneTicks = (byte)'5',
        [Description("���¼۸����ϸ�2��ticks")]
        LastPricePlusTwoTicks = (byte)'6',
        [Description("���¼۸����ϸ�3��ticks")]
        LastPricePlusThreeTicks = (byte)'7',
        [Description("��һ��")]
        AskPrice1 = (byte)'8',
        [Description("��һ�۸����ϸ�1��ticks")]
        AskPrice1PlusOneTicks = (byte)'9',
        [Description("��һ�۸����ϸ�2��ticks")]
        AskPrice1PlusTwoTicks = (byte)'A',
        [Description("��һ�۸����ϸ�3��ticks")]
        AskPrice1PlusThreeTicks = (byte)'B',
        [Description("��һ��")]
        BidPrice1 = (byte)'C',
        [Description("��һ�۸����ϸ�1��ticks")]
        BidPrice1PlusOneTicks = (byte)'D',
        [Description("��һ�۸����ϸ�2��ticks")]
        BidPrice1PlusTwoTicks = (byte)'E',
        [Description("��һ�۸����ϸ�3��ticks")]
        BidPrice1PlusThreeTicks = (byte)'F',
        [Description("�嵵��")]
        FiveLevelPrice = (byte)'G',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOffsetFlagEnum : byte
    {
        [Description("����")]
        Open = (byte)'0',
        [Description("ƽ��")]
        Close = (byte)'1',
        [Description("ǿƽ")]
        ForceClose = (byte)'2',
        [Description("ƽ��")]
        CloseToday = (byte)'3',
        [Description("ƽ��")]
        CloseYesterday = (byte)'4',
        [Description("ǿ��")]
        ForceOff = (byte)'5',
        [Description("����ǿƽ")]
        LocalForceClose = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForceCloseReasonEnum : byte
    {
        [Description("��ǿƽ")]
        NotForceClose = (byte)'0',
        [Description("�ʽ���")]
        LackDeposit = (byte)'1',
        [Description("�ͻ�����")]
        ClientOverPositionLimit = (byte)'2',
        [Description("��Ա����")]
        MemberOverPositionLimit = (byte)'3',
        [Description("�ֲַ�������")]
        NotMultiple = (byte)'4',
        [Description("Υ��")]
        Violation = (byte)'5',
        [Description("����")]
        Other = (byte)'6',
        [Description("��Ȼ���ٽ�����")]
        PersonDeliv = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderTypeEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("��������")]
        DeriveFromQuote = (byte)'1',
        [Description("�������")]
        DeriveFromCombination = (byte)'2',
        [Description("��ϱ���")]
        Combination = (byte)'3',
        [Description("������")]
        ConditionalOrder = (byte)'4',
        [Description("������")]
        Swap = (byte)'5',
        [Description("���ڽ��׳ɽ�����")]
        DeriveFromBlockTrade = (byte)'6',
        [Description("��ת�ֳɽ�����")]
        DeriveFromEFPTrade = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTimeConditionEnum : byte
    {
        [Description("������ɣ�������")]
        IOC = (byte)'1',
        [Description("������Ч")]
        GFS = (byte)'2',
        [Description("������Ч")]
        GFD = (byte)'3',
        [Description("ָ������ǰ��Ч")]
        GTD = (byte)'4',
        [Description("����ǰ��Ч")]
        GTC = (byte)'5',
        [Description("���Ͼ�����Ч")]
        GFA = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVolumeConditionEnum : byte
    {
        [Description("�κ�����")]
        AV = (byte)'1',
        [Description("��С����")]
        MV = (byte)'2',
        [Description("ȫ������")]
        CV = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcContingentConditionEnum : byte
    {
        [Description("����")]
        Immediately = (byte)'1',
        [Description("ֹ��")]
        Touch = (byte)'2',
        [Description("ֹӮ")]
        TouchProfit = (byte)'3',
        [Description("Ԥ��")]
        ParkedOrder = (byte)'4',
        [Description("���¼۴���������")]
        LastPriceGreaterThanStopPrice = (byte)'5',
        [Description("���¼۴��ڵ���������")]
        LastPriceGreaterEqualStopPrice = (byte)'6',
        [Description("���¼�С��������")]
        LastPriceLesserThanStopPrice = (byte)'7',
        [Description("���¼�С�ڵ���������")]
        LastPriceLesserEqualStopPrice = (byte)'8',
        [Description("��һ�۴���������")]
        AskPriceGreaterThanStopPrice = (byte)'9',
        [Description("��һ�۴��ڵ���������")]
        AskPriceGreaterEqualStopPrice = (byte)'A',
        [Description("��һ��С��������")]
        AskPriceLesserThanStopPrice = (byte)'B',
        [Description("��һ��С�ڵ���������")]
        AskPriceLesserEqualStopPrice = (byte)'C',
        [Description("��һ�۴���������")]
        BidPriceGreaterThanStopPrice = (byte)'D',
        [Description("��һ�۴��ڵ���������")]
        BidPriceGreaterEqualStopPrice = (byte)'E',
        [Description("��һ��С��������")]
        BidPriceLesserThanStopPrice = (byte)'F',
        [Description("��һ��С�ڵ���������")]
        BidPriceLesserEqualStopPrice = (byte)'H',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActionFlagEnum : byte
    {
        [Description("ɾ��")]
        Delete = (byte)'0',
        [Description("�޸�")]
        Modify = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradingRightEnum : byte
    {
        [Description("���Խ���")]
        Allow = (byte)'0',
        [Description("ֻ��ƽ��")]
        CloseOnly = (byte)'1',
        [Description("���ܽ���")]
        Forbidden = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrderSourceEnum : byte
    {
        [Description("���Բ�����")]
        Participant = (byte)'0',
        [Description("���Թ���Ա")]
        Administrator = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeTypeEnum : byte
    {
        [Description("��ϳֲֲ��Ϊ��һ�ֲ�,��ʼ����Ӧ���������͵ĳֲ�")]
        SplitCombination = (byte)'#',
        [Description("��ͨ�ɽ�")]
        Common = (byte)'0',
        [Description("��Ȩִ��")]
        OptionsExecution = (byte)'1',
        [Description("OTC�ɽ�")]
        OTC = (byte)'2',
        [Description("��ת�������ɽ�")]
        EFPDerived = (byte)'3',
        [Description("��������ɽ�")]
        CombinationDerived = (byte)'4',
        [Description("���ڽ��׳ɽ�")]
        BlockTrade = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPriceSourceEnum : byte
    {
        [Description("ǰ�ɽ���")]
        LastPrice = (byte)'0',
        [Description("��ί�м�")]
        Buy = (byte)'1',
        [Description("��ί�м�")]
        Sell = (byte)'2',
        [Description("����ɽ���")]
        OTC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstrumentStatusEnum : byte
    {
        [Description("����ǰ")]
        BeforeTrading = (byte)'0',
        [Description("�ǽ���")]
        NoTrading = (byte)'1',
        [Description("��������")]
        Continous = (byte)'2',
        [Description("���Ͼ��۱���")]
        AuctionOrdering = (byte)'3',
        [Description("���Ͼ��ۼ۸�ƽ��")]
        AuctionBalance = (byte)'4',
        [Description("���Ͼ��۴��")]
        AuctionMatch = (byte)'5',
        [Description("����")]
        Closed = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstStatusEnterReasonEnum : byte
    {
        [Description("�Զ��л�")]
        Automatic = (byte)'1',
        [Description("�ֶ��л�")]
        Manual = (byte)'2',
        [Description("�۶�")]
        Fuse = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBatchStatusEnum : byte
    {
        [Description("δ�ϴ�")]
        NoUpload = (byte)'1',
        [Description("���ϴ�")]
        Uploaded = (byte)'2',
        [Description("���ʧ��")]
        Failed = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnStyleEnum : byte
    {
        [Description("������Ʒ��")]
        All = (byte)'1',
        [Description("��Ʒ��")]
        ByProduct = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnPatternEnum : byte
    {
        [Description("���ɽ�����")]
        ByVolume = (byte)'1',
        [Description("������������")]
        ByFeeOnHand = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnLevelEnum : byte
    {
        [Description("����1")]
        Level1 = (byte)'1',
        [Description("����2")]
        Level2 = (byte)'2',
        [Description("����3")]
        Level3 = (byte)'3',
        [Description("����4")]
        Level4 = (byte)'4',
        [Description("����5")]
        Level5 = (byte)'5',
        [Description("����6")]
        Level6 = (byte)'6',
        [Description("����7")]
        Level7 = (byte)'7',
        [Description("����8")]
        Level8 = (byte)'8',
        [Description("����9")]
        Level9 = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReturnStandardEnum : byte
    {
        [Description("�ֽ׶η���")]
        ByPeriod = (byte)'1',
        [Description("��ĳһ��׼")]
        ByStandard = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMortgageTypeEnum : byte
    {
        [Description("�ʳ�")]
        Out = (byte)'0',
        [Description("����")]
        In = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorSettlementParamIDEnum : byte
    {
        [Description("��Ѻ����")]
        MortgageRatio = (byte)'4',
        [Description("��֤���㷨")]
        MarginWay = (byte)'5',
        [Description("���㵥����Ƿ������Ѻ")]
        BillDeposit = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeSettlementParamIDEnum : byte
    {
        [Description("��Ѻ����")]
        MortgageRatio = (byte)'1',
        [Description("�����ʽ�����")]
        OtherFundItem = (byte)'2',
        [Description("�����ʽ��뽻���������")]
        OtherFundImport = (byte)'3',
        [Description("�н���������Ϳ��ý��")]
        CFFEXMinPrepa = (byte)'6',
        [Description("֣�������㷽ʽ")]
        CZCESettlementType = (byte)'7',
        [Description("������������������ȡ��ʽ")]
        ExchDelivFeeMode = (byte)'9',
        [Description("Ͷ���߽�����������ȡ��ʽ")]
        DelivFeeMode = (byte)'0',
        [Description("֣������ϳֱֲ�֤����ȡ��ʽ")]
        CZCEComMarginType = (byte)'A',
        [Description("������������֤���Ƿ��Ż�")]
        DceComMarginType = (byte)'B',
        [Description("��ֵ��Ȩ��֤���Żݱ���")]
        OptOutDisCountRate = (byte)'a',
        [Description("��ͱ���ϵ��")]
        OptMiniGuarantee = (byte)'b',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemParamIDEnum : byte
    {
        [Description("Ͷ���ߴ�����С����")]
        InvestorIDMinLength = (byte)'1',
        [Description("Ͷ�����ʺŴ�����С����")]
        AccountIDMinLength = (byte)'2',
        [Description("Ͷ���߿���Ĭ�ϵ�¼Ȩ��")]
        UserRightLogon = (byte)'3',
        [Description("Ͷ���߽��׽��㵥�ɽ����ܷ�ʽ")]
        SettlementBillTrade = (byte)'4',
        [Description("ͳһ�������½��ױ��뷽ʽ")]
        TradingCode = (byte)'5',
        [Description("�����Ƿ��жϴ���δ���˵ĳ����ͷ����ʽ�")]
        CheckFund = (byte)'6',
        [Description("�Ƿ�����������ģ������Ȩ��")]
        CommModelRight = (byte)'7',
        [Description("�Ƿ����ñ�֤����ģ������Ȩ��")]
        MarginModelRight = (byte)'9',
        [Description("�Ƿ�淶�û����ܼ���")]
        IsStandardActive = (byte)'8',
        [Description("�ϴ��Ľ����������ļ�·��")]
        UploadSettlementFile = (byte)'U',
        [Description("�ϱ���֤���������ļ�·��")]
        DownloadCSRCFile = (byte)'D',
        [Description("���ɵĽ��㵥�ļ�·��")]
        SettlementBillFile = (byte)'S',
        [Description("֤����ļ���ʶ")]
        CSRCOthersFile = (byte)'C',
        [Description("Ͷ������Ƭ·��")]
        InvestorPhoto = (byte)'P',
        [Description("ȫ�ᾭ�͹�˾�ϴ��ļ�·��")]
        CSRCData = (byte)'R',
        [Description("��������¼�뷽ʽ")]
        InvestorPwdModel = (byte)'I',
        [Description("Ͷ�����н��������ļ�����·��")]
        CFFEXInvestorSettleFile = (byte)'F',
        [Description("Ͷ���ߴ�����뷽ʽ")]
        InvestorIDType = (byte)'a',
        [Description("���߻����Ȩ��")]
        FreezeMaxReMain = (byte)'r',
        [Description("��������ز���ʵʱ�ϳ�����")]
        IsSync = (byte)'A',
        [Description("�������Ȩ������")]
        RelieveOpenLimit = (byte)'O',
        [Description("�Ƿ�淶�û���������")]
        IsStandardFreeze = (byte)'X',
        [Description("֣�����Ƿ񿪷�����Ʒ���ױ�����")]
        CZCENormalProductHedge = (byte)'B',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeParamIDEnum : byte
    {
        [Description("ϵͳ�����㷨")]
        EncryptionStandard = (byte)'E',
        [Description("ϵͳ�����㷨")]
        RiskMode = (byte)'R',
        [Description("ϵͳ�����㷨�Ƿ�ȫ�� 0-�� 1-��")]
        RiskModeGlobal = (byte)'G',
        [Description("��������㷨")]
        modeEncode = (byte)'P',
        [Description("�۸�С��λ������")]
        tickMode = (byte)'T',
        [Description("�û����Ự��")]
        SingleUserSessionMaxNum = (byte)'S',
        [Description("���������¼ʧ����")]
        LoginFailMaxNum = (byte)'L',
        [Description("�Ƿ�ǿ����֤")]
        IsAuthForce = (byte)'A',
        [Description("�Ƿ񶳽�֤ȯ�ֲ�")]
        IsPosiFreeze = (byte)'F',
        [Description("�Ƿ��޲�")]
        IsPosiLimit = (byte)'M',
        [Description("֣����ѯ��ʱ����")]
        ForQuoteTimeInterval = (byte)'Q',
        [Description("�Ƿ��ڻ��޲�")]
        IsFuturePosiLimit = (byte)'B',
        [Description("�Ƿ��ڻ��µ�Ƶ������")]
        IsFutureOrderFreq = (byte)'C',
        [Description("��Ȩ�����Ƿ����ӯ��")]
        IsExecOrderProfit = (byte)'H',
        [Description("���ڿ����Ƿ���֤�������п����Ƿ���Ԥ�������˻�")]
        IsCheckBankAcc = (byte)'I',
        [Description("����������޸�����")]
        PasswordDeadLine = (byte)'J',
        [Description("ǿ����У��")]
        IsStrongPassword = (byte)'K',
        [Description("�����ʽ���Ѻ��")]
        BalanceMorgage = (byte)'a',
        [Description("��С���볤��")]
        MinPwdLen = (byte)'O',
        [Description("IP��������½ʧ�ܴ���")]
        LoginFailMaxNumForIP = (byte)'U',
        [Description("������Ч��")]
        PasswordPeriod = (byte)'V',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileIDEnum : byte
    {
        [Description("�ʽ�����")]
        SettlementFund = (byte)'F',
        [Description("�ɽ�����")]
        Trade = (byte)'T',
        [Description("Ͷ���ֲ߳�����")]
        InvestorPosition = (byte)'P',
        [Description("Ͷ���߷����ʽ�����")]
        SubEntryFund = (byte)'O',
        [Description("��ϳֲ�����")]
        CZCECombinationPos = (byte)'C',
        [Description("�ϱ���֤������������")]
        CSRCData = (byte)'R',
        [Description("֣����ƽ���˽�����")]
        CZCEClose = (byte)'L',
        [Description("֣������ƽ���˽�����")]
        CZCENoClose = (byte)'N',
        [Description("�ֲ���ϸ����")]
        PositionDtl = (byte)'D',
        [Description("��Ȩִ���ļ�")]
        OptionStrike = (byte)'S',
        [Description("����۱ȶ��ļ�")]
        SettlementPriceComparison = (byte)'M',
        [Description("�������ǳֱֲ䶯��ϸ")]
        NonTradePosChange = (byte)'B',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileTypeEnum : byte
    {
        [Description("����")]
        Settlement = (byte)'0',
        [Description("�˶�")]
        Check = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileFormatEnum : byte
    {
        [Description("�ı��ļ�(.txt)")]
        Txt = (byte)'0',
        [Description("ѹ���ļ�(.zip)")]
        Zip = (byte)'1',
        [Description("DBF�ļ�(.dbf)")]
        DBF = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileUploadStatusEnum : byte
    {
        [Description("�ϴ��ɹ�")]
        SucceedUpload = (byte)'1',
        [Description("�ϴ�ʧ��")]
        FailedUpload = (byte)'2',
        [Description("����ɹ�")]
        SucceedLoad = (byte)'3',
        [Description("���벿�ֳɹ�")]
        PartSucceedLoad = (byte)'4',
        [Description("����ʧ��")]
        FailedLoad = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferDirectionEnum : byte
    {
        [Description("�Ƴ�")]
        Out = (byte)'0',
        [Description("����")]
        In = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSpecialCreateRuleEnum : byte
    {
        [Description("û�����ⴴ������")]
        NoSpecialRule = (byte)'0',
        [Description("����������")]
        NoSpringFestival = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBasisPriceTypeEnum : byte
    {
        [Description("��һ��Լ�����")]
        LastSettlement = (byte)'1',
        [Description("��һ��Լ���̼�")]
        LaseClose = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductLifePhaseEnum : byte
    {
        [Description("��Ծ")]
        Active = (byte)'1',
        [Description("����Ծ")]
        NonActive = (byte)'2',
        [Description("ע��")]
        Canceled = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDeliveryModeEnum : byte
    {
        [Description("�ֽ𽻸�")]
        CashDeliv = (byte)'1',
        [Description("ʵ�ｻ��")]
        CommodityDeliv = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundIOTypeEnum : byte
    {
        [Description("�����")]
        FundIO = (byte)'1',
        [Description("����ת��")]
        Transfer = (byte)'2',
        [Description("���ڻ���")]
        SwapCurrency = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundTypeEnum : byte
    {
        [Description("���д��")]
        Deposite = (byte)'1',
        [Description("�����ʽ�")]
        ItemFund = (byte)'2',
        [Description("��˾����")]
        Company = (byte)'3',
        [Description("�ʽ���ת")]
        InnerTransfer = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundDirectionEnum : byte
    {
        [Description("���")]
        In = (byte)'1',
        [Description("����")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundStatusEnum : byte
    {
        [Description("��¼��")]
        Record = (byte)'1',
        [Description("�Ѹ���")]
        Check = (byte)'2',
        [Description("�ѳ���")]
        Charge = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPublishStatusEnum : byte
    {
        [Description("δ����")]
        None = (byte)'1',
        [Description("���ڷ���")]
        Publishing = (byte)'2',
        [Description("�ѷ���")]
        Published = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemStatusEnum : byte
    {
        [Description("����Ծ")]
        NonActive = (byte)'1',
        [Description("����")]
        Startup = (byte)'2',
        [Description("���׿�ʼ��ʼ��")]
        Initialize = (byte)'3',
        [Description("������ɳ�ʼ��")]
        Initialized = (byte)'4',
        [Description("���п�ʼ")]
        Close = (byte)'5',
        [Description("�������")]
        Closed = (byte)'6',
        [Description("����")]
        Settlement = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementStatusEnum : byte
    {
        [Description("��ʼ")]
        Initialize = (byte)'0',
        [Description("������")]
        Settlementing = (byte)'1',
        [Description("�ѽ���")]
        Settlemented = (byte)'2',
        [Description("�������")]
        Finished = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorTypeEnum : byte
    {
        [Description("��Ȼ��")]
        Person = (byte)'0',
        [Description("����")]
        Company = (byte)'1',
        [Description("Ͷ�ʻ���")]
        Fund = (byte)'2',
        [Description("���ⷨ��")]
        SpecialOrgan = (byte)'3',
        [Description("�ʹܻ�")]
        Asset = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerTypeEnum : byte
    {
        [Description("���׻�Ա")]
        Trade = (byte)'0',
        [Description("���׽����Ա")]
        TradeSettle = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskLevelEnum : byte
    {
        [Description("�ͷ��տͻ�")]
        Low = (byte)'1',
        [Description("��ͨ�ͻ�")]
        Normal = (byte)'2',
        [Description("��ע�ͻ�")]
        Focus = (byte)'3',
        [Description("���տͻ�")]
        Risk = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFeeAcceptStyleEnum : byte
    {
        [Description("��������ȡ")]
        ByTrade = (byte)'1',
        [Description("��������ȡ")]
        ByDeliv = (byte)'2',
        [Description("����")]
        None = (byte)'3',
        [Description("��ָ����������ȡ")]
        FixFee = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPasswordTypeEnum : byte
    {
        [Description("��������")]
        Trade = (byte)'1',
        [Description("�ʽ�����")]
        Account = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAlgorithmEnum : byte
    {
        [Description("��ӯ����������")]
        All = (byte)'1',
        [Description("��ӯ���ƣ�������")]
        OnlyLost = (byte)'2',
        [Description("��ӯ�ƣ���������")]
        OnlyGain = (byte)'3',
        [Description("��ӯ������������")]
        None = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcIncludeCloseProfitEnum : byte
    {
        [Description("����ƽ��ӯ��")]
        Include = (byte)'0',
        [Description("������ƽ��ӯ��")]
        NotInclude = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAllWithoutTradeEnum : byte
    {
        [Description("�޲��޳ɽ����ܿ����������")]
        Enable = (byte)'0',
        [Description("�ܿ����������")]
        Disable = (byte)'2',
        [Description("�޲ֲ��ܿ����������")]
        NoHoldEnable = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFuturePwdFlagEnum : byte
    {
        [Description("���˶�")]
        UnCheck = (byte)'0',
        [Description("�˶�")]
        Check = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferTypeEnum : byte
    {
        [Description("����ת�ڻ�")]
        BankToFuture = (byte)'0',
        [Description("�ڻ�ת����")]
        FutureToBank = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferValidFlagEnum : byte
    {
        [Description("��Ч��ʧ��")]
        Invalid = (byte)'0',
        [Description("��Ч")]
        Valid = (byte)'1',
        [Description("����")]
        Reverse = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReasonEnum : byte
    {
        [Description("��")]
        CD = (byte)'0',
        [Description("�ʽ���;")]
        ZT = (byte)'1',
        [Description("����")]
        QT = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSexEnum : byte
    {
        [Description("δ֪")]
        None = (byte)'0',
        [Description("��")]
        Man = (byte)'1',
        [Description("Ů")]
        Woman = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserTypeEnum : byte
    {
        [Description("Ͷ����")]
        Investor = (byte)'0',
        [Description("����Ա")]
        Operator = (byte)'1',
        [Description("����Ա")]
        SuperUser = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRateTypeEnum : byte
    {
        [Description("��֤����")]
        MarginRate = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcNoteTypeEnum : byte
    {
        [Description("���׽��㵥")]
        TradeSettleBill = (byte)'1',
        [Description("���׽����±�")]
        TradeSettleMonth = (byte)'2',
        [Description("׷�ӱ�֤��֪ͨ��")]
        CallMarginNotes = (byte)'3',
        [Description("ǿ��ƽ��֪ͨ��")]
        ForceCloseNotes = (byte)'4',
        [Description("�ɽ�֪ͨ��")]
        TradeNotes = (byte)'5',
        [Description("����֪ͨ��")]
        DelivNotes = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementStyleEnum : byte
    {
        [Description("���ն���")]
        Day = (byte)'1',
        [Description("��ʶԳ�")]
        Volume = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettlementBillTypeEnum : byte
    {
        [Description("�ձ�")]
        Day = (byte)'0',
        [Description("�±�")]
        Month = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserRightTypeEnum : byte
    {
        [Description("��¼")]
        Logon = (byte)'1',
        [Description("����ת��")]
        Transfer = (byte)'2',
        [Description("�ʼĽ��㵥")]
        EMail = (byte)'3',
        [Description("������㵥")]
        Fax = (byte)'4',
        [Description("������")]
        ConditionOrder = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginPriceTypeEnum : byte
    {
        [Description("������")]
        PreSettlementPrice = (byte)'1',
        [Description("���¼�")]
        SettlementPrice = (byte)'2',
        [Description("�ɽ�����")]
        AveragePrice = (byte)'3',
        [Description("���ּ�")]
        OpenPrice = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBillGenStatusEnum : byte
    {
        [Description("δ����")]
        None = (byte)'0',
        [Description("������")]
        NoGenerated = (byte)'1',
        [Description("������")]
        Generated = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAlgoTypeEnum : byte
    {
        [Description("�ֲִ����㷨")]
        HandlePositionAlgo = (byte)'1',
        [Description("Ѱ�ұ�֤�����㷨")]
        FindMarginRateAlgo = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHandlePositionAlgoIDEnum : byte
    {
        [Description("����")]
        Base = (byte)'1',
        [Description("������Ʒ������")]
        DCE = (byte)'2',
        [Description("֣����Ʒ������")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFindMarginRateAlgoIDEnum : byte
    {
        [Description("����")]
        Base = (byte)'1',
        [Description("������Ʒ������")]
        DCE = (byte)'2',
        [Description("֣����Ʒ������")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHandleTradingAccountAlgoIDEnum : byte
    {
        [Description("����")]
        Base = (byte)'1',
        [Description("������Ʒ������")]
        DCE = (byte)'2',
        [Description("֣����Ʒ������")]
        CZCE = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPersonTypeEnum : byte
    {
        [Description("ָ���µ���")]
        Order = (byte)'1',
        [Description("������Ȩ��")]
        Open = (byte)'2',
        [Description("�ʽ������")]
        Fund = (byte)'3',
        [Description("���㵥ȷ����")]
        Settlement = (byte)'4',
        [Description("����")]
        Company = (byte)'5',
        [Description("���˴���")]
        Corporation = (byte)'6',
        [Description("Ͷ������ϵ��")]
        LinkMan = (byte)'7',
        [Description("�ֻ������ʲ�������")]
        Ledger = (byte)'8',
        [Description("�У���������")]
        Trustee = (byte)'9',
        [Description("�У������ܻ������˴���")]
        TrusteeCorporation = (byte)'A',
        [Description("�У������ܻ���������Ȩ��")]
        TrusteeOpen = (byte)'B',
        [Description("�У������ܻ�����ϵ��")]
        TrusteeContact = (byte)'C',
        [Description("������Ȼ�˲ο�֤��")]
        ForeignerRefer = (byte)'D',
        [Description("���˴���ο�֤��")]
        CorporationRefer = (byte)'E',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcQueryInvestorRangeEnum : byte
    {
        [Description("����")]
        All = (byte)'1',
        [Description("��ѯ����")]
        Group = (byte)'2',
        [Description("��һͶ����")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInvestorRiskStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'1',
        [Description("����")]
        Warn = (byte)'2',
        [Description("׷��")]
        Call = (byte)'3',
        [Description("ǿƽ")]
        Force = (byte)'4',
        [Description("�쳣")]
        Exception = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserEventTypeEnum : byte
    {
        [Description("��¼")]
        Login = (byte)'1',
        [Description("�ǳ�")]
        Logout = (byte)'2',
        [Description("���׳ɹ�")]
        Trading = (byte)'3',
        [Description("����ʧ��")]
        TradingError = (byte)'4',
        [Description("�޸�����")]
        UpdatePassword = (byte)'5',
        [Description("�ͻ�����֤")]
        Authenticate = (byte)'6',
        [Description("����")]
        Other = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCloseStyleEnum : byte
    {
        [Description("�ȿ���ƽ")]
        Close = (byte)'0',
        [Description("��ƽ����ƽ��")]
        CloseToday = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStatModeEnum : byte
    {
        [Description("----")]
        Non = (byte)'0',
        [Description("����Լͳ��")]
        Instrument = (byte)'1',
        [Description("����Ʒͳ��")]
        Product = (byte)'2',
        [Description("��Ͷ����ͳ��")]
        Investor = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcParkedOrderStatusEnum : byte
    {
        [Description("δ����")]
        NotSend = (byte)'1',
        [Description("�ѷ���")]
        Send = (byte)'2',
        [Description("��ɾ��")]
        Deleted = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirDealStatusEnum : byte
    {
        [Description("���ڴ���")]
        Dealing = (byte)'1',
        [Description("����ɹ�")]
        DeaclSucceed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrgSystemIDEnum : byte
    {
        [Description("�ۺϽ���ƽ̨")]
        Standard = (byte)'0',
        [Description("��ʢϵͳ")]
        ESunny = (byte)'1',
        [Description("���˴�V6ϵͳ")]
        KingStarV6 = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirTradeStatusEnum : byte
    {
        [Description("����������")]
        NaturalDeal = (byte)'0',
        [Description("�ɹ�����")]
        SucceedEnd = (byte)'1',
        [Description("ʧ�ܽ���")]
        FailedEND = (byte)'2',
        [Description("�쳣��")]
        Exception = (byte)'3',
        [Description("���˹��쳣����")]
        ManualDeal = (byte)'4',
        [Description("ͨѶ�쳣 �����˹�����")]
        MesException = (byte)'5',
        [Description("ϵͳ�������˹�����")]
        SysException = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirBankAccTypeEnum : byte
    {
        [Description("����")]
        BankBook = (byte)'1',
        [Description("���")]
        BankCard = (byte)'2',
        [Description("���ÿ�")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirementStatusEnum : byte
    {
        [Description("����")]
        Natural = (byte)'0',
        [Description("����")]
        Canceled = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcVirementAvailAbilityEnum : byte
    {
        [Description("δȷ��")]
        NoAvailAbility = (byte)'0',
        [Description("��Ч")]
        AvailAbility = (byte)'1',
        [Description("����")]
        Repeal = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAMLGenStatusEnum : byte
    {
        [Description("��������")]
        Program = (byte)'0',
        [Description("�˹�����")]
        HandWork = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCFMMCKeyKindEnum : byte
    {
        [Description("�����������")]
        REQUEST = (byte)'R',
        [Description("CFMMC�Զ�����")]
        AUTO = (byte)'A',
        [Description("CFMMC�ֶ�����")]
        MANUAL = (byte)'M',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCertificationTypeEnum : byte
    {
        [Description("���֤")]
        IDCard = (byte)'0',
        [Description("����")]
        Passport = (byte)'1',
        [Description("����֤")]
        OfficerIDCard = (byte)'2',
        [Description("ʿ��֤")]
        SoldierIDCard = (byte)'3',
        [Description("����֤")]
        HomeComingCard = (byte)'4',
        [Description("���ڲ�")]
        HouseholdRegister = (byte)'5',
        [Description("Ӫҵִ�պ�")]
        LicenseNo = (byte)'6',
        [Description("��֯��������֤")]
        InstitutionCodeCard = (byte)'7',
        [Description("��ʱӪҵִ�պ�")]
        TempLicenseNo = (byte)'8',
        [Description("������ҵ�Ǽ�֤��")]
        NoEnterpriseLicenseNo = (byte)'9',
        [Description("����֤��")]
        OtherCard = (byte)'x',
        [Description("���ܲ�������")]
        SuperDepAgree = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileBusinessCodeEnum : byte
    {
        [Description("����")]
        Others = (byte)'0',
        [Description("ת�˽�����ϸ����")]
        TransferDetails = (byte)'1',
        [Description("�ͻ��˻�״̬����")]
        CustAccStatus = (byte)'2',
        [Description("�˻��ཻ����ϸ����")]
        AccountTradeDetails = (byte)'3',
        [Description("�ڻ��˻���Ϣ�����ϸ����")]
        FutureAccountChangeInfoDetails = (byte)'4',
        [Description("�ͻ��ʽ�̨�������ϸ����")]
        CustMoneyDetail = (byte)'5',
        [Description("�ͻ�������Ϣ��ϸ����")]
        CustCancelAccountInfo = (byte)'6',
        [Description("�ͻ��ʽ������˽��")]
        CustMoneyResult = (byte)'7',
        [Description("���������쳣����ļ�")]
        OthersExceptionResult = (byte)'8',
        [Description("�ͻ���Ϣ������ϸ")]
        CustInterestNetMoneyDetails = (byte)'9',
        [Description("�ͻ��ʽ�����ϸ")]
        CustMoneySendAndReceiveDetails = (byte)'a',
        [Description("���˴�������ʽ��ջ���")]
        CorporationMoneyTotal = (byte)'b',
        [Description("������ʽ��ջ���")]
        MainbodyMoneyTotal = (byte)'c',
        [Description("�ܷ�ƽ��������")]
        MainPartMonitorData = (byte)'d',
        [Description("������б��������")]
        PreparationMoney = (byte)'e',
        [Description("Э���������ʽ�������")]
        BankMoneyMonitorData = (byte)'f',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCashExchangeCodeEnum : byte
    {
        [Description("��")]
        Exchange = (byte)'1',
        [Description("��")]
        Cash = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcYesNoIndicatorEnum : byte
    {
        [Description("��")]
        Yes = (byte)'0',
        [Description("��")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBanlanceTypeEnum : byte
    {
        [Description("��ǰ���")]
        CurrentMoney = (byte)'0',
        [Description("�������")]
        UsableMoney = (byte)'1',
        [Description("��ȡ���")]
        FetchableMoney = (byte)'2',
        [Description("�������")]
        FreezeMoney = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcGenderEnum : byte
    {
        [Description("δ֪״̬")]
        Unknown = (byte)'0',
        [Description("��")]
        Male = (byte)'1',
        [Description("Ů")]
        Female = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFeePayFlagEnum : byte
    {
        [Description("�����淽֧������")]
        BEN = (byte)'0',
        [Description("�ɷ��ͷ�֧������")]
        OUR = (byte)'1',
        [Description("�ɷ��ͷ�֧������ķ��ã����淽֧�����ܵķ���")]
        SHA = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPassWordKeyTypeEnum : byte
    {
        [Description("������Կ")]
        ExchangeKey = (byte)'0',
        [Description("������Կ")]
        PassWordKey = (byte)'1',
        [Description("MAC��Կ")]
        MACKey = (byte)'2',
        [Description("������Կ")]
        MessageKey = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTPassWordTypeEnum : byte
    {
        [Description("��ѯ")]
        Query = (byte)'0',
        [Description("ȡ��")]
        Fetch = (byte)'1',
        [Description("ת��")]
        Transfer = (byte)'2',
        [Description("����")]
        Trade = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankRepealFlagEnum : byte
    {
        [Description("���������Զ�����")]
        BankNotNeedRepeal = (byte)'0',
        [Description("���д��Զ�����")]
        BankWaitingRepeal = (byte)'1',
        [Description("�������Զ�����")]
        BankBeenRepealed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerRepealFlagEnum : byte
    {
        [Description("���������Զ�����")]
        BrokerNotNeedRepeal = (byte)'0',
        [Description("���̴��Զ�����")]
        BrokerWaitingRepeal = (byte)'1',
        [Description("�������Զ�����")]
        BrokerBeenRepealed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInstitutionTypeEnum : byte
    {
        [Description("����")]
        Bank = (byte)'0',
        [Description("����")]
        Future = (byte)'1',
        [Description("ȯ��")]
        Store = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLastFragmentEnum : byte
    {
        [Description("������Ƭ")]
        Yes = (byte)'0',
        [Description("��������Ƭ")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAccStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("����")]
        Freeze = (byte)'1',
        [Description("��ʧ")]
        ReportLoss = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMoneyAccountStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("����")]
        Cancel = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcManageStatusEnum : byte
    {
        [Description("ָ�����")]
        Point = (byte)'0',
        [Description("Ԥָ��")]
        PrePoint = (byte)'1',
        [Description("����ָ��")]
        CancelPoint = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSystemTypeEnum : byte
    {
        [Description("����ת��")]
        FutureBankTransfer = (byte)'0',
        [Description("��֤ת��")]
        StockBankTransfer = (byte)'1',
        [Description("���������")]
        TheThirdPartStore = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTxnEndFlagEnum : byte
    {
        [Description("����������")]
        NormalProcessing = (byte)'0',
        [Description("�ɹ�����")]
        Success = (byte)'1',
        [Description("ʧ�ܽ���")]
        Failed = (byte)'2',
        [Description("�쳣��")]
        Abnormal = (byte)'3',
        [Description("���˹��쳣����")]
        ManualProcessedForException = (byte)'4',
        [Description("ͨѶ�쳣 �����˹�����")]
        CommuFailedNeedManualProcess = (byte)'5',
        [Description("ϵͳ�������˹�����")]
        SysErrorNeedManualProcess = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProcessStatusEnum : byte
    {
        [Description("δ����")]
        NotProcess = (byte)'0',
        [Description("��ʼ����")]
        StartProcess = (byte)'1',
        [Description("�������")]
        Finished = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCustTypeEnum : byte
    {
        [Description("��Ȼ��")]
        Person = (byte)'0',
        [Description("������")]
        Institution = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTTransferDirectionEnum : byte
    {
        [Description("�������ת�ڻ�")]
        FromBankToFuture = (byte)'1',
        [Description("�����ڻ�ת����")]
        FromFutureToBank = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOpenOrDestroyEnum : byte
    {
        [Description("����")]
        Open = (byte)'1',
        [Description("����")]
        Destroy = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAvailabilityFlagEnum : byte
    {
        [Description("δȷ��")]
        Invalid = (byte)'0',
        [Description("��Ч")]
        Valid = (byte)'1',
        [Description("����")]
        Repeal = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganTypeEnum : byte
    {
        [Description("���д���")]
        Bank = (byte)'1',
        [Description("����ǰ��")]
        Future = (byte)'2',
        [Description("����ת��ƽ̨����")]
        PlateForm = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganLevelEnum : byte
    {
        [Description("�������л������ܲ�")]
        HeadQuarters = (byte)'1',
        [Description("���з����Ļ��ڻ���˾Ӫҵ��")]
        Branch = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProtocalIDEnum : byte
    {
        [Description("����Э��")]
        FutureProtocal = (byte)'0',
        [Description("����Э��")]
        ICBCProtocal = (byte)'1',
        [Description("ũ��Э��")]
        ABCProtocal = (byte)'2',
        [Description("�й�����Э��")]
        CBCProtocal = (byte)'3',
        [Description("����Э��")]
        CCBProtocal = (byte)'4',
        [Description("����Э��")]
        BOCOMProtocal = (byte)'5',
        [Description("����ת��ƽ̨Э��")]
        FBTPlateFormProtocal = (byte)'X',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcConnectModeEnum : byte
    {
        [Description("������")]
        ShortConnect = (byte)'0',
        [Description("������")]
        LongConnect = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncModeEnum : byte
    {
        [Description("�첽")]
        ASync = (byte)'0',
        [Description("ͬ��")]
        Sync = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAccTypeEnum : byte
    {
        [Description("���д���")]
        BankBook = (byte)'1',
        [Description("���")]
        SavingCard = (byte)'2',
        [Description("���ÿ�")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFutureAccTypeEnum : byte
    {
        [Description("���д���")]
        BankBook = (byte)'1',
        [Description("���")]
        SavingCard = (byte)'2',
        [Description("���ÿ�")]
        CreditCard = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOrganStatusEnum : byte
    {
        [Description("����")]
        Ready = (byte)'0',
        [Description("ǩ��")]
        CheckIn = (byte)'1',
        [Description("ǩ��")]
        CheckOut = (byte)'2',
        [Description("�����ļ�����")]
        CheckFileArrived = (byte)'3',
        [Description("����")]
        CheckDetail = (byte)'4',
        [Description("��������")]
        DayEndClean = (byte)'5',
        [Description("ע��")]
        Invalid = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCCBFeeModeEnum : byte
    {
        [Description("��������")]
        ByAmount = (byte)'1',
        [Description("���¿���")]
        ByMonth = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCommApiTypeEnum : byte
    {
        [Description("�ͻ���")]
        Client = (byte)'1',
        [Description("�����")]
        Server = (byte)'2',
        [Description("����ϵͳ��UserApi")]
        UserApi = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLinkStatusEnum : byte
    {
        [Description("�Ѿ�����")]
        Connected = (byte)'1',
        [Description("û������")]
        Disconnected = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPwdFlagEnum : byte
    {
        [Description("���˶�")]
        NoCheck = (byte)'0',
        [Description("���ĺ˶�")]
        BlankCheck = (byte)'1',
        [Description("���ĺ˶�")]
        EncryptCheck = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSecuAccTypeEnum : byte
    {
        [Description("�ʽ��ʺ�")]
        AccountID = (byte)'1',
        [Description("�ʽ𿨺�")]
        CardID = (byte)'2',
        [Description("�Ϻ��ɶ��ʺ�")]
        SHStockholderID = (byte)'3',
        [Description("���ڹɶ��ʺ�")]
        SZStockholderID = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTransferStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("������")]
        Repealed = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSponsorTypeEnum : byte
    {
        [Description("����")]
        Broker = (byte)'0',
        [Description("����")]
        Bank = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReqRspTypeEnum : byte
    {
        [Description("����")]
        Request = (byte)'0',
        [Description("��Ӧ")]
        Response = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBTUserEventTypeEnum : byte
    {
        [Description("ǩ��")]
        SignIn = (byte)'0',
        [Description("����ת�ڻ�")]
        FromBankToFuture = (byte)'1',
        [Description("�ڻ�ת����")]
        FromFutureToBank = (byte)'2',
        [Description("����")]
        OpenAccount = (byte)'3',
        [Description("����")]
        CancelAccount = (byte)'4',
        [Description("��������˻�")]
        ChangeAccount = (byte)'5',
        [Description("��������ת�ڻ�")]
        RepealFromBankToFuture = (byte)'6',
        [Description("�����ڻ�ת����")]
        RepealFromFutureToBank = (byte)'7',
        [Description("��ѯ�����˻�")]
        QueryBankAccount = (byte)'8',
        [Description("��ѯ�ڻ��˻�")]
        QueryFutureAccount = (byte)'9',
        [Description("ǩ��")]
        SignOut = (byte)'A',
        [Description("��Կͬ��")]
        SyncKey = (byte)'B',
        [Description("ԤԼ����")]
        ReserveOpenAccount = (byte)'C',
        [Description("����ԤԼ����")]
        CancelReserveOpenAccount = (byte)'D',
        [Description("ԤԼ����ȷ��")]
        ReserveOpenAccountConfirm = (byte)'E',
        [Description("����")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDBOperationEnum : byte
    {
        [Description("����")]
        Insert = (byte)'0',
        [Description("����")]
        Update = (byte)'1',
        [Description("ɾ��")]
        Delete = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncFlagEnum : byte
    {
        [Description("��ͬ��")]
        Yes = (byte)'0',
        [Description("δͬ��")]
        No = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncTypeEnum : byte
    {
        [Description("һ��ͬ��")]
        OneOffSync = (byte)'0',
        [Description("��ʱͬ��")]
        TimerSync = (byte)'1',
        [Description("��ʱ��ȫͬ��")]
        TimerFullSync = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExDirectionEnum : byte
    {
        [Description("���")]
        Settlement = (byte)'0',
        [Description("�ۻ�")]
        Sale = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEResultFlagEnum : byte
    {
        [Description("�ɹ�")]
        Success = (byte)'0',
        [Description("�˻�����")]
        InsufficientBalance = (byte)'1',
        [Description("���׽��δ֪")]
        UnknownTrading = (byte)'8',
        [Description("ʧ��")]
        Fail = (byte)'x',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEExchStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("�����ط�")]
        ReExchange = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEFileFlagEnum : byte
    {
        [Description("���ݰ�")]
        DataPackage = (byte)'0',
        [Description("�ļ�")]
        File = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEAlreadyTradeEnum : byte
    {
        [Description("δ����")]
        NotTrade = (byte)'0',
        [Description("�ѽ���")]
        Trade = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEUserEventTypeEnum : byte
    {
        [Description("ǩ��")]
        SignIn = (byte)'0',
        [Description("����")]
        Exchange = (byte)'1',
        [Description("�����ط�")]
        ReExchange = (byte)'2',
        [Description("�����˻���ѯ")]
        QueryBankAccount = (byte)'3',
        [Description("������ϸ��ѯ")]
        QueryExchDetial = (byte)'4',
        [Description("������ܲ�ѯ")]
        QueryExchSummary = (byte)'5',
        [Description("������ʲ�ѯ")]
        QueryExchRate = (byte)'6',
        [Description("�����ļ�֪ͨ")]
        CheckBankAccount = (byte)'7',
        [Description("ǩ��")]
        SignOut = (byte)'8',
        [Description("����")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFBEReqFlagEnum : byte
    {
        [Description("δ����")]
        UnProcessed = (byte)'0',
        [Description("�ȴ�����")]
        WaitSend = (byte)'1',
        [Description("���ͳɹ�")]
        SendSuccess = (byte)'2',
        [Description("����ʧ��")]
        SendFailed = (byte)'3',
        [Description("�ȴ��ط�")]
        WaitReSend = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcNotifyClassEnum : byte
    {
        [Description("����")]
        NOERROR = (byte)'0',
        [Description("��ʾ")]
        Warn = (byte)'1',
        [Description("׷��")]
        Call = (byte)'2',
        [Description("ǿƽ")]
        Force = (byte)'3',
        [Description("����")]
        CHUANCANG = (byte)'4',
        [Description("�쳣")]
        Exception = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForceCloseTypeEnum : byte
    {
        [Description("�ֹ�ǿƽ")]
        Manual = (byte)'0',
        [Description("��һͶ���߸���ǿƽ")]
        Single = (byte)'1',
        [Description("����Ͷ���߸���ǿƽ")]
        Group = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskNotifyMethodEnum : byte
    {
        [Description("ϵͳ֪ͨ")]
        System = (byte)'0',
        [Description("����֪ͨ")]
        SMS = (byte)'1',
        [Description("�ʼ�֪ͨ")]
        EMail = (byte)'2',
        [Description("�˹�֪ͨ")]
        Manual = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskNotifyStatusEnum : byte
    {
        [Description("δ����")]
        NotGen = (byte)'0',
        [Description("������δ����")]
        Generated = (byte)'1',
        [Description("����ʧ��")]
        SendError = (byte)'2',
        [Description("�ѷ���δ����")]
        SendOk = (byte)'3',
        [Description("�ѽ���δȷ��")]
        Received = (byte)'4',
        [Description("��ȷ��")]
        Confirmed = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRiskUserEventEnum : byte
    {
        [Description("��������")]
        ExportData = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcConditionalOrderSortTypeEnum : byte
    {
        [Description("ʹ�����¼�����")]
        LastPriceAsc = (byte)'0',
        [Description("ʹ�����¼۽���")]
        LastPriceDesc = (byte)'1',
        [Description("ʹ����������")]
        AskPriceAsc = (byte)'2',
        [Description("ʹ�����۽���")]
        AskPriceDesc = (byte)'3',
        [Description("ʹ���������")]
        BidPriceAsc = (byte)'4',
        [Description("ʹ����۽���")]
        BidPriceDesc = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSendTypeEnum : byte
    {
        [Description("δ����")]
        NoSend = (byte)'0',
        [Description("�ѷ���")]
        Sended = (byte)'1',
        [Description("������")]
        Generated = (byte)'2',
        [Description("����ʧ��")]
        SendFail = (byte)'3',
        [Description("���ճɹ�")]
        Success = (byte)'4',
        [Description("����ʧ��")]
        Fail = (byte)'5',
        [Description("ȡ������")]
        Cancel = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientIDStatusEnum : byte
    {
        [Description("δ����")]
        NoApply = (byte)'1',
        [Description("���ύ����")]
        Submited = (byte)'2',
        [Description("�ѷ�������")]
        Sended = (byte)'3',
        [Description("���")]
        Success = (byte)'4',
        [Description("�ܾ�")]
        Refuse = (byte)'5',
        [Description("�ѳ�������")]
        Cancel = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcQuestionTypeEnum : byte
    {
        [Description("��ѡ")]
        Radio = (byte)'1',
        [Description("��ѡ")]
        Option = (byte)'2',
        [Description("���")]
        Blank = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBusinessTypeEnum : byte
    {
        [Description("����")]
        Request = (byte)'1',
        [Description("Ӧ��")]
        Response = (byte)'2',
        [Description("֪ͨ")]
        Notice = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCfmmcReturnCodeEnum : byte
    {
        [Description("�ɹ�")]
        Success = (byte)'0',
        [Description("�ÿͻ��Ѿ��������ڴ�����")]
        Working = (byte)'1',
        [Description("����пͻ����ϼ��ʧ��")]
        InfoFail = (byte)'2',
        [Description("�����ʵ���Ƽ��ʧ��")]
        IDCardFail = (byte)'3',
        [Description("��������")]
        OtherFail = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientTypeEnum : byte
    {
        [Description("����")]
        All = (byte)'0',
        [Description("����")]
        Person = (byte)'1',
        [Description("��λ")]
        Company = (byte)'2',
        [Description("����")]
        Other = (byte)'3',
        [Description("���ⷨ��")]
        SpecialOrgan = (byte)'4',
        [Description("�ʹܻ�")]
        Asset = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExchangeIDTypeEnum : byte
    {
        [Description("�Ϻ��ڻ�������")]
        SHFE = (byte)'S',
        [Description("֣����Ʒ������")]
        CZCE = (byte)'Z',
        [Description("������Ʒ������")]
        DCE = (byte)'D',
        [Description("�й������ڻ�������")]
        CFFEX = (byte)'J',
        [Description("�Ϻ�������Դ�������Ĺɷ����޹�˾")]
        INE = (byte)'N',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExClientIDTypeEnum : byte
    {
        [Description("�ױ�")]
        Hedge = (byte)'1',
        [Description("����")]
        Arbitrage = (byte)'2',
        [Description("Ͷ��")]
        Speculation = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUpdateFlagEnum : byte
    {
        [Description("δ����")]
        NoUpdate = (byte)'0',
        [Description("����ȫ����Ϣ�ɹ�")]
        Success = (byte)'1',
        [Description("����ȫ����Ϣʧ��")]
        Fail = (byte)'2',
        [Description("���½��ױ���ɹ�")]
        TCSuccess = (byte)'3',
        [Description("���½��ױ���ʧ��")]
        TCFail = (byte)'4',
        [Description("�Ѷ���")]
        Cancel = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyOperateIDEnum : byte
    {
        [Description("����")]
        OpenInvestor = (byte)'1',
        [Description("�޸������Ϣ")]
        ModifyIDCard = (byte)'2',
        [Description("�޸�һ����Ϣ")]
        ModifyNoIDCard = (byte)'3',
        [Description("���뽻�ױ���")]
        ApplyTradingCode = (byte)'4',
        [Description("�������ױ���")]
        CancelTradingCode = (byte)'5',
        [Description("����")]
        CancelInvestor = (byte)'6',
        [Description("�˻�����")]
        FreezeAccount = (byte)'8',
        [Description("���������˻�")]
        ActiveFreezeAccount = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyStatusIDEnum : byte
    {
        [Description("δ��ȫ")]
        NoComplete = (byte)'1',
        [Description("���ύ")]
        Submited = (byte)'2',
        [Description("�����")]
        Checked = (byte)'3',
        [Description("�Ѿܾ�")]
        Refused = (byte)'4',
        [Description("��ɾ��")]
        Deleted = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSendMethodEnum : byte
    {
        [Description("�ļ�����")]
        ByAPI = (byte)'1',
        [Description("���ӷ���")]
        ByFile = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcEventModeEnum : byte
    {
        [Description("����")]
        ADD = (byte)'1',
        [Description("�޸�")]
        UPDATE = (byte)'2',
        [Description("ɾ��")]
        DELETE = (byte)'3',
        [Description("����")]
        CHECK = (byte)'4',
        [Description("����")]
        COPY = (byte)'5',
        [Description("ע��")]
        CANCEL = (byte)'6',
        [Description("����")]
        Reverse = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUOAAutoSendEnum : byte
    {
        [Description("�Զ����Ͳ�����")]
        ASR = (byte)'1',
        [Description("�Զ����ͣ����Զ�����")]
        ASNR = (byte)'2',
        [Description("���Զ����ͣ��Զ�����")]
        NSAR = (byte)'3',
        [Description("���Զ����ͣ�Ҳ���Զ�����")]
        NSR = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFlowIDEnum : byte
    {
        [Description("Ͷ���߶�ӦͶ����������")]
        InvestorGroupFlow = (byte)'1',
        [Description("Ͷ����������������")]
        InvestorRate = (byte)'2',
        [Description("Ͷ������������ģ���ϵ����")]
        InvestorCommRateModel = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckLevelEnum : byte
    {
        [Description("�㼶����")]
        Zero = (byte)'0',
        [Description("һ������")]
        One = (byte)'1',
        [Description("��������")]
        Two = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckStatusEnum : byte
    {
        [Description("δ����")]
        Init = (byte)'0',
        [Description("������")]
        Checking = (byte)'1',
        [Description("�Ѹ���")]
        Checked = (byte)'2',
        [Description("�ܾ�")]
        Refuse = (byte)'3',
        [Description("����")]
        Cancel = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUsedStatusEnum : byte
    {
        [Description("δ��Ч")]
        Unused = (byte)'0',
        [Description("����Ч")]
        Used = (byte)'1',
        [Description("��Чʧ��")]
        Fail = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBankAcountOriginEnum : byte
    {
        [Description("�ֹ�¼��")]
        ByAccProperty = (byte)'0',
        [Description("����ת��")]
        ByFBTransfer = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMonthBillTradeSumEnum : byte
    {
        [Description("ͬ��ͬ��Լ")]
        ByInstrument = (byte)'0',
        [Description("ͬ��ͬ��Լͬ�۸�")]
        ByDayInsPrc = (byte)'1',
        [Description("ͬ��Լ")]
        ByDayIns = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTPTypeEnum : byte
    {
        [Description("�޶�̬����")]
        NONE = (byte)'0',
        [Description("ʱ������")]
        TOTP = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTPStatusEnum : byte
    {
        [Description("δʹ��")]
        Unused = (byte)'0',
        [Description("��ʹ��")]
        Used = (byte)'1',
        [Description("ע��")]
        Disuse = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBrokerUserTypeEnum : byte
    {
        [Description("Ͷ����")]
        Investor = (byte)'1',
        [Description("����Ա")]
        BrokerUser = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFutureTypeEnum : byte
    {
        [Description("��Ʒ�ڻ�")]
        Commodity = (byte)'1',
        [Description("�����ڻ�")]
        Financial = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundEventTypeEnum : byte
    {
        [Description("ת���޶�")]
        Restriction = (byte)'0',
        [Description("����ת���޶�")]
        TodayRestriction = (byte)'1',
        [Description("������ˮ")]
        Transfer = (byte)'2',
        [Description("�ʽ𶳽�")]
        Credit = (byte)'3',
        [Description("Ͷ���߿����ʽ����")]
        InvestorWithdrawAlm = (byte)'4',
        [Description("���������ʻ�ת���޶�")]
        BankRestriction = (byte)'5',
        [Description("����ǩԼ�˻�")]
        Accountregister = (byte)'6',
        [Description("�����������")]
        ExchangeFundIO = (byte)'7',
        [Description("Ͷ���߳����")]
        InvestorFundIO = (byte)'8',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAccountSourceTypeEnum : byte
    {
        [Description("����ͬ��")]
        FBTransfer = (byte)'0',
        [Description("�ֹ�¼��")]
        ManualEntry = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCodeSourceTypeEnum : byte
    {
        [Description("ͳһ����(�ѹ淶)")]
        UnifyAccount = (byte)'0',
        [Description("�ֹ�¼��(δ�淶)")]
        ManualEntry = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUserRangeEnum : byte
    {
        [Description("����")]
        All = (byte)'0',
        [Description("��һ����Ա")]
        Single = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcByGroupEnum : byte
    {
        [Description("��Ͷ����ͳ��")]
        Investor = (byte)'2',
        [Description("����ͳ��")]
        Group = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeSumStatModeEnum : byte
    {
        [Description("����Լͳ��")]
        Instrument = (byte)'1',
        [Description("����Ʒͳ��")]
        Product = (byte)'2',
        [Description("��������ͳ��")]
        Exchange = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExprSetModeEnum : byte
    {
        [Description("������й�������")]
        Relative = (byte)'1',
        [Description("��������")]
        Typical = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRateInvestorRangeEnum : byte
    {
        [Description("��˾��׼")]
        All = (byte)'1',
        [Description("ģ��")]
        Model = (byte)'2',
        [Description("��һͶ����")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSyncDataStatusEnum : byte
    {
        [Description("δͬ��")]
        Initialize = (byte)'0',
        [Description("ͬ����")]
        Settlementing = (byte)'1',
        [Description("��ͬ��")]
        Settlemented = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTradeSourceEnum : byte
    {
        [Description("���Խ�������ͨ�ر�")]
        NORMAL = (byte)'0',
        [Description("���Բ�ѯ")]
        QUERY = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFlexStatModeEnum : byte
    {
        [Description("��Ʒͳ��")]
        Product = (byte)'1',
        [Description("������ͳ��")]
        Exchange = (byte)'2',
        [Description("ͳ������")]
        All = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcByInvestorRangeEnum : byte
    {
        [Description("����ͳ��")]
        Property = (byte)'1',
        [Description("ͳ������")]
        All = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPropertyInvestorRangeEnum : byte
    {
        [Description("����")]
        All = (byte)'1',
        [Description("Ͷ��������")]
        Property = (byte)'2',
        [Description("��һͶ����")]
        Single = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileStatusEnum : byte
    {
        [Description("δ����")]
        NoCreate = (byte)'0',
        [Description("������")]
        Created = (byte)'1',
        [Description("����ʧ��")]
        Failed = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFileGenStyleEnum : byte
    {
        [Description("�·�")]
        FileTransmit = (byte)'0',
        [Description("����")]
        FileGen = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysOperModeEnum : byte
    {
        [Description("����")]
        Add = (byte)'1',
        [Description("�޸�")]
        Update = (byte)'2',
        [Description("ɾ��")]
        Delete = (byte)'3',
        [Description("����")]
        Copy = (byte)'4',
        [Description("����")]
        AcTive = (byte)'5',
        [Description("ע��")]
        CanCel = (byte)'6',
        [Description("����")]
        ReSet = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSysOperTypeEnum : byte
    {
        [Description("�޸Ĳ���Ա����")]
        UpdatePassword = (byte)'0',
        [Description("����Ա��֯�ܹ���ϵ")]
        UserDepartment = (byte)'1',
        [Description("��ɫ����")]
        RoleManager = (byte)'2',
        [Description("��ɫ��������")]
        RoleFunction = (byte)'3',
        [Description("������������")]
        BaseParam = (byte)'4',
        [Description("���ò���Ա")]
        SetUserID = (byte)'5',
        [Description("�û���ɫ����")]
        SetUserRole = (byte)'6',
        [Description("�û�IP����")]
        UserIpRestriction = (byte)'7',
        [Description("��֯�ܹ�����")]
        DepartmentManager = (byte)'8',
        [Description("��֯�ܹ����ѯ���ิ��")]
        DepartmentCopy = (byte)'9',
        [Description("���ױ������")]
        Tradingcode = (byte)'A',
        [Description("Ͷ����״̬ά��")]
        InvestorStatus = (byte)'B',
        [Description("Ͷ����Ȩ�޹���")]
        InvestorAuthority = (byte)'C',
        [Description("��������")]
        PropertySet = (byte)'D',
        [Description("����Ͷ��������")]
        ReSetInvestorPasswd = (byte)'E',
        [Description("Ͷ���߸�����Ϣά��")]
        InvestorPersonalityInfo = (byte)'F',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCSRCDataQueyTypeEnum : byte
    {
        [Description("��ѯ��ǰ�����ձ��͵�����")]
        Current = (byte)'0',
        [Description("��ѯ��ʷ���͵Ĵ����͹�˾������")]
        History = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFreezeStatusEnum : byte
    {
        [Description("��Ծ")]
        Normal = (byte)'1',
        [Description("����")]
        Freeze = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStandardStatusEnum : byte
    {
        [Description("�ѹ淶")]
        Standard = (byte)'0',
        [Description("δ�淶")]
        NonStandard = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcRightParamTypeEnum : byte
    {
        [Description("���߻�")]
        Freeze = (byte)'1',
        [Description("�������߻�")]
        FreezeActive = (byte)'2',
        [Description("����Ȩ������")]
        OpenLimit = (byte)'3',
        [Description("�������Ȩ������")]
        RelieveOpenLimit = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataStatusEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("��ɾ��")]
        Deleted = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAMLCheckStatusEnum : byte
    {
        [Description("δ����")]
        Init = (byte)'0',
        [Description("������")]
        Checking = (byte)'1',
        [Description("�Ѹ���")]
        Checked = (byte)'2',
        [Description("�ܾ��ϱ�")]
        RefuseReport = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmlDateTypeEnum : byte
    {
        [Description("�������")]
        DrawDay = (byte)'0',
        [Description("��������")]
        TouchDay = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmlCheckLevelEnum : byte
    {
        [Description("�㼶���")]
        CheckLevel0 = (byte)'0',
        [Description("һ�����")]
        CheckLevel1 = (byte)'1',
        [Description("�������")]
        CheckLevel2 = (byte)'2',
        [Description("�������")]
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
        [Description("����ǰ׼��")]
        Before = (byte)'1',
        [Description("����")]
        Settlement = (byte)'2',
        [Description("�����˶�")]
        After = (byte)'3',
        [Description("�������")]
        Settlemented = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettleManagerLevelEnum : byte
    {
        [Description("��Ҫ")]
        Must = (byte)'1',
        [Description("����")]
        Alarm = (byte)'2',
        [Description("��ʾ")]
        Prompt = (byte)'3',
        [Description("�����")]
        Ignore = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettleManagerGroupEnum : byte
    {
        [Description("�������˶�")]
        Exhcange = (byte)'1',
        [Description("�ڲ��˶�")]
        ASP = (byte)'2',
        [Description("�ϱ����ݺ˶�")]
        CSRC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLimitUseTypeEnum : byte
    {
        [Description("���ظ�ʹ��")]
        Repeatable = (byte)'1',
        [Description("�����ظ�ʹ��")]
        Unrepeatable = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDataResourceEnum : byte
    {
        [Description("��ϵͳ")]
        Settle = (byte)'1',
        [Description("������")]
        Exchange = (byte)'2',
        [Description("��������")]
        CSRC = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginTypeEnum : byte
    {
        [Description("��������֤����")]
        ExchMarginRate = (byte)'0',
        [Description("Ͷ���߱�֤����")]
        InstrMarginRate = (byte)'1',
        [Description("Ͷ���߽��ױ�֤����")]
        InstrMarginRateTrade = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActiveTypeEnum : byte
    {
        [Description("��������Ч")]
        Intraday = (byte)'1',
        [Description("������Ч")]
        Long = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMarginRateTypeEnum : byte
    {
        [Description("��������֤����")]
        Exchange = (byte)'1',
        [Description("Ͷ���߱�֤����")]
        Investor = (byte)'2',
        [Description("Ͷ���߽��ױ�֤����")]
        InvestorTrade = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBackUpStatusEnum : byte
    {
        [Description("δ���ɱ�������")]
        UnBak = (byte)'0',
        [Description("��������������")]
        BakUp = (byte)'1',
        [Description("�����ɱ�������")]
        BakUped = (byte)'2',
        [Description("��������ʧ��")]
        BakFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcInitSettlementEnum : byte
    {
        [Description("�����ʼ��δ��ʼ")]
        UnInitialize = (byte)'0',
        [Description("�����ʼ����")]
        Initialize = (byte)'1',
        [Description("�����ʼ�����")]
        Initialized = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReportStatusEnum : byte
    {
        [Description("δ���ɱ�������")]
        NoCreate = (byte)'0',
        [Description("��������������")]
        Create = (byte)'1',
        [Description("�����ɱ�������")]
        Created = (byte)'2',
        [Description("���ɱ�������ʧ��")]
        CreateFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSaveStatusEnum : byte
    {
        [Description("�鵵δ���")]
        UnSaveData = (byte)'0',
        [Description("�鵵���")]
        SaveDatad = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSettArchiveStatusEnum : byte
    {
        [Description("δ�鵵����")]
        UnArchived = (byte)'0',
        [Description("���ݹ鵵��")]
        Archiving = (byte)'1',
        [Description("�ѹ鵵����")]
        Archived = (byte)'2',
        [Description("�鵵����ʧ��")]
        ArchiveFail = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCTPTypeEnum : byte
    {
        [Description("δ֪����")]
        Unkown = (byte)'0',
        [Description("������")]
        MainCenter = (byte)'1',
        [Description("������")]
        BackUp = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCloseDealTypeEnum : byte
    {
        [Description("����")]
        Normal = (byte)'0',
        [Description("Ͷ��ƽ������")]
        SpecFirst = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMortgageFundUseRangeEnum : byte
    {
        [Description("����ʹ��")]
        None = (byte)'0',
        [Description("���ڱ�֤��")]
        Margin = (byte)'1',
        [Description("���������ѡ�ӯ������֤��")]
        All = (byte)'2',
        [Description("����ҷ���3")]
        CNY3 = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSpecProductTypeEnum : byte
    {
        [Description("֣�����ױ���Ʒ")]
        CzceHedge = (byte)'1',
        [Description("������Ѻ��Ʒ")]
        IneForeignCurrency = (byte)'2',
        [Description("�������߿�ƽ�ֲ�Ʒ")]
        DceOpenClose = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundMortgageTypeEnum : byte
    {
        [Description("��Ѻ")]
        Mortgage = (byte)'1',
        [Description("����")]
        Redemption = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAccountSettlementParamIDEnum : byte
    {
        [Description("������֤��")]
        BaseMargin = (byte)'1',
        [Description("���Ȩ���׼")]
        LowestInterest = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcFundMortDirectionEnum : byte
    {
        [Description("��������")]
        In = (byte)'1',
        [Description("�����ʳ�")]
        Out = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBusinessClassEnum : byte
    {
        [Description("ӯ��")]
        Profit = (byte)'0',
        [Description("����")]
        Loss = (byte)'1',
        [Description("����")]
        Other = (byte)'Z',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcSwapSourceTypeEnum : byte
    {
        [Description("�ֹ�")]
        Manual = (byte)'0',
        [Description("�Զ�����")]
        Automatic = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCurrExDirectionEnum : byte
    {
        [Description("���")]
        Settlement = (byte)'0',
        [Description("�ۻ�")]
        Sale = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCurrencySwapStatusEnum : byte
    {
        [Description("��¼��")]
        Entry = (byte)'1',
        [Description("�����")]
        Approve = (byte)'2',
        [Description("�Ѿܾ�")]
        Refuse = (byte)'3',
        [Description("�ѳ���")]
        Revoke = (byte)'4',
        [Description("�ѷ���")]
        Send = (byte)'5',
        [Description("����ɹ�")]
        Success = (byte)'6',
        [Description("����ʧ��")]
        Failure = (byte)'7',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReqFlagEnum : byte
    {
        [Description("δ����")]
        NoSend = (byte)'0',
        [Description("���ͳɹ�")]
        SendSuccess = (byte)'1',
        [Description("����ʧ��")]
        SendFailed = (byte)'2',
        [Description("�ȴ��ط�")]
        WaitReSend = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcResFlagEnum : byte
    {
        [Description("�ɹ�")]
        Success = (byte)'0',
        [Description("�˻�����")]
        InsuffiCient = (byte)'1',
        [Description("���׽��δ֪")]
        UnKnown = (byte)'8',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExStatusEnum : byte
    {
        [Description("�޸�ǰ")]
        Before = (byte)'0',
        [Description("�޸ĺ�")]
        After = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcClientRegionEnum : byte
    {
        [Description("���ڿͻ�")]
        Domestic = (byte)'1',
        [Description("�۰�̨�ͻ�")]
        GMT = (byte)'2',
        [Description("����ͻ�")]
        Foreign = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHasBoardEnum : byte
    {
        [Description("û��")]
        No = (byte)'0',
        [Description("��")]
        Yes = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStartModeEnum : byte
    {
        [Description("����")]
        Normal = (byte)'1',
        [Description("Ӧ��")]
        Emerge = (byte)'2',
        [Description("�ָ�")]
        Restore = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcTemplateTypeEnum : byte
    {
        [Description("ȫ��")]
        Full = (byte)'1',
        [Description("����")]
        Increment = (byte)'2',
        [Description("����")]
        BackUp = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLoginModeEnum : byte
    {
        [Description("����")]
        Trade = (byte)'0',
        [Description("ת��")]
        Transfer = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcPromptTypeEnum : byte
    {
        [Description("��Լ������")]
        Instrument = (byte)'1',
        [Description("��֤��ֶ���Ч")]
        Margin = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcHasTrusteeEnum : byte
    {
        [Description("��")]
        Yes = (byte)'1',
        [Description("û��")]
        No = (byte)'0',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAmTypeEnum : byte
    {
        [Description("����")]
        Bank = (byte)'1',
        [Description("֤ȯ��˾")]
        Securities = (byte)'2',
        [Description("����˾")]
        Fund = (byte)'3',
        [Description("���չ�˾")]
        Insurance = (byte)'4',
        [Description("���й�˾")]
        Trust = (byte)'5',
        [Description("����")]
        Other = (byte)'9',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCSRCFundIOTypeEnum : byte
    {
        [Description("�����")]
        FundIO = (byte)'0',
        [Description("���ڻ���")]
        SwapCurrency = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCusAccountTypeEnum : byte
    {
        [Description("�ڻ������˻�")]
        Futures = (byte)'1',
        [Description("���ڻ��ʹ�ҵ���µ��ʹܽ����˻�")]
        AssetmgrFuture = (byte)'2',
        [Description("�ۺ����ʹ�ҵ���µ��ڻ��ʹ��й��˻�")]
        AssetmgrTrustee = (byte)'3',
        [Description("�ۺ����ʹ�ҵ���µ��ʽ���ת�˻�")]
        AssetmgrTransfer = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcLanguageTypeEnum : byte
    {
        [Description("����")]
        Chinese = (byte)'1',
        [Description("Ӣ��")]
        English = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAssetmgrClientTypeEnum : byte
    {
        [Description("�����ʹܿͻ�")]
        Person = (byte)'1',
        [Description("��λ�ʹܿͻ�")]
        Organ = (byte)'2',
        [Description("���ⵥλ�ʹܿͻ�")]
        SpecialOrgan = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAssetmgrTypeEnum : byte
    {
        [Description("�ڻ���")]
        Futures = (byte)'3',
        [Description("�ۺ���")]
        SpecialOrgan = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCheckInstrTypeEnum : byte
    {
        [Description("��Լ������������")]
        HasExch = (byte)'0',
        [Description("��Լ��ϵͳ������")]
        HasATP = (byte)'1',
        [Description("��Լ�Ƚϲ�һ��")]
        HasDiff = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDeliveryTypeEnum : byte
    {
        [Description("�ֹ�����")]
        HandDeliv = (byte)'1',
        [Description("���ڽ���")]
        PersonDeliv = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMaxMarginSideAlgorithmEnum : byte
    {
        [Description("��ʹ�ô��߱�֤���㷨")]
        NO = (byte)'0',
        [Description("ʹ�ô��߱�֤���㷨")]
        YES = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDAClientTypeEnum : byte
    {
        [Description("��Ȼ��")]
        Person = (byte)'0',
        [Description("����")]
        Company = (byte)'1',
        [Description("����")]
        Other = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcUOAAssetmgrTypeEnum : byte
    {
        [Description("�ڻ���")]
        Futures = (byte)'1',
        [Description("�ۺ���")]
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
        [Description("����")]
        CallOptions = (byte)'1',
        [Description("����")]
        PutOptions = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeModeEnum : byte
    {
        [Description("ŷʽ")]
        Continental = (byte)'0',
        [Description("��ʽ")]
        American = (byte)'1',
        [Description("��Ľ��")]
        Bermuda = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeTypeEnum : byte
    {
        [Description("����Գ�")]
        Hedge = (byte)'0',
        [Description("ƥ��ִ��")]
        Match = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcApplyTypeEnum : byte
    {
        [Description("��ִ������")]
        NotStrikeNum = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcGiveUpDataSourceEnum : byte
    {
        [Description("ϵͳ����")]
        Gen = (byte)'0',
        [Description("�ֹ����")]
        Hand = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecResultEnum : byte
    {
        [Description("û��ִ��")]
        NoExec = (byte)'n',
        [Description("�Ѿ�ȡ��")]
        Canceled = (byte)'c',
        [Description("ִ�гɹ�")]
        OK = (byte)'0',
        [Description("��Ȩ�ֲֲ���")]
        NoPosition = (byte)'1',
        [Description("�ʽ𲻹�")]
        NoDeposit = (byte)'2',
        [Description("��Ա������")]
        NoParticipant = (byte)'3',
        [Description("�ͻ�������")]
        NoClient = (byte)'4',
        [Description("��Լ������")]
        NoInstrument = (byte)'6',
        [Description("û��ִ��Ȩ��")]
        NoRight = (byte)'7',
        [Description("�����������")]
        InvalidVolume = (byte)'8',
        [Description("û���㹻����ʷ�ɽ�")]
        NoEnoughHistoryTrade = (byte)'9',
        [Description("δ֪")]
        Unknown = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCombinationTypeEnum : byte
    {
        [Description("�ڻ����")]
        Future = (byte)'0',
        [Description("��ֱ�۲�BUL")]
        BUL = (byte)'1',
        [Description("��ֱ�۲�BER")]
        BER = (byte)'2',
        [Description("��ʽ���")]
        STD = (byte)'3',
        [Description("���ʽ���")]
        STG = (byte)'4',
        [Description("�������")]
        PRT = (byte)'5',
        [Description("ʱ��۲����")]
        CLD = (byte)'6',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcDceCombinationTypeEnum : byte
    {
        [Description("�ڻ��������")]
        SPL = (byte)'0',
        [Description("��Ȩ�������")]
        OPL = (byte)'1',
        [Description("�ڻ��������")]
        SP = (byte)'2',
        [Description("�ڻ���Ʒ�����")]
        SPC = (byte)'3',
        [Description("������Ȩ��ֱ�۲����")]
        BLS = (byte)'4',
        [Description("������Ȩ��ֱ�۲����")]
        BES = (byte)'5',
        [Description("��Ȩ�����۲����")]
        CAS = (byte)'6',
        [Description("��Ȩ��ʽ���")]
        STD = (byte)'7',
        [Description("��Ȩ���ʽ���")]
        STG = (byte)'8',
        [Description("�����ڻ���Ȩ���")]
        BFO = (byte)'9',
        [Description("�����ڻ���Ȩ���")]
        SFO = (byte)'a',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOptionRoyaltyPriceTypeEnum : byte
    {
        [Description("������")]
        PreSettlementPrice = (byte)'1',
        [Description("���ּ�")]
        OpenPrice = (byte)'4',
        [Description("���¼��������۽ϴ�ֵ")]
        MaxPreSettlementPrice = (byte)'5',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBalanceAlgorithmEnum : byte
    {
        [Description("��������Ȩ��ֵӯ��")]
        Default = (byte)'1',
        [Description("������Ȩ��ֵ����")]
        IncludeOptValLost = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcActionTypeEnum : byte
    {
        [Description("ִ��")]
        Exec = (byte)'1',
        [Description("����")]
        Abandon = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcForQuoteStatusEnum : byte
    {
        [Description("�Ѿ��ύ")]
        Submitted = (byte)'a',
        [Description("�Ѿ�����")]
        Accepted = (byte)'b',
        [Description("�Ѿ����ܾ�")]
        Rejected = (byte)'c',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcValueMethodEnum : byte
    {
        [Description("������ֵ")]
        Absolute = (byte)'0',
        [Description("������")]
        Ratio = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecOrderPositionFlagEnum : byte
    {
        [Description("����")]
        Reserve = (byte)'0',
        [Description("������")]
        UnReserve = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcExecOrderCloseFlagEnum : byte
    {
        [Description("�Զ�ƽ��")]
        AutoClose = (byte)'0',
        [Description("�����Զ�ƽ��")]
        NotToClose = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcProductTypeEnum : byte
    {
        [Description("�ڻ�")]
        Futures = (byte)'1',
        [Description("��Ȩ")]
        Options = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcCombDirectionEnum : byte
    {
        [Description("�������")]
        Comb = (byte)'0',
        [Description("������")]
        UnComb = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcStrikeOffsetTypeEnum : byte
    {
        [Description("ʵֵ��")]
        RealValue = (byte)'1',
        [Description("ӯ����")]
        ProfitValue = (byte)'2',
        [Description("ʵֵ����")]
        RealRatio = (byte)'3',
        [Description("ӯ������")]
        ProfitRatio = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcReserveOpenAccStasEnum : byte
    {
        [Description("�ȴ�������")]
        Processing = (byte)'0',
        [Description("�ѳ���")]
        Cancelled = (byte)'1',
        [Description("�ѿ���")]
        Opened = (byte)'2',
        [Description("��Ч����")]
        Invalid = (byte)'3',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcWeakPasswordSourceEnum : byte
    {
        [Description("�������")]
        Lib = (byte)'1',
        [Description("�ֹ�¼��")]
        Manual = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOptSelfCloseFlagEnum : byte
    {
        [Description("�ԶԳ���Ȩ��λ")]
        CloseSelfOptionPosition = (byte)'1',
        [Description("������Ȩ��λ")]
        ReserveOptionPosition = (byte)'2',
        [Description("�ԶԳ�������Լ����ڻ���λ")]
        SellCloseSelfFuturePosition = (byte)'3',
        [Description("����������Լ����ڻ���λ")]
        ReserveFuturePosition = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcBizTypeEnum : byte
    {
        [Description("�ڻ�")]
        Future = (byte)'1',
        [Description("֤ȯ")]
        Stock = (byte)'2',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcAppTypeEnum : byte
    {
        [Description("ֱ����Ͷ����")]
        Investor = (byte)'1',
        [Description("Ϊÿ��Ͷ���߶��������ӵ��м�")]
        InvestorRelay = (byte)'2',
        [Description("����Ͷ���߹���һ������Ա���ӵ��м�")]
        OperatorRelay = (byte)'3',
        [Description("δ֪")]
        UnKnown = (byte)'4',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcResponseValueEnum : byte
    {
        [Description("���ɹ�")]
        Right = (byte)'0',
        [Description("���ʧ��")]
        Refuse = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcOTCTradeTypeEnum : byte
    {
        [Description("���ڽ���")]
        Block = (byte)'0',
        [Description("��ת��")]
        EFP = (byte)'1',
    }
    
    
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum ThostFtdcMatchTypeEnum : byte
    {
        [Description("�����ֵ")]
        DV01 = (byte)'1',
        [Description("��ֵ")]
        ParValue = (byte)'2',
    }
    
    



}
