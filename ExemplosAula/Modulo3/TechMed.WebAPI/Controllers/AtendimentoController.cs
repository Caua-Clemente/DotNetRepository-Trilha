using Microsoft.AspNetCore.Mvc;
using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AtendimentoController : ControllerBase
{
   private readonly IAtendimentoCollection _atendimentos;
   public List<Atendimento> Atendimentos => _atendimentos.GetAll().ToList();
   public AtendimentoController(IAtendimentoCollection atendimentos) => _atendimentos = atendimentos;

   [HttpGet("atendimentos")]
   public IActionResult Get()
   {
      return Ok(Atendimentos);
   }

   [HttpGet("atendimento/{id}")]
   public IActionResult GetById(int id)
   {
      var atendimento = _atendimentos.GetById(id);
      return Ok(atendimento);
   }

   [HttpPost("atendimento/{medicoId}/{pacienteId}")]
   public IActionResult Post(int medicoId, int pacienteId, [FromBody] Atendimento atendimento)
   {
      _atendimentos.Create(atendimento, medicoId, pacienteId);
      return CreatedAtAction(nameof(Get),  atendimento);
   }

   [HttpPut("atendimento/{id}/{dateTime}")]
   public IActionResult Put(int id, DateTime dateTime, [FromBody] Atendimento atendimento)
   {
      if (_atendimentos.GetById(id) == null)
         return NoContent();
      _atendimentos.Update(id, atendimento, dateTime);
      return Ok(_atendimentos.GetById(id));
   }

   [HttpDelete("atendimento/{id}")]
   public IActionResult Delete(int id)
   {
      if (_atendimentos.GetById(id) == null)
         return NoContent();
      _atendimentos.Delete(id);
      return Ok();
   }

   // [HttpGet("atendimento/{id}/atendimentos")]
   // public IActionResult GetAtendimentos(int id)
   // {
   //    var atendimento = Enumerable.Range(1, 5).Select(index => new Atendimento
   //      {
   //          AtendimentoId = index,
   //          DataHora = DateTime.Now,
   //          AtendimentoId = id,
   //          Atendimento = new Atendimento
   //          {
   //              AtendimentoId = id,
   //              Nome = $"Atendimento {id}"
   //          }
   //      })
   //      .ToArray();
   //    return Ok(atendimento);
   // }
}
