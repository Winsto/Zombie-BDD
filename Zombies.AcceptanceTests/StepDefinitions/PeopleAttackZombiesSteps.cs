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
            var person = ScenarioContext.Current.Get<Person>();
            var zombie = ScenarioContext.Current.Get<Zombie>();

            person.Attack(zombie);
		}

		[Then(@"the zombie should die")]
		public void ThenTheZombieShouldDie()
        {
            var zombie = ScenarioContext.Current.Get<Zombie>();
            zombie.IsAnimated.Should().Be.False();
		}

		[Then(@"the zombie should not die")]
		public void ThenTheZombieShouldNotDie()
        {
            var zombie = ScenarioContext.Current.Get<Zombie>();
            zombie.IsAnimated.Should().Be.True();
		}
	}
}