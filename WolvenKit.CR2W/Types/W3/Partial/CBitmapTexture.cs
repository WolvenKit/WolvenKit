using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBitmapTexture : ITexture
	{
		[Ordinal(0)] [RED("width")] 		public CUInt32 Width { get; set;}

		[Ordinal(0)] [RED("height")] 		public CUInt32 Height { get; set;}

		[Ordinal(0)] [RED("format")] 		public CEnum<ETextureRawFormat> Format { get; set;}

		[Ordinal(0)] [RED("compression")] 		public CEnum<ETextureCompression> Compression { get; set;}

		[Ordinal(0)] [RED("sourceData")] 		public CHandle<CSourceTexture> SourceData { get; set;}

		[Ordinal(0)] [RED("textureGroup")] 		public CName TextureGroup { get; set;}

		[Ordinal(0)] [RED("pcDownscaleBias")] 		public CInt32 PcDownscaleBias { get; set;}

		[Ordinal(0)] [RED("xboneDownscaleBias")] 		public CInt32 XboneDownscaleBias { get; set;}

		[Ordinal(0)] [RED("ps4DownscaleBias")] 		public CInt32 Ps4DownscaleBias { get; set;}

		[Ordinal(0)] [RED("residentMipIndex")] 		public CUInt8 ResidentMipIndex { get; set;}

		[Ordinal(0)] [RED("textureCacheKey")] 		public CUInt32 TextureCacheKey { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBitmapTexture(cr2w, parent, name);

	}
}