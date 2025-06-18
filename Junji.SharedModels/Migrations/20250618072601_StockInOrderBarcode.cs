using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Junji.SharedModels.Migrations
{
    /// <inheritdoc />
    public partial class StockInOrderBarcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInOrderDetails_PurchaseOrderDetails_PurchaseOrderDetailId",
                table: "StockInOrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInOrders_Companies_CompanyId",
                table: "StockInOrders");

            migrationBuilder.DropIndex(
                name: "IX_StockInOrderDetails_PurchaseOrderDetailId",
                table: "StockInOrderDetails");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderDetailId",
                table: "StockInOrderDetails");

            migrationBuilder.AddColumn<string>(
                name: "Supplier",
                table: "StockInOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "StockInOrderBarcodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockInOrderDetailId = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInOrderBarcodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockInOrderBarcodes_StockInOrderDetails_StockInOrderDetailId",
                        column: x => x.StockInOrderDetailId,
                        principalTable: "StockInOrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockInOrderBarcodes_StockInOrderDetailId",
                table: "StockInOrderBarcodes",
                column: "StockInOrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInOrders_Companies_CompanyId",
                table: "StockInOrders",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInOrders_Companies_CompanyId",
                table: "StockInOrders");

            migrationBuilder.DropTable(
                name: "StockInOrderBarcodes");

            migrationBuilder.DropColumn(
                name: "Supplier",
                table: "StockInOrders");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderDetailId",
                table: "StockInOrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockInOrderDetails_PurchaseOrderDetailId",
                table: "StockInOrderDetails",
                column: "PurchaseOrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInOrderDetails_PurchaseOrderDetails_PurchaseOrderDetailId",
                table: "StockInOrderDetails",
                column: "PurchaseOrderDetailId",
                principalTable: "PurchaseOrderDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockInOrders_Companies_CompanyId",
                table: "StockInOrders",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
