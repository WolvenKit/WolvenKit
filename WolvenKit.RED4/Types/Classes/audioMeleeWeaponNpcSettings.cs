
namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponNpcSettings : audioMeleeWeaponSettings
	{
		public audioMeleeWeaponNpcSettings()
		{
			QuickAttackSettings = new audioMeleeAttackSettings();
			StrongAttackSettings = new audioMeleeAttackSettings();
			WeaponHandlingSettings = new audioWeaponHandlingSettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
