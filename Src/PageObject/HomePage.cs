using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Test_automation.Src.Actions;

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

        public string WaitUntilTitleHeaderVisible()
        {
            Wait.WaitUntilElementToBeClickable(driver, title_header, "fluent");
            return title_header.Text;
        }

    }
}
