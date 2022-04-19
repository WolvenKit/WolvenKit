using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDeviceStateSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("powerRestoredSound")] 
		public CName PowerRestoredSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("powerCutSound")] 
		public CName PowerCutSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("turnOnSound")] 
		public CName TurnOnSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("turnOffSound")] 
		public CName TurnOffSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("breakingSound")] 
		public CName BreakingSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioDeviceStateSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
