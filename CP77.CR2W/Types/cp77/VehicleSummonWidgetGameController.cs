using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("vehicleNameLabel")] public inkTextWidgetReference VehicleNameLabel { get; set; }
		[Ordinal(8)]  [RED("vehicleTypeIcon")] public inkImageWidgetReference VehicleTypeIcon { get; set; }
		[Ordinal(9)]  [RED("vehicleManufactorIcon")] public inkImageWidgetReference VehicleManufactorIcon { get; set; }
		[Ordinal(10)]  [RED("distanceLabel")] public inkTextWidgetReference DistanceLabel { get; set; }
		[Ordinal(11)]  [RED("isWaiting")] public inkTextWidgetReference IsWaiting { get; set; }
		[Ordinal(12)]  [RED("unit")] public CEnum<EMeasurementUnit> Unit { get; set; }
		[Ordinal(13)]  [RED("unitText")] public inkTextWidgetReference UnitText { get; set; }
		[Ordinal(14)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(15)]  [RED("animationCounterProxy")] public CHandle<inkanimProxy> AnimationCounterProxy { get; set; }
		[Ordinal(16)]  [RED("optionIntro")] public inkanimPlaybackOptions OptionIntro { get; set; }
		[Ordinal(17)]  [RED("optionCounter")] public inkanimPlaybackOptions OptionCounter { get; set; }
		[Ordinal(18)]  [RED("vehicleSummonDataDef")] public CHandle<VehicleSummonDataDef> VehicleSummonDataDef { get; set; }
		[Ordinal(19)]  [RED("vehicleSummonDataBB")] public CHandle<gameIBlackboard> VehicleSummonDataBB { get; set; }
		[Ordinal(20)]  [RED("vehicleSummonStateCallback")] public CUInt32 VehicleSummonStateCallback { get; set; }
		[Ordinal(21)]  [RED("vehicleSummonState")] public CUInt32 VehicleSummonState { get; set; }
		[Ordinal(22)]  [RED("vehiclePos")] public Vector4 VehiclePos { get; set; }
		[Ordinal(23)]  [RED("playerPos")] public Vector4 PlayerPos { get; set; }
		[Ordinal(24)]  [RED("distanceVector")] public Vector4 DistanceVector { get; set; }
		[Ordinal(25)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(26)]  [RED("distance")] public CInt32 Distance { get; set; }
		[Ordinal(27)]  [RED("vehicleID")] public entEntityID VehicleID { get; set; }
		[Ordinal(28)]  [RED("vehicleEntity")] public wCHandle<entEntity> VehicleEntity { get; set; }
		[Ordinal(29)]  [RED("vehicle")] public wCHandle<vehicleBaseObject> Vehicle { get; set; }
		[Ordinal(30)]  [RED("vehicleRecord")] public CHandle<gamedataVehicle_Record> VehicleRecord { get; set; }
		[Ordinal(31)]  [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }
		[Ordinal(32)]  [RED("iconRecord")] public CHandle<gamedataUIIcon_Record> IconRecord { get; set; }

		public VehicleSummonWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
