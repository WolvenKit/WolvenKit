using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsSectorCacheEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entryOffset")] 
		public CUInt32 EntryOffset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public physicsSectorCacheEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
