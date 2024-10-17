using Demo.Application;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Weather : Controller
    {
        public readonly IWeather _weather;
        public Weather(IWeather weather) {
            _weather = weather;

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var weatherDetails =await _weather.GetAllWeather();
            return View(weatherDetails);
        }
    }
}
