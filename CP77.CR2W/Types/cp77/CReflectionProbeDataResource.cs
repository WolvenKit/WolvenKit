using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CReflectionProbeDataResource : resStreamedResource
	{
		[Ordinal(1)] [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(2)] [RED("textureData")] public rendRenderTextureResource TextureData { get; set; }
		[Ordinal(3)] [RED("dataHash")] public CUInt64 DataHash { get; set; }
		[Ordinal(4)] [RED("haveSkyData")] public CBool HaveSkyData { get; set; }
		[Ordinal(5)] [RED("faceDepth", 6)] public CArrayFixedSize<CFloat> FaceDepth { get; set; }

		public CReflectionProbeDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
