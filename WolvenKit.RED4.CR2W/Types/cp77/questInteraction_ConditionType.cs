using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInteraction_ConditionType : questIObjectConditionType
	{
		private NodeRef _objectRef;
		private CEnum<questObjectInteractionEventType> _eventType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questObjectInteractionEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<questObjectInteractionEventType>) CR2WTypeManager.Create("questObjectInteractionEventType", "eventType", cr2w, this);
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

		public questInteraction_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
