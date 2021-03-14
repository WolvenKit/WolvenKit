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
			get
			{
				if (_eventName == null)
				{
					_eventName = (CName) CR2WTypeManager.Create("CName", "eventName", cr2w, this);
				}
				return _eventName;
			}
			set
			{
				if (_eventName == value)
				{
					return;
				}
				_eventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("transitions")] 
		public AIFSMTransitionListDefinition Transitions
		{
			get
			{
				if (_transitions == null)
				{
					_transitions = (AIFSMTransitionListDefinition) CR2WTypeManager.Create("AIFSMTransitionListDefinition", "transitions", cr2w, this);
				}
				return _transitions;
			}
			set
			{
				if (_transitions == value)
				{
					return;
				}
				_transitions = value;
				PropertySet(this);
			}
		}

		public AIFSMEventTransitionsListDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
