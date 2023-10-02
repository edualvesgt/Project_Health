using System.ComponentModel.DataAnnotations;

namespace webapi.Health_Clinic.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Obrigatorio")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha Obrigatorio")]
        public string? Senha { get; set; }
    }
}
