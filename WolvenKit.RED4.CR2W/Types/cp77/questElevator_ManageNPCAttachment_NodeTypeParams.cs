using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questElevator_ManageNPCAttachment_NodeTypeParams : CVariable
	{
		private NodeRef _elevatorRef;
		private gameEntityReference _npcRef;
		private CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> _action;

		[Ordinal(0)] 
		[RED("elevatorRef")] 
		public NodeRef ElevatorRef
		{
			get
			{
				if (_elevatorRef == null)
				{
					_elevatorRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "elevatorRef", cr2w, this);
				}
				return _elevatorRef;
			}
			set
			{
				if (_elevatorRef == value)
				{
					return;
				}
				_elevatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("npcRef")] 
		public gameEntityReference NpcRef
		{
			get
			{
				if (_npcRef == null)
				{
					_npcRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "npcRef", cr2w, this);
				}
				return _npcRef;
			}
			set
			{
				if (_npcRef == value)
				{
					return;
				}
				_npcRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction>) CR2WTypeManager.Create("questElevator_ManageNPCAttachment_NodeTypeParamsAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		public questElevator_ManageNPCAttachment_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
