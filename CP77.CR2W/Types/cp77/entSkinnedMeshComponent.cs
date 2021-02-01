using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(0)]  [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(1)]  [RED("acceptDismemberment")] public CBool AcceptDismemberment { get; set; }
		[Ordinal(2)]  [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(3)]  [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(4)]  [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(7)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(8)]  [RED("renderingPlaneAnimationParam")] public CName RenderingPlaneAnimationParam { get; set; }
		[Ordinal(9)]  [RED("useProxyMeshAsShadowMesh")] public CBool UseProxyMeshAsShadowMesh { get; set; }
		[Ordinal(10)]  [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }

		public entSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
