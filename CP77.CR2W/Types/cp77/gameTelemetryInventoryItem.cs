using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryInventoryItem : CVariable
	{
		[Ordinal(0)]  [RED("friendlyName")] public CString FriendlyName { get; set; }
		[Ordinal(1)]  [RED("iconic")] public CBool Iconic { get; set; }
		[Ordinal(2)]  [RED("isSilenced")] public CBool IsSilenced { get; set; }
		[Ordinal(3)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(4)]  [RED("itemLevel")] public CInt32 ItemLevel { get; set; }
		[Ordinal(5)]  [RED("itemType")] public CEnum<gamedataItemType> ItemType { get; set; }
		[Ordinal(6)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(7)]  [RED("quality")] public CInt32 Quality { get; set; }

		public gameTelemetryInventoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
