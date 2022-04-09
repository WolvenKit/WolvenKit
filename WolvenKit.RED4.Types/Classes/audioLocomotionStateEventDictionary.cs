using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionStateEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioLocomotionStateEventDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioLocomotionStateEventDictionaryItem>>();
			set => SetPropertyValue<CArray<audioLocomotionStateEventDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioLocomotionStateEventDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateEventDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateEventDictionaryItem>>(value);
		}

		public audioLocomotionStateEventDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
