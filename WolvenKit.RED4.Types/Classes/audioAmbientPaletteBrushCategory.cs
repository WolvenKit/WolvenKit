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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
