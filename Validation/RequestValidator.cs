using FluentValidation;
using TesteBOOSTIT.Model.Request;

namespace TesteBOOSTIT.Validation
{
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(x => x.Numbers).NotNull();
        }
    }
}