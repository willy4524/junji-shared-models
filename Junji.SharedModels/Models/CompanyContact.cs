using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Junji.SharedModels.Models
{
    public class CompanyContact
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(128)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }
    }
}
