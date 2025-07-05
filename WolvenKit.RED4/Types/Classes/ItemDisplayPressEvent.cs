using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemDisplayPressEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("display")] 
		public CWeakHandle<InventoryItemDisplayController> Display
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		public ItemDisplayPressEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
