using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IAtendimentoCollection
{  
   void Create(Atendimento atendimento, int medicoId, int pacienteId);
   ICollection<Atendimento> GetAll();
   Atendimento? GetById(int id);
   void Update(int id, Atendimento atendimento, DateTime dataHora);
   void Delete(int id);
}
