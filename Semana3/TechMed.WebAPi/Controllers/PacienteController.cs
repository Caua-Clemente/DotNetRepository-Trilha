using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TechMed.WebAPi.Model;

namespace TechMed.WebAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class PacienteController : ControllerBase
{

    private readonly ILogger<PacienteController> _logger;

    public PacienteController(ILogger<PacienteController> logger)
    {
        _logger = logger;
    }

    
    [HttpGet]
    public IEnumerable<Paciente> GetAll()
    {
        return Enumerable.Range(1, 5).Select(index => new Paciente
        {
            Name = Summaries[Random.Shared.Next(Summaries.Length)],
            IdPaciente = Guid.NewGuid()
        })
        .ToArray();
    }
}
