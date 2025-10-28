namespace MyMoney.Models
{
    public class MoneyTranscation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public bool IsIncome { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
