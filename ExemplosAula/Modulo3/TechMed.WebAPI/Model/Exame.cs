namespace TechMed.WebAPI.Model;
public class Exame
{
    public int ExameId { get; set; }
    public int AtendimentoId { get; set; }
    public required Atendimento Atendimento { get; set; }
    public DateTime DataHora { get; set; }
}
