namespace Escola.Application.DTOs.Nota
{
    public class NotaGetDTO
    {
        public int Id { get; set; }
        public int MatriculaId { get; set; }
        public decimal ValorNota { get; set; }
        public bool Aprovado { get; set; }
        public DateTime DataNota { get; set; }
    }
}
