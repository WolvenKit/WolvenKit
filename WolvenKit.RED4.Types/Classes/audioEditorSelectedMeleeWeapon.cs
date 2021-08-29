using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEditorSelectedMeleeWeapon : audioAudioMetadata
	{
		private CName _selectedWeaponConfigurationName;

		[Ordinal(1)] 
		[RED("selectedWeaponConfigurationName")] 
		public CName SelectedWeaponConfigurationName
		{
			get => GetProperty(ref _selectedWeaponConfigurationName);
			set => SetProperty(ref _selectedWeaponConfigurationName, value);
		}
	}
}
