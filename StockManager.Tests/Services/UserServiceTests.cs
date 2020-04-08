﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StockManager.Storage.Contracts;
using StockManager.Storage.Models;
using Tynamix.ObjectFiller;
using StockManager.Services.Services;
using System.Threading.Tasks;
using StockManager.Types.Types;
using StockManager.Storage.Repositories;
using StockManager.Services.Contracts;
using StockManager.Storage;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StockManager.Tests.Services {
  /// <summary>
  /// User service tests
  /// </summary>
  [TestClass]
  public class UserServiceTests {
    private readonly StorageContext db;
    private readonly IUserService userService;

    public UserServiceTests() {
      this.db = new StorageConfiguration().StorageContext;
      this.userService = new UserService(new UserRepository(this.db));
    }

    /// <summary>
    /// Test user create
    /// </summary>
    [TestMethod]
    public async Task ShouldCreateUserAsync() {
      // Arrange 
      User newUser = new User() {
        Username = "manel",
        Password = "123",
        RoleId = 1, // admin
      };

      // TODO: When the newUser is sent to the DB
      // After saveChanges, the newUser got the password updated
      // I can avoid get the user becouse his data already change?!!

      // Act 
      await this.userService.CreateUserAsync(newUser);
      User dbUser = await this.db.Users
        .Where(x => x.Username.ToLower() == newUser.Username.ToLower())
        .FirstOrDefaultAsync();

      // Assert 
      Assert.AreEqual(dbUser.Username, newUser.Username);
      Assert.AreEqual(dbUser.RoleId, newUser.RoleId);
      Assert.IsTrue(BCrypt.Net.BCrypt.Verify(newUser.Password, dbUser.Password));
      Assert.IsNotNull(dbUser.CreatedAt);
      Assert.IsNotNull(dbUser.UpdatedAt);
    }

    /// <summary>
    /// Test user create fails (username already exists)
    /// </summary>
    [TestMethod]
    public async Task ShoulFailCreateUserWithExistingUsername() {
      // Arrange 
      User user = new User() {
        Username = "admin",
        Password = "123",
        RoleId = 1, // admin
      };

      try {
        // Act 
        await this.userService.CreateUserAsync(user);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, "This username already exist.");
      }
    }

    /// <summary>
    /// Test user create fails (no username and password sent)
    /// </summary>
    [TestMethod]
    public async Task ShoulFailCreateUserNoUsernameAndPassword() {
      // Arrange 
      User user = new User() { RoleId = 1 };

      try {
        // Act 
        await this.userService.CreateUserAsync(user);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 2);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, "This field is required.");
        Assert.AreEqual(ex.Errors[1].Field, "Password");
        Assert.AreEqual(ex.Errors[1].Error, "This field is required.");
      }
    }

    /// <summary>
    /// Test user edit
    /// </summary>
    [TestMethod]
    public async Task ShouldEditUserAsync() {
      // Arrange 
      await this.userService.CreateUserAsync(new User() {
        Username = "manelito",
        Password = "123",
        RoleId = 2, // user
      });

      User mockUser = await this.db.Users
       .Where(x => x.Username.ToLower() == "manelito")
       .FirstOrDefaultAsync();

      // Act
      User updatedUser = new User() {
        UserId = mockUser.UserId,
        RoleId = 1,
        Username = "manelito updated",
        Password = "321",
      };

      await this.userService.EditUserAsync(updatedUser);
      User dbUser = await this.userService.GetUserByIdAsync(updatedUser.UserId);

      // Assert
      Assert.AreEqual(dbUser.UserId, updatedUser.UserId);
      Assert.AreEqual(dbUser.Username, "manelito updated");
      Assert.IsTrue(BCrypt.Net.BCrypt.Verify(updatedUser.Password, dbUser.Password));
      Assert.AreEqual(dbUser.RoleId, 1);
    }

    /// <summary>
    /// Test user edit fails (username already exists)
    /// </summary>
    [TestMethod]
    public async Task ShoulFailEditUserWithExistingUsername() {
      // Arrange 
      await this.userService.CreateUserAsync(new User() {
        Username = "manelito",
        Password = "123",
        RoleId = 2, // user
      });

      User mockUser = await this.db.Users
       .Where(x => x.Username.ToLower() == "manelito")
       .FirstOrDefaultAsync();

      try {
        // Act
        User updatedUser = new User() {
          UserId = mockUser.UserId,
          RoleId = mockUser.RoleId,
          Username = "admin",
        };

        await this.userService.EditUserAsync(updatedUser);

        Assert.Fail("It should have thrown an OperationErrorExeption");
      } catch (OperationErrorException ex) {
        // Assert 
        Assert.AreEqual(ex.Errors.Count, 1);
        Assert.AreEqual(ex.Errors[0].Field, "Username");
        Assert.AreEqual(ex.Errors[0].Error, "This username already exist.");
      }
    }

    /// <summary>
    /// Test user change password
    /// </summary>

    /// <summary>
    /// Test user change password fails (invalid current password)
    /// </summary>

    /// <summary>
    /// Test user change password fails (no current password and newPassword sent)
    /// </summary>

    /// <summary>
    /// Test user authentication
    /// </summary>

    /// <summary>
    /// Test user authentication fails (no username and password sent)
    /// </summary>

    /// <summary>
    /// Test user authentication fails (bad username and password combination)
    /// </summary>
  }
}
