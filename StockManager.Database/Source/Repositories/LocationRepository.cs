﻿using Microsoft.EntityFrameworkCore;
using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Database.Source.Repositories {
  public class LocationRepository : ILocationRepository {
    private readonly DatabaseContext _db;

    public LocationRepository(DatabaseContext db) {
      _db = db;
    }

    public async Task SaveDbChangesAsync() {
      await _db.SaveChangesAsync();
    }

    public async Task AddLocationAsync(Location location) {
      await _db.Locations.AddAsync(location);
    }
      
    public void RemoveLocation(Location location) {
      _db.Locations.Remove(location);
    }
      
    public async Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue) {
      if (!string.IsNullOrEmpty(searchValue)) {
        return await _db.Locations
          .Include(x => x.ProductLocations)
          .Where(location => location.Name.ToLower().Contains(searchValue.ToLower()))
          .ToListAsync();
      }

      return await _db.Locations.Include(x => x.ProductLocations).ToListAsync();
    }
     
    public async Task<Location> FindLocationByIdAsync(int locationId) {
      return await _db.Locations
        .Include(x => x.ProductLocations)
        .Where(location => location.LocationId == locationId)
        .FirstOrDefaultAsync();
    }

    public async Task<Location> FindLocationByNameAsync(string name) {
      return await _db.Locations
        .Where(location => location.Name.ToLower() == name.ToLower())
        .FirstOrDefaultAsync();
    }
        
    public async Task<int> CountLocationsAsync() {
      return await _db.Locations.CountAsync();
    }
  }
}
