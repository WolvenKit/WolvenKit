using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _objectRef;
		private CName _animationName;
		private CHandle<questTransformAnimatorNode_ActionType> _action;

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
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

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<questTransformAnimatorNode_ActionType> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<questTransformAnimatorNode_ActionType>) CR2WTypeManager.Create("handle:questTransformAnimatorNode_ActionType", "action", cr2w, this);
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

		public questTransformAnimatorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
