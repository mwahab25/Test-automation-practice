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
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How=How.Name,Using = "usernameOrEmailAddress")]
        private IWebElement username_text;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement password_text;

        [FindsBy(How = How.Id, Using = "kt_login_signin_submit")]
        private IWebElement login_btn;

        public void Login(string username,string password)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            Log.Info("type username");
            Report.Info("type username");

            wait.Until(ExpectedConditions.ElementToBeClickable(username_text));      
            username_text.SendKeys(username);

            Log.Info("type password");
            Report.Info("type password");
            wait.Until(ExpectedConditions.ElementToBeClickable(password_text));
            password_text.SendKeys(password);


            Log.Info("Click login");
            Report.Info("Click login");
            wait.Until(ExpectedConditions.ElementToBeClickable(login_btn));
            login_btn.Click();
        }

        public void Login(string[] username, string password)
        {
        }

    }
}
