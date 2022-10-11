using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_automation
{
    public static class Config
    {
        static Config()
        {
            Timeout = 30;
        }
        public static double Timeout { get; set; }
    }

    
}
