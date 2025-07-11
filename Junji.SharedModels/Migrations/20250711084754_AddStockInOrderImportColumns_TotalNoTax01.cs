using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Junji.SharedModels.Migrations
{
    /// <inheritdoc />
    public partial class AddStockInOrderImportColumns_TotalNoTax01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CostTwd",
                table: "StockInOrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceTwd",
                table: "StockInOrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostTwd",
                table: "StockInOrderDetails");

            migrationBuilder.DropColumn(
                name: "PriceTwd",
                table: "StockInOrderDetails");
        }
    }
}
