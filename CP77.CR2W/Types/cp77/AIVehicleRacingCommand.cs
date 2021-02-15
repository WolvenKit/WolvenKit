using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIVehicleRacingCommand : AIVehicleCommand
	{
		[Ordinal(6)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(7)] [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(8)] [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(9)] [RED("driveBackwards")] public CBool DriveBackwards { get; set; }
		[Ordinal(10)] [RED("startFromClosest")] public CBool StartFromClosest { get; set; }
		[Ordinal(11)] [RED("rubberBandingBool")] public CBool RubberBandingBool { get; set; }
		[Ordinal(12)] [RED("rubberBandingTargetRef")] public wCHandle<gameObject> RubberBandingTargetRef { get; set; }
		[Ordinal(13)] [RED("rubberBandingMinDistance")] public CFloat RubberBandingMinDistance { get; set; }
		[Ordinal(14)] [RED("rubberBandingMaxDistance")] public CFloat RubberBandingMaxDistance { get; set; }
		[Ordinal(15)] [RED("rubberBandingStopAndWait")] public CBool RubberBandingStopAndWait { get; set; }
		[Ordinal(16)] [RED("rubberBandingTeleportToCatchUp")] public CBool RubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(17)] [RED("rubberBandingStayInFront")] public CBool RubberBandingStayInFront { get; set; }

		public AIVehicleRacingCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
