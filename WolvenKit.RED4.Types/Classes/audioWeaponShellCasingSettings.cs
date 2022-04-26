using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponShellCasingSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<audioWeaponShellCasingMode> Mode
		{
			get => GetPropertyValue<CEnum<audioWeaponShellCasingMode>>();
			set => SetPropertyValue<CEnum<audioWeaponShellCasingMode>>(value);
		}

		[Ordinal(2)] 
		[RED("direction")] 
		public CEnum<audioWeaponShellCasingDirection> Direction
		{
			get => GetPropertyValue<CEnum<audioWeaponShellCasingDirection>>();
			set => SetPropertyValue<CEnum<audioWeaponShellCasingDirection>>(value);
		}

		[Ordinal(3)] 
		[RED("firstCollisionEventName")] 
		public CName FirstCollisionEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("secondCollisionEventName")] 
		public CName SecondCollisionEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("initialDelay")] 
		public CFloat InitialDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioWeaponShellCasingSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
