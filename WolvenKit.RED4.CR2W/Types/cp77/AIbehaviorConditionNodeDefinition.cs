using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
		[Ordinal(2)] [RED("resultIfFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfFailed { get; set; }

		public AIbehaviorConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
