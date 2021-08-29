using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventorySlotWrapperTooltip : AGenericTooltipController
	{
		private CWeakHandle<InventoryItemDisplayController> _itemDisplayController;

		[Ordinal(2)] 
		[RED("itemDisplayController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemDisplayController
		{
			get => GetProperty(ref _itemDisplayController);
			set => SetProperty(ref _itemDisplayController, value);
		}
	}
}
