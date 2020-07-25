using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.EntityFrameworkCore;

using StockManager.Core.Source;
using StockManager.Core.Source.Models;
using StockManager.Database.Source;
using StockManager.Services.Source;
using StockManager.Source.Forms;
using StockManager.Translations.Source;

namespace StockManager.Source
{
    internal static class Program
    {
        /// <summary>
        /// Logged in user
        /// </summary>
        public static User LoggedInUser { get; private set; }

        /// <summary>
        /// Kill the "Session"
        /// </summary>
        public static void Logout()
        {
            LoggedInUser = null;
        }

        /// <summary>
        /// Set the user after authentication
        /// </summary>
        public static void SetLoggedInUser(User user)
        {
            LoggedInUser = user;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the options builder for our database context
            DbContextOptionsBuilder<DatabaseContext> builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlite(AppConstants.connectionString);

            // Instantiate our database
            DatabaseContext DatabaseContext = new DatabaseContext(builder.Options);

            // Instantiate our repository
            IAppRepository AppRepository = new AppRepository(DatabaseContext);

            // Instantiate our services
            AppServices.ConfigureServices(AppRepository);

            // Set the application language
            AppTranslations.ConfigureLanguage(await AppServices.SettingsService.GetAppLanguageAsync());

            Application.Run(new MainForm());
        }
    }
}
