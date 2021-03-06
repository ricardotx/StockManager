﻿using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

using StockManager.Core.Source;
using StockManager.Database.Source;
using StockManager.Services.Source;

namespace StockManager.Tests.Source
{
    public class TestsConfig
    {
        private readonly SqliteConnection _connection;

        public TestsConfig()
        {
            // Set the Sqlite in memory database connection
            _connection = new SqliteConnection(AppConstants.connectionStringTestDB);

            // Open database connection
            _connection.Open();

            // Set the options builder for our test database context
            DbContextOptionsBuilder<DatabaseContext> builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseSqlite(_connection);

            // Instantiate our test database context
            DatabaseContext DatabaseContext = new DatabaseContext(builder.Options);

            // Instantiate our repository
            IAppRepository AppRepository = new AppRepository(DatabaseContext);

            // Instantiate our services
            AppServices.ConfigureServices(AppRepository);
        }

        /// <summary>
        /// Close database connection
        /// </summary>
        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}
