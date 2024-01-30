using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infrastructure.Persistence.COnfigurations;
public class DocumentoConfigurations : IEntityTypeConfiguration<Documento> 
{
    public void Configure(EntityTypeBuilder<Documento> builder)
    {
        builder.ToTable("Documentos").HasKey(m => m.DocumentoId);

        builder.HasOne(m => m.Caso).WithMany(m => m.Documentos).HasForeignKey(m => m.CasoId);
    }
}
