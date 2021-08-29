using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamDestructionChunkIndicesOffsets : meshMeshParameter
	{
		private CArray<meshChunkIndicesOffset> _offsets;
		private CArray<CUInt32> _chunkOffsets;
		private CArray<DataBuffer> _indices;

		[Ordinal(0)] 
		[RED("offsets")] 
		public CArray<meshChunkIndicesOffset> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(1)] 
		[RED("chunkOffsets")] 
		public CArray<CUInt32> ChunkOffsets
		{
			get => GetProperty(ref _chunkOffsets);
			set => SetProperty(ref _chunkOffsets, value);
		}

		[Ordinal(2)] 
		[RED("indices")] 
		public CArray<DataBuffer> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}
	}
}
