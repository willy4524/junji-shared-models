using System;
using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class StockInOrder
    {
        public int Id { get; set; }
        public string Code { get; set; }                 // 入庫單號
        public int CompanyId { get; set; }               // 廠商
        public string Contact { get; set; }              // 聯絡人
        public DateTime Date { get; set; }               // 入庫日期
        public string SaleOrderNo { get; set; }          // 銷貨單號
        public string InvoiceNo { get; set; }            // 發票號碼
        public string Remark { get; set; }
        
        // 關聯
        public Company Company { get; set; }
        public List<StockInOrderDetail> Details { get; set; }

        // 允許多對一採購單（每筆入庫單可選綁一個採購單）
        public int? PurchaseOrderId { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
