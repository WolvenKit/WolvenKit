using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEditorSelectedMeleeWeapon : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("selectedWeaponConfigurationName")] 
		public CName SelectedWeaponConfigurationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioEditorSelectedMeleeWeapon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
