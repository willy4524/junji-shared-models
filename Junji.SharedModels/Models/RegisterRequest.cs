namespace Junji.SharedModels.Models
{
    public class RegisterRequest
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? InviteCode { get; set; }    // 新增，註冊時可填推薦碼
    }
}
