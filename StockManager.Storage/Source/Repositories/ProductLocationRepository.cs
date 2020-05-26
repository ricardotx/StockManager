﻿using Microsoft.EntityFrameworkCore;
using StockManager.Storage.Source.Contracts;
using StockManager.Storage.Source.Models;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Storage.Source.Repositories {
  public class ProductLocationRepository : IProductLocationRepository {
    private readonly StorageContext _db;

    public ProductLocationRepository(StorageContext db) {
      _db = db;
    }

    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    public async Task InsertProductLocationAsync(ProductLocation data) {
      await _db.ProductLocations.AddAsync(data);
    }

    public async Task<ProductLocation> FindProductLocationAsync(int productId, int locationId) {
      return await _db.ProductLocations
        .Where(pl => pl.ProductId == productId && pl.LocationId == locationId)
        .FirstOrDefaultAsync();
    }

    public async Task<ProductLocation> FindProductLocationByIdAsync(int productLocationId) {
      return await _db.ProductLocations
        .Where(x => x.ProductLocationId == productLocationId)
        .FirstOrDefaultAsync();
    }

    public void RemoveProductLocation(ProductLocation productLocation) {
      _db.ProductLocations.Remove(productLocation);
    }
  }
}
