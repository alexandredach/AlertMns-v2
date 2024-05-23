namespace AlertMns.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Attachment { get; set; }
        public DateTime DispatchDate { get; set; }
    }
}
