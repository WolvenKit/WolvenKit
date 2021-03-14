using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskItem : CVariable
	{
		[Ordinal(0)] [RED("leftHandSide")] public CHandle<AIArgumentMapping> LeftHandSide { get; set; }
		[Ordinal(1)] [RED("rightHandSide")] public CHandle<AIArgumentMapping> RightHandSide { get; set; }

		public AIbehaviorAssignTaskItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
