using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_automation.Src.Utils;

namespace Test_automation.Src.Actions
{
    class Driver
    {
        private static IWebDriver driver;

        private static ChromeDriver BuildChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--headless");

            return new ChromeDriver();
        }

        private static FirefoxDriver BuildFirfoxDriver()
        {
            var options = new FirefoxOptions();
            options.AddArgument("-headless");
            return new FirefoxDriver(options);
        }

        private static EdgeDriver BuildEdgeDriver()
        {
            var options = new EdgeOptions();
            options.AddArgument("--headless");

            return new EdgeDriver(options);
        }

        private static IWebDriver BuildDriver(string browser)
        {
            switch (browser)
            {
                case "chrome":
                    return BuildChromeDriver();
                case "Firefox":
                    return BuildFirfoxDriver();
                case "Edge":
                    return BuildEdgeDriver();
                default:
                    throw new ArgumentException("browser not supported");
            }
        }

        public static void OpenBrowser()
        {
            driver = BuildDriver(Config.Browser);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            Log.Info($"Open { Config.Browser}");
            Report.Info($"Open { Config.Browser}");
        }

        public static void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
