using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventorySlotWrapperTooltip : AGenericTooltipController
	{
		[Ordinal(2)] 
		[RED("itemDisplayController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemDisplayController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}
	}
}
