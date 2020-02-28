﻿using StockManager.Database.Models;
using StockManager.Types;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Database.Brokers
{
  public interface ILocationBroker
  {
    Task SaveDbChangesAsync();

    Task AddLocationAsync(Location location);
   
    void RemoveLocation(Location location);

    Task<IEnumerable<Location>> FindAllLocationsAsync(string searchValue = null);

    Task<Location> FindLocationByIdAsync(int locationId);

  }
}
