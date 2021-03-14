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

		[Ordinal(2)] 
		[RED("resultOnEvent")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnEvent
		{
			get
			{
				if (_resultOnEvent == null)
				{
					_resultOnEvent = (CEnum<AIbehaviorCompletionStatus>) CR2WTypeManager.Create("AIbehaviorCompletionStatus", "resultOnEvent", cr2w, this);
				}
				return _resultOnEvent;
			}
			set
			{
				if (_resultOnEvent == value)
				{
					return;
				}
				_resultOnEvent = value;
				PropertySet(this);
			}
		}

		public AIbehaviorCompleteOnEventNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
