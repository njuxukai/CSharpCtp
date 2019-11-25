using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpCtp;
using CSharpCtp.MdUser;

namespace Test.MdUser
{
    class Program
    {
        static void Main(string[] args)
        {
            MdUserInfo userInfo = new MdUserInfo();

            
            userInfo.BrokerID = "88888";
            userInfo.UserID = "";
            userInfo.InvestorID = "";
            userInfo.Password = "";
            userInfo.FrontID = "tcp://114.80.55.116:42213";
            userInfo.FlowPath = "./md/";
            mdUser = new MdUserWrapper(userInfo);
            mdUser.OnFrontConnected += MdUser_onFrontConnected;
            mdUser.OnRtnDepthMarketData += MdUser_onRtnDepthMarketData;
            mdUser.OnRspUserLogin += MdUser_onRspUserLogin;
            mdUser.Connect();
            Console.Read();
        }

        private static void MdUser_onRspUserLogin(object sender, OnRspUserLoginEventArgs e)
        {
            string[] instruments = new string[2] { "IF1912", "IF2001"};
            mdUser.SubscribeMarketData(instruments, 2);
        }

        private static void MdUser_onRtnDepthMarketData(object sender, OnRtnDepthMarketDataEventArgs e)
        {
            if (e.PDepthMarketData != null)
            {
                Console.WriteLine(string.Format("[{0}.{1}] {2} [LastPrice={3:F1}]",
                    e.PDepthMarketData.Value.UpdateTime,
                    e.PDepthMarketData.Value.UpdateMillisec,
                    e.PDepthMarketData.Value.InstrumentID,
                    e.PDepthMarketData.Value.LastPrice));
            }
        }

        private static void MdUser_onFrontConnected(object sender, EventArgs e)
        {
            Console.WriteLine("OnFrontConnected");
        }

        static MdUserWrapper mdUser = null;
    }
}
