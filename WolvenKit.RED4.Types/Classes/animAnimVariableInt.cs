using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimVariableInt : animAnimVariable
	{
		private CInt32 _value;
		private CInt32 _default;
		private CInt32 _min;
		private CInt32 _max;

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(3)] 
		[RED("default")] 
		public CInt32 Default
		{
			get => GetProperty(ref _default);
			set => SetProperty(ref _default, value);
		}

		[Ordinal(4)] 
		[RED("min")] 
		public CInt32 Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(5)] 
		[RED("max")] 
		public CInt32 Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		public animAnimVariableInt()
		{
			_min = -16;
			_max = 16;
		}
	}
}
