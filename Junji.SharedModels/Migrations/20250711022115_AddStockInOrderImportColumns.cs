using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Junji.SharedModels.Migrations
{
    /// <inheritdoc />
    public partial class AddStockInOrderImportColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "StockInOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Customs",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ExchangeRate",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Freight",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsImport",
                table: "StockInOrders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "Customs",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "ExchangeRate",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "IsImport",
                table: "StockInOrders");
        }
    }
}
