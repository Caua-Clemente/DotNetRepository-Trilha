using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infrastructure.Persistence.COnfigurations;
public class AdvogadoConfigurations : IEntityTypeConfiguration<Advogado> 
{
    public void Configure(EntityTypeBuilder<Advogado> builder)
    {
        builder.ToTable("Advogados").HasKey(m => m.AdvogadoId);
    }
}
