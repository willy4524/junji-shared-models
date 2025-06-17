using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Junji.SharedModels.Models
{
    public class Inquiry
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;       // 詢價單號
        public int CompanyId { get; set; }              // 關聯到公司
        public Company Company { get; set; } = null!;   // 導覽屬性

        public string Contact { get; set; } = "";       // 聯絡人（選用字串 or 也可設 CompanyContactId）
        public DateTime Date { get; set; }              // 詢價日期
        public string Status { get; set; } = "待回覆";  // 狀態（待回覆/已回覆...）

        public decimal TaxRate { get; set; }            // 稅率（例如0.05）

        public string? SummaryDeliveryDate { get; set; } // 整張單交期（字串，前端控制格式）
        public string? SummaryRemark { get; set; }       // 整張單備註

        public List<InquiryDetail> Details { get; set; } = new();
    }
}
