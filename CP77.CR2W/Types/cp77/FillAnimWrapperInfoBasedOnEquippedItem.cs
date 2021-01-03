using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FillAnimWrapperInfoBasedOnEquippedItem : redEvent
	{
		[Ordinal(0)]  [RED("clearWrapperInfo")] public CBool ClearWrapperInfo { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("itemName")] public CName ItemName { get; set; }
		[Ordinal(3)]  [RED("itemType")] public CName ItemType { get; set; }

		public FillAnimWrapperInfoBasedOnEquippedItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
