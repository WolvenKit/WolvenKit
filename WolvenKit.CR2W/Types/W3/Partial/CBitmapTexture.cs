using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBitmapTexture : ITexture
	{
		[RED("width")] 		public CUInt32 Width { get; set;}

		[RED("height")] 		public CUInt32 Height { get; set;}

		[RED("format")] 		public CEnum<ETextureRawFormat> Format { get; set;}

		[RED("compression")] 		public CEnum<ETextureCompression> Compression { get; set;}

		[RED("sourceData")] 		public CHandle<CSourceTexture> SourceData { get; set;}

		[RED("textureGroup")] 		public CName TextureGroup { get; set;}

		[RED("pcDownscaleBias")] 		public CInt32 PcDownscaleBias { get; set;}

		[RED("xboneDownscaleBias")] 		public CInt32 XboneDownscaleBias { get; set;}

		[RED("ps4DownscaleBias")] 		public CInt32 Ps4DownscaleBias { get; set;}

		[RED("residentMipIndex")] 		public CUInt8 ResidentMipIndex { get; set;}

		[RED("textureCacheKey")] 		public CUInt32 TextureCacheKey { get; set;}

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBitmapTexture(cr2w, parent, name);

	}
}