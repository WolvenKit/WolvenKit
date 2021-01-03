using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CReflectionProbeDataResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("data")] public DataBuffer Data { get; set; }
		[Ordinal(1)]  [RED("dataHash")] public CUInt64 DataHash { get; set; }
		[Ordinal(2)]  [RED("faceDepth", 6)] public CArrayFixedSize<CFloat> FaceDepth { get; set; }
		[Ordinal(3)]  [RED("haveSkyData")] public CBool HaveSkyData { get; set; }
		[Ordinal(4)]  [RED("textureData")] public rendRenderTextureResource TextureData { get; set; }

		public CReflectionProbeDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
