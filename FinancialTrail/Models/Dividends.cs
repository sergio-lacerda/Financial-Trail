namespace FinancialTrail.Models
{
    public class Dividends
    {
        public string Symbol { get; set; }
        public IEnumerable<DividendsHistorical> Historical { get; set; }
    }
}
