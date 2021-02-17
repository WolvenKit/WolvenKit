using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRepeatNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] [RED("limit")] public CHandle<AIArgumentMapping> Limit { get; set; }
		[Ordinal(2)] [RED("repeatChildOnFailure")] public CBool RepeatChildOnFailure { get; set; }

		public AIbehaviorRepeatNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
