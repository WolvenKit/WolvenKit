using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplinePointDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("node")] public NodeRef Node { get; set; }
		[Ordinal(1)]  [RED("pointType")] public CEnum<worldPatrolSplinePointTypes> PointType { get; set; }
		[Ordinal(2)]  [RED("target")] public gameEntityReference Target { get; set; }

		public worldPatrolSplinePointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
