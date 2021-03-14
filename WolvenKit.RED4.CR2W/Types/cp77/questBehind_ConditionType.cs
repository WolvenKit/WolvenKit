using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBehind_ConditionType : questISensesConditionType
	{
		private gameEntityReference _targetRef;
		private CEnum<questBehindInteractionEventType> _eventType;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questBehindInteractionEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<questBehindInteractionEventType>) CR2WTypeManager.Create("questBehindInteractionEventType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		public questBehind_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
