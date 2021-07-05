using TechTalk.SpecFlow;

namespace AzurePipelinesExample.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            // Do nothing to make scenario pass
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            // Do nothing to make scenario pass
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            // Do nothing to make scenario pass
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            // Do nothing to make scenario pass
        }
    }
}
