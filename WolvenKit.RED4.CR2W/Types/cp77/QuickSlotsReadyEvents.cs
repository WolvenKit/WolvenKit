using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotsReadyEvents : QuickSlotsEvents
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

		public QuickSlotsReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
