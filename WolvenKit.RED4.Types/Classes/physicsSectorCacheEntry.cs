using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSectorCacheEntry : RedBaseClass
	{
		private CUInt32 _entryOffset;
		private CUInt32 _entrySize;

		[Ordinal(0)] 
		[RED("entryOffset")] 
		public CUInt32 EntryOffset
		{
			get => GetProperty(ref _entryOffset);
			set => SetProperty(ref _entryOffset, value);
		}

		[Ordinal(1)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get => GetProperty(ref _entrySize);
			set => SetProperty(ref _entrySize, value);
		}
	}
}
