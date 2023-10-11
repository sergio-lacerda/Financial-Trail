using System.Net.Http.Headers;

namespace FinancialTrail.Models
{
    public class ApiCommand
    {
        private readonly string _uriBase;
        private readonly string _apiKey;        
        public string Ticker { get; set; } = "AAPL";

        public ApiCommand() 
        {
            _uriBase = ApiInfo._ApiUriBase;
            _apiKey = ApiInfo._ApiKey;           
        }

        public async Task<CompanyProfile> getCompanyProfile()
        {
            HttpClient _httpClient = new HttpClient();
            string endPoint = _uriBase + $"/v3/profile/{Ticker}?apikey={_apiKey}";

            _httpClient.BaseAddress = new Uri(_uriBase);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    var company = await response.Content.ReadFromJsonAsync<IEnumerable<CompanyProfile>>();
                    return company.First();
                }
            }
            catch (Exception) { }

            return new CompanyProfile();
        }

        public async Task<IEnumerable<IntradayIndicator>> getIntraDayIndicators()
        {
            HttpClient _httpClient = new HttpClient();
            string endPoint = _uriBase + $"/v3/technical_indicator/15min/{Ticker}?period=10&type=ema&apikey={_apiKey}";

            _httpClient.BaseAddress = new Uri(_uriBase);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    var indicators = await response.Content.ReadFromJsonAsync<IEnumerable<IntradayIndicator>>();
                    return indicators.ToList();
                }
            }
            catch (Exception) { }

            return new List<IntradayIndicator>();
        }

        public async Task<Dividends> getDividendsHistorical()
        {
            HttpClient _httpClient = new HttpClient();
            string endPoint = _uriBase + $"/v3/historical-price-full/stock_dividend/{Ticker}?apikey={_apiKey}";

            _httpClient.BaseAddress = new Uri(_uriBase);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    var dividends = await response.Content.ReadFromJsonAsync<Dividends>();
                    return dividends;
                }
            }
            catch (Exception) { }

            return new Dividends();
        }

        public async Task<HistoricalPriceBase> getHistoricalPrice()
        {
            HttpClient _httpClient = new HttpClient();
            string endPoint = _uriBase + $"/v3/historical-price-full/{Ticker}?apikey={_apiKey}";

            _httpClient.BaseAddress = new Uri(_uriBase);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    var historical = await response.Content.ReadFromJsonAsync<HistoricalPriceBase>();
                    return historical;
                }
            }
            catch (Exception) { }

            return new HistoricalPriceBase();
        }






    }
}
