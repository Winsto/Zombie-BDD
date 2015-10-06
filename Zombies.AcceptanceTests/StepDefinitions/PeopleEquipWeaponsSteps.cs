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
            ScenarioContext.Current.Pending();
        }

		[Given(@"I do not have an equiped weapon")]
		public void GivenIDoNotHaveAnEquipedWeapon()
        {
            ScenarioContext.Current.Pending();
        }

		[When(@"I equip a weapon")]
		public void WhenIEquipAWeapon()
        {
            ScenarioContext.Current.Pending();
        }

		[Then(@"I should have an active weapon")]
		public void ThenIShouldHaveAnActiveWeapon()
        {
            ScenarioContext.Current.Pending();
        }
	}
}