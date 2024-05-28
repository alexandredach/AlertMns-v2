using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string Content { get; set; }
        public DateTime DispatchDate { get; set; }
    }
}
