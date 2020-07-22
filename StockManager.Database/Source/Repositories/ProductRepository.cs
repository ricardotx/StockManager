﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;

namespace StockManager.Database.Source.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly DatabaseContext _db;

        public ProductRepository(DatabaseContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Product>> FindAllWithProductLocationsAsync(Expression<Func<Product, bool>> expression)
        {
            return await _db.Products.Include(x => x.ProductLocations).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<Product>> FindAllWithProductLocationsAsync()
        {
            return await _db.Products.Include(x => x.ProductLocations).ToListAsync();
        }

        public async Task<Product> GetByIdWithProductLocationsAndStockMovementsAsync(int id)
        {
            return await _db.Products
                 .Include(x => x.ProductLocations)
                 .Include(x => x.StockMovements)
                 .Where(product => product.ProductId == id)
                 .FirstOrDefaultAsync();
        }
    }
}
