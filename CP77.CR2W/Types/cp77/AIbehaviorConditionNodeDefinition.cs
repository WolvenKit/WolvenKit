using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorConditionNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<AIbehaviorConditionDefinition> Condition { get; set; }
		[Ordinal(1)]  [RED("resultIfFailed")] public CEnum<AIbehaviorCompletionStatus> ResultIfFailed { get; set; }

		public AIbehaviorConditionNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
