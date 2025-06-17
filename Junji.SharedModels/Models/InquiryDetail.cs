namespace Junji.SharedModels.Models
{
    public class InquiryDetail
    {
        public int Id { get; set; }
        public int InquiryId { get; set; }
        public Inquiry Inquiry { get; set; } = null!;

        public int ProductId { get; set; }            // 關聯到商品
        public Product Product { get; set; } = null!; // 導覽屬性

        public string ProductName { get; set; } = ""; // 冗餘儲存商品名稱，避免商品後續修改
        public string? Spec { get; set; }             // 冗餘規格
        public string? Unit { get; set; }             // 冗餘單位

        public decimal Qty { get; set; }              // 數量
        public decimal Price { get; set; }            // 未稅單價
        public decimal PriceWithTax { get; set; }     // 含稅單價

        public string? DeliveryDate { get; set; }     // 交期
        public string? Remark { get; set; }           // 備註
    }
}