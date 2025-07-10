using System;

namespace Junji.SharedModels.Models
{
    public class PurchaseOrderDetail
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Spec { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public int ReceivedQty { get; set; }
        public decimal PriceTwd { get; set; }     // 台幣單價
        public decimal CostTwd { get; set; }      // 台幣成本（含稅運分攤）

        // 關聯
        public PurchaseOrder PurchaseOrder { get; set; }
        public Product Product { get; set; }
    }
}
