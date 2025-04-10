using BatalhaDePokemons.Crosscutting.Constantes;
using BatalhaDePokemons.Crosscutting.Dtos.Pokemon;
using FluentValidation;

namespace BatalhaDePokemons.Crosscutting.Validators;

public class ExperienciaDtoValidator : AbstractValidator<ExperienciaDto>
{
    public ExperienciaDtoValidator()
    {
        RuleFor(x => x.ExperienciaGanha)
            .GreaterThan(Caracteres.Zero).WithMessage(ValidationErrors.ValorMinimo(Caracteres.Zero));
    }
}