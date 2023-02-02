using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnVoicesetComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("combatVoSettingsName")] 
		public CName CombatVoSettingsName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnVoicesetComponent()
		{
			Name = "VoicesetComponent";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
