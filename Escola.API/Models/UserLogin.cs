using System.ComponentModel.DataAnnotations;

namespace Escola.API.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "O campo email é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O campo email deve conter no máximo 250 caracteres.")]
        [EmailAddress(ErrorMessage = "O campo email deve conter um endereço de email válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo senha é obrigatório.")]
        [MinLength(8, ErrorMessage = "O campo senha deve conter no mínimo 8 caracteres.")]
        [MaxLength(250, ErrorMessage = "O campo senha deve conter no máximo 250 caracteres.")]
        public string Senha { get; set; }
    }
}
