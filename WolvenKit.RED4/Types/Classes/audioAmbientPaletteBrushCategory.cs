using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAmbientPaletteBrushCategory : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("brushes")] 
		public CHandle<audioAmbientPaletteBrushDictionary> Brushes
		{
			get => GetPropertyValue<CHandle<audioAmbientPaletteBrushDictionary>>();
			set => SetPropertyValue<CHandle<audioAmbientPaletteBrushDictionary>>(value);
		}

		public audioAmbientPaletteBrushCategory()
		{
			Brushes = new audioAmbientPaletteBrushDictionary { EntryType = new audioAmbientPaletteBrushDictionaryItem() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
