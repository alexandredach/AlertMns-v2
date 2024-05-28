using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class WorkTime
    {
        [Key]
        public int WorkTimeId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}
