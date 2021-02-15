using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(7)] [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(8)] [RED("requiredLevel")] public CInt32 RequiredLevel { get; set; }
		[Ordinal(9)] [RED("itemQualityState")] public CName ItemQualityState { get; set; }

		public InventoryItemPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
