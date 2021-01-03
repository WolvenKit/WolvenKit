using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameItemAddedEvent : redEvent
	{
		[Ordinal(0)]  [RED("currentQuantity")] public CInt32 CurrentQuantity { get; set; }
		[Ordinal(1)]  [RED("flaggedAsSilent")] public CBool FlaggedAsSilent { get; set; }
		[Ordinal(2)]  [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(3)]  [RED("itemID")] public gameItemID ItemID { get; set; }

		public gameItemAddedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
