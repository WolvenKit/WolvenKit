using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SurveillanceCameraResaveData : CVariable
	{
		[Ordinal(0)] [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(1)] [RED("maxRotationAngle")] public CFloat MaxRotationAngle { get; set; }
		[Ordinal(2)] [RED("pitchAngle")] public CFloat PitchAngle { get; set; }
		[Ordinal(3)] [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(4)] [RED("canStreamVideo")] public CBool CanStreamVideo { get; set; }
		[Ordinal(5)] [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(6)] [RED("canBeControled")] public CBool CanBeControled { get; set; }
		[Ordinal(7)] [RED("factOnFeedReceived")] public CName FactOnFeedReceived { get; set; }
		[Ordinal(8)] [RED("questFactOnDetection")] public CName QuestFactOnDetection { get; set; }

		public SurveillanceCameraResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
