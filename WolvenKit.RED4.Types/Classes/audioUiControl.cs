using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiControl : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("uiEventsByAction")] 
		public CHandle<audioKeyUiSoundDictionary> UiEventsByAction
		{
			get => GetPropertyValue<CHandle<audioKeyUiSoundDictionary>>();
			set => SetPropertyValue<CHandle<audioKeyUiSoundDictionary>>(value);
		}
	}
}
