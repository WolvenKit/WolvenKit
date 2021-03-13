using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMotorcycleHUDGameController : gameuiBaseVehicleHUDGameController
	{
		[Ordinal(10)] [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(11)] [RED("activeVehicleUIBlackboard")] public wCHandle<gameIBlackboard> ActiveVehicleUIBlackboard { get; set; }
		[Ordinal(12)] [RED("vehicleBBStateConectionId")] public CUInt32 VehicleBBStateConectionId { get; set; }
		[Ordinal(13)] [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(14)] [RED("gearBBConnectionId")] public CUInt32 GearBBConnectionId { get; set; }
		[Ordinal(15)] [RED("tppBBConnectionId")] public CUInt32 TppBBConnectionId { get; set; }
		[Ordinal(16)] [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(17)] [RED("leanAngleBBConnectionId")] public CUInt32 LeanAngleBBConnectionId { get; set; }
		[Ordinal(18)] [RED("playerStateBBConnectionId")] public CUInt32 PlayerStateBBConnectionId { get; set; }
		[Ordinal(19)] [RED("playOptionReverse")] public inkanimPlaybackOptions PlayOptionReverse { get; set; }
		[Ordinal(20)] [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(21)] [RED("mainCanvas")] public wCHandle<inkCanvasWidget> MainCanvas { get; set; }
		[Ordinal(22)] [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(23)] [RED("chunksNumber")] public CInt32 ChunksNumber { get; set; }
		[Ordinal(24)] [RED("dynamicRpmPath")] public CName DynamicRpmPath { get; set; }
		[Ordinal(25)] [RED("rpmPerChunk")] public CInt32 RpmPerChunk { get; set; }
		[Ordinal(26)] [RED("hasRevMax")] public CBool HasRevMax { get; set; }
		[Ordinal(27)] [RED("HiResMode")] public CBool HiResMode { get; set; }
		[Ordinal(28)] [RED("revMaxPath")] public CName RevMaxPath { get; set; }
		[Ordinal(29)] [RED("revMaxChunk")] public CInt32 RevMaxChunk { get; set; }
		[Ordinal(30)] [RED("revMax")] public CInt32 RevMax { get; set; }
		[Ordinal(31)] [RED("revRedLine")] public CInt32 RevRedLine { get; set; }
		[Ordinal(32)] [RED("maxSpeed")] public CInt32 MaxSpeed { get; set; }
		[Ordinal(33)] [RED("speedTextWidget")] public inkTextWidgetReference SpeedTextWidget { get; set; }
		[Ordinal(34)] [RED("gearTextWidget")] public inkTextWidgetReference GearTextWidget { get; set; }
		[Ordinal(35)] [RED("RPMTextWidget")] public inkTextWidgetReference RPMTextWidget { get; set; }
		[Ordinal(36)] [RED("lower")] public wCHandle<inkCanvasWidget> Lower { get; set; }
		[Ordinal(37)] [RED("lowerSpeedBigR")] public wCHandle<inkCanvasWidget> LowerSpeedBigR { get; set; }
		[Ordinal(38)] [RED("lowerSpeedBigL")] public wCHandle<inkCanvasWidget> LowerSpeedBigL { get; set; }
		[Ordinal(39)] [RED("lowerSpeedSmallR")] public wCHandle<inkCanvasWidget> LowerSpeedSmallR { get; set; }
		[Ordinal(40)] [RED("lowerSpeedSmallL")] public wCHandle<inkCanvasWidget> LowerSpeedSmallL { get; set; }
		[Ordinal(41)] [RED("lowerSpeedFluffR")] public wCHandle<inkImageWidget> LowerSpeedFluffR { get; set; }
		[Ordinal(42)] [RED("lowerSpeedFluffL")] public wCHandle<inkImageWidget> LowerSpeedFluffL { get; set; }
		[Ordinal(43)] [RED("hudLowerPart")] public wCHandle<inkCanvasWidget> HudLowerPart { get; set; }
		[Ordinal(44)] [RED("lowerfluff_R")] public wCHandle<inkCanvasWidget> Lowerfluff_R { get; set; }
		[Ordinal(45)] [RED("lowerfluff_L")] public wCHandle<inkCanvasWidget> Lowerfluff_L { get; set; }
		[Ordinal(46)] [RED("HudHideAnimation")] public CHandle<inkanimProxy> HudHideAnimation { get; set; }
		[Ordinal(47)] [RED("HudShowAnimation")] public CHandle<inkanimProxy> HudShowAnimation { get; set; }
		[Ordinal(48)] [RED("HudRedLineAnimation")] public CHandle<inkanimProxy> HudRedLineAnimation { get; set; }
		[Ordinal(49)] [RED("fluffBlinking")] public CHandle<inkanimController> FluffBlinking { get; set; }

		public inkMotorcycleHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
