namespace Junji.SharedModels.Models
{
    public class Whiteboard
    {
        public int Id { get; set; }

        /// <summary>
        /// 白板類型，如 "product", "member", "order"... (唯一)
        /// </summary>
        public string Type { get; set; } = "";

        /// <summary>
        /// 白板內容
        /// </summary>
        public string Content { get; set; } = "";

        /// <summary>
        /// 最後更新時間
        /// </summary>
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
