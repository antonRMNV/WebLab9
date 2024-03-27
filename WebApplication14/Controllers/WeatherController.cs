using Microsoft.AspNetCore.Mvc;

namespace WebApplication14.Controllers
{
    public class WeatherController : Controller
    {
        [HttpGet]
        public IActionResult Weather()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Weather(string city)
        {
            return View("WeatherInfo", city);
        }
        [HttpGet]
        public IActionResult WeatherInfo(string city)
        {
            return View(city);
        }
    }
}

