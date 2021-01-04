using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveEventTagConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		[Ordinal(0)]  [RED("deactivateEvents")] public CBool DeactivateEvents { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		public AIbehaviorPassiveEventTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
