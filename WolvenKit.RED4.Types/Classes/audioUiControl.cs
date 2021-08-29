using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiControl : RedBaseClass
	{
		private CHandle<audioKeyUiSoundDictionary> _uiEventsByAction;

		[Ordinal(0)] 
		[RED("uiEventsByAction")] 
		public CHandle<audioKeyUiSoundDictionary> UiEventsByAction
		{
			get => GetProperty(ref _uiEventsByAction);
			set => SetProperty(ref _uiEventsByAction, value);
		}
	}
}
