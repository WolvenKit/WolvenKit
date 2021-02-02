using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldFoliageNode : worldNode
	{
		[Ordinal(0)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)]  [RED("foliageResource")] public raRef<worldFoliageCompiledResource> FoliageResource { get; set; }
		[Ordinal(3)]  [RED("foliageLocalBounds")] public Box FoliageLocalBounds { get; set; }
		[Ordinal(4)]  [RED("populationSpanInfo")] public worldFoliagePopulationSpanInfo PopulationSpanInfo { get; set; }
		[Ordinal(5)]  [RED("destructionHash")] public CUInt64 DestructionHash { get; set; }
		[Ordinal(6)]  [RED("autoHideDistanceScale")] public CFloat AutoHideDistanceScale { get; set; }
		[Ordinal(7)]  [RED("lodDistanceScale")] public CFloat LodDistanceScale { get; set; }
		[Ordinal(8)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(9)]  [RED("meshHeight")] public CFloat MeshHeight { get; set; }

		public worldFoliageNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
