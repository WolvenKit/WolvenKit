using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendChunk : CVariable
	{
		private rendVertexBufferChunk _chunkVertices;
		private rendIndexBufferChunk _chunkIndices;
		private CUInt16 _numVertices;
		private CUInt32 _numIndices;
		private CArray<CName> _materialId;
		private CUInt8 _vertexFactory;
		private CUInt16 _baseRenderMask;
		private CUInt16 _mergedRenderMask;
		private CEnum<EMeshChunkFlags> _renderMask;
		private CUInt8 _lodMask;

		[Ordinal(0)] 
		[RED("chunkVertices")] 
		public rendVertexBufferChunk ChunkVertices
		{
			get => GetProperty(ref _chunkVertices);
			set => SetProperty(ref _chunkVertices, value);
		}

		[Ordinal(1)] 
		[RED("chunkIndices")] 
		public rendIndexBufferChunk ChunkIndices
		{
			get => GetProperty(ref _chunkIndices);
			set => SetProperty(ref _chunkIndices, value);
		}

		[Ordinal(2)] 
		[RED("numVertices")] 
		public CUInt16 NumVertices
		{
			get => GetProperty(ref _numVertices);
			set => SetProperty(ref _numVertices, value);
		}

		[Ordinal(3)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetProperty(ref _numIndices);
			set => SetProperty(ref _numIndices, value);
		}

		[Ordinal(4)] 
		[RED("materialId")] 
		public CArray<CName> MaterialId
		{
			get => GetProperty(ref _materialId);
			set => SetProperty(ref _materialId, value);
		}

		[Ordinal(5)] 
		[RED("vertexFactory")] 
		public CUInt8 VertexFactory
		{
			get => GetProperty(ref _vertexFactory);
			set => SetProperty(ref _vertexFactory, value);
		}

		[Ordinal(6)] 
		[RED("baseRenderMask")] 
		public CUInt16 BaseRenderMask
		{
			get => GetProperty(ref _baseRenderMask);
			set => SetProperty(ref _baseRenderMask, value);
		}

		[Ordinal(7)] 
		[RED("mergedRenderMask")] 
		public CUInt16 MergedRenderMask
		{
			get => GetProperty(ref _mergedRenderMask);
			set => SetProperty(ref _mergedRenderMask, value);
		}

		[Ordinal(8)] 
		[RED("renderMask")] 
		public CEnum<EMeshChunkFlags> RenderMask
		{
			get => GetProperty(ref _renderMask);
			set => SetProperty(ref _renderMask, value);
		}

		[Ordinal(9)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetProperty(ref _lodMask);
			set => SetProperty(ref _lodMask, value);
		}

		public rendChunk(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
