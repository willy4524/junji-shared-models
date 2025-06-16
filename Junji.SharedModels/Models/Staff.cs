using System;
using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string StaffNo { get; set; } = "";
        public string Name { get; set; } = "";
        public string Account { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Department { get; set; } = "";
        public string Position { get; set; } = "";
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }
        public DateTime? ResignedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string? Note { get; set; }

        // 導覽屬性
        public ICollection<StaffRole> StaffRoles { get; set; } = new List<StaffRole>();
    }
}
