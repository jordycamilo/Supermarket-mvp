


using Supermarket_mvp.Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Properties;
using Supermarket_mvp.Views;
using Supermarket_mvp.Presenters;



namespace Supermarket_mvp
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
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            string sqlConnection1String = Settings.Default.SqlConnection1;
            MainView view = new MainView();
            
            new MainPresenter(view, sqlConnectionString);
            

            Application.Run((Form) view);   
            

        }
    }
}   