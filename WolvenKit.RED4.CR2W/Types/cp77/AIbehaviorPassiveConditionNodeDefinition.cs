using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("condition")] public CHandle<AIbehaviorPassiveConditionDefinition> Condition { get; set; }
		[Ordinal(2)] [RED("resultIfFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfFailed { get; set; }

		public AIbehaviorPassiveConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
