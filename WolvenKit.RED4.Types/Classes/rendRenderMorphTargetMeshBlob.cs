using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMorphTargetMeshBlob : IRenderResourceBlob
	{
		[Ordinal(0)] 
		[RED("header")] 
		public rendRenderMorphTargetMeshBlobHeader Header
		{
			get => GetPropertyValue<rendRenderMorphTargetMeshBlobHeader>();
			set => SetPropertyValue<rendRenderMorphTargetMeshBlobHeader>(value);
		}

		[Ordinal(1)] 
		[RED("diffsBuffer")] 
		public DataBuffer DiffsBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(2)] 
		[RED("mappingBuffer")] 
		public DataBuffer MappingBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(3)] 
		[RED("textureDiffsBuffer")] 
		public SerializationDeferredDataBuffer TextureDiffsBuffer
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(4)] 
		[RED("baseBlob")] 
		public CHandle<IRenderResourceBlob> BaseBlob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		public rendRenderMorphTargetMeshBlob()
		{
			Header = new() { TargetStartsInVertexDiffs = new(), TargetStartsInVertexDiffsMapping = new(), TargetPositionDiffScale = new(), TargetPositionDiffOffset = new(), NumVertexDiffsInEachChunk = new(), NumVertexDiffsMappingInEachChunk = new(), TargetTextureDiffsData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
