using AlertMns.Models;
using System.ComponentModel.DataAnnotations;

namespace AlertMns.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage ="Les mots de passe ne sont pas identiques")]
        public string? ConfirmPassword { get; set; }
        public int CompanyId { get; set; }
        public int PositionId { get; set; }
        // ajout des propriétés manquantes
        public List<Company> Companies { get; set; }
        public List<Position> Positions { get; set; }
        public List<Role> Roles { get; set; }

        public RegisterViewModel()
        {
            Companies = new List<Company>();
            Positions = new List<Position>();
            Roles = new List<Role>();
        }
    }
}
