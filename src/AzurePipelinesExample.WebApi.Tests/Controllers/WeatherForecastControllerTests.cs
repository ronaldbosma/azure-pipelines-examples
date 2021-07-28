using AzurePipelinesExample.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AzurePipelinesExample.WebApi.Tests.Controllers
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        [TestMethod]
        public void Retrieve_ValidNumberOfDays_ForecastReturned()
        {
            //Arrange
            var sut = new WeatherForecastController(null);
            var numberOfDays = 7;

            //Act
            var result = sut.Retrieve(numberOfDays).ToList();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(numberOfDays, result.Count);
        }
    }
}
