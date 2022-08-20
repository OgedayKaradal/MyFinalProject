using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsInStock).Must(StockGreaterThanZero).WithMessage("Number of stock must be greater than or equal to 0.");
            RuleFor(p => p.CategoryId).NotEmpty();
        }

        private bool StockGreaterThanZero(short number)
        {
            if (number >= 0)
                return true;
            return false;
        }
    }
}
