using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTriggerCondition : questCondition
	{
		private CEnum<questTriggerConditionType> _type;
		private NodeRef _triggerAreaRef;
		private gameEntityReference _activatorRef;
		private CBool _isPlayerActivator;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questTriggerConditionType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<questTriggerConditionType>) CR2WTypeManager.Create("questTriggerConditionType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggerAreaRef")] 
		public NodeRef TriggerAreaRef
		{
			get
			{
				if (_triggerAreaRef == null)
				{
					_triggerAreaRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "triggerAreaRef", cr2w, this);
				}
				return _triggerAreaRef;
			}
			set
			{
				if (_triggerAreaRef == value)
				{
					return;
				}
				_triggerAreaRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activatorRef")] 
		public gameEntityReference ActivatorRef
		{
			get
			{
				if (_activatorRef == null)
				{
					_activatorRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "activatorRef", cr2w, this);
				}
				return _activatorRef;
			}
			set
			{
				if (_activatorRef == value)
				{
					return;
				}
				_activatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get
			{
				if (_isPlayerActivator == null)
				{
					_isPlayerActivator = (CBool) CR2WTypeManager.Create("Bool", "isPlayerActivator", cr2w, this);
				}
				return _isPlayerActivator;
			}
			set
			{
				if (_isPlayerActivator == value)
				{
					return;
				}
				_isPlayerActivator = value;
				PropertySet(this);
			}
		}

		public questTriggerCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
