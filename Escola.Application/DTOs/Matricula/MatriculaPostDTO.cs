using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Escola.Application.DTOs.Matricula
{
    public class MatriculaPostDTO
    {
        [Required(ErrorMessage = "O campo usuário é obrigatório.")]
        public int UsuarioId { get; set; }
        [Required(ErrorMessage = "O campo turma é obrigatório.")]
        public int TurmaId { get; set; }
        [Required(ErrorMessage = "O campo data expiração é obrigatório.")]
        public DateTime DataExpiracao { get; set; }

    }
}
