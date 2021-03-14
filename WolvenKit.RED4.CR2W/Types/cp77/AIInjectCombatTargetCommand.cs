using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInjectCombatTargetCommand : AICombatRelatedCommand
	{
		private NodeRef _targetNodeRef;
		private gameEntityReference _targetPuppetRef;
		private CFloat _duration;

		[Ordinal(5)] 
		[RED("targetNodeRef")] 
		public NodeRef TargetNodeRef
		{
			get
			{
				if (_targetNodeRef == null)
				{
					_targetNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetNodeRef", cr2w, this);
				}
				return _targetNodeRef;
			}
			set
			{
				if (_targetNodeRef == value)
				{
					return;
				}
				_targetNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetPuppetRef")] 
		public gameEntityReference TargetPuppetRef
		{
			get
			{
				if (_targetPuppetRef == null)
				{
					_targetPuppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetPuppetRef", cr2w, this);
				}
				return _targetPuppetRef;
			}
			set
			{
				if (_targetPuppetRef == value)
				{
					return;
				}
				_targetPuppetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public AIInjectCombatTargetCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
