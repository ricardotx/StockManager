﻿using StockManager.Database.Source.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Services.Source.Contracts
{
    public interface IProductService
    {
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
