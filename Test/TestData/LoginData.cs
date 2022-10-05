using System.Collections.Generic;

namespace Test_automation.Test.TestData
{
    public static class LoginData
    {
        static LoginData()
        {
            List<string> usernames = new List<string>();
            
            usernames.Add("Admin");
            usernames.Add("User1");
            usernames.Add("User2");

            username = "admin";
            password = "123qwe";
        }
        public static string username { get; set; }
        public static string password { get; set; }

    }
}
