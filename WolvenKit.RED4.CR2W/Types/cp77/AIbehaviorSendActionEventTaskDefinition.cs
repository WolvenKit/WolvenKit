using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendActionEventTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<gameActionEvent> _event;

		[Ordinal(1)] 
		[RED("event")] 
		public CHandle<gameActionEvent> Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		public AIbehaviorSendActionEventTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
