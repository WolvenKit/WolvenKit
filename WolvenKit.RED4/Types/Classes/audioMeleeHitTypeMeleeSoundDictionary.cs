using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeHitTypeMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioMeleeHitTypeMeleeSoundDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioMeleeHitTypeMeleeSoundDictionaryItem>>();
			set => SetPropertyValue<CArray<audioMeleeHitTypeMeleeSoundDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem>>(value);
		}

		public audioMeleeHitTypeMeleeSoundDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
