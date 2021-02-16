using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMeshComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(9)] [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(10)] [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(11)] [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(12)] [RED("motionBlurScale")] public CFloat MotionBlurScale { get; set; }
		[Ordinal(13)] [RED("visualScale")] public Vector3 VisualScale { get; set; }
		[Ordinal(14)] [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(15)] [RED("objectTypeID")] public CEnum<ERenderObjectType> ObjectTypeID { get; set; }
		[Ordinal(16)] [RED("numInstances")] public CUInt32 NumInstances { get; set; }
		[Ordinal(17)] [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(18)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(19)] [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(20)] [RED("overrideMeshNavigationImpact")] public CBool OverrideMeshNavigationImpact { get; set; }
		[Ordinal(21)] [RED("navigationImpact")] public NavGenNavigationSetting NavigationImpact { get; set; }

		public entMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
