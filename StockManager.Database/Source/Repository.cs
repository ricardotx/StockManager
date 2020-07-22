﻿using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Repositories;

namespace StockManager.Database.Source
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext _context;
        private AppSettingsRepository _appSettingsRepository;
        private LocationRepository _locationRepository;
        private ProductLocationRepository _productLocationRepository;
        private ProductRepository _productRepository;
        private RoleRepository _roleRepository;
        private StockMovementRepository _stockMovementRepository;
        private UserRepository _userRepository;

        public Repository(DatabaseContext context)
        {
            _context = context;
        }

        public IAppSettingsRepository AppSettings => _appSettingsRepository = _appSettingsRepository ?? new AppSettingsRepository(_context);

        public ILocationRepository Locations => _locationRepository = _locationRepository ?? new LocationRepository(_context);

        public IProductLocationRepository ProductLocations => _productLocationRepository = _productLocationRepository ?? new ProductLocationRepository(_context);

        public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);

        public IRoleRepository Roles => _roleRepository = _roleRepository ?? new RoleRepository(_context);

        public IStockMovementRepository StockMovements => _stockMovementRepository = _stockMovementRepository ?? new StockMovementRepository(_context);

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);


        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
