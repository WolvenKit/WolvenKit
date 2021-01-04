using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleVcarGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("activeChunks")] public CInt32 ActiveChunks { get; set; }
		[Ordinal(1)]  [RED("activeVehicleBlackboard")] public CHandle<gameIBlackboard> ActiveVehicleBlackboard { get; set; }
		[Ordinal(2)]  [RED("animFadeOutProxy")] public CHandle<inkanimProxy> AnimFadeOutProxy { get; set; }
		[Ordinal(3)]  [RED("animFluffFadeInProxy")] public CHandle<inkanimProxy> AnimFluffFadeInProxy { get; set; }
		[Ordinal(4)]  [RED("anim_exterior_fadein")] public CHandle<inkanimDefinition> Anim_exterior_fadein { get; set; }
		[Ordinal(5)]  [RED("anim_exterior_fadeout")] public CHandle<inkanimDefinition> Anim_exterior_fadeout { get; set; }
		[Ordinal(6)]  [RED("anim_interior_fadeout")] public CHandle<inkanimDefinition> Anim_interior_fadeout { get; set; }
		[Ordinal(7)]  [RED("anim_interior_fluff1_anim1")] public CHandle<inkanimDefinition> Anim_interior_fluff1_anim1 { get; set; }
		[Ordinal(8)]  [RED("anim_interior_fluff1_anim2")] public CHandle<inkanimDefinition> Anim_interior_fluff1_anim2 { get; set; }
		[Ordinal(9)]  [RED("anim_interior_fluff1_fadein")] public CHandle<inkanimDefinition> Anim_interior_fluff1_fadein { get; set; }
		[Ordinal(10)]  [RED("anim_interior_fluff2_anim1")] public CHandle<inkanimDefinition> Anim_interior_fluff2_anim1 { get; set; }
		[Ordinal(11)]  [RED("anim_interior_fluff2_anim2")] public CHandle<inkanimDefinition> Anim_interior_fluff2_anim2 { get; set; }
		[Ordinal(12)]  [RED("anim_interior_fluff2_fadein")] public CHandle<inkanimDefinition> Anim_interior_fluff2_fadein { get; set; }
		[Ordinal(13)]  [RED("anim_interior_fluff3_fadein")] public CHandle<inkanimDefinition> Anim_interior_fluff3_fadein { get; set; }
		[Ordinal(14)]  [RED("anim_interior_fluff4_fadein")] public CHandle<inkanimDefinition> Anim_interior_fluff4_fadein { get; set; }
		[Ordinal(15)]  [RED("anim_interior_fluff5_fadein")] public CHandle<inkanimDefinition> Anim_interior_fluff5_fadein { get; set; }
		[Ordinal(16)]  [RED("anim_interior_rpm_fadein")] public CHandle<inkanimDefinition> Anim_interior_rpm_fadein { get; set; }
		[Ordinal(17)]  [RED("autopilotOnId")] public CUInt32 AutopilotOnId { get; set; }
		[Ordinal(18)]  [RED("chunksNumber")] public CInt32 ChunksNumber { get; set; }
		[Ordinal(19)]  [RED("dynamicRpmPath")] public CName DynamicRpmPath { get; set; }
		[Ordinal(20)]  [RED("fluff1animOptions1")] public inkanimPlaybackOptions Fluff1animOptions1 { get; set; }
		[Ordinal(21)]  [RED("fluff1animOptions2")] public inkanimPlaybackOptions Fluff1animOptions2 { get; set; }
		[Ordinal(22)]  [RED("fluff2animOptions1")] public inkanimPlaybackOptions Fluff2animOptions1 { get; set; }
		[Ordinal(23)]  [RED("fluff2animOptions2")] public inkanimPlaybackOptions Fluff2animOptions2 { get; set; }
		[Ordinal(24)]  [RED("hasRPM")] public CBool HasRPM { get; set; }
		[Ordinal(25)]  [RED("hasRevMax")] public CBool HasRevMax { get; set; }
		[Ordinal(26)]  [RED("hasSpeed")] public CBool HasSpeed { get; set; }
		[Ordinal(27)]  [RED("interiorFluff1Anim1Widget")] public wCHandle<inkCanvasWidget> InteriorFluff1Anim1Widget { get; set; }
		[Ordinal(28)]  [RED("interiorFluff1Anim1WidgetPath")] public CName InteriorFluff1Anim1WidgetPath { get; set; }
		[Ordinal(29)]  [RED("interiorFluff1Anim2Widget")] public wCHandle<inkCanvasWidget> InteriorFluff1Anim2Widget { get; set; }
		[Ordinal(30)]  [RED("interiorFluff1Anim2WidgetPath")] public CName InteriorFluff1Anim2WidgetPath { get; set; }
		[Ordinal(31)]  [RED("interiorFluff1Widget")] public wCHandle<inkCanvasWidget> InteriorFluff1Widget { get; set; }
		[Ordinal(32)]  [RED("interiorFluff1WidgetPath")] public CName InteriorFluff1WidgetPath { get; set; }
		[Ordinal(33)]  [RED("interiorFluff2Anim1Widget")] public wCHandle<inkCanvasWidget> InteriorFluff2Anim1Widget { get; set; }
		[Ordinal(34)]  [RED("interiorFluff2Anim1WidgetPath")] public CName InteriorFluff2Anim1WidgetPath { get; set; }
		[Ordinal(35)]  [RED("interiorFluff2Anim2Widget")] public wCHandle<inkCanvasWidget> InteriorFluff2Anim2Widget { get; set; }
		[Ordinal(36)]  [RED("interiorFluff2Anim2WidgetPath")] public CName InteriorFluff2Anim2WidgetPath { get; set; }
		[Ordinal(37)]  [RED("interiorFluff2Widget")] public wCHandle<inkCanvasWidget> InteriorFluff2Widget { get; set; }
		[Ordinal(38)]  [RED("interiorFluff2WidgetPath")] public CName InteriorFluff2WidgetPath { get; set; }
		[Ordinal(39)]  [RED("interiorFluff3Widget")] public wCHandle<inkCanvasWidget> InteriorFluff3Widget { get; set; }
		[Ordinal(40)]  [RED("interiorFluff3WidgetPath")] public CName InteriorFluff3WidgetPath { get; set; }
		[Ordinal(41)]  [RED("interiorFluff4Widget")] public wCHandle<inkCanvasWidget> InteriorFluff4Widget { get; set; }
		[Ordinal(42)]  [RED("interiorFluff4WidgetPath")] public CName InteriorFluff4WidgetPath { get; set; }
		[Ordinal(43)]  [RED("interiorFluff5Widget")] public wCHandle<inkCanvasWidget> InteriorFluff5Widget { get; set; }
		[Ordinal(44)]  [RED("interiorFluff5WidgetPath")] public CName InteriorFluff5WidgetPath { get; set; }
		[Ordinal(45)]  [RED("interiorRPMWidget")] public wCHandle<inkCanvasWidget> InteriorRPMWidget { get; set; }
		[Ordinal(46)]  [RED("interiorRPMWidgetPath")] public CName InteriorRPMWidgetPath { get; set; }
		[Ordinal(47)]  [RED("interiorRootWidget")] public wCHandle<inkCanvasWidget> InteriorRootWidget { get; set; }
		[Ordinal(48)]  [RED("interiorWidgetPath")] public CName InteriorWidgetPath { get; set; }
		[Ordinal(49)]  [RED("isInAutoPilot")] public CBool IsInAutoPilot { get; set; }
		[Ordinal(50)]  [RED("isInCombat")] public CBool IsInCombat { get; set; }
		[Ordinal(51)]  [RED("isInterior")] public CBool IsInterior { get; set; }
		[Ordinal(52)]  [RED("isWindow")] public CBool IsWindow { get; set; }
		[Ordinal(53)]  [RED("mountBBConnectionId")] public CUInt32 MountBBConnectionId { get; set; }
		[Ordinal(54)]  [RED("playerVehStateId")] public CUInt32 PlayerVehStateId { get; set; }
		[Ordinal(55)]  [RED("revMaxChunk")] public CInt32 RevMaxChunk { get; set; }
		[Ordinal(56)]  [RED("revMaxPath")] public CName RevMaxPath { get; set; }
		[Ordinal(57)]  [RED("rootWidget")] public wCHandle<inkCanvasWidget> RootWidget { get; set; }
		[Ordinal(58)]  [RED("rpmGaugeFullWidget")] public wCHandle<inkImageWidget> RpmGaugeFullWidget { get; set; }
		[Ordinal(59)]  [RED("rpmGaugeMaxSize")] public Vector2 RpmGaugeMaxSize { get; set; }
		[Ordinal(60)]  [RED("rpmMaxBBConnectionId")] public CUInt32 RpmMaxBBConnectionId { get; set; }
		[Ordinal(61)]  [RED("rpmPerChunk")] public CInt32 RpmPerChunk { get; set; }
		[Ordinal(62)]  [RED("rpmValueBBConnectionId")] public CUInt32 RpmValueBBConnectionId { get; set; }
		[Ordinal(63)]  [RED("speedBBConnectionId")] public CUInt32 SpeedBBConnectionId { get; set; }
		[Ordinal(64)]  [RED("speedTextWidget")] public wCHandle<inkTextWidget> SpeedTextWidget { get; set; }
		[Ordinal(65)]  [RED("vehicleBlackboard")] public wCHandle<gameIBlackboard> VehicleBlackboard { get; set; }
		[Ordinal(66)]  [RED("wasCombat")] public CBool WasCombat { get; set; }
		[Ordinal(67)]  [RED("windowWidget")] public wCHandle<inkCanvasWidget> WindowWidget { get; set; }
		[Ordinal(68)]  [RED("windowWidgetPath")] public CName WindowWidgetPath { get; set; }

		public vehicleVcarGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
