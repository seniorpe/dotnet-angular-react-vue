using Senior.Boilerplate.Debugging;

namespace Senior.Boilerplate
{
    public class BoilerplateConsts
    {
        public const string LocalizationSourceName = "Boilerplate";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "4f95f00c358348068c712173b5a64635";
    }
}
