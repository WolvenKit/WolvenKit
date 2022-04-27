using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioUiGenericControlSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("uiControlMatrix")] 
		public CArray<audioUiGenericControlSettingsMapItem> UiControlMatrix
		{
			get => GetPropertyValue<CArray<audioUiGenericControlSettingsMapItem>>();
			set => SetPropertyValue<CArray<audioUiGenericControlSettingsMapItem>>(value);
		}

		public audioUiGenericControlSettingsMap()
		{
			UiControlMatrix = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
