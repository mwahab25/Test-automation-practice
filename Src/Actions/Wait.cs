using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Log.Info($"WaitUntilElementToBeClickable { locator.Text}");
            Report.Info($"WaitUntilElementToBeClickable { locator.Text}");

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
