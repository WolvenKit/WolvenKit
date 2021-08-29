using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareItemLogicController : inkVirtualCompoundItemController
	{
		private inkCompoundWidgetReference _slotRoot;
		private CWeakHandle<InventoryItemDisplayController> _slot;

		[Ordinal(15)] 
		[RED("slotRoot")] 
		public inkCompoundWidgetReference SlotRoot
		{
			get => GetProperty(ref _slotRoot);
			set => SetProperty(ref _slotRoot, value);
		}

		[Ordinal(16)] 
		[RED("slot")] 
		public CWeakHandle<InventoryItemDisplayController> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}
	}
}
