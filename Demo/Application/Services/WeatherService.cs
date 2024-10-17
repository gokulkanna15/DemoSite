using Demo.Domain.Entities;

namespace Demo.Application
{
    public class WeatherService : IWeather
    {
        public readonly IRepository _repo;

        public WeatherService(IRepository repo) {
            _repo = repo;
        }
        public async Task<List<WeatherDatum>> GetAllWeather()
        {
            return await  _repo.GetAllWeather();
        }
        public async Task<List<WeatherDatum>> GetParticularLocationWeather()
        {
            string location = "chennai";
            return await _repo.GetParticularLocationWeather(location);
        }
    }
}
