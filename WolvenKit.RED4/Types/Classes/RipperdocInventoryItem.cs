using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocInventoryItem : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("data")] 
		public CHandle<RipperdocWrappedUIInventoryItem> Data
		{
			get => GetPropertyValue<CHandle<RipperdocWrappedUIInventoryItem>>();
			set => SetPropertyValue<CHandle<RipperdocWrappedUIInventoryItem>>(value);
		}

		[Ordinal(20)] 
		[RED("widget")] 
		public CWeakHandle<InventoryItemDisplayController> Widget
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public RipperdocInventoryItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
