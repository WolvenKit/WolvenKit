using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPanzerHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(10)] [RED("vehiclePS")] public CHandle<VehicleComponentPS> VehiclePS { get; set; }
		[Ordinal(11)] [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(12)] [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(13)] [RED("healthStatus")] public inkTextWidgetReference HealthStatus { get; set; }
		[Ordinal(14)] [RED("healthBar")] public inkWidgetReference HealthBar { get; set; }
		[Ordinal(15)] [RED("rightStickX")] public CFloat RightStickX { get; set; }
		[Ordinal(16)] [RED("rightStickY")] public CFloat RightStickY { get; set; }
		[Ordinal(17)] [RED("LeanAngleValue")] public inkCanvasWidgetReference LeanAngleValue { get; set; }
		[Ordinal(18)] [RED("CoriRotation")] public inkCanvasWidgetReference CoriRotation { get; set; }
		[Ordinal(19)] [RED("CompassRotation")] public inkCanvasWidgetReference CompassRotation { get; set; }
		[Ordinal(20)] [RED("Cori_S")] public inkCanvasWidgetReference Cori_S { get; set; }
		[Ordinal(21)] [RED("Cori_M")] public inkCanvasWidgetReference Cori_M { get; set; }
		[Ordinal(22)] [RED("trimmerArrow")] public inkImageWidgetReference TrimmerArrow { get; set; }
		[Ordinal(23)] [RED("SpeedValue")] public inkTextWidgetReference SpeedValue { get; set; }
		[Ordinal(24)] [RED("RPMValue")] public inkTextWidgetReference RPMValue { get; set; }
		[Ordinal(25)] [RED("scanBlackboard")] public wCHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(26)] [RED("psmBlackboard")] public wCHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(27)] [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(28)] [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(29)] [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(30)] [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(31)] [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(32)] [RED("activeVehicleUIBlackboard")] public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard { get; set; }
		[Ordinal(33)] [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(34)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(35)] [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(36)] [RED("tppBBConnectionId")] public CUInt32 TppBBConnectionId { get; set; }
		[Ordinal(37)] [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(38)] [RED("leanAngleBBConnectionId")] public CUInt32 LeanAngleBBConnectionId { get; set; }
		[Ordinal(39)] [RED("playerStateBBConnectionId")] public CUInt32 PlayerStateBBConnectionId { get; set; }
		[Ordinal(40)] [RED("isTargetingFriendlyConnectionId")] public CUInt32 IsTargetingFriendlyConnectionId { get; set; }
		[Ordinal(41)] [RED("bbPlayerStats")] public CHandle<gameIBlackboard> BbPlayerStats { get; set; }
		[Ordinal(42)] [RED("bbPlayerEventId")] public CUInt32 BbPlayerEventId { get; set; }
		[Ordinal(43)] [RED("currentHealth")] public CInt32 CurrentHealth { get; set; }
		[Ordinal(44)] [RED("previousHealth")] public CInt32 PreviousHealth { get; set; }
		[Ordinal(45)] [RED("maximumHealth")] public CInt32 MaximumHealth { get; set; }
		[Ordinal(46)] [RED("quickhacksMemoryPercent")] public CFloat QuickhacksMemoryPercent { get; set; }
		[Ordinal(47)] [RED("playerObject")] public wCHandle<gameObject> PlayerObject { get; set; }
		[Ordinal(48)] [RED("weaponBlackboard")] public wCHandle<gameIBlackboard> WeaponBlackboard { get; set; }
		[Ordinal(49)] [RED("weaponParamsListenerId")] public CUInt32 WeaponParamsListenerId { get; set; }
		[Ordinal(50)] [RED("targetIndicators")] public CArray<TargetIndicatorEntry> TargetIndicators { get; set; }
		[Ordinal(51)] [RED("targetHolder")] public inkCompoundWidgetReference TargetHolder { get; set; }
		[Ordinal(52)] [RED("targetWidgetLibraryName")] public CName TargetWidgetLibraryName { get; set; }
		[Ordinal(53)] [RED("targetWidgetPoolSize")] public CInt32 TargetWidgetPoolSize { get; set; }

		public gameuiPanzerHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
