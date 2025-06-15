namespace Junji.SharedModels.Models
{
    public class ShipmentCreateRequest
    {
        public string ShipNo { get; set; } = null!;
        public string? InvoiceNo { get; set; }
        public bool TaxIncluded { get; set; }
        public List<ShipmentProductRequest> Products { get; set; } = new();
        public string? MemberAccount { get; set; }
    }

    public class ShipmentProductRequest
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string? Note { get; set; }
    }
}
