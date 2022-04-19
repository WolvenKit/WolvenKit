using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioSceneDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioAudioSceneDictionaryItem>>();
			set => SetPropertyValue<CArray<audioAudioSceneDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAudioSceneDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioAudioSceneDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioAudioSceneDictionaryItem>>(value);
		}

		public audioAudioSceneDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
