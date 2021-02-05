using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudCameraController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("pitch_min")] public CFloat Pitch_min { get; set; }
		[Ordinal(8)]  [RED("pitch_max")] public CFloat Pitch_max { get; set; }
		[Ordinal(9)]  [RED("yaw_min")] public CFloat Yaw_min { get; set; }
		[Ordinal(10)]  [RED("yaw_max")] public CFloat Yaw_max { get; set; }
		[Ordinal(11)]  [RED("tele_min")] public CFloat Tele_min { get; set; }
		[Ordinal(12)]  [RED("tele_max")] public CFloat Tele_max { get; set; }
		[Ordinal(13)]  [RED("tele_scale")] public CFloat Tele_scale { get; set; }
		[Ordinal(14)]  [RED("max_zoom_level")] public CFloat Max_zoom_level { get; set; }
		[Ordinal(15)]  [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(16)]  [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(17)]  [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(18)]  [RED("timerHrs")] public inkTextWidgetReference TimerHrs { get; set; }
		[Ordinal(19)]  [RED("timerMin")] public inkTextWidgetReference TimerMin { get; set; }
		[Ordinal(20)]  [RED("timerSec")] public inkTextWidgetReference TimerSec { get; set; }
		[Ordinal(21)]  [RED("watermark")] public inkWidgetReference Watermark { get; set; }
		[Ordinal(22)]  [RED("yawCounter")] public inkTextWidgetReference YawCounter { get; set; }
		[Ordinal(23)]  [RED("pitchCounter")] public inkTextWidgetReference PitchCounter { get; set; }
		[Ordinal(24)]  [RED("pitch")] public inkCanvasWidgetReference Pitch { get; set; }
		[Ordinal(25)]  [RED("yaw")] public inkCanvasWidgetReference Yaw { get; set; }
		[Ordinal(26)]  [RED("tele")] public inkCanvasWidgetReference Tele { get; set; }
		[Ordinal(27)]  [RED("teleScale")] public inkCanvasWidgetReference TeleScale { get; set; }
		[Ordinal(28)]  [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(29)]  [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(30)]  [RED("tcsBlackboard")] public CHandle<gameIBlackboard> TcsBlackboard { get; set; }
		[Ordinal(31)]  [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(32)]  [RED("tcs_BBID")] public CUInt32 Tcs_BBID { get; set; }
		[Ordinal(33)]  [RED("deviceChain_BBID")] public CUInt32 DeviceChain_BBID { get; set; }
		[Ordinal(34)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(35)]  [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(36)]  [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(37)]  [RED("controlledObjectRef")] public wCHandle<gameObject> ControlledObjectRef { get; set; }
		[Ordinal(38)]  [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(39)]  [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(40)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(41)]  [RED("ownerObject")] public wCHandle<gameObject> OwnerObject { get; set; }
		[Ordinal(42)]  [RED("maxZoomLevel")] public CInt32 MaxZoomLevel { get; set; }

		public hudCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
