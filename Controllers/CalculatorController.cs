using Microsoft.AspNetCore.Mvc;
using JG.Task.Addition.Models;
using JG.Task.Addition.Data;
using System.Threading.Tasks;
using JG.Task.Addition.Services;

namespace JG.Task.Addition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CalculatorController : Controller
    {
        public AdditionActivityService _addition;

        public CalculatorController(AdditionActivityService addition)
        {
            _addition = addition;
        }

        [HttpPost("Calculate")]
        public async Task<IActionResult> Calculate([FromBody] AdditionRequest input)
        {
            if (input == null)
            {
                return BadRequest("Please insert a value for number 1 and 2");
            }

            decimal result = await _addition.AddingTwoNumbersToDatabase(input.FirstNumber, input.SecondNumber);
            return Ok(result);
                    
        }

    }

    public class AdditionRequest
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
    }
}
