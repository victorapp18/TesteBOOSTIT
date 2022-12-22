using Microsoft.AspNetCore.Mvc;
using TesteBOOSTIT.Model.Request;
using TesteBOOSTIT.Model.Result;

namespace TesteBOOSTIT.Commands
{
    public interface ICalculation
    {
        Task<Multiplos> GetDivisibilityEleven(Request Number);
    }
}
