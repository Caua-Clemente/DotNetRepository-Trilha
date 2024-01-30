using Microsoft.EntityFrameworkCore;
using TechAdvocacia.Core.Entities;

namespace TechAdvocacia.Infrastructure.Persistence;
public class TechAdvocaciaDbContext : DbContext
{
   public DbSet<Advogado> Advogados { get; set; }
   public DbSet<Cliente> Clientes { get; set; }
   public DbSet<Caso> Casos { get; set; }
   public DbSet<Documento> Documentos { get; set; }

    public TechAdvocaciaDbContext(DbContextOptions<TechAdvocaciaDbContext> options) : base(options)
    {
        //Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechAdvocaciaDbContext).Assembly);
    }
}
