using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMultilayerMaskBlob : IRenderResourceBlob
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
	}
}
