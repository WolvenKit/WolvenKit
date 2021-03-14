using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticOccluderMeshNode : worldNode
	{
		[Ordinal(4)] [RED("occluderType")] public CEnum<visWorldOccluderType> OccluderType { get; set; }
		[Ordinal(5)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(6)] [RED("autohideDistanceScale")] public CUInt8 AutohideDistanceScale { get; set; }
		[Ordinal(7)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }

		public worldStaticOccluderMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
