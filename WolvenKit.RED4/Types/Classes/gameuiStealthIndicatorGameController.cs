using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiStealthIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		public gameuiStealthIndicatorGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
