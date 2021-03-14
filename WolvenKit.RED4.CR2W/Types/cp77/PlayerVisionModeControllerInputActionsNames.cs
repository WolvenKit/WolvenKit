using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActionsNames : CVariable
	{
		private CName _buttonHold;
		private CName _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CName ButtonHold
		{
			get
			{
				if (_buttonHold == null)
				{
					_buttonHold = (CName) CR2WTypeManager.Create("CName", "buttonHold", cr2w, this);
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
		public CName ButtonToggle
		{
			get
			{
				if (_buttonToggle == null)
				{
					_buttonToggle = (CName) CR2WTypeManager.Create("CName", "buttonToggle", cr2w, this);
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

		public PlayerVisionModeControllerInputActionsNames(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
