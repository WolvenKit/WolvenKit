using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSkinnedClothComponent : entISkinTargetComponent
	{
		[Ordinal(0)]  [RED("graphicsMesh")] public raRef<CMesh> GraphicsMesh { get; set; }
		[Ordinal(1)]  [RED("physicalMesh")] public raRef<CMesh> PhysicalMesh { get; set; }
		[Ordinal(2)]  [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(3)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(4)]  [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(5)]  [RED("compiledTopologyData")] public meshCookedClothMeshTopologyData CompiledTopologyData { get; set; }

		public entSkinnedClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
