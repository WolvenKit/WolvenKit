using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamDestructionChunkIndicesOffsets : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<meshChunkIndicesOffset> Offsets
		{
			get => GetPropertyValue<CArray<meshChunkIndicesOffset>>();
			set => SetPropertyValue<CArray<meshChunkIndicesOffset>>(value);
		}

		[Ordinal(1)] 
		[RED("chunkOffsets")] 
		public CArray<CUInt32> ChunkOffsets
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(2)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetPropertyValue<CArray<DataBuffer>>();
			set => SetPropertyValue<CArray<DataBuffer>>(value);
		}

		public meshMeshParamDestructionChunkIndicesOffsets()
		{
			Offsets = new();
			ChunkOffsets = new();
			Indices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
