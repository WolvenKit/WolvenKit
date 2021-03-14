using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
	{
		private NodeRef _triggerNodeRef;
		private CBool _activate;
		private CBool _dismount;

		[Ordinal(0)] 
		[RED("triggerNodeRef")] 
		public NodeRef TriggerNodeRef
		{
			get
			{
				if (_triggerNodeRef == null)
				{
					_triggerNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "triggerNodeRef", cr2w, this);
				}
				return _triggerNodeRef;
			}
			set
			{
				if (_triggerNodeRef == value)
				{
					return;
				}
				_triggerNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activate")] 
		public CBool Activate
		{
			get
			{
				if (_activate == null)
				{
					_activate = (CBool) CR2WTypeManager.Create("Bool", "activate", cr2w, this);
				}
				return _activate;
			}
			set
			{
				if (_activate == value)
				{
					return;
				}
				_activate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get
			{
				if (_dismount == null)
				{
					_dismount = (CBool) CR2WTypeManager.Create("Bool", "dismount", cr2w, this);
				}
				return _dismount;
			}
			set
			{
				if (_dismount == value)
				{
					return;
				}
				_dismount = value;
				PropertySet(this);
			}
		}

		public questForbiddenTrigger_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
