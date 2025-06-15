namespace Junji.SharedModels.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Account { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string Email { get; set; } = "";
        public string? Phone { get; set; }
        public string? LineUUID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public int TotalPoints { get; set; } = 0;
        public int AvailablePoints { get; set; } = 0;
        public int RemainPoints { get; set; }

        // 等級
        public int MemberLevelId { get; set; }
        public MemberLevel MemberLevel { get; set; } = default!;

        // 推薦
        public string InviteCodeSelf { get; set; } = "";
        public int? ReferrerId { get; set; }
        public Member? Referrer { get; set; }

        public int VoucherRedeemed { get; set; } = 0;
        public bool IsEmailVerified { get; set; } = false;
        public string? EmailVerifyToken { get; set; }

        // 導覽屬性（**重點**：一定要初始化為 new List<T>()）
        public ICollection<ConsumptionHistory> ConsumptionHistories { get; set; } = new List<ConsumptionHistory>();
        public ICollection<PointHistory> PointHistories { get; set; } = new List<PointHistory>();
        public ICollection<InviteHistory> InviteHistories { get; set; } = new List<InviteHistory>();
    }
}
