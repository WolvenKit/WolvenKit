using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderMultilayerMaskBlob : IRenderResourceBlob
	{
		private rendRenderMultilayerMaskBlobHeader _header;
		private SerializationDeferredDataBuffer _atlasData;
		private SerializationDeferredDataBuffer _tilesData;

		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMultilayerMaskBlobHeader Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("atlasData")] 
		public SerializationDeferredDataBuffer AtlasData
		{
			get => GetProperty(ref _atlasData);
			set => SetProperty(ref _atlasData, value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public SerializationDeferredDataBuffer TilesData
		{
			get => GetProperty(ref _tilesData);
			set => SetProperty(ref _tilesData, value);
		}
	}
}
