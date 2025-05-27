using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase

    {
        [HttpGet("add")]

        public IActionResult Add(decimal a, decimal b)
        {
            return Ok(a + b);
        }

        [HttpGet("subtract")]

        public IActionResult Subtract(decimal a, decimal b)
        {
            return Ok(a - b);
        }

         [HttpGet("multiply")]

        public IActionResult Multiply(decimal a, decimal b)
        {
            return Ok(a * b);
        }


        [HttpGet("divide")]

        public IActionResult Divide(decimal a, decimal b)
        {
            return Ok(a / b);
        }

         [HttpGet("modulo")]

        public IActionResult Modulo(decimal a, decimal b)
        {
            return Ok(a % b);
        }
        
        [HttpGet("debt")]

        public IActionResult Debt(decimal a, decimal b,  decimal c)
        {
            return Ok(a + b + c);
        }

        

    }
}