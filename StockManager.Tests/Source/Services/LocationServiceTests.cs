﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Database.Source.Models;
using StockManager.Services.Source;
using StockManager.Translations.Source;
using StockManager.Types.Source;

namespace StockManager.Tests.Source.Services
{
    /// <summary>
    /// Location service tests
    /// </summary>
    [TestClass]
    public class LocationServiceTests
    {
        private TestsConfig _config;
        private Location _mockLocation;

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public void BeforeEachAsync()
        {
            _config = new TestsConfig();
            _mockLocation = new Location() { Name = "new Location" };
        }

        /// <summary>
        /// Should create location
        /// </summary>
        [TestMethod]
        public async Task ShouldCreateLocation()
        {
            // Arrange
            Location location = _mockLocation;

            // Act
            await AppServices.LocationService.CreateAsync(location);

            // Assert
            Assert.AreEqual(location.Name, "new Location");
            Assert.IsNotNull(location.CreatedAt);
            Assert.IsNotNull(location.UpdatedAt);
        }

        /// <summary>
        /// Should delete location
        /// </summary>
        [TestMethod]
        public async Task ShouldDeleteLocation()
        {
            // Arrange
            Location mockLocation = _mockLocation;
            await AppServices.LocationService.CreateAsync(mockLocation);

            // Act
            await AppServices.LocationService.DeleteAsync(new int[] { mockLocation.LocationId }, 1);

            Location dbLocation = await AppServices.LocationService
              .GetByIdAsync(mockLocation.LocationId);

            // Assert
            Assert.IsNull(dbLocation);
        }

        /// <summary>
        /// Should edit location
        /// </summary>
        [TestMethod]
        public async Task ShouldEditLocation()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse

            // Act
            Location updatedLocation = new Location()
            {
                LocationId = defaultLocation.LocationId,
                Name = "Updated location"
            };

            await AppServices.LocationService.EditAsync(updatedLocation);
            Location dbLocation = await AppServices.LocationService.GetByIdAsync(updatedLocation.LocationId);

            // Assert
            Assert.AreEqual(dbLocation.LocationId, updatedLocation.LocationId);
            Assert.AreEqual(dbLocation.Name, "Updated location");
        }

        /// <summary>
        /// Should fail create location with a existing name
        /// </summary>
        [TestMethod]
        public async Task ShouldFailCreateLocation_ExistingName()
        {
            // Arrange
            Location location = _mockLocation;

            try
            {
                // Act
                location.Name = "Warehouse"; // default
                await AppServices.LocationService.CreateAsync(location);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
            }
        }

        /// <summary>
        /// Should fail delete location - Main location
        /// </summary>
        [TestMethod]
        public async Task ShouldFailDeleteLocation_MainLocation()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse

            try
            {
                // Act
                await AppServices.LocationService.DeleteAsync(new int[] { defaultLocation.LocationId }, 1);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "MainLocation");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorMainLocation);
            }
        }

        /// <summary>
        /// Should fail edit location - existing name
        /// </summary>
        [TestMethod]
        public async Task ShouldFailEditLocation_ExistingLocationName()
        {
            // Arrange
            Location defaultLocation = await AppServices.LocationService.GetByIdAsync(1); // warehouse
            Location defaultLocation2 = await AppServices.LocationService.GetByIdAsync(2); // Vehicle#1

            try
            {
                // Act
                Location updatedLocation = new Location()
                {
                    LocationId = defaultLocation.LocationId,
                    Name = defaultLocation2.Name,
                };

                await AppServices.LocationService.EditAsync(updatedLocation);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.LocationErrorName);
            }
        }

        /// <summary>
        /// Should get all locations
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAllLocations()
        {
            // Arrange
            Location default1 = await AppServices.LocationService.GetByIdAsync(1); // Warehouse
            Location default2 = await AppServices.LocationService.GetByIdAsync(2); // Vehicle #1

            // Act
            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync();

            // Assert
            Assert.AreEqual(locations.Count(), 2);
            Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
            Assert.AreEqual(locations.ElementAt(1).Name, default2.Name);
        }

        /// <summary>
        /// Should search locations by name
        /// </summary>
        [TestMethod]
        public async Task ShouldSearchLocationByName()
        {
            // Arrange
            Location default1 = await AppServices.LocationService.GetByIdAsync(1); // Warehouse

            // Act
            IEnumerable<Location> locations = await AppServices.LocationService.GetAllAsync(default1.Name);

            // Assert
            Assert.AreEqual(locations.Count(), 1);
            Assert.AreEqual(locations.ElementAt(0).Name, default1.Name);
        }

        /// <summary>
        /// Should fail create location - no name sent
        /// </summary>
        [TestMethod]
        public async Task ShoulFailCreateLocation_NoNameSent()
        {
            // Arrange
            Location newLocation = new Location() { Name = "" };

            try
            {
                // Act
                await AppServices.LocationService.CreateAsync(newLocation);

                Assert.Fail("It should have thrown an OperationErrorExeption");
            }
            catch (OperationErrorException ex)
            {
                // Assert
                Assert.AreEqual(ex.Errors.Count, 1);
                Assert.AreEqual(ex.Errors[0].Field, "Name");
                Assert.AreEqual(ex.Errors[0].Error, Phrases.GlobalRequiredField);
            }
        }
    }
}
