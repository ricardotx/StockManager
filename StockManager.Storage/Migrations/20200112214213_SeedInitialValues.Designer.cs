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
    [Migration("20200112214213_SeedInitialValues")]
    partial class SeedInitialValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

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
                            CreatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230),
                            UpdatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230)
                        },
                        new
                        {
                            RoleId = 2,
                            Code = "User",
                            CreatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230),
                            UpdatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 141, DateTimeKind.Utc).AddTicks(230)
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
                            CreatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795),
                            Password = "$2b$10$eGGf5hvPB.DFTm5c1CkMS..tESLBS1ny7Jf06Y6UiKaOULQAXGQjK",
                            RoleId = 1,
                            UpdatedAt = new DateTime(2020, 1, 12, 21, 42, 13, 238, DateTimeKind.Utc).AddTicks(9795),
                            Username = "Admin"
                        });
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
