using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowTargetTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
		[Ordinal(1)]  [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
		[Ordinal(2)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(3)]  [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
		[Ordinal(4)]  [RED("distanceMin")] public CHandle<AIArgumentMapping> DistanceMin { get; set; }
		[Ordinal(5)]  [RED("distanceMax")] public CHandle<AIArgumentMapping> DistanceMax { get; set; }
		[Ordinal(6)]  [RED("isPlayer")] public CHandle<AIArgumentMapping> IsPlayer { get; set; }
		[Ordinal(7)]  [RED("stopHasReachedTarget")] public CHandle<AIArgumentMapping> StopHasReachedTarget { get; set; }
		[Ordinal(8)]  [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }
		[Ordinal(9)]  [RED("allowStubMovement")] public CHandle<AIArgumentMapping> AllowStubMovement { get; set; }

		public AIbehaviorDriveFollowTargetTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
