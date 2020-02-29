﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManager.Storage;

namespace StockManager.Storage.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20200115215122_AddProductLocationTable")]
    partial class AddProductLocationTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            CreatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728)
                        },
                        new
                        {
                            RoleId = 2,
                            Code = "User",
                            CreatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728),
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 391, DateTimeKind.Utc).AddTicks(5728)
                        });
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
                            CreatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 492, DateTimeKind.Utc).AddTicks(5147),
                            Password = "$2b$10$3C1rUtKBWz8Q3xOQFtPVAe56so25kIJgRLlynP0f5vBZINlwyeBqa",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2020, 1, 15, 21, 51, 21, 492, DateTimeKind.Utc).AddTicks(5147),
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
