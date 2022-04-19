using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DoorInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("doorStaturTextWidget")] 
		public CWeakHandle<inkTextWidget> DoorStaturTextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		public DoorInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
