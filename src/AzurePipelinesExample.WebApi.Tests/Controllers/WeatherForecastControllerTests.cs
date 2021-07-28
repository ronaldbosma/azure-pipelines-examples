using AzurePipelinesExample.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AzurePipelinesExample.WebApi.Tests.Controllers
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        [TestMethod]
        public void Get()
        {
            //Arrange
            var sut = new WeatherForecastController(null);

            //Act
            var result = sut.Get().ToList();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count);
        }
    }
}
