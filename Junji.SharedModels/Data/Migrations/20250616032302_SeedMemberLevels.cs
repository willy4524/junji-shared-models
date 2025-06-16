using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Junji.SharedModels.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedMemberLevels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MemberLevels",
                columns: new[] { "Id", "Description", "Name", "UpgradePoints" },
                values: new object[,]
                {
                    { 1, "可參加活動、集點兌換。", "一般會員", 0 },
                    { 2, "集滿1000點，集點商品享9.9折。", "銀牌會員", 1000 },
                    { 3, "集滿3000點，集點商品享9.7折。", "金牌會員", 3000 },
                    { 4, "集滿5000點，集點商品享9.5折。", "白金會員", 5000 },
                    { 5, "集滿10000點，集點商品享9.3折。", "鑽石會員", 10000 },
                    { 6, "集滿50000點，集點商品享9折。", "至尊會員", 50000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MemberLevels",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
