using Microsoft.AspNetCore.Mvc;
using Quan_ly_phat_nguoi.Models;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Data;

namespace Quan_ly_phat_nguoi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        async public Task<IActionResult> Index()
        {
            HocSinhDetails hs = new HocSinhDetails() { Name = "Lucky"};

            HttpClient client = new HttpClient();
            var  data = await client.GetAsync("https://localhost:7161/WeatherForeCast");

            var res = await data.Content.ReadAsStringAsync();

            var dataJson =  JsonConvert.DeserializeObject<IEnumerable<WeatherForecast>>(res);

            return View(dataJson);
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
