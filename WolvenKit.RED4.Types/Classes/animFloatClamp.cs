using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFloatClamp : RedBaseClass
	{
		private CBool _useMin;
		private CFloat _min;
		private CBool _useMax;
		private CFloat _max;

		[Ordinal(0)] 
		[RED("useMin")] 
		public CBool UseMin
		{
			get => GetProperty(ref _useMin);
			set => SetProperty(ref _useMin, value);
		}

		[Ordinal(1)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(2)] 
		[RED("useMax")] 
		public CBool UseMax
		{
			get => GetProperty(ref _useMax);
			set => SetProperty(ref _useMax, value);
		}

		[Ordinal(3)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public animFloatClamp()
		{
			_min = -1.000000F;
			_max = 1.000000F;
		}
	}
}
