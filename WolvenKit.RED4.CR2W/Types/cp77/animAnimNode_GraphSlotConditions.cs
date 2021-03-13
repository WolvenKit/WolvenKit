using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlotConditions : animAnimNode_GraphSlot
	{
		[Ordinal(14)] [RED("conditions")] public CArray<animGraphSlotCondition> Conditions { get; set; }

		public animAnimNode_GraphSlotConditions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
