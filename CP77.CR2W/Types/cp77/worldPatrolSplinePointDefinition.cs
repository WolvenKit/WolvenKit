using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplinePointDefinition : ISerializable
	{
		[Ordinal(0)] [RED("pointType")] public CEnum<worldPatrolSplinePointTypes> PointType { get; set; }
		[Ordinal(1)] [RED("node")] public NodeRef Node { get; set; }
		[Ordinal(2)] [RED("target")] public gameEntityReference Target { get; set; }

		public worldPatrolSplinePointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
