using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHouseDeviceWidgetController : DeviceWidgetControllerBase
	{
		[Ordinal(10)] 
		[RED("interiorManagerSlot")] 
		public CWeakHandle<inkWidget> InteriorManagerSlot
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public SmartHouseDeviceWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
