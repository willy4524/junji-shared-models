namespace Junji.SharedModels.Models
{
    public class RedeemRequest
    {
        public string Code16 { get; set; } = null!;
        public string? MemberAccount { get; set; }
    }
}
