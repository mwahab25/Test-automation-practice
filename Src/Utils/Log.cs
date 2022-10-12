using System;
using System.IO;

namespace Test_automation.Src.Utils
{
    class Log
    {
        private static string _filepath;
        private static object _setlock = new object();

        public static void SetLog(string filepath)
        {
            lock (_setlock)
            {
                _filepath = filepath;
                using (var log = File.CreateText(_filepath))
                {
                    log.WriteLine($"strart log:{DateTime.Now.ToLocalTime()}");
                }
            }
        }

        private static void writeline(string text)
        {
            using(var log = File.AppendText(_filepath))
            {
                log.WriteLine(text);
            }
        }

        public static void StartTestCase(string tcname)
        {
            writeline($"[STARTTESTCASE]:{tcname}");
        }

        public static void EndTestCase(string tcname)
        {
            writeline($"[ENDTESTCASE]:{tcname}");
        }

        public static void Info(string message)
        {
            writeline($"[INFO]:{message}");
        }

        public static void Pass(string message)
        {
            writeline($"[PASS]:{message}");
        }

        public static void Fail(string message)
        {
            writeline($"[FAIL]:{message}");
        }

        public static void Warning(string message)
        {
            writeline($"[WARNING]:{message}");
        }

        public static void Error(string message)
        {
            writeline($"[ERROR]:{message}");
        }
    }
}
