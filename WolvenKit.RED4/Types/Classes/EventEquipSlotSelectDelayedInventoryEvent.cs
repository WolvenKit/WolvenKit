using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EventEquipSlotSelectDelayedInventoryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<InventoryItemDisplayController> Controller
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public EventEquipSlotSelectDelayedInventoryEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
