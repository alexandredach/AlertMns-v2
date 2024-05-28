using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}
