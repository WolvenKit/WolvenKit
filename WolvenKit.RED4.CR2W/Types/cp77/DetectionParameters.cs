using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DetectionParameters : CVariable
	{
		[Ordinal(0)] [RED("canDetectIntruders")] public CBool CanDetectIntruders { get; set; }
		[Ordinal(1)] [RED("timeToActionAfterSpot")] public CFloat TimeToActionAfterSpot { get; set; }
		[Ordinal(2)] [RED("overrideRootRotation")] public CFloat OverrideRootRotation { get; set; }
		[Ordinal(3)] [RED("maxRotationAngle")] public CFloat MaxRotationAngle { get; set; }
		[Ordinal(4)] [RED("pitchAngle")] public CFloat PitchAngle { get; set; }
		[Ordinal(5)] [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }

		public DetectionParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
