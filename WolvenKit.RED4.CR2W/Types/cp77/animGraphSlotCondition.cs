using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGraphSlotCondition : CVariable
	{
		[Ordinal(0)] [RED("condition")] public CHandle<animIStaticCondition> Condition { get; set; }
		[Ordinal(1)] [RED("graph")] public rRef<animAnimGraph> Graph { get; set; }

		public animGraphSlotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
