using FluentValidation;

namespace Business.Models.Validations
{
    public class TagValidation : AbstractValidator<Tag>
    {
        public TagValidation()
        {
            RuleFor(t => t.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 30).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres")
                .NotEqual("Sorriso").WithMessage("O campo {PropertyName} não pode ter esse valor");
        }
    }
}
