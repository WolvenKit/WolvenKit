using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGlobaltvWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("overlayContainer")] 
		public inkCompoundWidgetReference OverlayContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		public gameuiGlobaltvWidgetGameController()
		{
			OverlayContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
