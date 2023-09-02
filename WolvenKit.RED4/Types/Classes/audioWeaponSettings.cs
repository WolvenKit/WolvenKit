using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class audioWeaponSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("bulletType")] 
		public CEnum<audioWeaponBulletType> BulletType
		{
			get => GetPropertyValue<CEnum<audioWeaponBulletType>>();
			set => SetPropertyValue<CEnum<audioWeaponBulletType>>(value);
		}

		[Ordinal(2)] 
		[RED("shellCasingType")] 
		public CEnum<audioWeaponShellCasingType> ShellCasingType
		{
			get => GetPropertyValue<CEnum<audioWeaponShellCasingType>>();
			set => SetPropertyValue<CEnum<audioWeaponShellCasingType>>(value);
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get => GetPropertyValue<audioWeaponHandlingSettings>();
			set => SetPropertyValue<audioWeaponHandlingSettings>(value);
		}

		[Ordinal(4)] 
		[RED("singleShotInSandevistan")] 
		public CBool SingleShotInSandevistan
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("chargeStartSound")] 
		public CName ChargeStartSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("chargeReadySound")] 
		public CName ChargeReadySound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("chargeOverchargeSound")] 
		public CName ChargeOverchargeSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("chargeDischargeSound")] 
		public CName ChargeDischargeSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("fireModeSounds")] 
		public audioWeaponFireModeSounds FireModeSounds
		{
			get => GetPropertyValue<audioWeaponFireModeSounds>();
			set => SetPropertyValue<audioWeaponFireModeSounds>(value);
		}

		public audioWeaponSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
