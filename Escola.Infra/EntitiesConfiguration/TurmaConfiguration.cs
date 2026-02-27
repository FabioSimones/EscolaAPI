using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(t => t.CursoId);

            builder.HasOne(x => x.Curso)
                .WithMany(x => x.Turmas)
                .HasForeignKey(x => x.CursoId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
