using System;
using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class StockInOrder
    {
        public int Id { get; set; }
        public string Code { get; set; }             // 入庫單號
        public int CompanyId { get; set; }           // 廠商
        public string Supplier { get; set; }         // 廠商名稱（冗餘顯示用）
        public string Contact { get; set; }          // 聯絡人
        public DateTime Date { get; set; }           // 入庫日期
        public string SaleOrderNo { get; set; }      // 銷貨單號
        public string InvoiceNo { get; set; }        // 發票號碼
        public string Remark { get; set; }           // 備註
        public int? PurchaseOrderId { get; set; }    // 關聯的採購單Id，可為null
        public decimal? Freight { get; set; }         // 運費
        public decimal? Customs { get; set; }         // 關稅
        public bool IsImport { get; set; }            // 是否進口商品
        public string Currency { get; set; }          // 幣別
        public decimal? ExchangeRate { get; set; }    // 匯率
        public decimal? TotalNoTaxTwd { get; set; }
        public decimal? TotalWithShippingNoTaxTwd { get; set; }
        public decimal? TotalWithShippingTaxTwd { get; set; }

        // 關聯
        public Company Company { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public List<StockInOrderDetail> Details { get; set; }
    }
}
