using FluentValidation;
using MAVN.Service.Campaign.Client.Models.Condition;

namespace MAVN.Service.Campaign.Validation.Condition
{
    public class RatioAttributeValidator 
        : AbstractValidator<RatioAttribute>
    {
        public RatioAttributeValidator()
        {
            RuleFor(r => r.RewardRatio)
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(100)
                .ScalePrecision(2, 5, false);

            RuleFor(r => r.PaymentRatio)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .LessThanOrEqualTo(100)
                .ScalePrecision(2, 5, false);

            RuleFor(r => r.Order)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
