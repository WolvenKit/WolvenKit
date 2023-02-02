using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioBreathingSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("exhaustionRtpc")] 
		public CName ExhaustionRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("idleFadeOutRtpc")] 
		public CName IdleFadeOutRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("initialState")] 
		public CName InitialState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioBreathingSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
