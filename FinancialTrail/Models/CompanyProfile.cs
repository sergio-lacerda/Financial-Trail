namespace FinancialTrail.Models
{
    public class CompanyProfile
    {
        public string symbol {  get; set; }
        public decimal price { get; set; }
        public string companyName { get; set; }
        public string currency {  get; set; }
        public string exchangeShortName { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string sector { get; set; }
        public string country { get; set; } 
        public string image { get; set; }
    }
}