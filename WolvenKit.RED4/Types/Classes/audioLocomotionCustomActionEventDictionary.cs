using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionCustomActionEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioLocomotionCustomActionEventDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioLocomotionCustomActionEventDictionaryItem>>();
			set => SetPropertyValue<CArray<audioLocomotionCustomActionEventDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioLocomotionCustomActionEventDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioLocomotionCustomActionEventDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioLocomotionCustomActionEventDictionaryItem>>(value);
		}

		public audioLocomotionCustomActionEventDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
