using NUnit.Framework;
using Test_automation.Src.Actions;
using Test_automation.Src.PageObject;
using Test_automation.Test.TestData;

namespace Test_automation.Test.Scripts
{

    [TestFixture]
    public class Tests : TestBase
    {
        [Test]
        public void Login()
        {
            Pages.Goto("http://mt-test.ahad.sa/");
            Pages.LoginPage.TypeUsername(LoginData.username);
            Pages.LoginPage.Typepassword(LoginData.password);
            Pages.LoginPage.ClickLogin();
            Pages.HomePage.WaitUntilTitleHeaderVisible();
            Assertion.AssertAreEqual(driver.Url, HomeData.url);
        }
    }


}