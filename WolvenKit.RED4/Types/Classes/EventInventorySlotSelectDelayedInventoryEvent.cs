using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EventInventorySlotSelectDelayedInventoryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public gameInventoryItemData Controller
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public CWeakHandle<inkWidget> Target
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public EventInventorySlotSelectDelayedInventoryEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
