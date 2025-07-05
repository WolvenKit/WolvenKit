using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMeleeWeaponVariations : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("playerWeaponConfigurationName")] 
		public CName PlayerWeaponConfigurationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("NPCWeaponConfigurationName")] 
		public CName NPCWeaponConfigurationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioMeleeWeaponVariations()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
