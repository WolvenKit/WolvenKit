using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameNetAIState : RedBaseClass
	{
		private CInt32 _value;
		private CInt32 _prevValue;
		private CFloat _time;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(1)] 
		[RED("prevValue")] 
		public CInt32 PrevValue
		{
			get => GetProperty(ref _prevValue);
			set => SetProperty(ref _prevValue, value);
		}

		[Ordinal(2)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}
	}
}
