using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldBendedMeshNode : worldNode
	{
		[Ordinal(0)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("deformationData")] public CArray<CMatrix> DeformationData { get; set; }
		[Ordinal(2)]  [RED("deformedBox")] public Box DeformedBox { get; set; }
		[Ordinal(3)]  [RED("isBendedRoad")] public CBool IsBendedRoad { get; set; }
		[Ordinal(4)]  [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(5)]  [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(6)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(7)]  [RED("navigationSetting")] public NavGenNavigationSetting NavigationSetting { get; set; }
		[Ordinal(8)]  [RED("removeFromRainMap")] public CBool RemoveFromRainMap { get; set; }

		public worldBendedMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
