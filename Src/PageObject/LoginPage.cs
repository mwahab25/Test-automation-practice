using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
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
            
            Element.Type(username_text, username, "username");

            Wait.WaitUntilElementToBeClickable(driver, password_text, "explicit");

            Element.Type(password_text,password, "password");

            Wait.WaitUntilElementToBeClickable(driver, login_btn, "fluent");

            Element.Click(login_btn,"login");
        }

        public void TypeUsername(string username)
        {
            Wait.WaitUntilElementToBeClickable(driver, username_text, "explicit");

            Element.Type(username_text, username,"username");
        }

        public void Typepassword(string password)
        {

            Wait.WaitUntilElementToBeClickable(driver, password_text, "explicit");

            Element.Type(password_text, password,"password");
        }

        public void ClickLogin()
        {
            Wait.WaitUntilElementToBeClickable(driver, login_btn, "fluent");

            Element.Click(login_btn,"login");
        }

        public void Goto(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
