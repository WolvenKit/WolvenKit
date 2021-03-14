using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_ShootAt : questCombatNodeParams
	{
		private NodeRef _targetOverrideNode;
		private gameEntityReference _targetOverridePuppet;
		private CFloat _duration;
		private CBool _once;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("targetOverrideNode")] 
		public NodeRef TargetOverrideNode
		{
			get
			{
				if (_targetOverrideNode == null)
				{
					_targetOverrideNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetOverrideNode", cr2w, this);
				}
				return _targetOverrideNode;
			}
			set
			{
				if (_targetOverrideNode == value)
				{
					return;
				}
				_targetOverrideNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetOverridePuppet")] 
		public gameEntityReference TargetOverridePuppet
		{
			get
			{
				if (_targetOverridePuppet == null)
				{
					_targetOverridePuppet = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetOverridePuppet", cr2w, this);
				}
				return _targetOverridePuppet;
			}
			set
			{
				if (_targetOverridePuppet == value)
				{
					return;
				}
				_targetOverridePuppet = value;
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
		[RED("once")] 
		public CBool Once
		{
			get
			{
				if (_once == null)
				{
					_once = (CBool) CR2WTypeManager.Create("Bool", "once", cr2w, this);
				}
				return _once;
			}
			set
			{
				if (_once == value)
				{
					return;
				}
				_once = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public questCombatNodeParams_ShootAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
