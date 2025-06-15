namespace Junji.SharedModels.Models
{
    public class InviteHistory
    {
        public int Id { get; set; }
        public int ReferrerId { get; set; }
        public Member Referrer { get; set; } = default!;

        public int InviteeId { get; set; }
        public Member Invitee { get; set; } = default!;

        public DateTime InviteDate { get; set; }
        public string Status { get; set; } = "";  // ex: 註冊成功、獎勵已發送...
        public int Points { get; set; }
    }

}
