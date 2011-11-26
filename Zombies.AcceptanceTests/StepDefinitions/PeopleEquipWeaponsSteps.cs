using Should.Fluent;
using TechTalk.SpecFlow;

namespace Zombies.AcceptanceTests.StepDefinitions
{
	[Binding]
	public class PeopleEquipWeaponsSteps
	{
		[Given(@"I have an equiped weapon")]
		public void GivenIHaveAnEquipedWeapon()
        {
            var person = ScenarioContext.Current.Get<Person>();
            person.EquipWeapon(new Weapon());
		}

		[Given(@"I do not have an equiped weapon")]
		public void GivenIDoNotHaveAnEquipedWeapon()
        {
            var person = ScenarioContext.Current.Get<Person>();
            person.EquipWeapon(null);
		}

		[When(@"I equip a weapon")]
		public void WhenIEquipAWeapon()
        {
            var person = ScenarioContext.Current.Get<Person>();
            person.EquipWeapon(new Weapon());
		}

		[Then(@"I should have an active weapon")]
		public void ThenIShouldHaveAnActiveWeapon()
        {
            var person = ScenarioContext.Current.Get<Person>();
            person.ActiveWeapon.Should().Not.Be.Null();
		}
	}
}