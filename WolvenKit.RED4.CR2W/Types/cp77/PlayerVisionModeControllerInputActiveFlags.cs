using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActiveFlags : CVariable
	{
		private CBool _buttonHold;
		private CBool _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CBool ButtonHold
		{
			get
			{
				if (_buttonHold == null)
				{
					_buttonHold = (CBool) CR2WTypeManager.Create("Bool", "buttonHold", cr2w, this);
				}
				return _buttonHold;
			}
			set
			{
				if (_buttonHold == value)
				{
					return;
				}
				_buttonHold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CBool ButtonToggle
		{
			get
			{
				if (_buttonToggle == null)
				{
					_buttonToggle = (CBool) CR2WTypeManager.Create("Bool", "buttonToggle", cr2w, this);
				}
				return _buttonToggle;
			}
			set
			{
				if (_buttonToggle == value)
				{
					return;
				}
				_buttonToggle = value;
				PropertySet(this);
			}
		}

		public PlayerVisionModeControllerInputActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
