﻿using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Services.Source.Contracts
{
    public interface IProductService
    {
        /// <summary>
        /// Count and return the total of the products in the app
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// Create new product
        /// </summary>
        Task CreateProductAsync(Product product, int userId);

        /// <summary>
        /// Delete products
        /// </summary>
        Task DeleteProductAsync(int[] productIds);

        /// <summary>
        /// Edit product
        /// </summary>
        Task EditProductAsync(Product product);

        /// <summary>
        /// Get product by id
        /// </summary>
        Task<Product> GetProductByIdAsync(int productId);

        /// <summary>
        /// Get all products
        /// </summary>
        Task<IEnumerable<Product>> GetProductsAsync(string searchValue = null);
    }
}
