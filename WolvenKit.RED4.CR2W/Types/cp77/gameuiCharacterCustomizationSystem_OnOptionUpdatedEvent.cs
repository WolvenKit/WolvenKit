using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent : redEvent
	{
		private wCHandle<gameuiCharacterCustomizationOption> _option;

		[Ordinal(0)] 
		[RED("option")] 
		public wCHandle<gameuiCharacterCustomizationOption> Option
		{
			get
			{
				if (_option == null)
				{
					_option = (wCHandle<gameuiCharacterCustomizationOption>) CR2WTypeManager.Create("whandle:gameuiCharacterCustomizationOption", "option", cr2w, this);
				}
				return _option;
			}
			set
			{
				if (_option == value)
				{
					return;
				}
				_option = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
