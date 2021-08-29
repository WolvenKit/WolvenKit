using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshChunkOffset : RedBaseClass
	{
		private CUInt32 _chunkIndex;
		private CUInt16 _start;
		private CUInt16 _count;

		[Ordinal(0)] 
		[RED("chunkIndex")] 
		public CUInt32 ChunkIndex
		{
			get => GetProperty(ref _chunkIndex);
			set => SetProperty(ref _chunkIndex, value);
		}

		[Ordinal(1)] 
		[RED("start")] 
		public CUInt16 Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(2)] 
		[RED("count")] 
		public CUInt16 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}
	}
}
