﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using StockManager.Core.Source.Models;
using StockManager.Services.Source;

namespace StockManager.Tests.Source.Services
{
    /// <summary>
    /// Role service tests
    /// </summary>
    [TestClass]
    public class RoleServiceTests
    {
        private TestsConfig _config;

        [TestCleanup]
        public void AfterEach()
        {
            _config.CloseConnection();
        }

        [TestInitialize]
        public void BeforeEach()
        {
            _config = new TestsConfig();
        }

        /// <summary>
        /// Should get all roles
        /// </summary>
        [TestMethod]
        public async Task ShouldGetAllRoles()
        {
            // Arrange

            // Act
            IEnumerable<Role> roles = await AppServices.RoleService.GetAllAsync();

            // Assert
            Assert.AreEqual(roles.Count(), 2);
            Assert.AreEqual(roles.ElementAt(0).Code, "Admin");
            Assert.AreEqual(roles.ElementAt(1).Code, "User");
        }
    }
}
