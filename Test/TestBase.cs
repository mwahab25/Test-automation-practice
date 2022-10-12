using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Test_automation.Src.Utils;
using Test_automation.Src.PageObject;
using Test_automation.Src.Actions;

namespace Test_automation.Test
{
    public abstract class TestBase
    {

        protected static IWebDriver driver;

        [OneTimeSetUp]
        public virtual void BeforeAll()
        {
            Log.SetLog(@"./log.txt");
            Report.SetReport(@"./Report");
            ExcelManager.SetExcel(@"D:\tc.xlsx");
        }

        [SetUp]
        public virtual void BeforeEach()
        {
            Driver.OpenBrowser();

            Pages.Init(driver);

            Log.StartTestCase(TestContext.CurrentContext.Test.Name);
            Report.CreateTest(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.Test.FullName);
        }


        [TearDown]
        public virtual void AfterEach()
        {
            driver.Close();    
        }


        [OneTimeTearDown]
        public virtual void AfterAll()
        {
            driver.Quit();
            Report.Flush();
            ExcelManager.SaveCloseExcel();
        }
    }
}
