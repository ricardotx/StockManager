﻿using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using StockManager.Services.Contracts;
using StockManager.Services.Services;
using StockManager.Storage;
using StockManager.Storage.Repositories;

namespace StockManager.Tests {
  public class Configuration {
    private readonly SqliteConnection connection;
    private readonly StorageContext StorageContext;

    public Configuration() {
      // Set the Sqlite in memory database connection
      this.connection = new SqliteConnection("DataSource =:memory:");

      // Open database connection 
      this.connection.Open();

      // Set the options builder for our test storage context
      var builder = new DbContextOptionsBuilder<StorageContext>();
      builder.UseSqlite(connection);

      // Instantiate our test storage context
      this.StorageContext = new StorageContext(builder.Options);
    }

    /// <summary>
    /// Set the user service
    /// </summary>
    /// <returns>IUserService</returns>
    public IUserService SetUserService() => new UserService(new UserRepository(this.StorageContext));

    /// <summary>
    /// Get the test storage context
    /// </summary>
    /// <returns>StorageContext</returns>
    public StorageContext GetStorageContext() => this.StorageContext;

    /// <summary>
    ///  Close storage connection after each test
    /// </summary>
    public void CloseConnection() => this.connection.Close();
  }
}
