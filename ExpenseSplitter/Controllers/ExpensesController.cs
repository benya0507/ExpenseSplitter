using ExpenseSplitter.Models;
using ExpenseSplitter.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace ExpenseSplitter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseCalculatorService _expenseCalculatorService;

        public ExpensesController(IExpenseCalculatorService expenseCalculatorService)
        {
            _expenseCalculatorService = expenseCalculatorService;
        }

        [HttpPost]
        public IActionResult Calculate([FromBody] ExpenseRequest request)
        {
            if (request.NumberOfPassengers <= 0)
            {
                return BadRequest("The number of passengers should be at least 1");
            }
            else
            {
                ExpenseResponse result = _expenseCalculatorService.CalculateExpense(request);
                return Ok(result);
            }
        }
    }
}
