namespace ExpenseSplitter.Models
{
    public class ExpenseRequest
    {
        public decimal Distance {  get; set; }
        public float FuelConsumption { get; set; }
        public decimal FuelPrice { get; set; }
        public int VignettePrice { get; set; }
        public int ExtraExpenses { get; set; }
        public int NumberOfPassengers { get; set; }
    }
}
