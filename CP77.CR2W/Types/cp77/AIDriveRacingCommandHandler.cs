using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIDriveRacingCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outDriveBackwards")] public CHandle<AIArgumentMapping> OutDriveBackwards { get; set; }
		[Ordinal(1)]  [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }
		[Ordinal(2)]  [RED("outReverseSpline")] public CHandle<AIArgumentMapping> OutReverseSpline { get; set; }
		[Ordinal(3)]  [RED("outRubberBandingBool")] public CHandle<AIArgumentMapping> OutRubberBandingBool { get; set; }
		[Ordinal(4)]  [RED("outRubberBandingMaxDistance")] public CHandle<AIArgumentMapping> OutRubberBandingMaxDistance { get; set; }
		[Ordinal(5)]  [RED("outRubberBandingMinDistance")] public CHandle<AIArgumentMapping> OutRubberBandingMinDistance { get; set; }
		[Ordinal(6)]  [RED("outRubberBandingStayInFront")] public CHandle<AIArgumentMapping> OutRubberBandingStayInFront { get; set; }
		[Ordinal(7)]  [RED("outRubberBandingStopAndWait")] public CHandle<AIArgumentMapping> OutRubberBandingStopAndWait { get; set; }
		[Ordinal(8)]  [RED("outRubberBandingTargetRef")] public CHandle<AIArgumentMapping> OutRubberBandingTargetRef { get; set; }
		[Ordinal(9)]  [RED("outRubberBandingTeleportToCatchUp")] public CHandle<AIArgumentMapping> OutRubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(10)]  [RED("outSecureTimeOut")] public CHandle<AIArgumentMapping> OutSecureTimeOut { get; set; }
		[Ordinal(11)]  [RED("outSpline")] public CHandle<AIArgumentMapping> OutSpline { get; set; }
		[Ordinal(12)]  [RED("outStartFromClosest")] public CHandle<AIArgumentMapping> OutStartFromClosest { get; set; }
		[Ordinal(13)]  [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }

		public AIDriveRacingCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
