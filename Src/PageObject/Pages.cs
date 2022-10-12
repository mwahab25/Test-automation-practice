using OpenQA.Selenium;
using Test_automation.Src.Actions;

namespace Test_automation.Src.PageObject
{
    public static class Pages
    {
        public static HomePage HomePage;
        public static LoginPage LoginPage;

        public static void Init(IWebDriver driver)
        {
            HomePage = new HomePage(driver);
            LoginPage = new LoginPage(driver);
        }

        public static void Goto(string url)
        {
            Driver.NavigateToUrl(url);
        }

    }
}
