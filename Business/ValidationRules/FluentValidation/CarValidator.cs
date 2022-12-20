using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            //RuleFor(c => c.Description).Must(StartWithA).WithMessage("Ürün ismi A ile başlamalıdır.");

            RuleFor(c => c.Description).NotEmpty().WithMessage("boş");
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("en az 2");
            RuleFor(c => c.DailyPrice).GreaterThan(50).WithMessage("50 den küçük");
            //RuleFor(c => c.ModelYear).Length(4).WithMessage("model");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
