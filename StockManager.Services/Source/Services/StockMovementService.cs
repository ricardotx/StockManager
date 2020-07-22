﻿using System.Collections.Generic;
using System.Threading.Tasks;

using StockManager.Database.Source.Contracts;
using StockManager.Database.Source.Models;
using StockManager.Services.Source.Contracts;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Services.Source.Services
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IRepository _repository;

        public StockMovementService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task AddStockMovementAsync(StockMovement data, bool applyDbChanges = false)
        {
            try
            {
                int locationId = ( int )((data.ToLocationId != null)
                  ? data.ToLocationId
                  : data.FromLocationId);

                ProductLocation productLocation = await AppServices.ProductLocationService
                  .GetProductLocationAsync(data.ProductId, locationId);

                // Calculate the new accumulated stock
                if (productLocation != null)
                {
                    data.Stock = (productLocation.Stock + data.Qty);
                }
                else
                {
                    // Set the accumulated if it is the first movement
                    data.Stock = data.Qty;
                }

                await _repository.StockMovements.AddAsync(data);

                // Normally this service is called inside other services and the call of the
                // SaveChangesAsync method it will be the responsibility of the other service. In
                // some circumstances we want the apply the db changes after create the stock
                // movement, for that we need to sent the applyDbChanges setted to true.
                if (applyDbChanges)
                {
                    await _repository.SaveChangesAsync();
                }
            }
            catch
            {
                OperationErrorsList errorsList = new OperationErrorsList();
                errorsList.AddError("add-stock-movement-db-error", Phrases.GlobalErrorOperationDB);

                throw new ServiceErrorException(errorsList);
            }
        }

        public async Task AddStockMovementInsideMainLocationAsync(int productId, float qty, bool isEntry, int userId)
        {
            try
            {
                Location mainLocation = await AppServices.LocationService.GetMainLocationAsync();
                ProductLocation productLocation = await AppServices.ProductLocationService
                  .GetProductLocationAsync(productId, mainLocation.LocationId);

                // If is an exit movement, set negative qty
                float qtyToMove = isEntry ? qty : (qty * (-1));

                // Create the stock movement
                await AddStockMovementAsync(new StockMovement()
                {
                    UserId = userId,
                    ProductId = productId,
                    ToLocationId = mainLocation.LocationId,
                    ToLocationName = mainLocation.Name,
                    Qty = qtyToMove,
                });

                // Update the stock in the ProductLocation relation
                productLocation.Stock += qtyToMove;

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task<IEnumerable<StockMovement>> GetAllAsync(string searchValue)
        {
            return await _repository.StockMovements
                .FindAllWithProductAndUserAsync(x => x.Product.Reference.ToLower().Contains(searchValue.ToLower())
                    || x.Product.Name.ToLower().Contains(searchValue.ToLower()));
        }

        public async Task<StockMovement> GetProductLastStockMovementAsync(int productId)
        {
            return await _repository.StockMovements.FindLastStockMovementAsync(x => x.ProductId == productId);
        }

        public async Task MoveStockBetweenLocationsAsync(int fromLocationId, int toLocationId, int productId, float qty, int userId)
        {
            OperationErrorsList errorsList = new OperationErrorsList();

            try
            {
                // Get the relation productId > fromLocationId to check if the qty can be accepted
                ProductLocation fromLocationRelation = await AppServices.ProductLocationService
                   .GetProductLocationAsync(productId, fromLocationId);

                if (fromLocationRelation.Stock < qty)
                {
                    errorsList.AddError("qty", Phrases.StockMovementErrorQty);
                    throw new OperationErrorException(errorsList);
                }

                Location fromLocation = await AppServices.LocationService.GetLocationByIdAsync(fromLocationId);
                Location toLocation = await AppServices.LocationService.GetLocationByIdAsync(toLocationId);

                // Set the stock movement between locations
                StockMovement stockMovement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = productId,
                    FromLocationId = fromLocation.LocationId,
                    FromLocationName = fromLocation.Name,
                    ToLocationId = toLocation.LocationId,
                    ToLocationName = toLocation.Name,
                    Qty = qty,
                };

                // Create the stock movement
                await AddStockMovementAsync(stockMovement);

                // Update the stock in the From location
                fromLocationRelation.Stock -= qty;

                // Update the stock in the To location
                ProductLocation toLocationRelation = await AppServices.ProductLocationService
                   .GetProductLocationAsync(productId, toLocationId);

                // If the product is associated to the location, update the stock
                if (toLocationRelation != null)
                {
                    toLocationRelation.Stock += qty;
                }
                else
                {
                    // If not, create the relation
                    await AppServices.ProductLocationService.AddProductLocationAsync(
                      new ProductLocation
                      {
                          LocationId = toLocationId,
                          ProductId = productId,
                          Stock = qty,
                      },
                      userId,
                      false,
                      false
                    );
                }

                await _repository.SaveChangesAsync();
            }
            catch (OperationErrorException operationErrorException)
            {
                throw operationErrorException;
            }
        }

        public async Task MoveStockToMainLocationAsync(ProductLocation data, int userId, bool applyDbChanges = false)
        {
            // Get the main location
            Location mainLocation = await AppServices.LocationService.GetMainLocationAsync();

            // Only create the stock movement if it has stock and the fromLocation is not the main location.
            if ((data.Stock > 0) && (mainLocation.LocationId != data.LocationId))
            {
                // Create a stock movement between locations
                StockMovement stockMovement = new StockMovement()
                {
                    UserId = userId,
                    ProductId = data.ProductId,
                    FromLocationId = data.LocationId,
                    FromLocationName = data.Location.Name,
                    ToLocationId = mainLocation.LocationId,
                    ToLocationName = mainLocation.Name,
                    Qty = data.Stock,
                };

                await AddStockMovementAsync(stockMovement);

                // Get the relation between the product and the main location to be updated
                ProductLocation mainLocationRelation = await AppServices.ProductLocationService
                  .GetProductLocationAsync(data.ProductId, mainLocation.LocationId);

                // Update the relation stock
                mainLocationRelation.Stock += data.Stock;

                if (applyDbChanges)
                {
                    await _repository.SaveChangesAsync();
                }
            }
        }
    }
}
