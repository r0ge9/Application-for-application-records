using DiplomApp.Domain;

namespace DiplomApp
{
    internal static class Program
    {
        public static string fio;
        public static string login { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new SignForm());
        }
    }
}