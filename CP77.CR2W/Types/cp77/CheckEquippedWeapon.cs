using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeapon : AIItemHandlingCondition
	{
		[Ordinal(0)] [RED("slotID")] public CHandle<AIArgumentMapping> SlotID { get; set; }
		[Ordinal(1)] [RED("itemID")] public CHandle<AIArgumentMapping> ItemID { get; set; }
		[Ordinal(2)] [RED("slotIDName")] public TweakDBID SlotIDName { get; set; }
		[Ordinal(3)] [RED("itemIDName")] public TweakDBID ItemIDName { get; set; }

		public CheckEquippedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
