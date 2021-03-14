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
			get
			{
				if (_shouldSendEvent == null)
				{
					_shouldSendEvent = (CBool) CR2WTypeManager.Create("Bool", "shouldSendEvent", cr2w, this);
				}
				return _shouldSendEvent;
			}
			set
			{
				if (_shouldSendEvent == value)
				{
					return;
				}
				_shouldSendEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timePressed")] 
		public CFloat TimePressed
		{
			get
			{
				if (_timePressed == null)
				{
					_timePressed = (CFloat) CR2WTypeManager.Create("Float", "timePressed", cr2w, this);
				}
				return _timePressed;
			}
			set
			{
				if (_timePressed == value)
				{
					return;
				}
				_timePressed = value;
				PropertySet(this);
			}
		}

		public QuickSlotsReadyEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
