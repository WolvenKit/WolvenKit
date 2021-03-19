using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionEvent : AIAIEvent
	{
		private CName _eventAction;
		private CHandle<gameActionInternalEvent> _internalEvent;

		[Ordinal(2)] 
		[RED("eventAction")] 
		public CName EventAction
		{
			get => GetProperty(ref _eventAction);
			set => SetProperty(ref _eventAction, value);
		}

		[Ordinal(3)] 
		[RED("internalEvent")] 
		public CHandle<gameActionInternalEvent> InternalEvent
		{
			get => GetProperty(ref _internalEvent);
			set => SetProperty(ref _internalEvent, value);
		}

		public gameActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
