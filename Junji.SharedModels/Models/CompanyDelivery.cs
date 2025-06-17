using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Junji.SharedModels.Models
{
    public class CompanyDelivery
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }
    }
}
