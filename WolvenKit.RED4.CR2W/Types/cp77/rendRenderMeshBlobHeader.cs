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
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("dataProcessing")] 
		public CUInt32 DataProcessing
		{
			get
			{
				if (_dataProcessing == null)
				{
					_dataProcessing = (CUInt32) CR2WTypeManager.Create("Uint32", "dataProcessing", cr2w, this);
				}
				return _dataProcessing;
			}
			set
			{
				if (_dataProcessing == value)
				{
					return;
				}
				_dataProcessing = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bonePositions")] 
		public CArray<Vector4> BonePositions
		{
			get
			{
				if (_bonePositions == null)
				{
					_bonePositions = (CArray<Vector4>) CR2WTypeManager.Create("array:Vector4", "bonePositions", cr2w, this);
				}
				return _bonePositions;
			}
			set
			{
				if (_bonePositions == value)
				{
					return;
				}
				_bonePositions = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("renderLODs")] 
		public CArray<CFloat> RenderLODs
		{
			get
			{
				if (_renderLODs == null)
				{
					_renderLODs = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "renderLODs", cr2w, this);
				}
				return _renderLODs;
			}
			set
			{
				if (_renderLODs == value)
				{
					return;
				}
				_renderLODs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("renderChunks")] 
		public CArray<CUInt8> RenderChunks
		{
			get
			{
				if (_renderChunks == null)
				{
					_renderChunks = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "renderChunks", cr2w, this);
				}
				return _renderChunks;
			}
			set
			{
				if (_renderChunks == value)
				{
					return;
				}
				_renderChunks = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("renderChunkInfos")] 
		public CArray<rendChunk> RenderChunkInfos
		{
			get
			{
				if (_renderChunkInfos == null)
				{
					_renderChunkInfos = (CArray<rendChunk>) CR2WTypeManager.Create("array:rendChunk", "renderChunkInfos", cr2w, this);
				}
				return _renderChunkInfos;
			}
			set
			{
				if (_renderChunkInfos == value)
				{
					return;
				}
				_renderChunkInfos = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("speedTreeWind")] 
		public CArray<CUInt8> SpeedTreeWind
		{
			get
			{
				if (_speedTreeWind == null)
				{
					_speedTreeWind = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "speedTreeWind", cr2w, this);
				}
				return _speedTreeWind;
			}
			set
			{
				if (_speedTreeWind == value)
				{
					return;
				}
				_speedTreeWind = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("customData")] 
		public CArray<CUInt8> CustomData
		{
			get
			{
				if (_customData == null)
				{
					_customData = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "customData", cr2w, this);
				}
				return _customData;
			}
			set
			{
				if (_customData == value)
				{
					return;
				}
				_customData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("customDataElemStride")] 
		public CUInt32 CustomDataElemStride
		{
			get
			{
				if (_customDataElemStride == null)
				{
					_customDataElemStride = (CUInt32) CR2WTypeManager.Create("Uint32", "customDataElemStride", cr2w, this);
				}
				return _customDataElemStride;
			}
			set
			{
				if (_customDataElemStride == value)
				{
					return;
				}
				_customDataElemStride = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("topologyData")] 
		public CArray<CUInt8> TopologyData
		{
			get
			{
				if (_topologyData == null)
				{
					_topologyData = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "topologyData", cr2w, this);
				}
				return _topologyData;
			}
			set
			{
				if (_topologyData == value)
				{
					return;
				}
				_topologyData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("topologyDataStride")] 
		public CUInt32 TopologyDataStride
		{
			get
			{
				if (_topologyDataStride == null)
				{
					_topologyDataStride = (CUInt32) CR2WTypeManager.Create("Uint32", "topologyDataStride", cr2w, this);
				}
				return _topologyDataStride;
			}
			set
			{
				if (_topologyDataStride == value)
				{
					return;
				}
				_topologyDataStride = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("topologyMetadata")] 
		public CArray<CUInt8> TopologyMetadata
		{
			get
			{
				if (_topologyMetadata == null)
				{
					_topologyMetadata = (CArray<CUInt8>) CR2WTypeManager.Create("array:Uint8", "topologyMetadata", cr2w, this);
				}
				return _topologyMetadata;
			}
			set
			{
				if (_topologyMetadata == value)
				{
					return;
				}
				_topologyMetadata = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("topologyMetadataStride")] 
		public CUInt32 TopologyMetadataStride
		{
			get
			{
				if (_topologyMetadataStride == null)
				{
					_topologyMetadataStride = (CUInt32) CR2WTypeManager.Create("Uint32", "topologyMetadataStride", cr2w, this);
				}
				return _topologyMetadataStride;
			}
			set
			{
				if (_topologyMetadataStride == value)
				{
					return;
				}
				_topologyMetadataStride = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("topology")] 
		public CArray<rendTopologyData> Topology
		{
			get
			{
				if (_topology == null)
				{
					_topology = (CArray<rendTopologyData>) CR2WTypeManager.Create("array:rendTopologyData", "topology", cr2w, this);
				}
				return _topology;
			}
			set
			{
				if (_topology == value)
				{
					return;
				}
				_topology = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("quantizationScale")] 
		public Vector4 QuantizationScale
		{
			get
			{
				if (_quantizationScale == null)
				{
					_quantizationScale = (Vector4) CR2WTypeManager.Create("Vector4", "quantizationScale", cr2w, this);
				}
				return _quantizationScale;
			}
			set
			{
				if (_quantizationScale == value)
				{
					return;
				}
				_quantizationScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("quantizationOffset")] 
		public Vector4 QuantizationOffset
		{
			get
			{
				if (_quantizationOffset == null)
				{
					_quantizationOffset = (Vector4) CR2WTypeManager.Create("Vector4", "quantizationOffset", cr2w, this);
				}
				return _quantizationOffset;
			}
			set
			{
				if (_quantizationOffset == value)
				{
					return;
				}
				_quantizationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("vertexBufferSize")] 
		public CUInt32 VertexBufferSize
		{
			get
			{
				if (_vertexBufferSize == null)
				{
					_vertexBufferSize = (CUInt32) CR2WTypeManager.Create("Uint32", "vertexBufferSize", cr2w, this);
				}
				return _vertexBufferSize;
			}
			set
			{
				if (_vertexBufferSize == value)
				{
					return;
				}
				_vertexBufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("indexBufferSize")] 
		public CUInt32 IndexBufferSize
		{
			get
			{
				if (_indexBufferSize == null)
				{
					_indexBufferSize = (CUInt32) CR2WTypeManager.Create("Uint32", "indexBufferSize", cr2w, this);
				}
				return _indexBufferSize;
			}
			set
			{
				if (_indexBufferSize == value)
				{
					return;
				}
				_indexBufferSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("indexBufferOffset")] 
		public CUInt32 IndexBufferOffset
		{
			get
			{
				if (_indexBufferOffset == null)
				{
					_indexBufferOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "indexBufferOffset", cr2w, this);
				}
				return _indexBufferOffset;
			}
			set
			{
				if (_indexBufferOffset == value)
				{
					return;
				}
				_indexBufferOffset = value;
				PropertySet(this);
			}
		}

		public rendRenderMeshBlobHeader(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
