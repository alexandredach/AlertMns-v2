using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Content { get; set; }
        public string Attachment { get; set; }
        public DateTime DispatchDate { get; set; }
    }
}
