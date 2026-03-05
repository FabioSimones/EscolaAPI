using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOs.Curso
{
    public class CursoPutDTO
    {
        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public int Id { get; set; } 

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome deve ter no máximo 50 caractéres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(150, ErrorMessage = "O Descrição deve ter no máximo 150 caractéres.")]
        public string Descricao { get; set; }
    }
}
