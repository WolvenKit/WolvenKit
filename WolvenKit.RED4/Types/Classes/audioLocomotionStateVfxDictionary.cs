using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionStateVfxDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioLocomotionStateVfxDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioLocomotionStateVfxDictionaryItem>>();
			set => SetPropertyValue<CArray<audioLocomotionStateVfxDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioLocomotionStateVfxDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioLocomotionStateVfxDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioLocomotionStateVfxDictionaryItem>>(value);
		}

		public audioLocomotionStateVfxDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
