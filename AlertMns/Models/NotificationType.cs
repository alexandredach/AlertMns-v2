using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class NotificationType
    {
        [Key]
        public int NotificationTypeId { get; set; }
        public string Name { get; set; }
    }
}
