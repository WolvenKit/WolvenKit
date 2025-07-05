using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderMeshBlobHeader : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("dataProcessing")] 
		public CUInt32 DataProcessing
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("bonePositions")] 
		public CArray<Vector4> BonePositions
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		[Ordinal(3)] 
		[RED("renderLODs")] 
		public CArray<CFloat> RenderLODs
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("renderChunks")] 
		public CArray<CUInt8> RenderChunks
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(5)] 
		[RED("renderChunkInfos")] 
		public CArray<rendChunk> RenderChunkInfos
		{
			get => GetPropertyValue<CArray<rendChunk>>();
			set => SetPropertyValue<CArray<rendChunk>>(value);
		}

		[Ordinal(6)] 
		[RED("speedTreeWind")] 
		public CArray<CUInt8> SpeedTreeWind
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(7)] 
		[RED("opacityMicromaps")] 
		public CArray<CUInt8> OpacityMicromaps
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(8)] 
		[RED("customData")] 
		public CArray<CUInt8> CustomData
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(9)] 
		[RED("customDataElemStride")] 
		public CUInt32 CustomDataElemStride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(10)] 
		[RED("topologyData")] 
		public CArray<CUInt8> TopologyData
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(11)] 
		[RED("topologyDataStride")] 
		public CUInt32 TopologyDataStride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("topologyMetadata")] 
		public CArray<CUInt8> TopologyMetadata
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		[Ordinal(13)] 
		[RED("topologyMetadataStride")] 
		public CUInt32 TopologyMetadataStride
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(14)] 
		[RED("topology")] 
		public CArray<rendTopologyData> Topology
		{
			get => GetPropertyValue<CArray<rendTopologyData>>();
			set => SetPropertyValue<CArray<rendTopologyData>>(value);
		}

		[Ordinal(15)] 
		[RED("quantizationScale")] 
		public Vector4 QuantizationScale
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(16)] 
		[RED("quantizationOffset")] 
		public Vector4 QuantizationOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(17)] 
		[RED("vertexBufferSize")] 
		public CUInt32 VertexBufferSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("indexBufferSize")] 
		public CUInt32 IndexBufferSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("indexBufferOffset")] 
		public CUInt32 IndexBufferOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public rendRenderMeshBlobHeader()
		{
			BonePositions = new();
			RenderLODs = new();
			RenderChunks = new();
			RenderChunkInfos = new();
			SpeedTreeWind = new();
			OpacityMicromaps = new();
			CustomData = new();
			TopologyData = new();
			TopologyMetadata = new();
			Topology = new();
			QuantizationScale = new Vector4();
			QuantizationOffset = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
