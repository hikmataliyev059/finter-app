using finter_app.Areas.Manage.Helpers.DTOs.Positions;
using FluentValidation;

namespace finter_app.Areas.Manage.Helpers.Validators.Positions;

public class UpdatePositionDtoValidator : AbstractValidator<UpdatePositionDto>
{
    public UpdatePositionDtoValidator()
    {
        RuleFor(x => x.Name)
           .NotEmpty()
           .NotNull()
           .MinimumLength(3)
           .WithMessage("Minimum 3 simvol daxil edin")
           .MaximumLength(30)
           .WithMessage("Maximum 30 simvol daxil edin");
    }
}
