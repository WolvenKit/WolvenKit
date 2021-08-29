using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StealthStimThresholdEvent : redEvent
	{
		private CBool _reset;
		private CFloat _timeThreshold;

		[Ordinal(0)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetProperty(ref _reset);
			set => SetProperty(ref _reset, value);
		}

		[Ordinal(1)] 
		[RED("timeThreshold")] 
		public CFloat TimeThreshold
		{
			get => GetProperty(ref _timeThreshold);
			set => SetProperty(ref _timeThreshold, value);
		}
	}
}
