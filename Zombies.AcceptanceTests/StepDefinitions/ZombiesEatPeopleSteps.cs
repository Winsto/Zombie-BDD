using Should.Fluent;
using TechTalk.SpecFlow;

namespace Zombies.AcceptanceTests.StepDefinitions
{
	[Binding]
	public class ZombiesEatPeopleSteps
	{
		[Given(@"I have an animated zombie")]
		public void GivenIHaveAnAnimatedZombie()
		{
            ScenarioContext.Current.Pending();
        }

		[Given(@"I have a living person")]
		public void GivenIHaveALivingPerson()
		{
            ScenarioContext.Current.Pending();
        }

		[When(@"I eat a person")]
		public void WhenIEatAPerson()
		{
            ScenarioContext.Current.Pending();
        }

		[Then(@"the person should die")]
		public void ThenThePersonShouldDie()
        {
            ScenarioContext.Current.Pending();
        }

	}
}