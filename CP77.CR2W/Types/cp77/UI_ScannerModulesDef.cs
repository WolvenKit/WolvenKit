using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_ScannerModulesDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("ObjectType")] public gamebbScriptID_Int32 ObjectType { get; set; }
		[Ordinal(1)]  [RED("ScannerAbilities")] public gamebbScriptID_Variant ScannerAbilities { get; set; }
		[Ordinal(2)]  [RED("ScannerArchetype")] public gamebbScriptID_Variant ScannerArchetype { get; set; }
		[Ordinal(3)]  [RED("ScannerAttitude")] public gamebbScriptID_Variant ScannerAttitude { get; set; }
		[Ordinal(4)]  [RED("ScannerAuthorization")] public gamebbScriptID_Variant ScannerAuthorization { get; set; }
		[Ordinal(5)]  [RED("ScannerBountySystem")] public gamebbScriptID_Variant ScannerBountySystem { get; set; }
		[Ordinal(6)]  [RED("ScannerConnections")] public gamebbScriptID_Variant ScannerConnections { get; set; }
		[Ordinal(7)]  [RED("ScannerDescription")] public gamebbScriptID_Variant ScannerDescription { get; set; }
		[Ordinal(8)]  [RED("ScannerDeviceStatus")] public gamebbScriptID_Variant ScannerDeviceStatus { get; set; }
		[Ordinal(9)]  [RED("ScannerFaction")] public gamebbScriptID_Variant ScannerFaction { get; set; }
		[Ordinal(10)]  [RED("ScannerHealth")] public gamebbScriptID_Variant ScannerHealth { get; set; }
		[Ordinal(11)]  [RED("ScannerLevel")] public gamebbScriptID_Variant ScannerLevel { get; set; }
		[Ordinal(12)]  [RED("ScannerName")] public gamebbScriptID_Variant ScannerName { get; set; }
		[Ordinal(13)]  [RED("ScannerNetworkLevel")] public gamebbScriptID_Variant ScannerNetworkLevel { get; set; }
		[Ordinal(14)]  [RED("ScannerNetworkStatus")] public gamebbScriptID_Variant ScannerNetworkStatus { get; set; }
		[Ordinal(15)]  [RED("ScannerQuickHackDescription")] public gamebbScriptID_Variant ScannerQuickHackDescription { get; set; }
		[Ordinal(16)]  [RED("ScannerRarity")] public gamebbScriptID_Variant ScannerRarity { get; set; }
		[Ordinal(17)]  [RED("ScannerResistances")] public gamebbScriptID_Variant ScannerResistances { get; set; }
		[Ordinal(18)]  [RED("ScannerSkillChecks")] public gamebbScriptID_Variant ScannerSkillChecks { get; set; }
		[Ordinal(19)]  [RED("ScannerSquadInfo")] public gamebbScriptID_Variant ScannerSquadInfo { get; set; }
		[Ordinal(20)]  [RED("ScannerVehicleDriveLayout")] public gamebbScriptID_Variant ScannerVehicleDriveLayout { get; set; }
		[Ordinal(21)]  [RED("ScannerVehicleHorsepower")] public gamebbScriptID_Variant ScannerVehicleHorsepower { get; set; }
		[Ordinal(22)]  [RED("ScannerVehicleInfo")] public gamebbScriptID_Variant ScannerVehicleInfo { get; set; }
		[Ordinal(23)]  [RED("ScannerVehicleManufacturer")] public gamebbScriptID_Variant ScannerVehicleManufacturer { get; set; }
		[Ordinal(24)]  [RED("ScannerVehicleMass")] public gamebbScriptID_Variant ScannerVehicleMass { get; set; }
		[Ordinal(25)]  [RED("ScannerVehicleName")] public gamebbScriptID_Variant ScannerVehicleName { get; set; }
		[Ordinal(26)]  [RED("ScannerVehicleProductionYears")] public gamebbScriptID_Variant ScannerVehicleProductionYears { get; set; }
		[Ordinal(27)]  [RED("ScannerVehicleState")] public gamebbScriptID_Variant ScannerVehicleState { get; set; }
		[Ordinal(28)]  [RED("ScannerVulnerabilities")] public gamebbScriptID_Variant ScannerVulnerabilities { get; set; }
		[Ordinal(29)]  [RED("ScannerWeaponBasic")] public gamebbScriptID_Variant ScannerWeaponBasic { get; set; }
		[Ordinal(30)]  [RED("ScannerWeaponDetailed")] public gamebbScriptID_Variant ScannerWeaponDetailed { get; set; }

		public UI_ScannerModulesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
