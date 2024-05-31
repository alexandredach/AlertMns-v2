using System.ComponentModel.DataAnnotations;

namespace AlertMns.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Merci d'indiquer votre adresse e-mail")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="La saisie du mot de passe est obligatoire")]
        public string? Password { get; set; }

    }
}
