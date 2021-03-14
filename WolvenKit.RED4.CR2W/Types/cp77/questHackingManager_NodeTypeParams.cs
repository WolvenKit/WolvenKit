using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHackingManager_NodeTypeParams : CVariable
	{
		private NodeRef _objectRef;
		private CArray<CHandle<questHackingManager_ActionType>> _actions;

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
		[RED("actions")] 
		public CArray<CHandle<questHackingManager_ActionType>> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<CHandle<questHackingManager_ActionType>>) CR2WTypeManager.Create("array:handle:questHackingManager_ActionType", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		public questHackingManager_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
