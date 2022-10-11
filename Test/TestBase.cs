using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_automation.Src;

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
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://mt-test.ahad.sa/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
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
