using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobHeader : CVariable
	{
		[Ordinal(0)] [RED("version")] public CUInt32 Version { get; set; }
		[Ordinal(1)] [RED("sizeInfo")] public rendRenderTextureBlobSizeInfo SizeInfo { get; set; }
		[Ordinal(2)] [RED("textureInfo")] public rendRenderTextureBlobTextureInfo TextureInfo { get; set; }
		[Ordinal(3)] [RED("mipMapInfo")] public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo { get; set; }
		[Ordinal(4)] [RED("histogramData")] public CArray<rendHistogramBias> HistogramData { get; set; }
		[Ordinal(5)] [RED("flags")] public CUInt32 Flags { get; set; }

		public rendRenderTextureBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
