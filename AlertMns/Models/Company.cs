using System.ComponentModel.DataAnnotations;

namespace AlertMns.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
    }
}
