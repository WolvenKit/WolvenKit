using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSmoothFloatClamp : RedBaseClass
	{
		private CFloat _min;
		private CFloat _max;
		private CLegacySingleChannelCurve<CFloat> _marginEaseOutCurve;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(2)] 
		[RED("marginEaseOutCurve")] 
		public CLegacySingleChannelCurve<CFloat> MarginEaseOutCurve
		{
			get => GetProperty(ref _marginEaseOutCurve);
			set => SetProperty(ref _marginEaseOutCurve, value);
		}

		public animSmoothFloatClamp()
		{
			_min = -1.000000F;
			_max = 1.000000F;
		}
	}
}
