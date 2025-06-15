namespace Junji.SharedModels.Models
{
    public class ShipmentCode
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; } = null!;

        public string Code16 { get; set; } = null!; // 16 碼亂數碼
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsUsed { get; set; } = false;
        public DateTime? UsedAt { get; set; }
        public string? UsedByAccount { get; set; }
        public int Points { get; set; }   // 點數（未稅金額 * 0.01 四捨五入）
    }
}