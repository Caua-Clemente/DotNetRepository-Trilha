using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infrastructure.Persistence.COnfigurations;
public class ClienteConfigurations : IEntityTypeConfiguration<Cliente> 
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes").HasKey(m => m.ClienteId);
    }
}
