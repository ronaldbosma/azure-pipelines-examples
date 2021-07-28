using AzurePipelinesExample.WebApi;
using AzurePipelinesExample.WebApi.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace AzurePipelinesExample.Specs.Steps
{
    [Binding]
    public sealed class WeatherForecastStepDefinitions
    {
        private readonly WeatherForecastController _weatherForecastController = new WeatherForecastController(null);
        private IList<WeatherForecast> _result;

        [When(@"I get the weather foreceast")]
        public void WhenIGetTheWeatherForeceast()
        {
            _result = _weatherForecastController.Get().ToList();
        }

        [Then(@"the forecast for (.*) days is returned")]
        public void ThenTheForecastForDaysIsReturned(int expectedNumberOfForecasts)
        {
            Assert.IsNotNull(_result);
            Assert.AreEqual(expectedNumberOfForecasts, _result.Count);
        }

    }
}
