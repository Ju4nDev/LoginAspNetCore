using System.ComponentModel.DataAnnotations;

namespace LoginAspNetCore.Models
{
    public class Client
    {
        [Display(Name = "Código")]
        [Required]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required]
        public string? Name { get; set; }

        [Display(Name = "Email")]
        [Required]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        public string? Email { get; set; }

        [Display(Name = "Senha")]
        [Required]
        public string? Password { get; set; }
    }
}
