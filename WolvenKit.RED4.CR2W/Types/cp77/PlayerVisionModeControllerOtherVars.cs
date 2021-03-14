using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerOtherVars : CVariable
	{
		private CBool _enabledByToggle;
		private CBool _active;

		[Ordinal(0)] 
		[RED("enabledByToggle")] 
		public CBool EnabledByToggle
		{
			get
			{
				if (_enabledByToggle == null)
				{
					_enabledByToggle = (CBool) CR2WTypeManager.Create("Bool", "enabledByToggle", cr2w, this);
				}
				return _enabledByToggle;
			}
			set
			{
				if (_enabledByToggle == value)
				{
					return;
				}
				_enabledByToggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		public PlayerVisionModeControllerOtherVars(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
