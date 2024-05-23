using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ConnectionDate { get; set; }
        public bool Status { get; set; }
    }
}
