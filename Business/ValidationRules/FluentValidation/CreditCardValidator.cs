using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CreditCardValidator:AbstractValidator<CreditCard>
    {
        public CreditCardValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty().WithMessage("Customer Id can not be empty.");
            RuleFor(c=>c.NameSurname).NotEmpty().WithMessage("Name Surname can not be empty.");
            RuleFor(c => c.CardNo).NotEmpty().WithMessage("Card no can not be empty.");
            RuleFor(c => c.Cvc).NotEmpty().WithMessage("Cvc can not be empty.");
            RuleFor(c=>c.ExpirationDate).NotEmpty().WithMessage("Expiration Date can not be empty.");

        }
    }
}
