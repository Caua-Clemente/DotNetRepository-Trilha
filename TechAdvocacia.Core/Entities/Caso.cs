namespace TechAdvocacia.Core.Entities;
public class Caso
{
    public int CasoId { get; set; }
    //public DateTime DataHoraAbertura { get; set; }
    //public DateTime? DataHoraEncerramento { get; set; }
    public int AdvogadoId { get; set; }
    public required Advogado Advogado { get; set; }
    public int ClienteId { get; set; }
    public required Cliente Cliente { get; set; }
    public ICollection<Documento>? Documentos { get; set; }

}
