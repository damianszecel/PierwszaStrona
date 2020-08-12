using System.ComponentModel.DataAnnotations;

namespace FirstSite.Models
{
    public class OrderPosition
    {
        [Key]
        public int OrderPositionId { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Course course { get; set; }
        public virtual Order order { get; set; }
    }
}