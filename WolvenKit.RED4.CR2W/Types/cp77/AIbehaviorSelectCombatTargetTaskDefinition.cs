using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(2)] [RED("targetClosest")] public CBool TargetClosest { get; set; }

		public AIbehaviorSelectCombatTargetTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
