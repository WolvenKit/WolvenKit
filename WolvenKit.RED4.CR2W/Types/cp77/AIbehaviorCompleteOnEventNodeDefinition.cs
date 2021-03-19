using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompleteOnEventNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		private CName _eventName;
		private CEnum<AIbehaviorCompletionStatus> _resultOnEvent;

		[Ordinal(1)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(2)] 
		[RED("resultOnEvent")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnEvent
		{
			get => GetProperty(ref _resultOnEvent);
			set => SetProperty(ref _resultOnEvent, value);
		}

		public AIbehaviorCompleteOnEventNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
