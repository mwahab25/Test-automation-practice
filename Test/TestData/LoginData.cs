using Test_automation.Src.Utils;

namespace Test_automation.Test.TestData
{
    public static class LoginData
    {
        static LoginData()
        {
            username = ExcelManager.GetCellData(1, 0, "login");
            password = ExcelManager.GetCellData(1, 1, "login");
        }
        public static string username { get; set; }
        public static string password { get; set; }

    }
}
