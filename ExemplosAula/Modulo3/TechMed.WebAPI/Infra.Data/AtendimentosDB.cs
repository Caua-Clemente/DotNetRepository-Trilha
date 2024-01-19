using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data;
public class AtendimentosDB : IAtendimentoCollection
{
   private readonly List<Atendimento> _atendimentos = new List<Atendimento>();
   private int _id = 0;   
   public void Create(Atendimento atendimento, int medicoId, int pacienteId)
   {
      if(_atendimentos.Count > 0)
         _id = _atendimentos.Max(m => m.AtendimentoId);
      atendimento.AtendimentoId = ++_id;
      atendimento.MedicoId = medicoId;
      atendimento.PacienteId = pacienteId;
      atendimento.DataHora = DateTime.Now.AddDays(10);
      _atendimentos.Add(atendimento);
   }
   public void Delete(int id)
   {
      _atendimentos.RemoveAll(m => m.AtendimentoId == id);
   }
   public ICollection<Atendimento> GetAll()
   {
      return _atendimentos.ToArray();
   }
   public Atendimento? GetById(int id)
   {
      return _atendimentos.FirstOrDefault(m => m.AtendimentoId == id);
   }
   
   public void Update(int id, Atendimento atendimento, DateTime dataHora)
   {
      var atendimentoDB = _atendimentos.FirstOrDefault(m => m.AtendimentoId == id);
      if(atendimentoDB is not null)
      {
         atendimentoDB.DataHora = dataHora;
      }
   }
}
