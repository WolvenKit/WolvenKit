using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(7)] [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(8)] [RED("type")] public CEnum<VendorConfirmationPopupType> Type { get; set; }
		[Ordinal(9)] [RED("price")] public CInt32 Price { get; set; }

		public VendorConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
