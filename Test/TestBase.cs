using NUnit.Framework;
using Test_automation.Src.Actions;
using Test_automation.Src.PageObject;
using Test_automation.Src.Utils;

namespace Test_automation.Test
{
    public abstract class TestBase
    {
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
            Log.StartTestCase(TestContext.CurrentContext.Test.Name);
            Report.CreateTest(TestContext.CurrentContext.Test.Name, TestContext.CurrentContext.Test.FullName);
            
            Driver.Init(Config.Browser);
            Pages.Init(Driver.driver); 
        }


        [TearDown]
        public virtual void AfterEach()
        {
            Driver.CloseDriver();    
        }


        [OneTimeTearDown]
        public virtual void AfterAll()
        {
            Driver.QuitDriver();
            Report.Flush();
            ExcelManager.SaveCloseExcel();
        }
    }
}
