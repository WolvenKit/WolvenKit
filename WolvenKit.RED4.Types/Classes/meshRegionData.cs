using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshRegionData : RedBaseClass
	{
		private CArray<meshChunkOffset> _chunkDataIntact;
		private CArray<meshChunkOffset> _chunkDataFractured;
		private CUInt64 _chunkMaskIntact;
		private CUInt64 _chunkMaskFractured;
		private CBool _isStaticRemains;

		[Ordinal(0)] 
		[RED("chunkDataIntact")] 
		public CArray<meshChunkOffset> ChunkDataIntact
		{
			get => GetProperty(ref _chunkDataIntact);
			set => SetProperty(ref _chunkDataIntact, value);
		}

		[Ordinal(1)] 
		[RED("chunkDataFractured")] 
		public CArray<meshChunkOffset> ChunkDataFractured
		{
			get => GetProperty(ref _chunkDataFractured);
			set => SetProperty(ref _chunkDataFractured, value);
		}

		[Ordinal(2)] 
		[RED("chunkMaskIntact")] 
		public CUInt64 ChunkMaskIntact
		{
			get => GetProperty(ref _chunkMaskIntact);
			set => SetProperty(ref _chunkMaskIntact, value);
		}

		[Ordinal(3)] 
		[RED("chunkMaskFractured")] 
		public CUInt64 ChunkMaskFractured
		{
			get => GetProperty(ref _chunkMaskFractured);
			set => SetProperty(ref _chunkMaskFractured, value);
		}

		[Ordinal(4)] 
		[RED("isStaticRemains")] 
		public CBool IsStaticRemains
		{
			get => GetProperty(ref _isStaticRemains);
			set => SetProperty(ref _isStaticRemains, value);
		}
	}
}
