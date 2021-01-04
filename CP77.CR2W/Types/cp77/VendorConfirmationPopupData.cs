using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)]  [RED("price")] public CInt32 Price { get; set; }
		[Ordinal(2)]  [RED("quantity")] public CInt32 Quantity { get; set; }
		[Ordinal(3)]  [RED("type")] public CEnum<VendorConfirmationPopupType> Type { get; set; }

		public VendorConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
