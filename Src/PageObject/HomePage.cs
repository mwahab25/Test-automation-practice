using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_automation.Src.PageObject
{
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "h3.kt-subheader__title")]
        private IWebElement title_header;

        public string GetHeaderTitle()
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait.Until(ExpectedConditions.ElementToBeClickable(title_header));

           return  title_header.Text;

        }

    }
}
