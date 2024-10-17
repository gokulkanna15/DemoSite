using Demo.Domain.Entities;

namespace Demo.Application
{
    public interface IRepository
    {
        Task<List<WeatherDatum>> GetAllWeather();
        Task<List<WeatherDatum>> GetParticularLocationWeather(string location);
    }
}
