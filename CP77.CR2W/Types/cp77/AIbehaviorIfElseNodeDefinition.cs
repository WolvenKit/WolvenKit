using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIfElseNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("condition")] public CHandle<AIbehaviorExpressionSocket> Condition { get; set; }

		public AIbehaviorIfElseNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
