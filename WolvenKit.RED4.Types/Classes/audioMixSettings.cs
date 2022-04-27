using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMixSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("masterVolume")] 
		public CFloat MasterVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("sfxVolume")] 
		public CFloat SfxVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("musicVolume")] 
		public CFloat MusicVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("voVolume")] 
		public CFloat VoVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("uiMenuVolume")] 
		public CFloat UiMenuVolume
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("onStartupEvent")] 
		public CName OnStartupEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMixSettings()
		{
			MasterVolume = 10.000000F;
			SfxVolume = 10.000000F;
			MusicVolume = 10.000000F;
			VoVolume = 10.000000F;
			UiMenuVolume = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
