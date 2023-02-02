using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SMeshChunkPacked : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("vertexType")] 
		public CEnum<EMeshVertexType> VertexType
		{
			get => GetPropertyValue<CEnum<EMeshVertexType>>();
			set => SetPropertyValue<CEnum<EMeshVertexType>>(value);
		}

		[Ordinal(1)] 
		[RED("materialID")] 
		public CArray<CName> MaterialID
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("numBonesPerVertex")] 
		public CUInt8 NumBonesPerVertex
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("numVertices")] 
		public CUInt32 NumVertices
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("numIndices")] 
		public CUInt32 NumIndices
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("firstVertex")] 
		public CUInt32 FirstVertex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("firstIndex")] 
		public CUInt32 FirstIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("renderMask")] 
		public CBitField<EMeshChunkRenderMask> RenderMask
		{
			get => GetPropertyValue<CBitField<EMeshChunkRenderMask>>();
			set => SetPropertyValue<CBitField<EMeshChunkRenderMask>>(value);
		}

		[Ordinal(8)] 
		[RED("chunkRenderMask")] 
		public CBitField<EMeshChunkFlags> ChunkRenderMask
		{
			get => GetPropertyValue<CBitField<EMeshChunkFlags>>();
			set => SetPropertyValue<CBitField<EMeshChunkFlags>>(value);
		}

		[Ordinal(9)] 
		[RED("useForShadowmesh")] 
		public CBool UseForShadowmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("streams")] 
		public CArray<SMeshStream> Streams
		{
			get => GetPropertyValue<CArray<SMeshStream>>();
			set => SetPropertyValue<CArray<SMeshStream>>(value);
		}

		[Ordinal(11)] 
		[RED("streamMask")] 
		public CUInt64 StreamMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(12)] 
		[RED("lodMask")] 
		public CUInt8 LodMask
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public SMeshChunkPacked()
		{
			MaterialID = new();
			RenderMask = Enums.EMeshChunkRenderMask.MCR_Scene | Enums.EMeshChunkRenderMask.MCR_Cascade1;
			ChunkRenderMask = Enums.EMeshChunkFlags.MCF_RenderInScene | Enums.EMeshChunkFlags.MCF_RenderInShadows;
			Streams = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
