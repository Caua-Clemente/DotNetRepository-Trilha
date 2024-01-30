namespace TechAdvocacia.Core.Entities;
public class Documento
{
    public int DocumentoId { get; set; }
    //public string? Descricao { get; set; }
    public int CasoId { get; set; }
    public Caso Caso { get; set; } = null!;
}
