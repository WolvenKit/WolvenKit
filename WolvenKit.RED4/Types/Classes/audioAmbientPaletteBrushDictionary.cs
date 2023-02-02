using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientPaletteBrushDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAmbientPaletteBrushDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioAmbientPaletteBrushDictionaryItem>>();
			set => SetPropertyValue<CArray<audioAmbientPaletteBrushDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAmbientPaletteBrushDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioAmbientPaletteBrushDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioAmbientPaletteBrushDictionaryItem>>(value);
		}

		public audioAmbientPaletteBrushDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
