using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NPCItemToEquip : CVariable
	{
		[Ordinal(0)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(1)]  [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(2)]  [RED("bodySlotID")] public TweakDBID BodySlotID { get; set; }

		public NPCItemToEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
