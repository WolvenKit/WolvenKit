using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindLaneTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("pointOnLane")] public CHandle<AIArgumentMapping> PointOnLane { get; set; }
		[Ordinal(2)] [RED("filter")] public CEnum<worldFindLaneFilter> Filter { get; set; }

		public AIbehaviorFindLaneTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
