using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("itemName")] public CString ItemName { get; set; }
		[Ordinal(2)]  [RED("itemQualityState")] public CName ItemQualityState { get; set; }
		[Ordinal(3)]  [RED("requiredLevel")] public CInt32 RequiredLevel { get; set; }

		public InventoryItemPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
