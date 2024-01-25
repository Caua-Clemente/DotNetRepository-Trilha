using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class AtendimentoService : IAtendimentoService
{
  private readonly ITechMedContext _context;
  public AtendimentoService(ITechMedContext context)
  {
    _context = context;
  }

  
}
