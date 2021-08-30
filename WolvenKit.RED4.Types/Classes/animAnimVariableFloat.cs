using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableFloat : animAnimVariable
	{
		private CFloat _value;
		private CFloat _default;
		private CFloat _min;
		private CFloat _max;

		[Ordinal(2)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public CFloat Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}

		[Ordinal(4)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(5)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public animAnimVariableFloat()
		{
			_min = -16.000000F;
			_max = 16.000000F;
		}
	}
}
