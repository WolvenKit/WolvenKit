using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAmbientPaletteBrushCategory : audioAudioMetadata
	{
		private CHandle<audioAmbientPaletteBrushDictionary> _brushes;

		[Ordinal(1)] 
		[RED("brushes")] 
		public CHandle<audioAmbientPaletteBrushDictionary> Brushes
		{
			get => GetProperty(ref _brushes);
			set => SetProperty(ref _brushes, value);
		}
	}
}
