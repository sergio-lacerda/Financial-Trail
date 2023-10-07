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

            var IntradayIndicators = await _api.getIntraDayIndicators();
            ViewData["IntradayIndicators"] = IntradayIndicators;

            var DividendsHist = await _api.getDividendsHistorical();
            ViewData["DividendsHistorical"] = DividendsHist;

            return View();
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