using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(8)]  [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(9)]  [RED("vehicleBBReadyConectionId")] public CUInt32 VehicleBBReadyConectionId { get; set; }
		[Ordinal(10)]  [RED("vehicleBBUIActivId")] public CUInt32 VehicleBBUIActivId { get; set; }
		[Ordinal(11)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(12)]  [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(13)]  [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(14)]  [RED("rpmMaxBBConnectionId")] public CUInt32 RpmMaxBBConnectionId { get; set; }
		[Ordinal(15)]  [RED("autopilotOnId")] public CUInt32 AutopilotOnId { get; set; }
		[Ordinal(16)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(17)]  [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(18)]  [RED("gearTextWidget")] public inkTextWidgetReference GearTextWidget { get; set; }
		[Ordinal(19)]  [RED("rpmValueWidget")] public inkTextWidgetReference RpmValueWidget { get; set; }
		[Ordinal(20)]  [RED("rpmGaugeForegroundWidget")] public inkRectangleWidgetReference RpmGaugeForegroundWidget { get; set; }
		[Ordinal(21)]  [RED("autopilotTextWidget")] public inkTextWidgetReference AutopilotTextWidget { get; set; }
		[Ordinal(22)]  [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(23)]  [RED("chunksNumber")] public CInt32 ChunksNumber { get; set; }
		[Ordinal(24)]  [RED("dynamicRpmPath")] public CName DynamicRpmPath { get; set; }
		[Ordinal(25)]  [RED("rpmPerChunk")] public CInt32 RpmPerChunk { get; set; }
		[Ordinal(26)]  [RED("hasRevMax")] public CBool HasRevMax { get; set; }
		[Ordinal(27)]  [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(28)]  [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(29)]  [RED("isInAutoPilot")] public CBool IsInAutoPilot { get; set; }
		[Ordinal(30)]  [RED("isVehicleReady")] public CBool IsVehicleReady { get; set; }
		[Ordinal(31)]  [RED("HudRedLineAnimation")] public CHandle<inkanimProxy> HudRedLineAnimation { get; set; }

		public vehicleInteriorUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
