namespace Junji.SharedModels.Models
{
    public class StaffRole
    {
        public int StaffId { get; set; }
        public Staff Staff { get; set; } = default!;

        public int RoleId { get; set; }
        public Role Role { get; set; } = default!;
    }
}
