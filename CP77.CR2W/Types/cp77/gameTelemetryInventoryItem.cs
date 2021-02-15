using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryInventoryItem : CVariable
	{
		[Ordinal(0)] [RED("friendlyName")] public CString FriendlyName { get; set; }
		[Ordinal(1)] [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(2)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(3)] [RED("quality")] public CInt32 Quality { get; set; }
		[Ordinal(4)] [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(5)] [RED("iconic")] public CBool Iconic { get; set; }
		[Ordinal(6)] [RED("itemLevel")] public CInt32 ItemLevel { get; set; }
		[Ordinal(7)] [RED("isSilenced")] public CBool IsSilenced { get; set; }

		public gameTelemetryInventoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
