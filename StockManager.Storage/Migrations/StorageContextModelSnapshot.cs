﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManager.Storage;

namespace StockManager.Storage.Migrations
{
    [DbContext(typeof(StorageContext))]
    partial class StorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("StockManager.Storage.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("StockManager.Storage.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.HasIndex("Reference")
                        .IsUnique()
                        .HasName("UniqueReference");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StockManager.Storage.Models.ProductLocation", b =>
                {
                    b.Property<int>("ProductLocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MinStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0f);

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Stock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("REAL")
                        .HasDefaultValue(0f);

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductLocationId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId", "LocationId")
                        .IsUnique()
                        .HasName("UniqueProductIdLocationIdPair");

                    b.ToTable("ProductLocations");
                });

            modelBuilder.Entity("StockManager.Storage.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasName("UniqueCode");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Code = "Admin",
                            CreatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 801, DateTimeKind.Utc).AddTicks(7086),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 801, DateTimeKind.Utc).AddTicks(7086)
                        },
                        new
                        {
                            RoleId = 2,
                            Code = "User",
                            CreatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 801, DateTimeKind.Utc).AddTicks(7086),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 801, DateTimeKind.Utc).AddTicks(7086)
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Models.StockMovement", b =>
                {
                    b.Property<int>("StockMovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FromLocationId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Qty")
                        .HasColumnType("REAL");

                    b.Property<float>("Stock")
                        .HasColumnType("REAL");

                    b.Property<int?>("ToLocationId")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StockMovementId");

                    b.HasIndex("FromLocationId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ToLocationId");

                    b.HasIndex("UserId");

                    b.ToTable("StockMovements");
                });

            modelBuilder.Entity("StockManager.Storage.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasName("UniqueUsername");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 895, DateTimeKind.Utc).AddTicks(6443),
                            Password = "$2b$10$RB3mgMvdY7yaykuMNVtmde.w0sQyO4AZJWeFrKjWnLy0Y0v6hAobe",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 52, 40, 895, DateTimeKind.Utc).AddTicks(6443),
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Models.ProductLocation", b =>
                {
                    b.HasOne("StockManager.Storage.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockManager.Storage.Models.StockMovement", b =>
                {
                    b.HasOne("StockManager.Storage.Models.Location", "FromLocation")
                        .WithMany()
                        .HasForeignKey("FromLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Models.Location", "ToLocation")
                        .WithMany()
                        .HasForeignKey("ToLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockManager.Storage.Models.User", b =>
                {
                    b.HasOne("StockManager.Storage.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
