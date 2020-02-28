﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StockManager.Database.Models;
using StockManager.Database.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StockManager.Database
{
  public class StorageContext : DbContext
  {
    public StorageContext() : base()
    {
      // Run the migrations when the DB is instantiated 
      this.Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlite(@"Data Source=.\StockManagerDB.sqlite");
    }

    /// <summary>
    /// Auto fill the CreatedAt and the UpdatedAt model fields
    /// https://www.entityframeworktutorial.net/faq/set-created-and-modified-date-in-efcore.aspx
    /// </summary>
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
      IEnumerable<EntityEntry> entries = ChangeTracker
          .Entries()
          .Where(x => x.Entity is BaseEntity
            && (x.State == EntityState.Added || x.State == EntityState.Modified));

      foreach (EntityEntry entityEntry in entries)
      {
        ((BaseEntity)entityEntry.Entity).UpdatedAt = DateTime.UtcNow;

        if (entityEntry.State == EntityState.Added)
        {
          ((BaseEntity)entityEntry.Entity).CreatedAt = DateTime.UtcNow;
        }
      }

      return await base.SaveChangesAsync(true, cancellationToken);
    }

    /// <summary>
    /// Add models indexes and seed the inital DB values
    /// https://docs.microsoft.com/en-us/ef/core/modeling/indexes
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Role>()
          .HasIndex(x => x.Code)
          .IsUnique()
          .HasName("UniqueCode");

      modelBuilder.Entity<User>()
          .HasIndex(x => x.Username)
          .IsUnique()
          .HasName("UniqueUsername");

      modelBuilder.Entity<Product>()
          .HasIndex(x => x.Reference)
          .IsUnique()
          .HasName("UniqueReference");

      modelBuilder.Entity<ProductLocation>()
         .Property(x => x.Stock)
         .HasDefaultValue(0);

      modelBuilder.Entity<ProductLocation>()
         .Property(x => x.MinStock)
         .HasDefaultValue(0);

      modelBuilder.Entity<ProductLocation>()
        .HasIndex(x => new { x.ProductId, x.LocationId })
        .IsUnique()
        .HasName("UniqueProductIdLocationIdPair");

      // Seed the DB with the initial values
      // https://code-maze.com/migrations-and-seed-data-efcore/
      modelBuilder.ApplyConfiguration(new RolesConfiguration());
      modelBuilder.ApplyConfiguration(new UsersConfiguration());
    }

    /// <summary>
    /// Add Database Tables Here..
    /// </summary>
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductLocation> ProductLocations { get; set; }
    public DbSet<StockMovement> StockMovements { get; set; }
  }
}
