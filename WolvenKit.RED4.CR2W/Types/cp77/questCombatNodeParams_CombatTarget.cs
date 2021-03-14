using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_CombatTarget : questCombatNodeParams
	{
		private NodeRef _targetNode;
		private gameEntityReference _targetPuppet;
		private CFloat _duration;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("targetNode")] 
		public NodeRef TargetNode
		{
			get
			{
				if (_targetNode == null)
				{
					_targetNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetNode", cr2w, this);
				}
				return _targetNode;
			}
			set
			{
				if (_targetNode == value)
				{
					return;
				}
				_targetNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetPuppet")] 
		public gameEntityReference TargetPuppet
		{
			get
			{
				if (_targetPuppet == null)
				{
					_targetPuppet = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetPuppet", cr2w, this);
				}
				return _targetPuppet;
			}
			set
			{
				if (_targetPuppet == value)
				{
					return;
				}
				_targetPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get
			{
				if (_immediately == null)
				{
					_immediately = (CBool) CR2WTypeManager.Create("Bool", "immediately", cr2w, this);
				}
				return _immediately;
			}
			set
			{
				if (_immediately == value)
				{
					return;
				}
				_immediately = value;
				PropertySet(this);
			}
		}

		public questCombatNodeParams_CombatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
