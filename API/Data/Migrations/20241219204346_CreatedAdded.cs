using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    OldPrice = table.Column<long>(type: "INTEGER", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    IsOnSale = table.Column<bool>(type: "INTEGER", nullable: false),
                    Specifications_Brand = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_OperatingSystem = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_CPU = table.Column<string>(type: "TEXT", nullable: true),
                    Specifications_ScreenSize = table.Column<float>(type: "REAL", nullable: true),
                    Specifications_ScreenType = table.Column<string>(type: "TEXT", nullable: true),
                    Specifications_RAM = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_InternalStorage = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_BatteryCapacity = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_FastCharging = table.Column<bool>(type: "INTEGER", nullable: true),
                    Specifications_FastChargingWatt = table.Column<int>(type: "INTEGER", nullable: true),
                    Specifications_WirelessCharging = table.Column<bool>(type: "INTEGER", nullable: true),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "CameraSpecifications",
                columns: table => new
                {
                    SpecificationProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    CameraType = table.Column<int>(type: "INTEGER", nullable: false),
                    Megapixels = table.Column<int>(type: "INTEGER", nullable: false),
                    IsStabilized = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CameraSpecifications", x => new { x.SpecificationProductId, x.Id });
                    table.ForeignKey(
                        name: "FK_CameraSpecifications_Products_SpecificationProductId",
                        column: x => x.SpecificationProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CameraSpecifications");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
