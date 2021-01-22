using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobTextureInfo : CVariable
	{
		[Ordinal(0)]  [RED("dataAlignment")] public CUInt32 DataAlignment { get; set; }
		[Ordinal(1)]  [RED("mipCount")] public CUInt8 MipCount { get; set; }
		[Ordinal(2)]  [RED("sliceCount")] public CUInt16 SliceCount { get; set; }
		[Ordinal(3)]  [RED("sliceSize")] public CUInt32 SliceSize { get; set; }
		[Ordinal(4)]  [RED("textureDataSize")] public CUInt32 TextureDataSize { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<GpuWrapApieTextureType> Type { get; set; }

		public rendRenderTextureBlobTextureInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
