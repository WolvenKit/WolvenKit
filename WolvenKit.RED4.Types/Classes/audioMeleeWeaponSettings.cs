using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeWeaponSettings : audioAudioMetadata
	{
		private audioMeleeAttackSettings _quickAttackSettings;
		private audioMeleeAttackSettings _strongAttackSettings;
		private audioWeaponHandlingSettings _weaponHandlingSettings;

		[Ordinal(1)] 
		[RED("quickAttackSettings")] 
		public audioMeleeAttackSettings QuickAttackSettings
		{
			get => GetProperty(ref _quickAttackSettings);
			set => SetProperty(ref _quickAttackSettings, value);
		}

		[Ordinal(2)] 
		[RED("strongAttackSettings")] 
		public audioMeleeAttackSettings StrongAttackSettings
		{
			get => GetProperty(ref _strongAttackSettings);
			set => SetProperty(ref _strongAttackSettings, value);
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get => GetProperty(ref _weaponHandlingSettings);
			set => SetProperty(ref _weaponHandlingSettings, value);
		}
	}
}
