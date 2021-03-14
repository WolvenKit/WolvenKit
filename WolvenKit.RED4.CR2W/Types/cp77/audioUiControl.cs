using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiControl : CVariable
	{
		private CHandle<audioKeyUiSoundDictionary> _uiEventsByAction;

		[Ordinal(0)] 
		[RED("uiEventsByAction")] 
		public CHandle<audioKeyUiSoundDictionary> UiEventsByAction
		{
			get
			{
				if (_uiEventsByAction == null)
				{
					_uiEventsByAction = (CHandle<audioKeyUiSoundDictionary>) CR2WTypeManager.Create("handle:audioKeyUiSoundDictionary", "uiEventsByAction", cr2w, this);
				}
				return _uiEventsByAction;
			}
			set
			{
				if (_uiEventsByAction == value)
				{
					return;
				}
				_uiEventsByAction = value;
				PropertySet(this);
			}
		}

		public audioUiControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
