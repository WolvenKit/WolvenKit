using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_ActiveVehicleDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("VehPlayerStateData")] 
		public gamebbScriptID_Variant VehPlayerStateData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerMounted")] 
		public gamebbScriptID_Bool IsPlayerMounted
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("IsTPPCameraOn")] 
		public gamebbScriptID_Bool IsTPPCameraOn
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("PositionInRace")] 
		public gamebbScriptID_Int32 PositionInRace
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("IsFPPRearviewCameraActivated")] 
		public gamebbScriptID_Bool IsFPPRearviewCameraActivated
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(5)] 
		[RED("RemoteControlledVehicleData")] 
		public gamebbScriptID_Variant RemoteControlledVehicleData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(6)] 
		[RED("MountedWeaponsTargets")] 
		public gamebbScriptID_Variant MountedWeaponsTargets
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(7)] 
		[RED("MountedMissileLauncherAmmo")] 
		public gamebbScriptID_Uint32 MountedMissileLauncherAmmo
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(8)] 
		[RED("MountedPowerWeaponAmmo")] 
		public gamebbScriptID_Uint32 MountedPowerWeaponAmmo
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		public UI_ActiveVehicleDataDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
