using ServiceStack.FluentValidation;
using System;
using TTF.Services.Models;

namespace TTF.Services.Validation
{
    public class InputValidator : AbstractValidator<Input>
    {
        public InputValidator()
        {
            MappingAlgorithmTypes mapping;
            RuleFor(input => input.MappingType).NotNull();
            RuleFor(input => input.MappingType).Must(type => Enum.TryParse(type, ignoreCase: true, result:out mapping));
        }
    }
}
