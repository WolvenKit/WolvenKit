using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendIRenderTextureBlob : IRenderResourceBlob
	{
		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderTextureBlobHeader Header
		{
			get => GetPropertyValue<rendRenderTextureBlobHeader>();
			set => SetPropertyValue<rendRenderTextureBlobHeader>(value);
		}

		[Ordinal(1)] 
		[RED("textureData")] 
		public SerializationDeferredDataBuffer TextureData
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		public rendIRenderTextureBlob()
		{
			Header = new() { SizeInfo = new() { Depth = 1 }, TextureInfo = new(), MipMapInfo = new(), HistogramData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
