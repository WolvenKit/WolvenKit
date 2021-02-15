using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDecoratorNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		[Ordinal(0)] [RED("child")] public CHandle<AIbehaviorTreeNodeDefinition> Child { get; set; }

		public AIbehaviorDecoratorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
