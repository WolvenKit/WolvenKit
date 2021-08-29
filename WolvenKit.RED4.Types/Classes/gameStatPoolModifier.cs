using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatPoolModifier : RedBaseClass
	{
		private CBool _enabled;
		private CFloat _rangeBegin;
		private CFloat _rangeEnd;
		private CFloat _startDelay;
		private CFloat _valuePerSec;
		private CBool _delayOnChange;
		private CBool _usingPointValues;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		[Ordinal(1)] 
		[RED("rangeBegin")] 
		public CFloat RangeBegin
		{
			get => GetProperty(ref _rangeBegin);
			set => SetProperty(ref _rangeBegin, value);
		}

		[Ordinal(2)] 
		[RED("rangeEnd")] 
		public CFloat RangeEnd
		{
			get => GetProperty(ref _rangeEnd);
			set => SetProperty(ref _rangeEnd, value);
		}

		[Ordinal(3)] 
		[RED("startDelay")] 
		public CFloat StartDelay
		{
			get => GetProperty(ref _startDelay);
			set => SetProperty(ref _startDelay, value);
		}

		[Ordinal(4)] 
		[RED("valuePerSec")] 
		public CFloat ValuePerSec
		{
			get => GetProperty(ref _valuePerSec);
			set => SetProperty(ref _valuePerSec, value);
		}

		[Ordinal(5)] 
		[RED("delayOnChange")] 
		public CBool DelayOnChange
		{
			get => GetProperty(ref _delayOnChange);
			set => SetProperty(ref _delayOnChange, value);
		}

		[Ordinal(6)] 
		[RED("usingPointValues")] 
		public CBool UsingPointValues
		{
			get => GetProperty(ref _usingPointValues);
			set => SetProperty(ref _usingPointValues, value);
		}
	}
}
