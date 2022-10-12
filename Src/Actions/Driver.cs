using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using Test_automation.Src.Utils;

namespace Test_automation.Src.Actions
{
    public class Driver
    {
        public static IWebDriver driver;
        public static void Init(string browser)
        {
            driver = BuildDriver(browser);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Config.Timeout);

            Log.Info($"open {browser} browser");
            Report.Info($"open {browser} browser");
        }
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

        public static void NavigateToUrl(string url)
        {
            Log.Info($"Navigate to  {url}");
            Report.Info($"Navigate to  {url}");
            driver.Navigate().GoToUrl(url);
        }

        public static string GetUrl()
        {
            return driver.Url;
        }

        public static void CloseDriver()
        {
            Log.Info($"Close browser");
            Report.Info($"Close browser");
            driver.Close();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

    }
}
