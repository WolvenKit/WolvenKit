using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendIRenderTextureBlob : IRenderResourceBlob
	{
		private rendRenderTextureBlobHeader _header;
		private SerializationDeferredDataBuffer _textureData;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderTextureBlobHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("textureData")] 
		public SerializationDeferredDataBuffer TextureData
		{
			get => GetProperty(ref _textureData);
			set => SetProperty(ref _textureData, value);
		}
	}
}
