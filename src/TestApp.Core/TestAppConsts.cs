using TestApp.Debugging;

namespace TestApp
{
    public class TestAppConsts
    {
        public const string LocalizationSourceName = "TestApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1ad3859403a04e0688f8f0f9f5ea822b";
    }
}
