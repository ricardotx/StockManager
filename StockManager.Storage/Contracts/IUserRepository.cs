﻿using StockManager.Storage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManager.Storage.Contracts {
  public interface IUserRepository {
    Task SaveDbChangesAsync();

    Task AddUserAsync(User user);

    void RemoveUser(User user);

    Task<IEnumerable<User>> FindAllUsersAsync(string searchValue = null);

    Task<User> FindUserByIdAsync(int userId);

    Task<User> FindUserByUsernameAsync(string username);
  }
}
