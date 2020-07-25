﻿using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Core.Source.Models;

namespace StockManager.Core.Source.Services
{
    public interface IStockMovementService
    {
        /// <summary>
        /// Create a stock movement
        /// </summary>
        /// <param name="data">StockMovement data</param>
        /// <param name="applyDbChanges">
        /// Set it to true if you want to call "SaveDbChangesAsync" immediately after create the
        /// stock movement
        /// </param>
        Task CreateAsync(StockMovement data, bool applyDbChanges = false);

        /// <summary>
        /// Create an entry/exit stock movement inside the main location and update the LocationProductStock
        /// </summary>
        Task CreateMovementInsideMainLocationAsync(int productId, float qty, bool isEntry, int userId);

        /// <summary>
        /// Get all stock movements
        /// </summary>
        Task<IEnumerable<StockMovement>> GetAllAsync(string searchValue);

        /// <summary>
        /// Get the product last stock movement
        /// </summary>
        Task<StockMovement> GetProductLastMovementAsync(int productId);

        /// <summary>
        /// Move the stock from one location to another.
        /// </summary>
        Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId);

        /// <summary>
        /// Move the stock back to the main location
        /// </summary>
        /// <param name="applyDbChanges">
        /// Set it to true if you want to call "SaveDbChangesAsync" immediately after finished the
        /// stock movement
        /// </param>
        Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false);
    }
}
