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
			get => GetProperty(ref _uiEventsByAction);
			set => SetProperty(ref _uiEventsByAction, value);
		}

		public audioUiControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
