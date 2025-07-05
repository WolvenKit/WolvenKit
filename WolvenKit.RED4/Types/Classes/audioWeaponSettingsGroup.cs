using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponSettingsGroup : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("playerSettings")] 
		public CName PlayerSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("playerSilenced")] 
		public CName PlayerSilenced
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("npcSettings")] 
		public CName NpcSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("npcSilenced")] 
		public CName NpcSilenced
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioWeaponSettingsGroup()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
