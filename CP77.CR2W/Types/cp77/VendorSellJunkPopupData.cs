using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("items")] public CArray<wCHandle<gameItemData>> Items { get; set; }
		[Ordinal(1)]  [RED("itemsQuantity")] public CInt32 ItemsQuantity { get; set; }
		[Ordinal(2)]  [RED("limitedItems")] public CArray<CHandle<VendorJunkSellItem>> LimitedItems { get; set; }
		[Ordinal(3)]  [RED("limitedItemsQuantity")] public CInt32 LimitedItemsQuantity { get; set; }
		[Ordinal(4)]  [RED("limitedTotalPrice")] public CInt32 LimitedTotalPrice { get; set; }
		[Ordinal(5)]  [RED("totalPrice")] public CFloat TotalPrice { get; set; }

		public VendorSellJunkPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
