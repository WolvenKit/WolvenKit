using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowTargetTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("allowStubMovement")] public CHandle<AIArgumentMapping> AllowStubMovement { get; set; }
		[Ordinal(1)]  [RED("distanceMax")] public CHandle<AIArgumentMapping> DistanceMax { get; set; }
		[Ordinal(2)]  [RED("distanceMin")] public CHandle<AIArgumentMapping> DistanceMin { get; set; }
		[Ordinal(3)]  [RED("isPlayer")] public CHandle<AIArgumentMapping> IsPlayer { get; set; }
		[Ordinal(4)]  [RED("needDriver")] public CHandle<AIArgumentMapping> NeedDriver { get; set; }
		[Ordinal(5)]  [RED("secureTimeOut")] public CHandle<AIArgumentMapping> SecureTimeOut { get; set; }
		[Ordinal(6)]  [RED("stopHasReachedTarget")] public CHandle<AIArgumentMapping> StopHasReachedTarget { get; set; }
		[Ordinal(7)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(8)]  [RED("useKinematic")] public CHandle<AIArgumentMapping> UseKinematic { get; set; }
		[Ordinal(9)]  [RED("useTraffic")] public CHandle<AIArgumentMapping> UseTraffic { get; set; }

		public AIbehaviorDriveFollowTargetTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
