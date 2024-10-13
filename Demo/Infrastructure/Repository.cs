using Demo.Application;
using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure
{
    public class Repository :IRepository
    {
        private readonly DemoDbContext _context;
        public Repository(DemoDbContext _context ) { 

            this._context = _context;

        }

        public async Task<List<WeatherDatum>> GetAllWeather()
        {
           List< WeatherDatum> weatherDetails = await _context.WeatherData.ToListAsync();
            return weatherDetails;
        }

        public async Task<List<WeatherDatum>> GetParticularLocationWeather(string location)
        {
            List<WeatherDatum> weatherDetails = await _context.WeatherData.Where(a => a.Address.Equals(location, StringComparison.OrdinalIgnoreCase)).ToListAsync();
            return weatherDetails;
        }
    }
}
