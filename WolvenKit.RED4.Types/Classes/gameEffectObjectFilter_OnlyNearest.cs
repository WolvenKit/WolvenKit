using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_OnlyNearest : gameEffectObjectGroupFilter
	{
		private CUInt32 _count;

		[Ordinal(0)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		public gameEffectObjectFilter_OnlyNearest()
		{
			_count = 1;
		}
	}
}
