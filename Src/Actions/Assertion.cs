using NUnit.Framework;
using Test_automation.Src.Utils;

namespace Test_automation.Src.Actions
{
    public class Assertion
    {
        public static void AssertAreEqual(string expected,string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
                Log.Pass("test case passed");
                Report.Pass("test case passed");
            }
            catch
            {
                Log.Fail("test case Failed");
                Report.Fail("test case Failed");
            }
        }
    }
}
