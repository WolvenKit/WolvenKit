using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleInteriorUIGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("HudRedLineAnimation")] public CHandle<inkanimProxy> HudRedLineAnimation { get; set; }
		[Ordinal(1)]  [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(2)]  [RED("autopilotOnId")] public CUInt32 AutopilotOnId { get; set; }
		[Ordinal(3)]  [RED("autopilotTextWidget")] public inkTextWidgetReference AutopilotTextWidget { get; set; }
		[Ordinal(4)]  [RED("chunksNumber")] public CInt32 ChunksNumber { get; set; }
		[Ordinal(5)]  [RED("dynamicRpmPath")] public CName DynamicRpmPath { get; set; }
		[Ordinal(6)]  [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(7)]  [RED("gearTextWidget")] public inkTextWidgetReference GearTextWidget { get; set; }
		[Ordinal(8)]  [RED("hasRevMax")] public CBool HasRevMax { get; set; }
		[Ordinal(9)]  [RED("isInAutoPilot")] public CBool IsInAutoPilot { get; set; }
		[Ordinal(10)]  [RED("isVehicleReady")] public CBool IsVehicleReady { get; set; }
		[Ordinal(11)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(12)]  [RED("rpmGaugeForegroundWidget")] public inkRectangleWidgetReference RpmGaugeForegroundWidget { get; set; }
		[Ordinal(13)]  [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(14)]  [RED("rpmMaxBBConnectionId")] public CUInt32 RpmMaxBBConnectionId { get; set; }
		[Ordinal(15)]  [RED("rpmMaxValue")] public CFloat RpmMaxValue { get; set; }
		[Ordinal(16)]  [RED("rpmPerChunk")] public CInt32 RpmPerChunk { get; set; }
		[Ordinal(17)]  [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(18)]  [RED("rpmValueWidget")] public inkTextWidgetReference RpmValueWidget { get; set; }
		[Ordinal(19)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(20)]  [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(21)]  [RED("vehicleBBReadyConectionId")] public CUInt32 VehicleBBReadyConectionId { get; set; }
		[Ordinal(22)]  [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(23)]  [RED("vehicleBBUIActivId")] public CUInt32 VehicleBBUIActivId { get; set; }
		[Ordinal(24)]  [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }

		public vehicleInteriorUIGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
