using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Junji.SharedModels.Models
{
    public class Company // 名稱建議 Company 或 CustomerVendor，避免與 Member 混淆
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } // potential_customer, vendor, customer, both...

        [Required, MaxLength(8)]
        public string TaxId { get; set; } // 統編

        [MaxLength(128)]
        public string Name { get; set; } // 公司名稱

        [MaxLength(24)]
        public string Phone { get; set; } // 公司電話

        [MaxLength(256)]
        public string Address { get; set; } // 公司地址

        [MaxLength(128)]
        public string Email { get; set; } // 公司Email

        [MaxLength(1024)]
        public string Memo { get; set; } // 備註

        // 1:N 聯絡人
        public List<CompanyContact> Contacts { get; set; } = new();

        // 1:N 送貨地址
        public List<CompanyDelivery> Deliveries { get; set; } = new();
    }
}
