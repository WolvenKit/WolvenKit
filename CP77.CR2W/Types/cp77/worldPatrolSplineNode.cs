using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplineNode : worldSplineNode
	{
		[Ordinal(0)]  [RED("patrolPointDefs")] public CArray<CHandle<worldPatrolSplinePointDefinition>> PatrolPointDefs { get; set; }
		[Ordinal(1)]  [RED("patrolPoints")] public CArray<NodeRef> PatrolPoints { get; set; }
		[Ordinal(2)]  [RED("spots")] public CArray<CHandle<worldTrafficSpotDefinition>> Spots { get; set; }

		public worldPatrolSplineNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
