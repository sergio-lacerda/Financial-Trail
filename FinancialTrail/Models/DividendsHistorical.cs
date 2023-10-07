namespace FinancialTrail.Models
{
    public class DividendsHistorical
    {
        public string Date { get; set; }
        public decimal AdjDividend { get; set; }
        public decimal Dividend { get; set; }
        public string PaymentDate { get; set; }
    }
}
