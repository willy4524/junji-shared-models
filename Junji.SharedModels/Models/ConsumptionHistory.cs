using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Junji.SharedModels.Models
{
    public class ConsumptionHistory
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; } = default!;

        public DateTime Date { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public string Description { get; set; } = "";
        public int PointsEarned { get; set; }
    }

}
