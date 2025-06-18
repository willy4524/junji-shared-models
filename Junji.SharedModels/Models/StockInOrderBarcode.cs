using System;

namespace Junji.SharedModels.Models
{
    public class StockInOrderBarcode
    {
        public int Id { get; set; }
        public int StockInOrderDetailId { get; set; }
        public string Barcode { get; set; }

        // 關聯
        public StockInOrderDetail StockInOrderDetail { get; set; }
    }
}
