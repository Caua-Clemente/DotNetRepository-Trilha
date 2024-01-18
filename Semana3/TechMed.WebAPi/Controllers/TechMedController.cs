using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TechMed.WebAPi.Model;

namespace TechMed.WebAPi.Controllers;

[ApiController]
[Route("[controller]")]
public class TechMedController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Jose", "Caua", "Maria", "JUlia", "Luciano", "Luciana"
    };

    private readonly ILogger<TechMedController> _logger;

    public TechMedController(ILogger<TechMedController> logger)
    {
        _logger = logger;
    }

    private readonly IOptions<OpeningTime> _openingTIme;
    public TechMedController(IOptions<OpeningTime> openingTime)
    {
        _openingTIme = openingTime;
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

    [HttpGet("/{id}")]
    public IActionResult GetById(Guid id)
    {
        Paciente paciente = new Paciente();
        paciente.Name = Summaries[Random.Shared.Next(Summaries.Length)];
        paciente.IdPaciente = id;

        return Ok(paciente);
    }

    [HttpDelete("/{id}")]
    public IActionResult Delete(Guid id)
    {
        Paciente paciente = new Paciente();
        paciente.Name = Summaries[Random.Shared.Next(Summaries.Length)];
        paciente.IdPaciente = id;

        return Ok(paciente);
    }

    [HttpPost("/{Nome}")]
    public IActionResult Post(string Nome)
    {
        Paciente paciente = new Paciente();
        paciente.Name = Nome;
        paciente.IdPaciente = Guid.NewGuid();

        return Ok(paciente);
    }

    [HttpPut("/{id}/{Nome}")]
    public IActionResult Put(Guid id, string Nome)
    {
        Paciente paciente = new Paciente();
        paciente.Name = Nome;
        paciente.IdPaciente = id;

        return Ok(paciente);
    }
}
