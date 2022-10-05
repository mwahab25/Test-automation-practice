using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_automation.Test.TestData
{
    public static class HomeData
    {
        static HomeData()
        {
            url = "https://mt-test.ahad.sa/App/TenantDashboard";
        }
        public static string url { get; set; }
    }
}
