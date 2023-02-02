using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAnimationOverrideDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAnimationOverrideDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioAnimationOverrideDictionaryItem>>();
			set => SetPropertyValue<CArray<audioAnimationOverrideDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAnimationOverrideDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioAnimationOverrideDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioAnimationOverrideDictionaryItem>>(value);
		}

		public audioAnimationOverrideDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
