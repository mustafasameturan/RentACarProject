using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PowerValidator : AbstractValidator<Power>
    {
        public PowerValidator()
        {
            RuleFor(p => p.PowerId).NotEmpty();
            RuleFor(p => p.HorsePower).MinimumLength(2);
        }
    }
}
