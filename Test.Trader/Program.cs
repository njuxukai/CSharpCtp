using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCtp;
using CSharpCtp.Trader;


namespace Test.Trader
{
    class Program
    {
        static void Main(string[] args)
        {
            TraderInfo traderInfo = new TraderInfo();
            traderInfo.BrokerID = "88888";
            traderInfo.UserID = "";
            traderInfo.InvestorID = "";
            traderInfo.Password = "";
            traderInfo.FrontID = "tcp://114.80.55.115:42205";
            traderInfo.FlowPath = "./trader/";
            traderInfo.PrivateTopicResumeType = (int)THOST_TE_RESUME_TYPE.THOST_TERT_RESTART;
            traderInfo.PublicTopicResumeType = (int)THOST_TE_RESUME_TYPE.THOST_TERT_RESTART;
            traderInfo.AppID = "";
            traderInfo.AuthCode = "";
            traderInfo.AuthKind = 1;

            trader = new TraderWrapper(traderInfo);
            trader.OnFrontConnected += Trader_OnFrontConnected; ;
            trader.OnRspUserLogin += Trader_OnRspUserLogin;
            trader.OnRspSettlementInfoConfirm += Trader_OnRspSettlementInfoConfirm;
            trader.Connect();
            Console.Read();

        }

        private static void Trader_OnRspSettlementInfoConfirm(object sender, OnRspSettlementInfoConfirmEventArgs e)
        {
            Console.WriteLine("Trader_OnRspSettlementInfoConfirm");
        }

        private static void Trader_OnRspUserLogin(object sender, OnRspUserLoginEventArgs e)
        {
            Console.WriteLine("Trader_OnRspUserLogin");
            if (e.PRspInfo != null && e.PRspInfo.Value.ErrorID != 0)
            {
                Console.WriteLine(string.Format("OnRspUserLogin[{0}:{1}]",
                    e.PRspInfo.Value.ErrorID,
                    e.PRspInfo.Value.ErrorMsg));
            }
        }

        private static void Trader_OnFrontConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Trader_OnFrontConnected");
        }

        static TraderWrapper trader = null;
    }


}
