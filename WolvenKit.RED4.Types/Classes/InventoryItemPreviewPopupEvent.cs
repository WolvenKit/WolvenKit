using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemPreviewPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<InventoryItemPreviewData> Data
		{
			get => GetPropertyValue<CHandle<InventoryItemPreviewData>>();
			set => SetPropertyValue<CHandle<InventoryItemPreviewData>>(value);
		}
	}
}
