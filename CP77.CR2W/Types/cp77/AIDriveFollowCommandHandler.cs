using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIDriveFollowCommandHandler : AICommandHandlerBase
	{
		[Ordinal(0)]  [RED("outAllowStubMovement")] public CHandle<AIArgumentMapping> OutAllowStubMovement { get; set; }
		[Ordinal(1)]  [RED("outDistanceMax")] public CHandle<AIArgumentMapping> OutDistanceMax { get; set; }
		[Ordinal(2)]  [RED("outDistanceMin")] public CHandle<AIArgumentMapping> OutDistanceMin { get; set; }
		[Ordinal(3)]  [RED("outNeedDriver")] public CHandle<AIArgumentMapping> OutNeedDriver { get; set; }
		[Ordinal(4)]  [RED("outSecureTimeOut")] public CHandle<AIArgumentMapping> OutSecureTimeOut { get; set; }
		[Ordinal(5)]  [RED("outStopWhenTargetReached")] public CHandle<AIArgumentMapping> OutStopWhenTargetReached { get; set; }
		[Ordinal(6)]  [RED("outTarget")] public CHandle<AIArgumentMapping> OutTarget { get; set; }
		[Ordinal(7)]  [RED("outTrafficTryNeighborsForEnd")] public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd { get; set; }
		[Ordinal(8)]  [RED("outTrafficTryNeighborsForStart")] public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart { get; set; }
		[Ordinal(9)]  [RED("outUseKinematic")] public CHandle<AIArgumentMapping> OutUseKinematic { get; set; }
		[Ordinal(10)]  [RED("outUseTraffic")] public CHandle<AIArgumentMapping> OutUseTraffic { get; set; }

		public AIDriveFollowCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
