using FinancialTrail.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinancialTrail.Controllers
{
    public class HomeController : Controller
    {
        private ApiCommand _api;

        public HomeController()
        {
            _api = new ApiCommand();
        }

        public IActionResult Search(string inTicker)
        {
            ApiInfo._Ticker = inTicker.Trim().ToUpper();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            try
            {                
                var CompanyData = await _api.getCompanyProfile();
                ViewData["CompanyData"] = CompanyData;

                var DividendsHist = await _api.getDividendsHistorical();                
                ViewData["DividendsHistorical"] = DividendsHist;
            }
            catch (Exception)
            {
                ViewData["CompanyData"] = new CompanyProfile();
                ViewData["DividendsHistorical"] = new Dividends();
            }            

            return View();
        }

        public async Task<JsonResult> GetIntradayData()
        {
            var IntradayIndicators = await _api.getIntraDayIndicators();

            string today = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            string lastNegotiationDay = IntradayIndicators.First().Date.ToString().Split(" ")[0];

            var todayData = IntradayIndicators.Where(i => i.Date.Contains(today)).ToList();
            var lastDayData = IntradayIndicators.Where(i => i.Date.Contains(lastNegotiationDay)).ToList();

            if (todayData.Count > 0)
                return Json(todayData);
            else
                return Json(lastDayData);
        }

        public async Task<JsonResult> GetHistoricalPriceData()
        {
            var HistPrice = await _api.getHistoricalPrice();            
            return Json(HistPrice);
        }

        public async Task<JsonResult> GetDividendsByYear()
        {
            var dividends = await _api.getDividendsHistorical();
            var data = dividends.Historical
                .GroupBy(h => h.Date.Split("-")[0])
                .Select(
                    item => new
                    {
                        Year = item.Key,
                        Total = item.Sum(v => v.Dividend)
                    }
                );
            return Json(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Order()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}