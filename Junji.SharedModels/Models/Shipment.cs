namespace Junji.SharedModels.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public string ShipNo { get; set; } = null!;
        public string? InvoiceNo { get; set; }
        public bool TaxIncluded { get; set; }
        public decimal TotalAmount { get; set; }
        public string? MemberAccount { get; set; }  // 會員帳號（可為 null）
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<ShipmentProduct> Products { get; set; } = new();
        public List<ShipmentCode> Codes { get; set; } = new();
    }
}