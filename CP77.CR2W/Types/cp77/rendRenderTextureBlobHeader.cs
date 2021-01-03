using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobHeader : CVariable
	{
		[Ordinal(0)]  [RED("flags")] public CUInt32 Flags { get; set; }
		[Ordinal(1)]  [RED("histogramData")] public CArray<rendHistogramBias> HistogramData { get; set; }
		[Ordinal(2)]  [RED("mipMapInfo")] public CArray<rendRenderTextureBlobMipMapInfo> MipMapInfo { get; set; }
		[Ordinal(3)]  [RED("sizeInfo")] public rendRenderTextureBlobSizeInfo SizeInfo { get; set; }
		[Ordinal(4)]  [RED("textureInfo")] public rendRenderTextureBlobTextureInfo TextureInfo { get; set; }
		[Ordinal(5)]  [RED("version")] public CUInt32 Version { get; set; }

		public rendRenderTextureBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
