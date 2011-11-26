namespace Zombies
{
	public class Person
	{
		public bool IsAlive { get; private set; }
		public Weapon ActiveWeapon { get; set; }

		public Person()
		{
			IsAlive = true;
		}

		public void EquipWeapon(Weapon weapon)
		{
			ActiveWeapon = weapon;
		}

		public void Attack(Zombie zombie)
		{
			if (null != ActiveWeapon)
				zombie.Die();
		}

		public void Die()
		{
			IsAlive = false;
		}
	}
}