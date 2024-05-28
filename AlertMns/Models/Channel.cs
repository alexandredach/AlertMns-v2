using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Channel
    {
        [Key]
        public int ChannelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
