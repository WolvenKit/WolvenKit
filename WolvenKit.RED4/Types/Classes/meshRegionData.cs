using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshRegionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunkDataIntact")] 
		public CArray<meshChunkOffset> ChunkDataIntact
		{
			get => GetPropertyValue<CArray<meshChunkOffset>>();
			set => SetPropertyValue<CArray<meshChunkOffset>>(value);
		}

		[Ordinal(1)] 
		[RED("chunkDataFractured")] 
		public CArray<meshChunkOffset> ChunkDataFractured
		{
			get => GetPropertyValue<CArray<meshChunkOffset>>();
			set => SetPropertyValue<CArray<meshChunkOffset>>(value);
		}

		[Ordinal(2)] 
		[RED("chunkMaskIntact")] 
		public CUInt64 ChunkMaskIntact
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(3)] 
		[RED("chunkMaskFractured")] 
		public CUInt64 ChunkMaskFractured
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("isStaticRemains")] 
		public CBool IsStaticRemains
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public meshRegionData()
		{
			ChunkDataIntact = new();
			ChunkDataFractured = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
