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

namespace Test_automation
{
    
    [TestFixture]
    public class Tests
    {
        private static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Log.SetLog(@"./log.txt");
            Report.SetReport(@"./Report");

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mt-test.ahad.sa/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [Test]
        public void Test1()
        {
            Log.StartTestCase("Login to system");
            Report.CreateTest("Login", "Login to system");

            LoginPage login_page = new LoginPage(driver);

            //for (int i = 0; i < LoginData.username.Length; i++)
            //{
                login_page.Login(LoginData.username, LoginData.password);
            //}

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

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Report.Flush();
        }
    }

    
}