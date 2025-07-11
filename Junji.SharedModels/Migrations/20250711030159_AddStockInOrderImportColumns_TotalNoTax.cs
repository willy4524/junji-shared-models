using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Junji.SharedModels.Migrations
{
    /// <inheritdoc />
    public partial class AddStockInOrderImportColumns_TotalNoTax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalNoTaxTwd",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithShippingNoTaxTwd",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithShippingTaxTwd",
                table: "StockInOrders",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalNoTaxTwd",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "TotalWithShippingNoTaxTwd",
                table: "StockInOrders");

            migrationBuilder.DropColumn(
                name: "TotalWithShippingTaxTwd",
                table: "StockInOrders");
        }
    }
}
