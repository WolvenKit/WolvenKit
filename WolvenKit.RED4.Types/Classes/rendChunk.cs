using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendChunk : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunkVertices")] 
		public rendVertexBufferChunk ChunkVertices
		{
			get => GetPropertyValue<rendVertexBufferChunk>();
			set => SetPropertyValue<rendVertexBufferChunk>(value);
		}

		[Ordinal(1)] 
		[RED("chunkIndices")] 
		public rendIndexBufferChunk ChunkIndices
		{
			get => GetPropertyValue<rendIndexBufferChunk>();
			set => SetPropertyValue<rendIndexBufferChunk>(value);
		}

		[Ordinal(2)] 
		[RED("numVertices")] 
		public CUInt16 NumVertices
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(3)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("materialId")] 
		public CArray<CName> MaterialId
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("vertexFactory")] 
		public CUInt8 VertexFactory
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(6)] 
		[RED("baseRenderMask")] 
		public CUInt16 BaseRenderMask
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(7)] 
		[RED("mergedRenderMask")] 
		public CUInt16 MergedRenderMask
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(8)] 
		[RED("renderMask")] 
		public CBitField<EMeshChunkFlags> RenderMask
		{
			get => GetPropertyValue<CBitField<EMeshChunkFlags>>();
			set => SetPropertyValue<CBitField<EMeshChunkFlags>>(value);
		}

		[Ordinal(9)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public rendChunk()
		{
			ChunkVertices = new() { VertexLayout = new() { Elements = new(0), SlotStrides = new(0), Hash = 4294967295 }, ByteOffsets = new(0) };
			ChunkIndices = new() { Pe = Enums.GpuWrapApieIndexBufferChunkType.IBCT_Max };
			MaterialId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
