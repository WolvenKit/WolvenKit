using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiSpecificControlSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("uiEventSettingsMatrix")] 
		public CArray<audioUiControlEventsSettingsMapItem> UiEventSettingsMatrix
		{
			get => GetPropertyValue<CArray<audioUiControlEventsSettingsMapItem>>();
			set => SetPropertyValue<CArray<audioUiControlEventsSettingsMapItem>>(value);
		}

		public audioUiSpecificControlSettingsMapItem()
		{
			UiEventSettingsMatrix = new();
		}
	}
}
