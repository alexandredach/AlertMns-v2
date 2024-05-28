using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }
        public string Name { get; set; }
    }
}
