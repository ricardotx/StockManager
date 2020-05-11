﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManager.Storage.Source;

namespace StockManager.Storage.Source.Migrations
{
    [DbContext(typeof(StorageContext))]
    [Migration("20200511185729_AddSettingsModel")]
    partial class AddSettingsModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("StockManager.Storage.Source.Models.Location", b =>
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

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UniqueName");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433),
                            Name = "Warehouse",
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433)
                        },
                        new
                        {
                            LocationId = 2,
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433),
                            Name = "Vehicle #1",
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 93, DateTimeKind.Utc).AddTicks(5433)
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.Product", b =>
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

            modelBuilder.Entity("StockManager.Storage.Source.Models.ProductLocation", b =>
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

            modelBuilder.Entity("StockManager.Storage.Source.Models.Role", b =>
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
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266),
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266)
                        },
                        new
                        {
                            RoleId = 2,
                            Code = "User",
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266),
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 978, DateTimeKind.Utc).AddTicks(8266)
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.Settings", b =>
                {
                    b.Property<int>("SettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("SettingsId");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            SettingsId = 1,
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 952, DateTimeKind.Utc).AddTicks(4484),
                            Language = "pt-PT",
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 27, 952, DateTimeKind.Utc).AddTicks(4484)
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.StockMovement", b =>
                {
                    b.Property<int>("StockMovementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FromLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Qty")
                        .HasColumnType("REAL");

                    b.Property<float>("Stock")
                        .HasColumnType("REAL");

                    b.Property<int?>("ToLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StockMovementId");

                    b.HasIndex("FromLocationId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ToLocationId");

                    b.HasIndex("UserId");

                    b.ToTable("StockMovements");
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.User", b =>
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
                            CreatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 78, DateTimeKind.Utc).AddTicks(8967),
                            Password = "$2b$10$Hm1bEXmRSjHTQFfoA4bu7uXupkYzVmtVevsxpJjyIYPSq5DlJZUc2",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2020, 5, 11, 18, 57, 28, 78, DateTimeKind.Utc).AddTicks(8967),
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.ProductLocation", b =>
                {
                    b.HasOne("StockManager.Storage.Source.Models.Location", "Location")
                        .WithMany("ProductLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Source.Models.Product", "Product")
                        .WithMany("ProductLocations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.StockMovement", b =>
                {
                    b.HasOne("StockManager.Storage.Source.Models.Location", "FromLocation")
                        .WithMany("StockMovementsFrom")
                        .HasForeignKey("FromLocationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("StockManager.Storage.Source.Models.Product", "Product")
                        .WithMany("StockMovements")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StockManager.Storage.Source.Models.Location", "ToLocation")
                        .WithMany("StockMovementsTo")
                        .HasForeignKey("ToLocationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("StockManager.Storage.Source.Models.User", "User")
                        .WithMany("StockMovements")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);
                });

            modelBuilder.Entity("StockManager.Storage.Source.Models.User", b =>
                {
                    b.HasOne("StockManager.Storage.Source.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
