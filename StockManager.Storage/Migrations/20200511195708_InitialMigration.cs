﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Storage.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    AppSettingsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.AppSettingsId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Reference = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Code = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "ProductLocations",
                columns: table => new
                {
                    ProductLocationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Stock = table.Column<float>(nullable: false, defaultValue: 0f),
                    MinStock = table.Column<float>(nullable: false, defaultValue: 0f),
                    ProductId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLocations", x => x.ProductLocationId);
                    table.ForeignKey(
                        name: "FK_ProductLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductLocations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockMovements",
                columns: table => new
                {
                    StockMovementId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Qty = table.Column<float>(nullable: false),
                    Stock = table.Column<float>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    FromLocationId = table.Column<int>(nullable: true),
                    ToLocationId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMovements", x => x.StockMovementId);
                    table.ForeignKey(
                        name: "FK_StockMovements_Locations_FromLocationId",
                        column: x => x.FromLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_StockMovements_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockMovements_Locations_ToLocationId",
                        column: x => x.ToLocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_StockMovements_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "AppSettings",
                columns: new[] { "AppSettingsId", "CreatedAt", "Language", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 5, 11, 19, 57, 7, 692, DateTimeKind.Utc).AddTicks(8549), "pt-PT", new DateTime(2020, 5, 11, 19, 57, 7, 692, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2020, 5, 11, 19, 57, 7, 837, DateTimeKind.Utc).AddTicks(3886), "Warehouse", new DateTime(2020, 5, 11, 19, 57, 7, 837, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2020, 5, 11, 19, 57, 7, 837, DateTimeKind.Utc).AddTicks(3886), "Vehicle #1", new DateTime(2020, 5, 11, 19, 57, 7, 837, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 1, "Admin", new DateTime(2020, 5, 11, 19, 57, 7, 719, DateTimeKind.Utc).AddTicks(2112), new DateTime(2020, 5, 11, 19, 57, 7, 719, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Code", "CreatedAt", "UpdatedAt" },
                values: new object[] { 2, "User", new DateTime(2020, 5, 11, 19, 57, 7, 719, DateTimeKind.Utc).AddTicks(2112), new DateTime(2020, 5, 11, 19, 57, 7, 719, DateTimeKind.Utc).AddTicks(2112) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "LastLogin", "Password", "RoleId", "UpdatedAt", "Username" },
                values: new object[] { 1, new DateTime(2020, 5, 11, 19, 57, 7, 822, DateTimeKind.Utc).AddTicks(7100), null, "$2b$10$d6Cx5ONpi0o08El8P3Nefukv/pMjPB6VhNoGwz.TTbWfXzn69uNLO", 1, new DateTime(2020, 5, 11, 19, 57, 7, 822, DateTimeKind.Utc).AddTicks(7100), "Admin" });

            migrationBuilder.CreateIndex(
                name: "UniqueName",
                table: "Locations",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductLocations_LocationId",
                table: "ProductLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "UniqueProductIdLocationIdPair",
                table: "ProductLocations",
                columns: new[] { "ProductId", "LocationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UniqueReference",
                table: "Products",
                column: "Reference",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UniqueCode",
                table: "Roles",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_FromLocationId",
                table: "StockMovements",
                column: "FromLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ProductId",
                table: "StockMovements",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_ToLocationId",
                table: "StockMovements",
                column: "ToLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_StockMovements_UserId",
                table: "StockMovements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UniqueUsername",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "ProductLocations");

            migrationBuilder.DropTable(
                name: "StockMovements");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
