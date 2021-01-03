using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIDriveOnSplineCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outDriveBackwards")] public CHandle<AIArgumentMapping> OutDriveBackwards { get; set; }
		[Ordinal(1)]  [RED("outForcedStartSpeed")] public CHandle<AIArgumentMapping> OutForcedStartSpeed { get; set; }
		[Ordinal(2)]  [RED("outKeepDistanceBool")] public CHandle<AIArgumentMapping> OutKeepDistanceBool { get; set; }
		[Ordinal(3)]  [RED("outKeepDistanceCompanion")] public CHandle<AIArgumentMapping> OutKeepDistanceCompanion { get; set; }
		[Ordinal(4)]  [RED("outKeepDistanceDistance")] public CHandle<AIArgumentMapping> OutKeepDistanceDistance { get; set; }
		[Ordinal(5)]  [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }
		[Ordinal(6)]  [RED("outReverseSpline")] public CHandle<AIArgumentMapping> OutReverseSpline { get; set; }
		[Ordinal(7)]  [RED("outRubberBandingBool")] public CHandle<AIArgumentMapping> OutRubberBandingBool { get; set; }
		[Ordinal(8)]  [RED("outRubberBandingMaxDistance")] public CHandle<AIArgumentMapping> OutRubberBandingMaxDistance { get; set; }
		[Ordinal(9)]  [RED("outRubberBandingMinDistance")] public CHandle<AIArgumentMapping> OutRubberBandingMinDistance { get; set; }
		[Ordinal(10)]  [RED("outRubberBandingStayInFront")] public CHandle<AIArgumentMapping> OutRubberBandingStayInFront { get; set; }
		[Ordinal(11)]  [RED("outRubberBandingStopAndWait")] public CHandle<AIArgumentMapping> OutRubberBandingStopAndWait { get; set; }
		[Ordinal(12)]  [RED("outRubberBandingTargetRef")] public CHandle<AIArgumentMapping> OutRubberBandingTargetRef { get; set; }
		[Ordinal(13)]  [RED("outRubberBandingTeleportToCatchUp")] public CHandle<AIArgumentMapping> OutRubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(14)]  [RED("outSecureTimeOut")] public CHandle<AIArgumentMapping> OutSecureTimeOut { get; set; }
		[Ordinal(15)]  [RED("outSpline")] public CHandle<AIArgumentMapping> OutSpline { get; set; }
		[Ordinal(16)]  [RED("outStartFromClosest")] public CHandle<AIArgumentMapping> OutStartFromClosest { get; set; }
		[Ordinal(17)]  [RED("outStopAtPathEnd")] public CHandle<AIArgumentMapping> OutStopAtPathEnd { get; set; }
		[Ordinal(18)]  [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }

		public AIDriveOnSplineCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
