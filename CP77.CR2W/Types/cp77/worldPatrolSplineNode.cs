using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplineNode : worldSplineNode
	{
		[Ordinal(7)] [RED("patrolPointDefs")] public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs { get; set; }
		[Ordinal(8)] [RED("patrolPoints")] public CArray<NodeRef> PatrolPoints { get; set; }
		[Ordinal(9)] [RED("spots")] public CArray<CHandle<worldTrafficSpotDefinition>> Spots { get; set; }

		public worldPatrolSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
