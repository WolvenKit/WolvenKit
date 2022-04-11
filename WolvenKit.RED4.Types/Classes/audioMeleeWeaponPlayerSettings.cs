
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeWeaponPlayerSettings : audioMeleeWeaponSettings
	{

		public audioMeleeWeaponPlayerSettings()
		{
			QuickAttackSettings = new();
			StrongAttackSettings = new();
			WeaponHandlingSettings = new();
		}
	}
}
