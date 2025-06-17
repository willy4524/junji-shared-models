namespace Junji.SharedModels.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Code { get; set; }              // 商品編號/品號，可選填
        public string Name { get; set; } = null!;      // 商品名稱（必填）

        public string? Spec { get; set; }              // 規格（如: 220V/18吋/白色）
        public string? Unit { get; set; }              // 單位（如: 台、包、條）

        public decimal? Cost { get; set; }             // 參考成本
        public decimal? Price { get; set; }            // 售價（牌價）

        public string Status { get; set; } = "啟用";   // 狀態（啟用/停售/停產），預設啟用

        public string? Remark { get; set; }            // 備註

        // 關聯
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
