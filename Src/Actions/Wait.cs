using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Test_automation.Src.Utils;

namespace Test_automation.Src.Actions
{
    class Wait
    {
        private static WebDriverWait wait;

        private static void WaitExplicit(IWebDriver driver,double? timeout =null)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout ?? Config.Timeout));
        }

        private static void WaitFluent(IWebDriver driver, double? timeout = null)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout ?? Config.Timeout))
            { PollingInterval = TimeSpan.FromMilliseconds(500) };

            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException), typeof(StaleElementReferenceException));
        }

        public static void WaitUntilElementToBeClickable(IWebDriver driver,IWebElement locator,string waittype,double? timeout =null)
        {
            Log.Info($"WaitUntilElementToBeClickable");
            Report.Info($"WaitUntilElementToBeClickable");

            if (waittype == "explicit")
            {
                WaitExplicit(driver,timeout);
            }
            else
            {
                WaitFluent(driver,timeout);
            }
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

    }
}
