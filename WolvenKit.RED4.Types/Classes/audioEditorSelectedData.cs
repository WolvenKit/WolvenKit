using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEditorSelectedData : audioAudioMetadata
	{
		private CName _selectedWeaponConfigurationName;
		private CName _selectedFootstepsEventName;

		[Ordinal(1)] 
		[RED("selectedWeaponConfigurationName")] 
		public CName SelectedWeaponConfigurationName
		{
			get => GetProperty(ref _selectedWeaponConfigurationName);
			set => SetProperty(ref _selectedWeaponConfigurationName, value);
		}

		[Ordinal(2)] 
		[RED("selectedFootstepsEventName")] 
		public CName SelectedFootstepsEventName
		{
			get => GetProperty(ref _selectedFootstepsEventName);
			set => SetProperty(ref _selectedFootstepsEventName, value);
		}
	}
}
