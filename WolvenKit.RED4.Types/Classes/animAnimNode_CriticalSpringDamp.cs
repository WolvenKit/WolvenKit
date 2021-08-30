using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CriticalSpringDamp : animAnimNode_FloatValue
	{
		private CFloat _smoothTime;
		private CBool _useRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("smoothTime")] 
		public CFloat SmoothTime
		{
			get => GetProperty(ref _smoothTime);
			set => SetProperty(ref _smoothTime, value);
		}

		[Ordinal(12)] 
		[RED("useRange")] 
		public CBool UseRange
		{
			get => GetProperty(ref _useRange);
			set => SetProperty(ref _useRange, value);
		}

		[Ordinal(13)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetProperty(ref _rangeMin);
			set => SetProperty(ref _rangeMin, value);
		}

		[Ordinal(14)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetProperty(ref _rangeMax);
			set => SetProperty(ref _rangeMax, value);
		}

		[Ordinal(15)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		public animAnimNode_CriticalSpringDamp()
		{
			_smoothTime = 1.000000F;
			_rangeMin = -180.000000F;
			_rangeMax = 180.000000F;
		}
	}
}
