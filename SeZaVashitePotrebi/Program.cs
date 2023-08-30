using SeZaVashitePotrebi.Classes;

namespace SeZaVashitePotrebi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static List<Item> AllItems { get; set; } = new List<Item>();
        public static List<AppUser> RegisteredUsers { get; set; } = new List<AppUser>();
        public static AppUser? LoggedIn { get; set; }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}