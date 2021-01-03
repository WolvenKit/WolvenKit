using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DynamicTexture : ITexture
	{
		[Ordinal(0)]  [RED("dataFormat")] public CEnum<DynamicTextureDataFormat> DataFormat { get; set; }
		[Ordinal(1)]  [RED("generator")] public CHandle<IDynamicTextureGenerator> Generator { get; set; }
		[Ordinal(2)]  [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(3)]  [RED("mipChain")] public CBool MipChain { get; set; }
		[Ordinal(4)]  [RED("samplesCount")] public CUInt8 SamplesCount { get; set; }
		[Ordinal(5)]  [RED("scaleToViewport")] public CBool ScaleToViewport { get; set; }
		[Ordinal(6)]  [RED("width")] public CUInt32 Width { get; set; }

		public DynamicTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
