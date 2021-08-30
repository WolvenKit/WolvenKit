using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ContactShadowsConfig : RedBaseClass
	{
		private CFloat _range;
		private CFloat _rangeLimit;
		private CFloat _screenEdgeFadeRange;
		private CFloat _distanceFadeLimit;
		private CFloat _distanceFadeRange;

		[Ordinal(0)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(1)] 
		[RED("rangeLimit")] 
		public CFloat RangeLimit
		{
			get => GetProperty(ref _rangeLimit);
			set => SetProperty(ref _rangeLimit, value);
		}

		[Ordinal(2)] 
		[RED("screenEdgeFadeRange")] 
		public CFloat ScreenEdgeFadeRange
		{
			get => GetProperty(ref _screenEdgeFadeRange);
			set => SetProperty(ref _screenEdgeFadeRange, value);
		}

		[Ordinal(3)] 
		[RED("distanceFadeLimit")] 
		public CFloat DistanceFadeLimit
		{
			get => GetProperty(ref _distanceFadeLimit);
			set => SetProperty(ref _distanceFadeLimit, value);
		}

		[Ordinal(4)] 
		[RED("distanceFadeRange")] 
		public CFloat DistanceFadeRange
		{
			get => GetProperty(ref _distanceFadeRange);
			set => SetProperty(ref _distanceFadeRange, value);
		}

		public ContactShadowsConfig()
		{
			_range = 0.050000F;
			_rangeLimit = 0.075000F;
			_screenEdgeFadeRange = 0.150000F;
			_distanceFadeLimit = 3.000000F;
			_distanceFadeRange = 1.000000F;
		}
	}
}
