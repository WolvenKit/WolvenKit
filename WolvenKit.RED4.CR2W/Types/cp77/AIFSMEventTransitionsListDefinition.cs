using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFSMEventTransitionsListDefinition : CVariable
	{
		private CName _eventName;
		private AIFSMTransitionListDefinition _transitions;

		[Ordinal(0)] 
		[RED("eventName")] 
		public CName EventName
		{
			get => GetProperty(ref _eventName);
			set => SetProperty(ref _eventName, value);
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public AIFSMTransitionListDefinition Transitions
		{
			get => GetProperty(ref _transitions);
			set => SetProperty(ref _transitions, value);
		}

		public AIFSMEventTransitionsListDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
