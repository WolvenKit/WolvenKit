using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animInertializationFloatClamp : RedBaseClass
	{
		private CBool _isActive;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public animInertializationFloatClamp()
		{
			_min = -1.000000F;
			_max = 1.000000F;
		}
	}
}
