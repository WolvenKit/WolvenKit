using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemAddedEvent : redEvent
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(2)]  [RED("currentQuantity")] public CInt32 CurrentQuantity { get; set; }
		[Ordinal(3)]  [RED("flaggedAsSilent")] public CBool FlaggedAsSilent { get; set; }

		public gameItemAddedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
