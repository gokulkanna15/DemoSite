using Demo.Domain.Entities;

namespace Demo.Application
{
    public interface IWeather
    {
        Task<List<WeatherDatum>> GetAllWeather();
        Task<List<WeatherDatum>> GetParticularLocationWeather();
    }
}
