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
            Pages.Goto("https://mt-test.ahad.sa/Account/Login");
            Pages.LoginPage.TypeUsername(LoginData.username);
            Pages.LoginPage.Typepassword(LoginData.password);
            Pages.LoginPage.ClickLogin();
            Pages.HomePage.WaitUntilTitleHeaderVisible();
            Assertion.AssertAreEqual(Driver.GetUrl(), HomeData.url);
        }
    }


}