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
			var zombie = new Zombie();
            ScenarioContext.Current.Set(zombie);
		}

		[Given(@"I have a living person")]
		public void GivenIHaveALivingPerson()
		{
			var person = new Person();
            ScenarioContext.Current.Set(person);
		}

		[When(@"I eat a person")]
		public void WhenIEatAPerson()
		{
            var zombie = ScenarioContext.Current.Get<Zombie>();
            var person = ScenarioContext.Current.Get<Person>();

			zombie.Eat(person);
		}

		[Then(@"the person should die")]
		public void ThenThePersonShouldDie()
        {
            var person = ScenarioContext.Current.Get<Person>();
			person.IsAlive.Should().Be.False();
		}

	}
}