using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSPartSlots : CVariable
	{
		[Ordinal(0)]  [RED("innerItemData")] public gameInnerItemData InnerItemData { get; set; }
		[Ordinal(1)]  [RED("installedPart")] public gameItemID InstalledPart { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(3)]  [RED("status")] public CEnum<gameESlotState> Status { get; set; }

		public gameSPartSlots(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
