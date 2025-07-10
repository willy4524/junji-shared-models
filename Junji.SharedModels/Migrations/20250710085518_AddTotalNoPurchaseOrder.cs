using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Junji.SharedModels.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalNoPurchaseOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalNoTaxTwd",
                table: "PurchaseOrders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithShippingNoTaxTwd",
                table: "PurchaseOrders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalWithShippingTaxTwd",
                table: "PurchaseOrders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CostTwd",
                table: "PurchaseOrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceTwd",
                table: "PurchaseOrderDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalNoTaxTwd",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "TotalWithShippingNoTaxTwd",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "TotalWithShippingTaxTwd",
                table: "PurchaseOrders");

            migrationBuilder.DropColumn(
                name: "CostTwd",
                table: "PurchaseOrderDetails");

            migrationBuilder.DropColumn(
                name: "PriceTwd",
                table: "PurchaseOrderDetails");
        }
    }
}
