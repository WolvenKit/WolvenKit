using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDroneGlobalSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("speedRtpc")] 
		public CName SpeedRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("thrustRtpc")] 
		public CName ThrustRtpc
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioDroneGlobalSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
