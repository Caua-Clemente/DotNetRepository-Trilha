namespace TechAdvocacia.Core.Entities;
public abstract class Pessoa : BaseEntity
{
    public required string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public required string CPF { get; set; }
}
