namespace TechAdvocacia.Core.Entities;
public class Cliente : Pessoa
{
    public int ClienteId { get; set; }
    //public string? EstadoCivil { get; set; }
    //public string? Profissao { get; set; }
    public ICollection<Caso>? Casos { get; }
}
