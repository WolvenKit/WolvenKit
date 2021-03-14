using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSwitchPair : CVariable
	{
		private wCHandle<gameuiCharacterCustomizationOption> _prevOption;
		private wCHandle<gameuiCharacterCustomizationOption> _currOption;

		[Ordinal(0)] 
		[RED("prevOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> PrevOption
		{
			get
			{
				if (_prevOption == null)
				{
					_prevOption = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "prevOption", cr2w, this);
				}
				return _prevOption;
			}
			set
			{
				if (_prevOption == value)
				{
					return;
				}
				_prevOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currOption")] 
		public wCHandle<gameuiCharacterCustomizationOption> CurrOption
		{
			get
			{
				if (_currOption == null)
				{
					_currOption = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "currOption", cr2w, this);
				}
				return _currOption;
			}
			set
			{
				if (_currOption == value)
				{
					return;
				}
				_currOption = value;
				PropertySet(this);
			}
		}

		public gameuiSwitchPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
