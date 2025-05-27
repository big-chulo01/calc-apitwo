using Microsoft.AspNetCore.Mvc;
using CalculatorApi.Interfaces;

namespace CalculatorApi.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculator;

        public CalculatorController(ICalculatorService calculator)
        {
            _calculator = calculator;
        }

        [HttpGet("add")]
        public ActionResult<double> Add(double x, double y) =>
            Ok(_calculator.Add(x, y));

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double x, double y) =>
            Ok(_calculator.Subtract(x, y));

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double x, double y) =>
            Ok(_calculator.Multiply(x, y));

        [HttpGet("divide")]
        public ActionResult<double> Divide(double x, double y) =>
            Ok(_calculator.Divide(x, y));
    }
}