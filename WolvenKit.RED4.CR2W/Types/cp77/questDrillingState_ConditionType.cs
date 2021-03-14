using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDrillingState_ConditionType : questIObjectConditionType
	{
		private NodeRef _objectRef;
		private CEnum<questDrillingState> _state;

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
		[RED("state")] 
		public CEnum<questDrillingState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<questDrillingState>) CR2WTypeManager.Create("questDrillingState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public questDrillingState_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
