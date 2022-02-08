
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeWeaponNpcSettings : audioMeleeWeaponSettings
	{

		public audioMeleeWeaponNpcSettings()
		{
			QuickAttackSettings = new();
			StrongAttackSettings = new();
			WeaponHandlingSettings = new();
		}
	}
}
