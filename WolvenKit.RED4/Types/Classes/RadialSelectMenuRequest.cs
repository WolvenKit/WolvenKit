using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialSelectMenuRequest : redEvent
	{
		[Ordinal(0)] 
		[RED("eventData")] 
		public CWeakHandle<RadialMenuItemController> EventData
		{
			get => GetPropertyValue<CWeakHandle<RadialMenuItemController>>();
			set => SetPropertyValue<CWeakHandle<RadialMenuItemController>>(value);
		}

		public RadialSelectMenuRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
