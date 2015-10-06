using Should.Fluent;
using TechTalk.SpecFlow;

namespace Zombies.AcceptanceTests.StepDefinitions
{
	[Binding]
	public class PeopleAttackZombiesSteps
	{
		[When(@"I attack a zombie")]
		public void WhenIAttackAZombie()
        {
            ScenarioContext.Current.Pending();
        }

		[Then(@"the zombie should die")]
		public void ThenTheZombieShouldDie()
        {
            ScenarioContext.Current.Pending();
        }

		[Then(@"the zombie should not die")]
		public void ThenTheZombieShouldNotDie()
        {
            ScenarioContext.Current.Pending();
        }
	}
}