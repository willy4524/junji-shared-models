 namespace Junji.SharedModels.Models
{
    public class ShipmentProduct
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; } = null!;

        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string? Note { get; set; }
    }
}