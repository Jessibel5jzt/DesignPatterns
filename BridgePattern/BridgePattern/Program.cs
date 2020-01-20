using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var enemy = new IEnemy();
			var soldier = new ISoldier();
			var gun = new IGun();
			var cannon = new ICannon();
			enemy.SetWeapon(gun);
			soldier.SetWeapon(cannon);
			gun.DamageValue(soldier);
			cannon.DamageValue(enemy);
			Console.ReadLine();
		}
	}

	public abstract class IWeapon
	{
		public abstract void DamageValue(ICharacter character);
	}

	public class IGun : IWeapon
	{
		public override void DamageValue(ICharacter character)
		{
			Console.WriteLine("Gun");
		}
	}

	public class ICannon : IWeapon
	{
		public override void DamageValue(ICharacter character)
		{
			Console.WriteLine("Cannon");
		}
	}

	public abstract class ICharacter
	{
		protected IWeapon m_Weapon = null;

		public void SetWeapon(IWeapon theWeapon)
		{
			m_Weapon = theWeapon;
		}

		public abstract void InstantiateCharacter();
	}

	public class ISoldier : ICharacter
	{
		public override void InstantiateCharacter()
		{
			m_Weapon.DamageValue(this);
		}
	}

	public class IEnemy : ICharacter
	{
		public override void InstantiateCharacter()
		{
			m_Weapon.DamageValue(this);
		}
	}
}
