using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplaySettingsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("DisableAutomaticSwitchToVehicleTPP")] 
		public gamebbScriptID_Bool DisableAutomaticSwitchToVehicleTPP
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("EnableVehicleToggleSummonMode")] 
		public gamebbScriptID_Bool EnableVehicleToggleSummonMode
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public GameplaySettingsDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
