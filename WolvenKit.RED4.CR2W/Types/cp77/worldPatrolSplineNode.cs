using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplineNode : worldSplineNode
	{
		[Ordinal(9)] [RED("patrolPointDefs")] public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs { get; set; }
		[Ordinal(10)] [RED("patrolPoints")] public CArray<NodeRef> PatrolPoints { get; set; }
		[Ordinal(11)] [RED("spots")] public CArray<CHandle<worldTrafficSpotDefinition>> Spots { get; set; }

		public worldPatrolSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
