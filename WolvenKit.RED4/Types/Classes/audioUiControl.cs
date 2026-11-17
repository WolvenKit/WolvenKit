using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioUiControl : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("uiEventsByAction")] 
		public CHandle<audioKeyUiSoundDictionary> UiEventsByAction
		{
			get => GetPropertyValue<CHandle<audioKeyUiSoundDictionary>>();
			set => SetPropertyValue<CHandle<audioKeyUiSoundDictionary>>(value);
		}

		public audioUiControl()
		{
			UiEventsByAction = new audioKeyUiSoundDictionary { EntryType = new audioKeyUiSoundPairDictionaryItem() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
