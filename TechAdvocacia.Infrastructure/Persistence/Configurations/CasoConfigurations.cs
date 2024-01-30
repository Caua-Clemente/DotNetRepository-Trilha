using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infrastructure.Persistence.COnfigurations;
public class CasoConfigurations : IEntityTypeConfiguration<Caso> 
{
    public void Configure(EntityTypeBuilder<Caso> builder)
    {
        builder.ToTable("Casos").HasKey(m => m.CasoId);

        builder.HasOne(m => m.Advogado).WithMany(m => m.Casos).HasForeignKey(m => m.AdvogadoId);

        builder.HasOne(m => m.Cliente).WithMany(m => m.Casos).HasForeignKey(m => m.ClienteId);
    }
}
