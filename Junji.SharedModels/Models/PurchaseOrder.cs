using System;
using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }
        public string Code { get; set; }         // 採購單號（PO20240618001）
        public int CompanyId { get; set; }       // 廠商（FK）
        public string Contact { get; set; }      // 聯絡人（或用 CompanyContact FK）
        public DateTime Date { get; set; }       // 建立日期
        public DateTime? EstimatedDeliveryDate { get; set; } // 預計到貨日
        public string Status { get; set; }       // 狀態
        public string PaymentStatus { get; set; } // 付款狀態
        public decimal DepositAmount { get; set; }
        public string Remark { get; set; }
        public decimal ShippingFee { get; set; }        // 運費
        public bool IsImportProduct { get; set; }       // 是否進口商品
        public string? Currency { get; set; }           // 貨幣
        public decimal? ExchangeRate { get; set; }      // 匯率
        public decimal CustomsDuty { get; set; }        // 關稅
        public decimal TotalNoTaxTwd { get; set; }        // 全部商品未稅台幣
        public decimal TotalWithShippingNoTaxTwd { get; set; } // 含運未稅
        public decimal TotalWithShippingTaxTwd { get; set; }   // 含運含稅
        
        // 關聯
        public Company Company { get; set; }
        public List<PurchaseOrderDetail> Details { get; set; }
    }
}
