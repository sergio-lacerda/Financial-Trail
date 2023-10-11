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

        public async Task<IActionResult> Index()
        {
            var CompanyData = await _api.getCompanyProfile();
            ViewData["CompanyData"] = CompanyData;            

            var DividendsHist = await _api.getDividendsHistorical();
            ViewData["DividendsHistorical"] = DividendsHist;

            return View();
        }

        public async Task<JsonResult> GetIntradayData()
        {
            var IntradayIndicators = await _api.getIntraDayIndicators();
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            return Json(IntradayIndicators.Where(i => i.Date.Contains(today.ToString("yyyy-MM-dd"))));
        }

        public async Task<JsonResult> GetHistoricalPriceData()
        {
            var HistPrice = await _api.getHistoricalPrice();            
            return Json(HistPrice);
        }

        public IActionResult Privacy()
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