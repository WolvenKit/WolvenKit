using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ScannerModulesDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _scannerName;
		private gamebbScriptID_Variant _scannerHealth;
		private gamebbScriptID_Variant _scannerLevel;
		private gamebbScriptID_Variant _scannerAuthorization;
		private gamebbScriptID_Variant _scannerRarity;
		private gamebbScriptID_Variant _scannerArchetype;
		private gamebbScriptID_Variant _scannerFaction;
		private gamebbScriptID_Variant _scannerWeaponBasic;
		private gamebbScriptID_Variant _scannerWeaponDetailed;
		private gamebbScriptID_Variant _scannerVulnerabilities;
		private gamebbScriptID_Variant _scannerSquadInfo;
		private gamebbScriptID_Variant _scannerResistances;
		private gamebbScriptID_Variant _scannerAbilities;
		private gamebbScriptID_Variant _scannerAttitude;
		private gamebbScriptID_Variant _scannerBountySystem;
		private gamebbScriptID_Variant _scannerDeviceStatus;
		private gamebbScriptID_Variant _scannerNetworkLevel;
		private gamebbScriptID_Variant _scannerNetworkStatus;
		private gamebbScriptID_Variant _scannerConnections;
		private gamebbScriptID_Variant _scannerDescription;
		private gamebbScriptID_Variant _scannerSkillChecks;
		private gamebbScriptID_Variant _scannerVehicleName;
		private gamebbScriptID_Variant _scannerVehicleManufacturer;
		private gamebbScriptID_Variant _scannerVehicleProductionYears;
		private gamebbScriptID_Variant _scannerVehicleDriveLayout;
		private gamebbScriptID_Variant _scannerVehicleHorsepower;
		private gamebbScriptID_Variant _scannerVehicleMass;
		private gamebbScriptID_Variant _scannerVehicleState;
		private gamebbScriptID_Variant _scannerVehicleInfo;
		private gamebbScriptID_Variant _scannerQuickHackDescription;
		private gamebbScriptID_Int32 _objectType;

		[Ordinal(0)] 
		[RED("ScannerName")] 
		public gamebbScriptID_Variant ScannerName
		{
			get => GetProperty(ref _scannerName);
			set => SetProperty(ref _scannerName, value);
		}

		[Ordinal(1)] 
		[RED("ScannerHealth")] 
		public gamebbScriptID_Variant ScannerHealth
		{
			get => GetProperty(ref _scannerHealth);
			set => SetProperty(ref _scannerHealth, value);
		}

		[Ordinal(2)] 
		[RED("ScannerLevel")] 
		public gamebbScriptID_Variant ScannerLevel
		{
			get => GetProperty(ref _scannerLevel);
			set => SetProperty(ref _scannerLevel, value);
		}

		[Ordinal(3)] 
		[RED("ScannerAuthorization")] 
		public gamebbScriptID_Variant ScannerAuthorization
		{
			get => GetProperty(ref _scannerAuthorization);
			set => SetProperty(ref _scannerAuthorization, value);
		}

		[Ordinal(4)] 
		[RED("ScannerRarity")] 
		public gamebbScriptID_Variant ScannerRarity
		{
			get => GetProperty(ref _scannerRarity);
			set => SetProperty(ref _scannerRarity, value);
		}

		[Ordinal(5)] 
		[RED("ScannerArchetype")] 
		public gamebbScriptID_Variant ScannerArchetype
		{
			get => GetProperty(ref _scannerArchetype);
			set => SetProperty(ref _scannerArchetype, value);
		}

		[Ordinal(6)] 
		[RED("ScannerFaction")] 
		public gamebbScriptID_Variant ScannerFaction
		{
			get => GetProperty(ref _scannerFaction);
			set => SetProperty(ref _scannerFaction, value);
		}

		[Ordinal(7)] 
		[RED("ScannerWeaponBasic")] 
		public gamebbScriptID_Variant ScannerWeaponBasic
		{
			get => GetProperty(ref _scannerWeaponBasic);
			set => SetProperty(ref _scannerWeaponBasic, value);
		}

		[Ordinal(8)] 
		[RED("ScannerWeaponDetailed")] 
		public gamebbScriptID_Variant ScannerWeaponDetailed
		{
			get => GetProperty(ref _scannerWeaponDetailed);
			set => SetProperty(ref _scannerWeaponDetailed, value);
		}

		[Ordinal(9)] 
		[RED("ScannerVulnerabilities")] 
		public gamebbScriptID_Variant ScannerVulnerabilities
		{
			get => GetProperty(ref _scannerVulnerabilities);
			set => SetProperty(ref _scannerVulnerabilities, value);
		}

		[Ordinal(10)] 
		[RED("ScannerSquadInfo")] 
		public gamebbScriptID_Variant ScannerSquadInfo
		{
			get => GetProperty(ref _scannerSquadInfo);
			set => SetProperty(ref _scannerSquadInfo, value);
		}

		[Ordinal(11)] 
		[RED("ScannerResistances")] 
		public gamebbScriptID_Variant ScannerResistances
		{
			get => GetProperty(ref _scannerResistances);
			set => SetProperty(ref _scannerResistances, value);
		}

		[Ordinal(12)] 
		[RED("ScannerAbilities")] 
		public gamebbScriptID_Variant ScannerAbilities
		{
			get => GetProperty(ref _scannerAbilities);
			set => SetProperty(ref _scannerAbilities, value);
		}

		[Ordinal(13)] 
		[RED("ScannerAttitude")] 
		public gamebbScriptID_Variant ScannerAttitude
		{
			get => GetProperty(ref _scannerAttitude);
			set => SetProperty(ref _scannerAttitude, value);
		}

		[Ordinal(14)] 
		[RED("ScannerBountySystem")] 
		public gamebbScriptID_Variant ScannerBountySystem
		{
			get => GetProperty(ref _scannerBountySystem);
			set => SetProperty(ref _scannerBountySystem, value);
		}

		[Ordinal(15)] 
		[RED("ScannerDeviceStatus")] 
		public gamebbScriptID_Variant ScannerDeviceStatus
		{
			get => GetProperty(ref _scannerDeviceStatus);
			set => SetProperty(ref _scannerDeviceStatus, value);
		}

		[Ordinal(16)] 
		[RED("ScannerNetworkLevel")] 
		public gamebbScriptID_Variant ScannerNetworkLevel
		{
			get => GetProperty(ref _scannerNetworkLevel);
			set => SetProperty(ref _scannerNetworkLevel, value);
		}

		[Ordinal(17)] 
		[RED("ScannerNetworkStatus")] 
		public gamebbScriptID_Variant ScannerNetworkStatus
		{
			get => GetProperty(ref _scannerNetworkStatus);
			set => SetProperty(ref _scannerNetworkStatus, value);
		}

		[Ordinal(18)] 
		[RED("ScannerConnections")] 
		public gamebbScriptID_Variant ScannerConnections
		{
			get => GetProperty(ref _scannerConnections);
			set => SetProperty(ref _scannerConnections, value);
		}

		[Ordinal(19)] 
		[RED("ScannerDescription")] 
		public gamebbScriptID_Variant ScannerDescription
		{
			get => GetProperty(ref _scannerDescription);
			set => SetProperty(ref _scannerDescription, value);
		}

		[Ordinal(20)] 
		[RED("ScannerSkillChecks")] 
		public gamebbScriptID_Variant ScannerSkillChecks
		{
			get => GetProperty(ref _scannerSkillChecks);
			set => SetProperty(ref _scannerSkillChecks, value);
		}

		[Ordinal(21)] 
		[RED("ScannerVehicleName")] 
		public gamebbScriptID_Variant ScannerVehicleName
		{
			get => GetProperty(ref _scannerVehicleName);
			set => SetProperty(ref _scannerVehicleName, value);
		}

		[Ordinal(22)] 
		[RED("ScannerVehicleManufacturer")] 
		public gamebbScriptID_Variant ScannerVehicleManufacturer
		{
			get => GetProperty(ref _scannerVehicleManufacturer);
			set => SetProperty(ref _scannerVehicleManufacturer, value);
		}

		[Ordinal(23)] 
		[RED("ScannerVehicleProductionYears")] 
		public gamebbScriptID_Variant ScannerVehicleProductionYears
		{
			get => GetProperty(ref _scannerVehicleProductionYears);
			set => SetProperty(ref _scannerVehicleProductionYears, value);
		}

		[Ordinal(24)] 
		[RED("ScannerVehicleDriveLayout")] 
		public gamebbScriptID_Variant ScannerVehicleDriveLayout
		{
			get => GetProperty(ref _scannerVehicleDriveLayout);
			set => SetProperty(ref _scannerVehicleDriveLayout, value);
		}

		[Ordinal(25)] 
		[RED("ScannerVehicleHorsepower")] 
		public gamebbScriptID_Variant ScannerVehicleHorsepower
		{
			get => GetProperty(ref _scannerVehicleHorsepower);
			set => SetProperty(ref _scannerVehicleHorsepower, value);
		}

		[Ordinal(26)] 
		[RED("ScannerVehicleMass")] 
		public gamebbScriptID_Variant ScannerVehicleMass
		{
			get => GetProperty(ref _scannerVehicleMass);
			set => SetProperty(ref _scannerVehicleMass, value);
		}

		[Ordinal(27)] 
		[RED("ScannerVehicleState")] 
		public gamebbScriptID_Variant ScannerVehicleState
		{
			get => GetProperty(ref _scannerVehicleState);
			set => SetProperty(ref _scannerVehicleState, value);
		}

		[Ordinal(28)] 
		[RED("ScannerVehicleInfo")] 
		public gamebbScriptID_Variant ScannerVehicleInfo
		{
			get => GetProperty(ref _scannerVehicleInfo);
			set => SetProperty(ref _scannerVehicleInfo, value);
		}

		[Ordinal(29)] 
		[RED("ScannerQuickHackDescription")] 
		public gamebbScriptID_Variant ScannerQuickHackDescription
		{
			get => GetProperty(ref _scannerQuickHackDescription);
			set => SetProperty(ref _scannerQuickHackDescription, value);
		}

		[Ordinal(30)] 
		[RED("ObjectType")] 
		public gamebbScriptID_Int32 ObjectType
		{
			get => GetProperty(ref _objectType);
			set => SetProperty(ref _objectType, value);
		}

		public UI_ScannerModulesDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
