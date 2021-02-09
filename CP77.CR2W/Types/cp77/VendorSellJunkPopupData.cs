using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("items")] public CArray<wCHandle<gameItemData>> Items { get; set; }
		[Ordinal(1)]  [RED("limitedItems")] public CArray<CHandle<VendorJunkSellItem>> LimitedItems { get; set; }
		[Ordinal(2)]  [RED("itemsQuantity")] public CInt32 ItemsQuantity { get; set; }
		[Ordinal(3)]  [RED("limitedItemsQuantity")] public CInt32 LimitedItemsQuantity { get; set; }
		[Ordinal(4)]  [RED("totalPrice")] public CFloat TotalPrice { get; set; }
		[Ordinal(5)]  [RED("limitedTotalPrice")] public CInt32 LimitedTotalPrice { get; set; }

		public VendorSellJunkPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
