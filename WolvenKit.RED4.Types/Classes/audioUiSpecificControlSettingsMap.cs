using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioUiSpecificControlSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("specificControlSettingsMatrix")] 
		public CArray<audioUiSpecificControlSettingsMapItem> SpecificControlSettingsMatrix
		{
			get => GetPropertyValue<CArray<audioUiSpecificControlSettingsMapItem>>();
			set => SetPropertyValue<CArray<audioUiSpecificControlSettingsMapItem>>(value);
		}

		public audioUiSpecificControlSettingsMap()
		{
			SpecificControlSettingsMatrix = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
