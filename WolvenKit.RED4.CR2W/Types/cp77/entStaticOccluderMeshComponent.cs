using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entStaticOccluderMeshComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("mesh")] public rRef<CMesh> Mesh { get; set; }
		[Ordinal(6)] [RED("scale")] public Vector3 Scale { get; set; }
		[Ordinal(7)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(8)] [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(9)] [RED("occluderAutohideDistanceScale")] public CUInt8 OccluderAutohideDistanceScale { get; set; }

		public entStaticOccluderMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
