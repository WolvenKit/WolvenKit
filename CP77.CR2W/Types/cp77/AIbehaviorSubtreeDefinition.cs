using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		[Ordinal(2)] [RED("tree")] public CHandle<AIbehaviorParameterizedBehavior> Tree { get; set; }

		public AIbehaviorSubtreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
