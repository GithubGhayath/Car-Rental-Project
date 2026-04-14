using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DriverLicenseNumber = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    ContactInformation = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleReturns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActualReturnDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualRentalDays = table.Column<byte>(type: "tinyint", nullable: true),
                    Mileage = table.Column<short>(type: "smallint", nullable: true),
                    ConsumedMileage = table.Column<short>(type: "smallint", nullable: true),
                    FinalCheckNotes = table.Column<string>(type: "NVARCHAR(500)", maxLength: 500, nullable: true),
                    AdditionalCharges = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValue: 0m),
                    ActualTotalDueAmount = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleReturns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Model = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: true),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    PlateNumber = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    VehicleCategoryId = table.Column<int>(type: "int", nullable: false),
                    RentalPricePerDay = table.Column<decimal>(type: "smallmoney", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleCategories_VehicleCategoryId",
                        column: x => x.VehicleCategoryId,
                        principalTable: "VehicleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(300)", maxLength: 300, nullable: false),
                    MaintenanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenances_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    RentalStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    RentalEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    PickupLocation = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    DropoffLocation = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    InitialRentalDays = table.Column<byte>(type: "tinyint", nullable: false),
                    RentalPricePerDay = table.Column<decimal>(type: "smallmoney", nullable: false),
                    InitialTotalDueAmount = table.Column<decimal>(type: "smallmoney", nullable: false),
                    InitialCheckNotes = table.Column<string>(type: "NVARCHAR(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalBookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalBookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalBookings_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentalTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentalBookingId = table.Column<int>(type: "int", nullable: false),
                    VehicleReturnId = table.Column<int>(type: "int", nullable: false),
                    PaymentDetails = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    PaidInitialTotalDueAmount = table.Column<decimal>(type: "smallmoney", nullable: false),
                    ActualTotalDueAmount = table.Column<decimal>(type: "smallmoney", nullable: false),
                    TotalRemaining = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValue: 0m),
                    TotalRefundedAmount = table.Column<decimal>(type: "smallmoney", nullable: false, defaultValue: 0m),
                    TransactionDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedTransactionDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentalTransactions_RentalBookings_RentalBookingId",
                        column: x => x.RentalBookingId,
                        principalTable: "RentalBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalTransactions_VehicleReturns_VehicleReturnId",
                        column: x => x.VehicleReturnId,
                        principalTable: "VehicleReturns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VehicleId",
                table: "Maintenances",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalBookings_CustomerId",
                table: "RentalBookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalBookings_VehicleId",
                table: "RentalBookings",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalTransactions_RentalBookingId",
                table: "RentalTransactions",
                column: "RentalBookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalTransactions_VehicleReturnId",
                table: "RentalTransactions",
                column: "VehicleReturnId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_FuelTypeId",
                table: "Vehicles",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleCategoryId",
                table: "Vehicles",
                column: "VehicleCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "RentalTransactions");

            migrationBuilder.DropTable(
                name: "RentalBookings");

            migrationBuilder.DropTable(
                name: "VehicleReturns");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "FuleTypes");

            migrationBuilder.DropTable(
                name: "VehicleCategories");
        }
    }
}
