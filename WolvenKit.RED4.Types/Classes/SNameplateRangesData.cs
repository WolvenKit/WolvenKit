using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SNameplateRangesData : RedBaseClass
	{
		private CFloat _c_DisplayRange;
		private CFloat _c_MaxDisplayRange;
		private CFloat _c_MaxDisplayRangeNotAggressive;
		private CFloat _c_DisplayRangeNotAggressive;

		[Ordinal(0)] 
		[RED("c_DisplayRange")] 
		public CFloat C_DisplayRange
		{
			get => GetProperty(ref _c_DisplayRange);
			set => SetProperty(ref _c_DisplayRange, value);
		}

		[Ordinal(1)] 
		[RED("c_MaxDisplayRange")] 
		public CFloat C_MaxDisplayRange
		{
			get => GetProperty(ref _c_MaxDisplayRange);
			set => SetProperty(ref _c_MaxDisplayRange, value);
		}

		[Ordinal(2)] 
		[RED("c_MaxDisplayRangeNotAggressive")] 
		public CFloat C_MaxDisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_MaxDisplayRangeNotAggressive);
			set => SetProperty(ref _c_MaxDisplayRangeNotAggressive, value);
		}

		[Ordinal(3)] 
		[RED("c_DisplayRangeNotAggressive")] 
		public CFloat C_DisplayRangeNotAggressive
		{
			get => GetProperty(ref _c_DisplayRangeNotAggressive);
			set => SetProperty(ref _c_DisplayRangeNotAggressive, value);
		}

		public SNameplateRangesData()
		{
			_c_DisplayRange = 35.000000F;
			_c_MaxDisplayRange = 50.000000F;
			_c_MaxDisplayRangeNotAggressive = 10.000000F;
			_c_DisplayRangeNotAggressive = 3.000000F;
		}
	}
}
