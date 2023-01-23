using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshChunkOffset : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("chunkIndex")] 
		public CUInt32 ChunkIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("start")] 
		public CUInt16 Start
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt16 Count
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public meshChunkOffset()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
