using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiSetupScrollBarForAttributeEvent : redEvent
	{
		private CUInt32 _attribute;
		private CFloat _startValue;
		private CFloat _minValue;
		private CFloat _maxValue;
		private CFloat _step;

		[Ordinal(0)] 
		[RED("attribute")] 
		public CUInt32 Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		[Ordinal(1)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(2)] 
		[RED("minValue")] 
		public CFloat MinValue
		{
			get => GetProperty(ref _minValue);
			set => SetProperty(ref _minValue, value);
		}

		[Ordinal(3)] 
		[RED("maxValue")] 
		public CFloat MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(4)] 
		[RED("step")] 
		public CFloat Step
		{
			get => GetProperty(ref _step);
			set => SetProperty(ref _step, value);
		}
	}
}
