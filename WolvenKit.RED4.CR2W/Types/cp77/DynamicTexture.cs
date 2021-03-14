using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DynamicTexture : ITexture
	{
		[Ordinal(1)] [RED("width")] public CUInt32 Width { get; set; }
		[Ordinal(2)] [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(3)] [RED("scaleToViewport")] public CBool ScaleToViewport { get; set; }
		[Ordinal(4)] [RED("mipChain")] public CBool MipChain { get; set; }
		[Ordinal(5)] [RED("samplesCount")] public CUInt8 SamplesCount { get; set; }
		[Ordinal(6)] [RED("dataFormat")] public CEnum<DynamicTextureDataFormat> DataFormat { get; set; }
		[Ordinal(7)] [RED("generator")] public CHandle<IDynamicTextureGenerator> Generator { get; set; }

		public DynamicTexture(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
