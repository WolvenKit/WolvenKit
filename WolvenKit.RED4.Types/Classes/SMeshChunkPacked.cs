using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SMeshChunkPacked : RedBaseClass
	{
		private CEnum<EMeshVertexType> _vertexType;
		private CArray<CName> _materialID;
		private CUInt8 _numBonesPerVertex;
		private CUInt32 _numVertices;
		private CUInt32 _numIndices;
		private CUInt32 _firstVertex;
		private CUInt32 _firstIndex;
		private CEnum<EMeshChunkRenderMask> _renderMask;
		private CEnum<EMeshChunkFlags> _chunkRenderMask;
		private CBool _useForShadowmesh;
		private CArray<SMeshStream> _streams;
		private CUInt64 _streamMask;
		private CUInt8 _lodMask;

		[Ordinal(0)] 
		[RED("vertexType")] 
		public CEnum<EMeshVertexType> VertexType
		{
			get => GetProperty(ref _vertexType);
			set => SetProperty(ref _vertexType, value);
		}

		[Ordinal(1)] 
		[RED("materialID")] 
		public CArray<CName> MaterialID
		{
			get => GetProperty(ref _materialID);
			set => SetProperty(ref _materialID, value);
		}

		[Ordinal(2)] 
		[RED("numBonesPerVertex")] 
		public CUInt8 NumBonesPerVertex
		{
			get => GetProperty(ref _numBonesPerVertex);
			set => SetProperty(ref _numBonesPerVertex, value);
		}

		[Ordinal(3)] 
		[RED("numVertices")] 
		public CUInt32 NumVertices
		{
			get => GetProperty(ref _numVertices);
			set => SetProperty(ref _numVertices, value);
		}

		[Ordinal(4)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetProperty(ref _numIndices);
			set => SetProperty(ref _numIndices, value);
		}

		[Ordinal(5)] 
		[RED("firstVertex")] 
		public CUInt32 FirstVertex
		{
			get => GetProperty(ref _firstVertex);
			set => SetProperty(ref _firstVertex, value);
		}

		[Ordinal(6)] 
		[RED("firstIndex")] 
		public CUInt32 FirstIndex
		{
			get => GetProperty(ref _firstIndex);
			set => SetProperty(ref _firstIndex, value);
		}

		[Ordinal(7)] 
		[RED("renderMask")] 
		public CEnum<EMeshChunkRenderMask> RenderMask
		{
			get => GetProperty(ref _renderMask);
			set => SetProperty(ref _renderMask, value);
		}

		[Ordinal(8)] 
		[RED("chunkRenderMask")] 
		public CEnum<EMeshChunkFlags> ChunkRenderMask
		{
			get => GetProperty(ref _chunkRenderMask);
			set => SetProperty(ref _chunkRenderMask, value);
		}

		[Ordinal(9)] 
		[RED("useForShadowmesh")] 
		public CBool UseForShadowmesh
		{
			get => GetProperty(ref _useForShadowmesh);
			set => SetProperty(ref _useForShadowmesh, value);
		}

		[Ordinal(10)] 
		[RED("streams")] 
		public CArray<SMeshStream> Streams
		{
			get => GetProperty(ref _streams);
			set => SetProperty(ref _streams, value);
		}

		[Ordinal(11)] 
		[RED("streamMask")] 
		public CUInt64 StreamMask
		{
			get => GetProperty(ref _streamMask);
			set => SetProperty(ref _streamMask, value);
		}

		[Ordinal(12)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetProperty(ref _lodMask);
			set => SetProperty(ref _lodMask, value);
		}

		public SMeshChunkPacked()
		{
			_renderMask = new() { Value = Enums.EMeshChunkRenderMask.MCR_Scene | Enums.EMeshChunkRenderMask.MCR_Cascade1 };
			_chunkRenderMask = new() { Value = Enums.EMeshChunkFlags.MCF_RenderInScene | Enums.EMeshChunkFlags.MCF_RenderInShadows };
		}
	}
}
