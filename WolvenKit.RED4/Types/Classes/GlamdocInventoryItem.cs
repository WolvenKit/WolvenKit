using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocInventoryItem : inkVirtualCompoundItemController
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
		public CHandle<GlamdocWrappedUIInventoryItem> Data
		{
			get => GetPropertyValue<CHandle<GlamdocWrappedUIInventoryItem>>();
			set => SetPropertyValue<CHandle<GlamdocWrappedUIInventoryItem>>(value);
		}

		[Ordinal(20)] 
		[RED("widget")] 
		public CWeakHandle<InventoryItemDisplayController> Widget
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public GlamdocInventoryItem()
		{
			Root = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
