﻿using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Services.Source.Contracts
{
    public interface IProductLocationService
    {
        /// <summary>
        /// Associate a product to a location
        /// </summary>
        /// <param name="productLocation"></param>
        /// <param name="userId"></param>
        /// <param name="applyDbChanges">Set to false to skip the db save changes</param>
        /// <param name="createStockMovement">Set to false to skip the creation of the stock movement</param>
        Task CreateAsync(ProductLocation productLocation, int userId, bool applyDbChanges = true, bool createStockMovement = true);

        /// <summary>
        /// Remove the association product-location
        /// </summary>
        Task DeleteAsyn(int productLocationId, int userId);

        /// <summary>
        /// Get the ProductLocation relation for the given productId and locationId
        /// </summary>
        Task<ProductLocation> GetOneAsync(int productId, int locationId);

        /// <summary>
        /// Get the ProductLocation by id
        /// </summary>
        Task<ProductLocation> GetByIdAsync(int productLocationId);

        /// <summary>
        /// Update the product location min stock
        /// </summary>
        Task UpdateMinStock(int productLocation, float minStock);
    }
}
