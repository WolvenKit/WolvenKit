using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsNodeStreamedConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(1)] [RED("nodeRef")] public CHandle<AIArgumentMapping> NodeRef { get; set; }

		public AIbehaviorIsNodeStreamedConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
