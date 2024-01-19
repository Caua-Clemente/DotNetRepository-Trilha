using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data;
public class ExamesDB : IExameCollection
{
   private readonly List<Exame> _exames = new List<Exame>();
   private int _id = 0;   
   public void Create(Exame exame)
   {
      if(_exames.Count > 0)
         _id = _exames.Max(m => m.ExameId);
      exame.ExameId = ++_id;
      _exames.Add(exame);
   }
   public void Delete(int id)
   {
      _exames.RemoveAll(m => m.ExameId == id);
   }
   public ICollection<Exame> GetAll()
   {
      return _exames.ToArray();
   }
   public Exame? GetById(int id)
   {
      return _exames.FirstOrDefault(m => m.ExameId == id);
   }
   public void Update(int id, Exame exame)
   {
      var exameDB = _exames.FirstOrDefault(m => m.ExameId == id);
      if(exameDB is not null)
      {
        atendimentoDB.DataHora = dataHora;
      }
   }
}
