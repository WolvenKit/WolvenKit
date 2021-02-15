using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entSkinnedMeshComponent : entISkinTargetComponent
	{
		[Ordinal(10)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(11)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(12)] [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(13)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(14)] [RED("acceptDismemberment")] public CBool AcceptDismemberment { get; set; }
		[Ordinal(15)] [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(16)] [RED("renderingPlaneAnimationParam")] public CName RenderingPlaneAnimationParam { get; set; }
		[Ordinal(17)] [RED("visibilityAnimationParam")] public CName VisibilityAnimationParam { get; set; }
		[Ordinal(18)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(19)] [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(20)] [RED("useProxyMeshAsShadowMesh")] public CBool UseProxyMeshAsShadowMesh { get; set; }

		public entSkinnedMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
