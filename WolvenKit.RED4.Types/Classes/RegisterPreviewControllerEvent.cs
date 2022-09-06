using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterPreviewControllerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<gameuiWardrobeSetPreviewGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiWardrobeSetPreviewGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiWardrobeSetPreviewGameController>>(value);
		}

		public RegisterPreviewControllerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
