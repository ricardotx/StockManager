﻿using StockManager.Services.Source.Contracts;
using StockManager.Services.Source.Services;
using StockManager.Storage.Source;
using StockManager.Storage.Source.Repositories;

namespace StockManager.Services.Source {
  public static class AppServices {
    public static IAppSettingsService SettingsService { get; private set; }
    public static IUserService UserService { get; private set; }
    public static IRoleService RoleService { get; private set; }
    public static ILocationService LocationService { get; private set; }
    public static IProductService ProductService { get; private set; }
    public static IProductLocationService ProductLocationService { get; private set; }
    public static IStockMovementService StockMovementService { get; private set; }

    public static void ConfigureServices(DatabaseContext storageContext) {
      // Instantiate our services
      SettingsService = new AppSettingsService(new AppSettingsRepository(storageContext));
      UserService = new UserService(new UserRepository(storageContext));
      RoleService = new RoleService(new RoleRepository(storageContext));
      LocationService = new LocationService(new LocationRepository(storageContext));
      ProductService = new ProductService(new ProductRepository(storageContext));
      ProductLocationService = new ProductLocationService(new ProductLocationRepository(storageContext));
      StockMovementService = new StockMovementService(new StockMovementRepository(storageContext));
    }
  }
}
