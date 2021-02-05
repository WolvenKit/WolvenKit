using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entStaticOccluderMeshComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("scale")] public Vector3 Scale { get; set; }
		[Ordinal(2)]  [RED("color")] public CColor Color { get; set; }
		[Ordinal(3)]  [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(4)]  [RED("occluderAutohideDistanceScale")] public CUInt8 OccluderAutohideDistanceScale { get; set; }

		public entStaticOccluderMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
