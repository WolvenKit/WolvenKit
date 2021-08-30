using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SNewsFeedData : RedBaseClass
	{
		private CFloat _interval;
		private CArray<SNewsFeedElementData> _elements;

		[Ordinal(0)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		[Ordinal(1)] 
		[RED("elements")] 
		public CArray<SNewsFeedElementData> Elements
		{
			get => GetProperty(ref _elements);
			set => SetProperty(ref _elements, value);
		}

		public SNewsFeedData()
		{
			_interval = 5.000000F;
		}
	}
}
