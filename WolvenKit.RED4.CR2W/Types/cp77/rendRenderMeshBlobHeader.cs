using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMeshBlobHeader : CVariable
	{
		private CUInt32 _version;
		private CUInt32 _dataProcessing;
		private CArray<Vector4> _bonePositions;
		private CArray<CFloat> _renderLODs;
		private CArray<CUInt8> _renderChunks;
		private CArray<rendChunk> _renderChunkInfos;
		private CArray<CUInt8> _speedTreeWind;
		private CArray<CUInt8> _customData;
		private CUInt32 _customDataElemStride;
		private CArray<CUInt8> _topologyData;
		private CUInt32 _topologyDataStride;
		private CArray<CUInt8> _topologyMetadata;
		private CUInt32 _topologyMetadataStride;
		private CArray<rendTopologyData> _topology;
		private Vector4 _quantizationScale;
		private Vector4 _quantizationOffset;
		private CUInt32 _vertexBufferSize;
		private CUInt32 _indexBufferSize;
		private CUInt32 _indexBufferOffset;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("dataProcessing")] 
		public CUInt32 DataProcessing
		{
			get => GetProperty(ref _dataProcessing);
			set => SetProperty(ref _dataProcessing, value);
		}

		[Ordinal(2)] 
		[RED("bonePositions")] 
		public CArray<Vector4> BonePositions
		{
			get => GetProperty(ref _bonePositions);
			set => SetProperty(ref _bonePositions, value);
		}

		[Ordinal(3)] 
		[RED("renderLODs")] 
		public CArray<CFloat> RenderLODs
		{
			get => GetProperty(ref _renderLODs);
			set => SetProperty(ref _renderLODs, value);
		}

		[Ordinal(4)] 
		[RED("renderChunks")] 
		public CArray<CUInt8> RenderChunks
		{
			get => GetProperty(ref _renderChunks);
			set => SetProperty(ref _renderChunks, value);
		}

		[Ordinal(5)] 
		[RED("renderChunkInfos")] 
		public CArray<rendChunk> RenderChunkInfos
		{
			get => GetProperty(ref _renderChunkInfos);
			set => SetProperty(ref _renderChunkInfos, value);
		}

		[Ordinal(6)] 
		[RED("speedTreeWind")] 
		public CArray<CUInt8> SpeedTreeWind
		{
			get => GetProperty(ref _speedTreeWind);
			set => SetProperty(ref _speedTreeWind, value);
		}

		[Ordinal(7)] 
		[RED("customData")] 
		public CArray<CUInt8> CustomData
		{
			get => GetProperty(ref _customData);
			set => SetProperty(ref _customData, value);
		}

		[Ordinal(8)] 
		[RED("customDataElemStride")] 
		public CUInt32 CustomDataElemStride
		{
			get => GetProperty(ref _customDataElemStride);
			set => SetProperty(ref _customDataElemStride, value);
		}

		[Ordinal(9)] 
		[RED("topologyData")] 
		public CArray<CUInt8> TopologyData
		{
			get => GetProperty(ref _topologyData);
			set => SetProperty(ref _topologyData, value);
		}

		[Ordinal(10)] 
		[RED("topologyDataStride")] 
		public CUInt32 TopologyDataStride
		{
			get => GetProperty(ref _topologyDataStride);
			set => SetProperty(ref _topologyDataStride, value);
		}

		[Ordinal(11)] 
		[RED("topologyMetadata")] 
		public CArray<CUInt8> TopologyMetadata
		{
			get => GetProperty(ref _topologyMetadata);
			set => SetProperty(ref _topologyMetadata, value);
		}

		[Ordinal(12)] 
		[RED("topologyMetadataStride")] 
		public CUInt32 TopologyMetadataStride
		{
			get => GetProperty(ref _topologyMetadataStride);
			set => SetProperty(ref _topologyMetadataStride, value);
		}

		[Ordinal(13)] 
		[RED("topology")] 
		public CArray<rendTopologyData> Topology
		{
			get => GetProperty(ref _topology);
			set => SetProperty(ref _topology, value);
		}

		[Ordinal(14)] 
		[RED("quantizationScale")] 
		public Vector4 QuantizationScale
		{
			get => GetProperty(ref _quantizationScale);
			set => SetProperty(ref _quantizationScale, value);
		}

		[Ordinal(15)] 
		[RED("quantizationOffset")] 
		public Vector4 QuantizationOffset
		{
			get => GetProperty(ref _quantizationOffset);
			set => SetProperty(ref _quantizationOffset, value);
		}

		[Ordinal(16)] 
		[RED("vertexBufferSize")] 
		public CUInt32 VertexBufferSize
		{
			get => GetProperty(ref _vertexBufferSize);
			set => SetProperty(ref _vertexBufferSize, value);
		}

		[Ordinal(17)] 
		[RED("indexBufferSize")] 
		public CUInt32 IndexBufferSize
		{
			get => GetProperty(ref _indexBufferSize);
			set => SetProperty(ref _indexBufferSize, value);
		}

		[Ordinal(18)] 
		[RED("indexBufferOffset")] 
		public CUInt32 IndexBufferOffset
		{
			get => GetProperty(ref _indexBufferOffset);
			set => SetProperty(ref _indexBufferOffset, value);
		}

		public rendRenderMeshBlobHeader(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
