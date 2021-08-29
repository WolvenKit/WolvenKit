using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiSpecificControlSettingsMapItem : audioAudioMetadata
	{
		private CArray<audioUiControlEventsSettingsMapItem> _uiEventSettingsMatrix;

		[Ordinal(1)] 
		[RED("uiEventSettingsMatrix")] 
		public CArray<audioUiControlEventsSettingsMapItem> UiEventSettingsMatrix
		{
			get => GetProperty(ref _uiEventSettingsMatrix);
			set => SetProperty(ref _uiEventSettingsMatrix, value);
		}
	}
}
