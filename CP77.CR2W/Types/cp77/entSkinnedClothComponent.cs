using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSkinnedClothComponent : entISkinTargetComponent
	{
		[Ordinal(10)] [RED("graphicsMesh")] public raRef<CMesh> GraphicsMesh { get; set; }
		[Ordinal(11)] [RED("physicalMesh")] public raRef<CMesh> PhysicalMesh { get; set; }
		[Ordinal(12)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(13)] [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(14)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(15)] [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(16)] [RED("compiledTopologyData")] public meshCookedClothMeshTopologyData CompiledTopologyData { get; set; }

		public entSkinnedClothComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
