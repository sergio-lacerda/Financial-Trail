using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace FinancialTrail.Models
{
    public static class ApiInfo
    {
        public static string _ApiKey;
        public static string _ApiUriBase;
        public static string Ticker { get; set; } = string.Empty;
    }
}
