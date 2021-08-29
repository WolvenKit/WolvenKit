using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCacheKey : RedBaseClass
	{
		private physicsGeometryKey _key;
		private CUInt32 _entryIndex;

		[Ordinal(0)] 
		[RED("key")] 
		public physicsGeometryKey Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("entryIndex")] 
		public CUInt32 EntryIndex
		{
			get => GetProperty(ref _entryIndex);
			set => SetProperty(ref _entryIndex, value);
		}
	}
}
