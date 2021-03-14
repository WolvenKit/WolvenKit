using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitcherInfo : gameuiCharacterCustomizationInfo
	{
		private CArray<gameuiSwitcherOption> _options;
		private CBool _switchVisibility;

		[Ordinal(12)] 
		[RED("options")] 
		public CArray<gameuiSwitcherOption> Options
		{
			get
			{
				if (_options == null)
				{
					_options = (CArray<gameuiSwitcherOption>) CR2WTypeManager.Create("array:gameuiSwitcherOption", "options", cr2w, this);
				}
				return _options;
			}
			set
			{
				if (_options == value)
				{
					return;
				}
				_options = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("switchVisibility")] 
		public CBool SwitchVisibility
		{
			get
			{
				if (_switchVisibility == null)
				{
					_switchVisibility = (CBool) CR2WTypeManager.Create("Bool", "switchVisibility", cr2w, this);
				}
				return _switchVisibility;
			}
			set
			{
				if (_switchVisibility == value)
				{
					return;
				}
				_switchVisibility = value;
				PropertySet(this);
			}
		}

		public gameuiSwitcherInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
