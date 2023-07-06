using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class rendRenderMultilayerMaskBlob : IRenderResourceBlob
	{
		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMultilayerMaskBlobHeader Header
		{
			get => GetPropertyValue<rendRenderMultilayerMaskBlobHeader>();
			set => SetPropertyValue<rendRenderMultilayerMaskBlobHeader>(value);
		}

		[Ordinal(1)] 
		[RED("atlasData")] 
		public SerializationDeferredDataBuffer AtlasData
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public SerializationDeferredDataBuffer TilesData
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		public rendRenderMultilayerMaskBlob()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
