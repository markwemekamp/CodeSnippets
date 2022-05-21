using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Api.IntegrationTests
{
    [TestClass]
    public class SwaggerIntegratinoTests
    {
        [TestMethod]
        public async Task SwaggerInterface_ShouldReturnSuccess()
        {
            // Arrange
            var application = new TestableApi();
            var client = application.CreateClient();

            // Act
            var response = await client.GetAsync("/swagger");

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}
