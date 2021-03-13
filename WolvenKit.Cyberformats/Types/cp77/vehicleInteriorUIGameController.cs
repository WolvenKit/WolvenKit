using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(10)] [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(11)] [RED("vehicleBBReadyConectionId")] public CUInt32 VehicleBBReadyConectionId { get; set; }
		[Ordinal(12)] [RED("vehicleBBUIActivId")] public CUInt32 VehicleBBUIActivId { get; set; }
		[Ordinal(13)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(14)] [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(15)] [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(16)] [RED("rpmMaxBBConnectionId")] public CUInt32 RpmMaxBBConnectionId { get; set; }
		[Ordinal(17)] [RED("autopilotOnId")] public CUInt32 AutopilotOnId { get; set; }
		[Ordinal(18)] [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(19)] [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(20)] [RED("gearTextWidget")] public inkTextWidgetReference GearTextWidget { get; set; }
		[Ordinal(21)] [RED("rpmValueWidget")] public inkTextWidgetReference RpmValueWidget { get; set; }
		[Ordinal(22)] [RED("rpmGaugeForegroundWidget")] public inkRectangleWidgetReference RpmGaugeForegroundWidget { get; set; }
		[Ordinal(23)] [RED("autopilotTextWidget")] public inkTextWidgetReference AutopilotTextWidget { get; set; }
		[Ordinal(24)] [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(25)] [RED("chunksNumber")] public CInt32 ChunksNumber { get; set; }
		[Ordinal(26)] [RED("dynamicRpmPath")] public CName DynamicRpmPath { get; set; }
		[Ordinal(27)] [RED("rpmPerChunk")] public CInt32 RpmPerChunk { get; set; }
		[Ordinal(28)] [RED("hasRevMax")] public CBool HasRevMax { get; set; }
		[Ordinal(29)] [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(30)] [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(31)] [RED("isInAutoPilot")] public CBool IsInAutoPilot { get; set; }
		[Ordinal(32)] [RED("isVehicleReady")] public CBool IsVehicleReady { get; set; }
		[Ordinal(33)] [RED("HudRedLineAnimation")] public CHandle<inkanimProxy> HudRedLineAnimation { get; set; }

		public vehicleInteriorUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
