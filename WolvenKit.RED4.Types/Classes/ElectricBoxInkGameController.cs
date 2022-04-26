using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElectricBoxInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("onOverrideListener")] 
		public CHandle<redCallbackObject> OnOverrideListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public ElectricBoxInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
