using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiQuadRacerLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(0)]  [RED("endgameDelay")] public CFloat EndgameDelay { get; set; }
		[Ordinal(1)]  [RED("baseMultiplicatorScale")] public CFloat BaseMultiplicatorScale { get; set; }
		[Ordinal(2)]  [RED("skyWidget")] public inkWidgetReference SkyWidget { get; set; }
		[Ordinal(3)]  [RED("road")] public CArray<gameuiRoadEditorSegment> Road { get; set; }
		[Ordinal(4)]  [RED("checkpointLibraryName")] public CName CheckpointLibraryName { get; set; }
		[Ordinal(5)]  [RED("roadLibraryName")] public CName RoadLibraryName { get; set; }
		[Ordinal(6)]  [RED("backgroundLibraryName")] public CName BackgroundLibraryName { get; set; }
		[Ordinal(7)]  [RED("timeToPassCheckpoint")] public CFloat TimeToPassCheckpoint { get; set; }
		[Ordinal(8)]  [RED("scorePerMeter")] public CInt32 ScorePerMeter { get; set; }
		[Ordinal(9)]  [RED("scorePerExtraSecond")] public CInt32 ScorePerExtraSecond { get; set; }
		[Ordinal(10)]  [RED("bonusTime")] public CFloat BonusTime { get; set; }
		[Ordinal(11)]  [RED("backgroundStitch")] public CFloat BackgroundStitch { get; set; }
		[Ordinal(12)]  [RED("drawDistance")] public CUInt32 DrawDistance { get; set; }
		[Ordinal(13)]  [RED("carDistanceOfView")] public CInt32 CarDistanceOfView { get; set; }
		[Ordinal(14)]  [RED("colorBlindDrawDistance")] public CUInt32 ColorBlindDrawDistance { get; set; }
		[Ordinal(15)]  [RED("segmentDetails")] public CUInt32 SegmentDetails { get; set; }
		[Ordinal(16)]  [RED("segmentLength")] public CFloat SegmentLength { get; set; }
		[Ordinal(17)]  [RED("roadWidth")] public CFloat RoadWidth { get; set; }
		[Ordinal(18)]  [RED("backgroundSpeed")] public CFloat BackgroundSpeed { get; set; }
		[Ordinal(19)]  [RED("cameraFov")] public CFloat CameraFov { get; set; }
		[Ordinal(20)]  [RED("cameraHeight")] public CFloat CameraHeight { get; set; }
		[Ordinal(21)]  [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(22)]  [RED("defaultMaxSpeed")] public CFloat DefaultMaxSpeed { get; set; }
		[Ordinal(23)]  [RED("nitroMaxSpeed")] public CFloat NitroMaxSpeed { get; set; }
		[Ordinal(24)]  [RED("acceleration")] public CFloat Acceleration { get; set; }
		[Ordinal(25)]  [RED("breaking")] public CFloat Breaking { get; set; }
		[Ordinal(26)]  [RED("deceleration")] public CFloat Deceleration { get; set; }
		[Ordinal(27)]  [RED("offRoadLimit")] public CFloat OffRoadLimit { get; set; }
		[Ordinal(28)]  [RED("offRoadDeceleration")] public CFloat OffRoadDeceleration { get; set; }
		[Ordinal(29)]  [RED("centrifugalForce")] public CFloat CentrifugalForce { get; set; }
		[Ordinal(30)]  [RED("playerSegmentOffset")] public CInt32 PlayerSegmentOffset { get; set; }

		public gameuiQuadRacerLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
