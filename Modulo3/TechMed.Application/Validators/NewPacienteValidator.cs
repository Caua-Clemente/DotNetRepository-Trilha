using System.Text.RegularExpressions;
using FluentValidation;
using TechMed.Application.InputModels;

namespace TechMed.Application.Validators;
public class NewPacienteValidator : AbstractValidator<NewPacienteInputModel>
{
    public NewPacienteValidator()
    {
        RuleFor(p => p.Nome)
            .NotEmpty().WithMessage("O nome do paciente é obrigatório")
            .MinimumLength(3).WithMessage("O nome do paciente deve ter no mínimo 3 caracteres.");

        RuleFor(p => p.Cpf)
            .NotEmpty().WithMessage("O CPF do paciente é obrigatório")
            .Must(ValidateCpf).WithMessage("O CPF deve estar no formato 000.000.000-00");

        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("O email do paciente é obrigatório")
            .EmailAddress().WithMessage("Formato de email inválido");
    }

    public static bool ValidateCpf(string cpf){
        string cpfPattern = @"^\d{3}\.\d{3}\.\d{3}\-\d{2}\$";

        Regex regex = new Regex(cpfPattern);

      return regex.IsMatch(cpf);
    }
}
