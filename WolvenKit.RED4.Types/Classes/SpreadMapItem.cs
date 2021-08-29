using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpreadMapItem : RedBaseClass
	{
		private CWeakHandle<gamedataInteractionBase_Record> _key;
		private CInt32 _count;
		private CFloat _range;

		[Ordinal(0)] 
		[RED("key")] 
		public CWeakHandle<gamedataInteractionBase_Record> Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(2)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}
	}
}
