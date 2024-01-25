using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class PacienteService : IPacienteService
{
  private readonly ITechMedContext _context;
  public PacienteService(ITechMedContext context)
  {
    _context = context;
  }

  public int Create(NewPacienteInputModel paciente)
  {
    return _context.PacientesCollection.Create(new Paciente{
      Nome = paciente.Nome,
      Endereco = paciente.Endereco,
      Telefone = paciente.Telefone
      });

  }

  public void Delete(int id)
  {
    _context.PacientesCollection.Delete(id);
  }

  public List<PacienteViewModel> GetAll()
  {
    var pacientes = _context.PacientesCollection.GetAll().Select(m => new PacienteViewModel{
      PacienteId = m.PacienteId,
      Nome = m.Nome,
      Endereco = m.Endereco,
      Telefone = m.Telefone
    }).ToList();

    return pacientes;

  }

  public PacienteViewModel? GetById(int id)
  {
    var paciente = _context.PacientesCollection.GetById(id);
    
    if(paciente is null)
      return null;

    var PacienteViewModel = new PacienteViewModel{
      PacienteId = paciente.PacienteId,
      Nome = paciente.Nome,
      Endereco = paciente.Endereco,
      Telefone = paciente.Telefone
    };
    return PacienteViewModel;
  }

  public void Update(int id, NewPacienteInputModel paciente)
  {
    _context.PacientesCollection.Update(id, new Paciente{
      Nome = paciente.Nome,
      Endereco = paciente.Endereco,
      Telefone = paciente.Telefone,
    });
  }
}
