using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeTankPickupController : gameuiarcadeArcadeObjectController
	{
		[Ordinal(3)] 
		[RED("pickup")] 
		public inkWidgetReference Pickup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("pickupText")] 
		public inkWidgetReference PickupText
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeTankPickupController()
		{
			Pickup = new inkWidgetReference();
			PickupText = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
