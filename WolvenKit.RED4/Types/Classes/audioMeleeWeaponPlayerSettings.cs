
namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponPlayerSettings : audioMeleeWeaponSettings
	{
		public audioMeleeWeaponPlayerSettings()
		{
			QuickAttackSettings = new audioMeleeAttackSettings();
			StrongAttackSettings = new audioMeleeAttackSettings();
			WeaponHandlingSettings = new audioWeaponHandlingSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
