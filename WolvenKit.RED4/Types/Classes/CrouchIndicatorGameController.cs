using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrouchIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("crouchIcon")] 
		public inkImageWidgetReference CrouchIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("genderName")] 
		public CName GenderName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("psmLocomotionStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmLocomotionStateChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CrouchIndicatorGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
