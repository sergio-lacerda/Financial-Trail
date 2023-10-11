namespace FinancialTrail.Models
{
    public class HistoricalPriceBase
    {
        public string Symbol { get; set; }
        public IEnumerable<HistoricalPrice> Historical { get; set; }
    }
}
