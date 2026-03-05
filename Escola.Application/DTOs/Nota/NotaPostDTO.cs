using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOs.Nota
{
    public class NotaPostDTO
    {
        [Required(ErrorMessage = "O campo matricula é obrigatório.")]
        public int MatriculaId { get; set; }
        [Required(ErrorMessage = "O campo valor nota é obrigatório.")]
        [Range(0, 100, ErrorMessage = "O valor da nota deve ser entre 0 e 100.")]
        public decimal ValorNota { get; set; }
    }
}
