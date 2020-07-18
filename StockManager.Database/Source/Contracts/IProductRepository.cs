﻿using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Contracts
{
    public interface IProductRepository
    {
        /// <summary>
        /// Add new product
        /// </summary>
        Task AddProductAsync(Product product);

        /// <summary>
        /// Count all the products in the DB
        /// </summary>
        Task<int> CountAsync();

        /// <summary>
        /// Find all products
        /// </summary>
        Task<IEnumerable<Product>> FindAllProductsAsync(string searchValue = null);

        /// <summary>
        /// Find product by id
        /// </summary>
        Task<Product> FindProductByIdAsync(int productId, bool includeRelations = true);

        /// <summary>
        /// Find user by reference
        /// </summary>
        Task<Product> FindProductByReferenceAsync(string reference);

        /// <summary>
        /// Remove product
        /// </summary>
        void RemoveProduct(Product product);

        /// <summary>
        /// Save DB changes
        /// </summary>
        Task SaveDbChangesAsync();
    }
}
