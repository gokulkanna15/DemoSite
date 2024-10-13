using Demo.Application;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    [ApiController]
    public class Weather : Controller
    {
        public readonly IWeather _weather;
        public Weather(IWeather weather) {
            _weather = weather;

        }

        public async Task<IActionResult> Index()
        {
            var weatherDetails =await _weather.GetAllWeather();
            return View(weatherDetails);
        }
    }
}
