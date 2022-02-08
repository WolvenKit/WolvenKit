using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEditorSelectedData : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("selectedWeaponConfigurationName")] 
		public CName SelectedWeaponConfigurationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("selectedFootstepsEventName")] 
		public CName SelectedFootstepsEventName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
