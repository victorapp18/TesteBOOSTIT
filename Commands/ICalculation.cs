using Microsoft.AspNetCore.Mvc;
using TesteBOOSTIT.Model.Request;
using TesteBOOSTIT.Model.Result;

namespace TesteBOOSTIT.Commands
{
    public interface ICalculation
    {
        IEnumerable<Multiplos> GetDivisibilityEleven(Request Number);
    }
}
