using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDismembermentSoundSettings : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("headEvent")] 
		public CName HeadEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("armEvent")] 
		public CName ArmEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("legEvent")] 
		public CName LegEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioDismembermentSoundSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
