using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldInstancedOccluderNode : worldNode
	{
		[Ordinal(2)] [RED("worldBounds")] public Box WorldBounds { get; set; }
		[Ordinal(3)] [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(4)] [RED("autohideDistanceScale")] public CUInt8 AutohideDistanceScale { get; set; }
		[Ordinal(5)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }

		public worldInstancedOccluderNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
