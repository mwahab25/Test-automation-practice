using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace Test_automation.Src.Utils
{
    class Report
    {
        private static ExtentReports extent;
        private static ExtentTest testcase;
        public static void SetReport(string reportpath)
        {
            extent = new ExtentReports();
            var htmlreport = new ExtentHtmlReporter(reportpath);
            htmlreport.Config.Theme = Theme.Standard;
            extent.AttachReporter(htmlreport);
        }

        public static void Flush()
        {
            extent.Flush();
        }

        public static void CreateTest(string _testcase,string desc)
        {
            testcase = extent.CreateTest(_testcase, desc);
        }
        public static void StartTestCase(string message)
        {
            testcase.Info($"Start TestCase{message}");
        }

        public static void EndTestCase(string message)
        {
            testcase.Info($"End TestCase{message}");
        }

        public static void Info(string message)
        {
            testcase.Info(message);
        }

        public static void Pass(string message)
        {
            testcase.Pass(message);
        }

        public static void Fail(string message)
        {
            testcase.Fail(message);
        }

        public static void Error(string message)
        {
            testcase.Error(message);
        }

        public static void Warn(string message)
        {
            testcase.Warning(message);
        }
    }
}
