using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("stationNameWidget")] 
		public inkTextWidgetReference StationNameWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("stationLogoWidget")] 
		public inkImageWidgetReference StationLogoWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public RadioInkGameController()
		{
			StationNameWidget = new inkTextWidgetReference();
			StationLogoWidget = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
