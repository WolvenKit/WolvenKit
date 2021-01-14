using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEventWithTagConditionDefinition : AIbehaviorConditionDefinition
	{
		[Ordinal(0)]  [RED("consumeEvent")] public CBool ConsumeEvent { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		public AIbehaviorEventWithTagConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
