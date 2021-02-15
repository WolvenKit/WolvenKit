using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FillAnimWrapperInfoBasedOnEquippedItem : redEvent
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("itemType")] public CName ItemType { get; set; }
		[Ordinal(2)] [RED("itemName")] public CName ItemName { get; set; }
		[Ordinal(3)] [RED("clearWrapperInfo")] public CBool ClearWrapperInfo { get; set; }

		public FillAnimWrapperInfoBasedOnEquippedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
