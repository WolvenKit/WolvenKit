using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommand : AIFollowerCommand
	{
		private gameEntityReference _targetRef;
		private CBool _approachBeforeTakedown;
		private CBool _doNotTeleportIfTargetIsVisible;
		private wCHandle<gameObject> _target;

		[Ordinal(5)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("approachBeforeTakedown")] 
		public CBool ApproachBeforeTakedown
		{
			get
			{
				if (_approachBeforeTakedown == null)
				{
					_approachBeforeTakedown = (CBool) CR2WTypeManager.Create("Bool", "approachBeforeTakedown", cr2w, this);
				}
				return _approachBeforeTakedown;
			}
			set
			{
				if (_approachBeforeTakedown == value)
				{
					return;
				}
				_approachBeforeTakedown = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("doNotTeleportIfTargetIsVisible")] 
		public CBool DoNotTeleportIfTargetIsVisible
		{
			get
			{
				if (_doNotTeleportIfTargetIsVisible == null)
				{
					_doNotTeleportIfTargetIsVisible = (CBool) CR2WTypeManager.Create("Bool", "doNotTeleportIfTargetIsVisible", cr2w, this);
				}
				return _doNotTeleportIfTargetIsVisible;
			}
			set
			{
				if (_doNotTeleportIfTargetIsVisible == value)
				{
					return;
				}
				_doNotTeleportIfTargetIsVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public AIFollowerTakedownCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
