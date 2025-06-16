using System.Collections.Generic;

namespace Junji.SharedModels.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Code { get; set; } = "";     // e.g. Product.Create
        public string Name { get; set; } = "";     // 顯示用名稱
        public string? Desc { get; set; }          // 描述

        // 導覽屬性
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
