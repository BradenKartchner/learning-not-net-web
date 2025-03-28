namespace WebApplication1.Models
{

    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public double Amount { get; set; }
        public string Category { get; set;} = null!;
        public DateTime Date { get; set; } = DateTime.Now;
    }
}