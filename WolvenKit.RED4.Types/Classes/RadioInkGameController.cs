using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadioInkGameController : DeviceInkGameControllerBase
	{
		private inkTextWidgetReference _stationNameWidget;
		private inkImageWidgetReference _stationLogoWidget;

		[Ordinal(16)] 
		[RED("stationNameWidget")] 
		public inkTextWidgetReference StationNameWidget
		{
			get => GetProperty(ref _stationNameWidget);
			set => SetProperty(ref _stationNameWidget, value);
		}

		[Ordinal(17)] 
		[RED("stationLogoWidget")] 
		public inkImageWidgetReference StationLogoWidget
		{
			get => GetProperty(ref _stationLogoWidget);
			set => SetProperty(ref _stationLogoWidget, value);
		}
	}
}
