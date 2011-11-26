namespace Zombies
{
	public class Zombie
	{
		public bool IsAnimated { get; private set; }

		public Zombie()
		{
			IsAnimated = true;
		}

		public void Die()
		{
			IsAnimated = false;
		}

		public void Eat(Person person)
		{
			person.Die();
		}
	}
}