using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMesh_ : resStreamedResource
	{
		[Ordinal(1)] [RED("baseMesh")] public rRef<CMesh> BaseMesh { get; set; }
		[Ordinal(2)] [RED("targets")] public CArray<MorphTargetMeshEntry> Targets { get; set; }
		[Ordinal(3)] [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(4)] [RED("baseTextureParamName")] public CName BaseTextureParamName { get; set; }
		[Ordinal(5)] [RED("blob")] public CHandle<IRenderResourceBlob> Blob { get; set; }
		[Ordinal(6)] [RED("baseMeshAppearance")] public CName BaseMeshAppearance { get; set; }
		[Ordinal(7)] [RED("baseTexture")] public rRef<ITexture> BaseTexture { get; set; }

		public MorphTargetMesh_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
