using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_automation.Src.Actions
{
    class Element
    {

        public static void Click(IWebElement element)
        {
            Log.Info($"Click { element.ToString()}");
            Report.Info($"Click { element.ToString()}");
            
            element.Click();
        }
        public static void Type(IWebElement element, string text)
        {
            Log.Info($"Type { text} on element {element.ToString()}");
            Report.Info($"Type { text} on element {element.ToString()}");
            element.SendKeys(text);
        }
    }
}
