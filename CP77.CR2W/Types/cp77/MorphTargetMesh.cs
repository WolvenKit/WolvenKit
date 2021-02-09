using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMesh : resStreamedResource
	{
        [Ordinal(0)] [RED("baseMesh")] public rRef<CMesh> BaseMesh { get; set; }



        [Ordinal(1)] [RED("targets")] public CArray<MorphTargetMeshEntry> Targets { get; set; }
        [Ordinal(2)]  [RED("boundingBox")] public Box BoundingBox { get; set; }
		[Ordinal(3)]  [RED("baseTextureParamName")] public CName BaseTextureParamName { get; set; }
        [Ordinal(4)] [RED("blob")] public CHandle<IRenderResourceBlob> Blob { get; set; }
        [Ordinal(5)] [RED("baseMeshAppearance")] public CName BaseMeshAppearance { get; set; }
        [Ordinal(6)]  [RED("baseTexture")] public rRef<ITexture> BaseTexture { get; set; }

        [Ordinal(999)] [RED("resourceVersion")] public CUInt8 resourceVersion { get; set; }


        public MorphTargetMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
