using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionRotateToObjectTreeNodeDefinition : AIbehaviorActionRotateBaseTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("completeWhenRotated")] public CHandle<AIArgumentMapping> CompleteWhenRotated { get; set; }

		public AIbehaviorActionRotateToObjectTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
