using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DetectionParameters : CVariable
	{
		[Ordinal(0)]  [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(1)]  [RED("maxRotationAngle")] public CFloat MaxRotationAngle { get; set; }
		[Ordinal(2)]  [RED("overrideRootRotation")] public CFloat OverrideRootRotation { get; set; }
		[Ordinal(3)]  [RED("pitchAngle")] public CFloat PitchAngle { get; set; }
		[Ordinal(4)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(5)]  [RED("timeToActionAfterSpot")] public CFloat TimeToActionAfterSpot { get; set; }

		public DetectionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
