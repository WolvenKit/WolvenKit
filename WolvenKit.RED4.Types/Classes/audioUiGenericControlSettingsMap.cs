using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiGenericControlSettingsMap : audioAudioMetadata
	{
		private CArray<audioUiGenericControlSettingsMapItem> _uiControlMatrix;

		[Ordinal(1)] 
		[RED("uiControlMatrix")] 
		public CArray<audioUiGenericControlSettingsMapItem> UiControlMatrix
		{
			get => GetProperty(ref _uiControlMatrix);
			set => SetProperty(ref _uiControlMatrix, value);
		}
	}
}
