using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareItemLogicController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("slotRoot")] 
		public inkCompoundWidgetReference SlotRoot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("slot")] 
		public CWeakHandle<InventoryItemDisplayController> Slot
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		public CyberwareItemLogicController()
		{
			SlotRoot = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
