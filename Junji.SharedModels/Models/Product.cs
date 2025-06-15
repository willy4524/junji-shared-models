namespace Junji.SharedModels.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; } = null!;      // 商品編號
        public string Name { get; set; } = null!;      // 品名
        public string? Remark { get; set; }            // 備註
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }

}
