using Demo.Application;
using Demo.Domain.Entities;
using Demo.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using Xunit;

namespace DemoTest
{
    public class UnitTest1 
    {
        private readonly Mock<IRepository> _mockRepo; // Mock the repository
        private readonly WeatherService _weatherService;

        public UnitTest1()
        {
            _mockRepo = new Mock<IRepository>(); // Mock the repository
            _weatherService = new WeatherService(_mockRepo.Object); // Inject mock repository
        }

        [Fact]
        public async Task GetAllWeather_Returns_WeatherDataList()
        {
            // Arrange
            var weatherData = new List<WeatherDatum>
    {
        new WeatherDatum
        {
            Address = "123 Main St",
            Latitude = 34.05,
            Longitude = -118.25,
            DateTime = DateTime.Now
        },
        new WeatherDatum
        {
            Address = "456 Maple Dr",
            Latitude = 40.71,
            Longitude = -74.01,
            DateTime = DateTime.Now
        }
    };

            _mockRepo.Setup(r => r.GetAllWeather()).ReturnsAsync(weatherData); // Mock the repository method

            // Act
            var result = await _weatherService.GetAllWeather();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.NotNull(result[0]);
        }

    }

}