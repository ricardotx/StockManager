﻿using StockManager.Database.Source.Models;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
  public interface IProductLocationService
  {
    /// <summary>
    /// Associate a product to a location
    /// </summary>
    Task AddProductLocationAsync(ProductLocation data, int userId);

    /// <summary>
    /// Remove the association product-location
    /// </summary>
    Task DeleteProductLocationAsyn(int productLocationId, int userId);
  }
}