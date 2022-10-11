using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using Test_automation.Src.PageObject;
using Test_automation.Test.TestData;
using Test_automation.Src;
using AventStack.ExtentReports;

namespace Test_automation.Test.Scripts
{
    
    [TestFixture]
    public class Tests : TestBase
    {

        [Test]
        public void Login()
        {
            Log.StartTestCase("Login to system");
            Report.CreateTest("Login", "Login to system");

            LoginPage login_page = new LoginPage(driver);

            string username = ExcelManager.GetCellData(1, 0, "login");
            string password = ExcelManager.GetCellData(1, 1, "login");

            login_page.Login(username, password);


            HomePage home_page = new HomePage(driver);

            home_page.GetHeaderTitle();

            try
            {
                Assert.AreEqual(driver.Url, HomeData.url);
                Log.Pass("Login test case passed");
                Report.Pass("Login test case passed");
            }
            catch
            {
                Log.Fail("Login test case Failed");
                Report.Fail("Login test case Failed");
            }
            ExcelManager.SetCellData("pass",2, 0, "login");
        }
    }

    
}