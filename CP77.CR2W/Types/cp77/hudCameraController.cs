using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudCameraController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("AnimOptions")] public inkanimPlaybackOptions AnimOptions { get; set; }
		[Ordinal(1)]  [RED("AnimProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(2)]  [RED("CameraID")] public inkTextWidgetReference CameraID { get; set; }
		[Ordinal(3)]  [RED("Date")] public inkTextWidgetReference Date { get; set; }
		[Ordinal(4)]  [RED("PSM_BBID")] public CUInt32 PSM_BBID { get; set; }
		[Ordinal(5)]  [RED("Timer")] public inkTextWidgetReference Timer { get; set; }
		[Ordinal(6)]  [RED("alpha_fadein")] public CHandle<inkanimDefinition> Alpha_fadein { get; set; }
		[Ordinal(7)]  [RED("controlledObjectRef")] public wCHandle<gameObject> ControlledObjectRef { get; set; }
		[Ordinal(8)]  [RED("currentTime")] public GameTime CurrentTime { get; set; }
		[Ordinal(9)]  [RED("currentZoom")] public CFloat CurrentZoom { get; set; }
		[Ordinal(10)]  [RED("deviceChain_BBID")] public CUInt32 DeviceChain_BBID { get; set; }
		[Ordinal(11)]  [RED("maxZoomLevel")] public CInt32 MaxZoomLevel { get; set; }
		[Ordinal(12)]  [RED("max_zoom_level")] public CFloat Max_zoom_level { get; set; }
		[Ordinal(13)]  [RED("ownerObject")] public wCHandle<gameObject> OwnerObject { get; set; }
		[Ordinal(14)]  [RED("pitch")] public inkCanvasWidgetReference Pitch { get; set; }
		[Ordinal(15)]  [RED("pitchCounter")] public inkTextWidgetReference PitchCounter { get; set; }
		[Ordinal(16)]  [RED("pitch_max")] public CFloat Pitch_max { get; set; }
		[Ordinal(17)]  [RED("pitch_min")] public CFloat Pitch_min { get; set; }
		[Ordinal(18)]  [RED("psmBlackboard")] public CHandle<gameIBlackboard> PsmBlackboard { get; set; }
		[Ordinal(19)]  [RED("root")] public wCHandle<inkCompoundWidget> Root { get; set; }
		[Ordinal(20)]  [RED("scanBlackboard")] public CHandle<gameIBlackboard> ScanBlackboard { get; set; }
		[Ordinal(21)]  [RED("tcsBlackboard")] public CHandle<gameIBlackboard> TcsBlackboard { get; set; }
		[Ordinal(22)]  [RED("tcs_BBID")] public CUInt32 Tcs_BBID { get; set; }
		[Ordinal(23)]  [RED("tele")] public inkCanvasWidgetReference Tele { get; set; }
		[Ordinal(24)]  [RED("teleScale")] public inkCanvasWidgetReference TeleScale { get; set; }
		[Ordinal(25)]  [RED("tele_max")] public CFloat Tele_max { get; set; }
		[Ordinal(26)]  [RED("tele_min")] public CFloat Tele_min { get; set; }
		[Ordinal(27)]  [RED("tele_scale")] public CFloat Tele_scale { get; set; }
		[Ordinal(28)]  [RED("timerHrs")] public inkTextWidgetReference TimerHrs { get; set; }
		[Ordinal(29)]  [RED("timerMin")] public inkTextWidgetReference TimerMin { get; set; }
		[Ordinal(30)]  [RED("timerSec")] public inkTextWidgetReference TimerSec { get; set; }
		[Ordinal(31)]  [RED("watermark")] public inkWidgetReference Watermark { get; set; }
		[Ordinal(32)]  [RED("yaw")] public inkCanvasWidgetReference Yaw { get; set; }
		[Ordinal(33)]  [RED("yawCounter")] public inkTextWidgetReference YawCounter { get; set; }
		[Ordinal(34)]  [RED("yaw_max")] public CFloat Yaw_max { get; set; }
		[Ordinal(35)]  [RED("yaw_min")] public CFloat Yaw_min { get; set; }

		public hudCameraController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
