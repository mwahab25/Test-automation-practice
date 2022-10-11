using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_automation.Src.Actions;

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
            Wait.WaitUntilElementToBeClickable(driver, username_text, "explicit");
            
            Element.Type(username_text, username);

            Wait.WaitUntilElementToBeClickable(driver, password_text, "explicit");

            Element.Type(password_text,password);

            Wait.WaitUntilElementToBeClickable(driver, login_btn, "fluent");

            Element.Click(login_btn);
        }

        public void Login(string[] username, string password)
        {
        }

    }
}
