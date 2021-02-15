using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPassiveSignalConditionDefinition : AIbehaviorPassiveConditionDefinition
	{
		[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)] [RED("deactivateSignal")] public CBool DeactivateSignal { get; set; }

		public AIbehaviorPassiveSignalConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
