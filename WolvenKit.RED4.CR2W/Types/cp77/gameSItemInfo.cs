using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSItemInfo : CVariable
	{
		[Ordinal(0)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }

		public gameSItemInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
