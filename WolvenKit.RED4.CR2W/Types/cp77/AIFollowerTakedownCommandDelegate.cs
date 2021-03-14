using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFollowerTakedownCommandDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CHandle<AIArgumentMapping> _inCommand;
		private CBool _approachBeforeTakedown;
		private CBool _doNotTeleportIfTargetIsVisible;

		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get
			{
				if (_inCommand == null)
				{
					_inCommand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "inCommand", cr2w, this);
				}
				return _inCommand;
			}
			set
			{
				if (_inCommand == value)
				{
					return;
				}
				_inCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public AIFollowerTakedownCommandDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
