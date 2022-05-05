using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("quickAttackSettings")] 
		public audioMeleeAttackSettings QuickAttackSettings
		{
			get => GetPropertyValue<audioMeleeAttackSettings>();
			set => SetPropertyValue<audioMeleeAttackSettings>(value);
		}

		[Ordinal(2)] 
		[RED("strongAttackSettings")] 
		public audioMeleeAttackSettings StrongAttackSettings
		{
			get => GetPropertyValue<audioMeleeAttackSettings>();
			set => SetPropertyValue<audioMeleeAttackSettings>(value);
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get => GetPropertyValue<audioWeaponHandlingSettings>();
			set => SetPropertyValue<audioWeaponHandlingSettings>(value);
		}

		public audioMeleeWeaponSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
