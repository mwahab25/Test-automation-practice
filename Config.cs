namespace Test_automation
{
    public static class Config
    {
        static Config()
        {
            Timeout = 30;
            Browser = "chrome";
        }
        public static double Timeout { get; set; }

        public static string Browser { get; set; }
    }

    
}
