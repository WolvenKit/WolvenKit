using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioScanningSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("scanningStartEvent")] 
		public CName ScanningStartEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("scanningStopEvent")] 
		public CName ScanningStopEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("scanningCompleteEvent")] 
		public CName ScanningCompleteEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("scanningAvailableEvent")] 
		public CName ScanningAvailableEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioScanningSettings()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
