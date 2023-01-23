using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get => GetPropertyValue<CEnum<ERadioStationList>>();
			set => SetPropertyValue<CEnum<ERadioStationList>>(value);
		}

		[Ordinal(1)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RadioSetup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
