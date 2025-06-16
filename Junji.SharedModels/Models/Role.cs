using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";     // 角色名稱
        public string? Desc { get; set; }          // 描述
        public bool IsSystem { get; set; } = false; // 是否為內建角色

        // 導覽屬性
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
        public ICollection<StaffRole> StaffRoles { get; set; } = new List<StaffRole>();
    }
}