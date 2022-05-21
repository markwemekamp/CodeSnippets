using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Api.IntegrationTests
{
    [TestClass]
    public class WeatherForecastIntegrationTests
    {
        [TestMethod]
        public async Task WeatherForecastEndpoint_ShouldReturnSuccess()
        {
            // Arrange
            var application = new TestableApi();
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/WeatherForecast");

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
