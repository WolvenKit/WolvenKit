using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NPCItemToEquip : CVariable
	{
		[Ordinal(0)]  [RED("bodySlotID")] public TweakDBID BodySlotID { get; set; }
		[Ordinal(1)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public NPCItemToEquip(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
