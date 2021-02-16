using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompositeTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] [RED("children")] public CArray<CHandle<AIbehaviorTreeNodeDefinition>> Children { get; set; }

		public AIbehaviorCompositeTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
