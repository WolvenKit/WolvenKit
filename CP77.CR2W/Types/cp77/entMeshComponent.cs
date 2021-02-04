using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entMeshComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("mesh")] public raRef<CMesh> Mesh { get; set; }
		[Ordinal(1)]  [RED("meshAppearance")] public CName MeshAppearance { get; set; }
		[Ordinal(2)]  [RED("castShadows")] public CBool CastShadows { get; set; }
		[Ordinal(3)]  [RED("castLocalShadows")] public CBool CastLocalShadows { get; set; }
		[Ordinal(4)]  [RED("motionBlurScale")] public CFloat MotionBlurScale { get; set; }
		[Ordinal(5)]  [RED("visualScale")] public Vector3 VisualScale { get; set; }
		[Ordinal(6)]  [RED("renderingPlane")] public CEnum<ERenderingPlane> RenderingPlane { get; set; }
		[Ordinal(7)]  [RED("objectTypeID")] public CEnum<ERenderObjectType> ObjectTypeID { get; set; }
		[Ordinal(8)]  [RED("numInstances")] public CUInt32 NumInstances { get; set; }
		[Ordinal(9)]  [RED("chunkMask")] public CUInt64 ChunkMask { get; set; }
		[Ordinal(10)]  [RED("LODMode")] public CEnum<entMeshComponentLODMode> LODMode { get; set; }
		[Ordinal(11)]  [RED("overrideMeshNavigationImpact")] public CBool OverrideMeshNavigationImpact { get; set; }
		[Ordinal(12)]  [RED("navigationImpact")] public NavGenNavigationSetting NavigationImpact { get; set; }

		public entMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
