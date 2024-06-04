using System.ComponentModel.DataAnnotations;

namespace AlertMns.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "La saisie de l'e-mail est obligatoire")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="La saisie du mot de passe est obligatoire")]
        public string? Password { get; set; }
        [Display(Name ="Mémoriser les identifiants de connexion")]
        public bool RememberMe { get; set; }
    }
}
