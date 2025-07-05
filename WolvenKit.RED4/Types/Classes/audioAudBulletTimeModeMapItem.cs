using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("timeModeRTPC")] 
		public CName TimeModeRTPC
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAudBulletTimeModeMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
