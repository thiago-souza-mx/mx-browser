using IniParser;
using IniParser.Model;
using System.Text;

namespace WebAppMX
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var parser = new FileIniDataParser();
            IniData ini = parser.ReadFile("app.ini", Encoding.UTF8);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SplashForm(ini));
        }
    }
}