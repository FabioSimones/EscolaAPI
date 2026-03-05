using System.ComponentModel.DataAnnotations;

namespace Escola.Application.DTOs.Nota
{
    public class NotaPutDTO
    {
        [Required(ErrorMessage = "O campo ID é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo MatriculaID é obrigatório")]
        public int MatriculaId { get; set; }

        [Required(ErrorMessage = "O campo nota é obrigatório")]
        [Range(0, 100, ErrorMessage ="O valor da nota deve estar entre 0 e 100")]
        public decimal ValorNota { get; set; }
    }
}
