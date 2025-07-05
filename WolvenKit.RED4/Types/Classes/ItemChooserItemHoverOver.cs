using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemChooserItemHoverOver : redEvent
	{
		[Ordinal(0)] 
		[RED("sourceEvent")] 
		public CHandle<inkPointerEvent> SourceEvent
		{
			get => GetPropertyValue<CHandle<inkPointerEvent>>();
			set => SetPropertyValue<CHandle<inkPointerEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("targetItem")] 
		public CWeakHandle<InventoryItemDisplayController> TargetItem
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public ItemChooserItemHoverOver()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
