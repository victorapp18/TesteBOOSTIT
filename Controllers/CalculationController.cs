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

        [HttpPost]
        public async Task<ActionResult<Multiplos>> GetAsync([FromBody]Request request)
        {
            var data = await _Calculation.GetDivisibilityEleven(request);
            return Ok(data);
        }
    }
}