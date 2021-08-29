using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeDuration_Debug_VDB : StrikeDuration_Debug
	{
		private CFloat _uPDATE_DELAY;
		private CFloat _dISPLAY_DURATION;
		private CFloat _timeToNextUpdate;

		[Ordinal(0)] 
		[RED("UPDATE_DELAY")] 
		public CFloat UPDATE_DELAY
		{
			get => GetProperty(ref _uPDATE_DELAY);
			set => SetProperty(ref _uPDATE_DELAY, value);
		}

		[Ordinal(1)] 
		[RED("DISPLAY_DURATION")] 
		public CFloat DISPLAY_DURATION
		{
			get => GetProperty(ref _dISPLAY_DURATION);
			set => SetProperty(ref _dISPLAY_DURATION, value);
		}

		[Ordinal(2)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetProperty(ref _timeToNextUpdate);
			set => SetProperty(ref _timeToNextUpdate, value);
		}
	}
}
