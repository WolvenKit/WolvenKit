using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickSlotsReadyEvents : QuickSlotsEvents
	{
		private CBool _shouldSendEvent;
		private CFloat _timePressed;

		[Ordinal(0)] 
		[RED("shouldSendEvent")] 
		public CBool ShouldSendEvent
		{
			get => GetProperty(ref _shouldSendEvent);
			set => SetProperty(ref _shouldSendEvent, value);
		}

		[Ordinal(1)] 
		[RED("timePressed")] 
		public CFloat TimePressed
		{
			get => GetProperty(ref _timePressed);
			set => SetProperty(ref _timePressed, value);
		}

		public QuickSlotsReadyEvents()
		{
			_shouldSendEvent = true;
		}
	}
}
