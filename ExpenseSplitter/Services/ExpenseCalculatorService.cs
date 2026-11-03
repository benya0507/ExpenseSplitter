using ExpenseSplitter.Models;

namespace ExpenseSplitter.Services
{
    public class ExpenseCalculatorService : IExpenseCalculatorService
    {
        public ExpenseResponse CalculateExpense(ExpenseRequest request)
        {
            decimal fuelCost = (request.Distance / 100) * request.FuelConsumption * request.FuelPrice;
            decimal totalCost = fuelCost + request.VignettePrice + request.ExtraExpenses;
            decimal costPerPerson = totalCost / request.NumberOfPassengers;
            return new ExpenseResponse
            {
                TotalCost = totalCost,
                CostPerPerson = costPerPerson,
            };
        }
    }
}
