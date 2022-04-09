using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioLocomotionCustomActionVfxDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioLocomotionCustomActionVfxDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioLocomotionCustomActionVfxDictionaryItem>>();
			set => SetPropertyValue<CArray<audioLocomotionCustomActionVfxDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioLocomotionCustomActionVfxDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioLocomotionCustomActionVfxDictionaryItem>>(value);
		}

		public audioLocomotionCustomActionVfxDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
