using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(10)] [RED("endgameDelay")] public CFloat EndgameDelay { get; set; }
		[Ordinal(11)] [RED("baseMultiplicatorScale")] public CFloat BaseMultiplicatorScale { get; set; }
		[Ordinal(12)] [RED("skyWidget")] public inkWidgetReference SkyWidget { get; set; }
		[Ordinal(13)] [RED("road")] public CArray<gameuiRoadEditorSegment> Road { get; set; }
		[Ordinal(14)] [RED("checkpointLibraryName")] public CName CheckpointLibraryName { get; set; }
		[Ordinal(15)] [RED("roadLibraryName")] public CName RoadLibraryName { get; set; }
		[Ordinal(16)] [RED("backgroundLibraryName")] public CName BackgroundLibraryName { get; set; }
		[Ordinal(17)] [RED("timeToPassCheckpoint")] public CFloat TimeToPassCheckpoint { get; set; }
		[Ordinal(18)] [RED("scorePerMeter")] public CInt32 ScorePerMeter { get; set; }
		[Ordinal(19)] [RED("scorePerExtraSecond")] public CInt32 ScorePerExtraSecond { get; set; }
		[Ordinal(20)] [RED("bonusTime")] public CFloat BonusTime { get; set; }
		[Ordinal(21)] [RED("backgroundStitch")] public CFloat BackgroundStitch { get; set; }
		[Ordinal(22)] [RED("drawDistance")] public CUInt32 DrawDistance { get; set; }
		[Ordinal(23)] [RED("carDistanceOfView")] public CInt32 CarDistanceOfView { get; set; }
		[Ordinal(24)] [RED("colorBlindDrawDistance")] public CUInt32 ColorBlindDrawDistance { get; set; }
		[Ordinal(25)] [RED("segmentDetails")] public CUInt32 SegmentDetails { get; set; }
		[Ordinal(26)] [RED("segmentLength")] public CFloat SegmentLength { get; set; }
		[Ordinal(27)] [RED("roadWidth")] public CFloat RoadWidth { get; set; }
		[Ordinal(28)] [RED("backgroundSpeed")] public CFloat BackgroundSpeed { get; set; }
		[Ordinal(29)] [RED("cameraFov")] public CFloat CameraFov { get; set; }
		[Ordinal(30)] [RED("cameraHeight")] public CFloat CameraHeight { get; set; }
		[Ordinal(31)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(32)] [RED("defaultMaxSpeed")] public CFloat DefaultMaxSpeed { get; set; }
		[Ordinal(33)] [RED("nitroMaxSpeed")] public CFloat NitroMaxSpeed { get; set; }
		[Ordinal(34)] [RED("acceleration")] public CFloat Acceleration { get; set; }
		[Ordinal(35)] [RED("breaking")] public CFloat Breaking { get; set; }
		[Ordinal(36)] [RED("deceleration")] public CFloat Deceleration { get; set; }
		[Ordinal(37)] [RED("offRoadLimit")] public CFloat OffRoadLimit { get; set; }
		[Ordinal(38)] [RED("offRoadDeceleration")] public CFloat OffRoadDeceleration { get; set; }
		[Ordinal(39)] [RED("centrifugalForce")] public CFloat CentrifugalForce { get; set; }
		[Ordinal(40)] [RED("playerSegmentOffset")] public CInt32 PlayerSegmentOffset { get; set; }
		[Ordinal(41)] [RED("timeLeftText")] public inkTextWidgetReference TimeLeftText { get; set; }
		[Ordinal(42)] [RED("scoreText")] public inkTextWidgetReference ScoreText { get; set; }
		[Ordinal(43)] [RED("speedText")] public inkTextWidgetReference SpeedText { get; set; }
		[Ordinal(44)] [RED("notificationText")] public inkTextWidgetReference NotificationText { get; set; }
		[Ordinal(45)] [RED("notificationAnimationName")] public CName NotificationAnimationName { get; set; }
		[Ordinal(46)] [RED("speedCoeficient")] public CFloat SpeedCoeficient { get; set; }
		[Ordinal(47)] [RED("currentNotificationAnimation")] public CHandle<inkanimProxy> CurrentNotificationAnimation { get; set; }
		[Ordinal(48)] [RED("lastTime")] public CInt32 LastTime { get; set; }

		public gameuiQuadRacerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
