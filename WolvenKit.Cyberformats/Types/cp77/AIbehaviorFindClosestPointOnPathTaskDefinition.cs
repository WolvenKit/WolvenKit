using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnPathTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("path")] public CHandle<AIArgumentMapping> Path { get; set; }
		[Ordinal(2)] [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
		[Ordinal(3)] [RED("positionOnPath")] public CHandle<AIArgumentMapping> PositionOnPath { get; set; }
		[Ordinal(4)] [RED("entryTangent")] public CHandle<AIArgumentMapping> EntryTangent { get; set; }

		public AIbehaviorFindClosestPointOnPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
