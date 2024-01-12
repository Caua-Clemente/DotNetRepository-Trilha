using TechMed.Infrastructure.Persistence;
using TechMed.Domain.Entities;

var context = new TechMedContext();

context.Medicos.RemoveRange(context.Medicos);
context.Pacientes.RemoveRange(context.Pacientes);
context.Atendimentos.RemoveRange(context.Atendimentos);
context.Exames.RemoveRange(context.Exames);


Console.WriteLine($"Criar um médico no banco de dados");

var medico = new Medico{
    Nome = "Dr. Testado",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = 10000
};
context.Medicos.Add(medico);

Console.WriteLine($"Criar um paciente no banco de dados");
var paciente = new Paciente{
    Nome = "Cobaia",
    CPF = "101.202.303-00",
    Endereco = "Rua A, 0",
    Telefone = "1234-5678"
};
context.Pacientes.Add(paciente);

Console.WriteLine($"Criar um atendimento no banco de dados");
var atendimento1 = new Atendimento{
    DataHora = DateTime.Today,
    Medico = medico,
    Paciente = paciente
};
context.Atendimentos.Add(atendimento1);

var atendimento2 = new Atendimento{
    DataHora = DateTime.Today,
    Medico = medico,
    Paciente = paciente
};
context.Atendimentos.Add(atendimento2);

var atendimento3 = new Atendimento{
    DataHora = DateTime.Today,
    Medico = medico,
    Paciente = paciente
};
context.Atendimentos.Add(atendimento3);

Console.WriteLine($"Criar um atendimento no banco de dados");
var exame1 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame1);

var exame2 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame2);

var exame3 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento2
};
context.Exames.Add(exame3);

var exame4 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento2
};
context.Exames.Add(exame4);

/*
var exame2 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame2);

var exame3 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame3);

var exame1 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame1);

var exame2 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame2);

var exame3 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame3);

var exame1 = new Exame{
    Local = "Gabriela Center",
    DataHora = DateTime.Today,
    Atendimento = atendimento1
};
context.Exames.Add(exame10);
*/
context.SaveChanges();

/*
Console.WriteLine($"Lendo todos os médicos no banco de dados");
foreach (var med in context.Medicos.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {med.Id} - Nome: {med.Nome} - CRM: {med.CRM}");
}

Console.WriteLine($"Lendo todos os pacientes no banco de dados");
foreach (var pac in context.Pacientes.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {pac.Id} - Nome: {pac.Nome} - CRM: {pac.CPF}");
}


Console.WriteLine($"Criar um médico no banco de dados");

var medico = new Medico{
    Nome = "Dr. Dexter",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = 10000
};
context.Medicos.Add(medico);

Console.WriteLine($"Criar um paciente no banco de dados");
var paciente = new Paciente{
    Nome = "Valber",
    CPF = "101.202.303-00",
    Endereco = "Rua A, 0",
    Telefone = "1234-5678"
};

context.Pacientes.Add(paciente);

context.SaveChanges();


Console.WriteLine($"Atualizando o nome de um paciente no banco de dados");
var doente = context.Pacientes.Where(p => p.CPF == "101.202.303-00").FirstOrDefault();
doente.Nome = "João";
context.Pacientes.Update(doente);

context.SaveChanges();

Console.WriteLine($"Removendo o primeiro médico no banco de dados");
var primeiroMedico = context.Medicos.FirstOrDefault();
context.Medicos.Remove(primeiroMedico);


context.SaveChanges();

Console.WriteLine($"Finalizando o programa");
*/