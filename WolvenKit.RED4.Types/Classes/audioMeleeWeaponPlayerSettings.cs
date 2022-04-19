
namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponPlayerSettings : audioMeleeWeaponSettings
	{
		public audioMeleeWeaponPlayerSettings()
		{
			QuickAttackSettings = new();
			StrongAttackSettings = new();
			WeaponHandlingSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
