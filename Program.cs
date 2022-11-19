using Testing;
using biblioteca.tools;
namespace SGB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            /*dbTests.TestGetBook();*/
            SectionTools sectionTools = new();
            sectionTools.CreateSectionFile();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new login());
        }
    }
}