using CommuTech_Admin.Classes;
using CommuTech_Admin.Forms;
namespace CommuTech_Admin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            FirestoreHelper.SetEnviroonmentVariable();
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashScreen());
        }
    }
}