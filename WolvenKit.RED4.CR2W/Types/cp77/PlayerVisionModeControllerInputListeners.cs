using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputListeners : CVariable
	{
		private CUInt32 _buttonHold;
		private CUInt32 _buttonToggle;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CUInt32 ButtonHold
		{
			get
			{
				if (_buttonHold == null)
				{
					_buttonHold = (CUInt32) CR2WTypeManager.Create("Uint32", "buttonHold", cr2w, this);
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
		public CUInt32 ButtonToggle
		{
			get
			{
				if (_buttonToggle == null)
				{
					_buttonToggle = (CUInt32) CR2WTypeManager.Create("Uint32", "buttonToggle", cr2w, this);
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

		public PlayerVisionModeControllerInputListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
