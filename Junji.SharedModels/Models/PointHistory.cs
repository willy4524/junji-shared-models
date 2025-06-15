using Junji.SharedModels.Models;

namespace Junji.SharedModels.Models
{
    public class PointHistory
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;

        public DateTime Date { get; set; }
        public int Points { get; set; }     // +/-
        public string Type { get; set; } = "";    // ex: 消費回饋、兌換、推薦、調整
        public string Remark { get; set; } = "";
    }
}
