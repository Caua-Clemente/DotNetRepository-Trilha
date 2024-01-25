namespace TechMed.Core.Entities;
public class Atendimento : BaseEntity
{
    public int AtendimentoId { get; set; }
    public DateTime DataHora { get; set; }
    public int MedicoId { get; set; }
    public Medico Medico { get; set; }
    public int PacienteId { get; set; }
    public Paciente Paciente {get; set;}
}
