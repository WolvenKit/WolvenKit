using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIThrowGrenadeCommand : AICombatRelatedCommand
	{
		private NodeRef _targetOverrideNodeRef;
		private gameEntityReference _targetOverridePuppetRef;
		private CFloat _duration;
		private CBool _once;

		[Ordinal(5)] 
		[RED("targetOverrideNodeRef")] 
		public NodeRef TargetOverrideNodeRef
		{
			get
			{
				if (_targetOverrideNodeRef == null)
				{
					_targetOverrideNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetOverrideNodeRef", cr2w, this);
				}
				return _targetOverrideNodeRef;
			}
			set
			{
				if (_targetOverrideNodeRef == value)
				{
					return;
				}
				_targetOverrideNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("targetOverridePuppetRef")] 
		public gameEntityReference TargetOverridePuppetRef
		{
			get
			{
				if (_targetOverridePuppetRef == null)
				{
					_targetOverridePuppetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetOverridePuppetRef", cr2w, this);
				}
				return _targetOverridePuppetRef;
			}
			set
			{
				if (_targetOverridePuppetRef == value)
				{
					return;
				}
				_targetOverridePuppetRef = value;
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

		[Ordinal(8)] 
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

		public AIThrowGrenadeCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
