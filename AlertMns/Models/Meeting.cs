using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Meeting
    {
        [Key]
        public int MeetingId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Status { get; set; }
    }
}
