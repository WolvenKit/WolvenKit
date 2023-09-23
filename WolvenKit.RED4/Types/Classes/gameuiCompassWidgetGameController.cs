using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCompassWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiCompassWidgetGameController()
		{
			CompassWidget = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
