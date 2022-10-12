using OpenQA.Selenium;
using Test_automation.Src.Utils;

namespace Test_automation.Src.Actions
{
    class Element
    {

        public static void Click(IWebElement element,string elementname)
        {
            Log.Info($"Click { elementname}");
            Report.Info($"Click { elementname}");
            
            element.Click();
        }
        public static void Type(IWebElement element, string text,string elementname)
        {
            Log.Info($"Type { text} on element {elementname}");
            Report.Info($"Type { text} on element {elementname}");
            element.SendKeys(text);
        }
    }
}
