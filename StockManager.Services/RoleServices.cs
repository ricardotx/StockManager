﻿using StockManager.Database;
using StockManager.Database.Models;
using StockManager.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManager.Services
{
  public class RoleServices : IRoleRepository
  {
    private readonly AppDbContext db;

    public RoleServices(AppDbContext db)
    {
      this.db = db;
    }

    /*
     * Get All Roles 
     */
    public IEnumerable<Role> GetRoles() => this.db.Roles.ToList();
  }
}
