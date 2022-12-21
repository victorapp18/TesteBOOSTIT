using Microsoft.AspNetCore.Mvc;
using TesteBOOSTIT.Commands;
using TesteBOOSTIT.Model.Request;
using TesteBOOSTIT.Model.Result;

namespace TesteBOOSTIT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly ICalculation _Calculation;

        public CalculationController(ILogger<CalculationController> logger, ICalculation Calculation)
        {
            _Calculation = Calculation;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Multiplos> GetAsync()
        {
            var data = _Calculation.GetDivisibilityEleven(null);
            return data;
        }
    }
}