using System;
using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class StockInOrderDetail
    {
        public int Id { get; set; }
        public int StockInOrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Spec { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public List<StockInOrderBarcode> Barcodes { get; set; }

        // 關聯
        public StockInOrder StockInOrder { get; set; }
        public Product Product { get; set; }
    }
}
