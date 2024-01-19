using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IPacienteCollection
{  
   void Create(Paciente paciente);
   ICollection<Paciente> GetAll();
   Paciente? GetById(int id);
   void Update(int id, Paciente paciente);
   void Delete(int id);
}
