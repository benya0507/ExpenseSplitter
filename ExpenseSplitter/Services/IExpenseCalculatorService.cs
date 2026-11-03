using ExpenseSplitter.Models;

namespace ExpenseSplitter.Services
{
    public interface IExpenseCalculatorService
    {
        public ExpenseResponse CalculateExpense(ExpenseRequest request);
    }
}
