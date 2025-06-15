namespace Junji.SharedModels.Models
{
    public class MemberLevel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";             // ex: 一般、銀牌、金牌
        public string Description { get; set; } = "";      // 等級說明
        public int UpgradePoints { get; set; }       // 升級所需點數

        public ICollection<Member> Members { get; set; } = default!;
    }

}
