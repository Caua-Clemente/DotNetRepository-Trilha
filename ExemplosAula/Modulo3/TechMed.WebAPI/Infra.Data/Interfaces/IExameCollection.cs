using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IExameCollection
{  
   void Create(Exame exame);
   ICollection<Exame> GetAll();
   Exame? GetById(int id);
   void Update(int id, Exame exame);
   void Delete(int id);
}
