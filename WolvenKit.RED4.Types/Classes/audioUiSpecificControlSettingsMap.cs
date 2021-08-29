using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiSpecificControlSettingsMap : audioAudioMetadata
	{
		private CArray<audioUiSpecificControlSettingsMapItem> _specificControlSettingsMatrix;

		[Ordinal(1)] 
		[RED("specificControlSettingsMatrix")] 
		public CArray<audioUiSpecificControlSettingsMapItem> SpecificControlSettingsMatrix
		{
			get => GetProperty(ref _specificControlSettingsMatrix);
			set => SetProperty(ref _specificControlSettingsMatrix, value);
		}
	}
}
