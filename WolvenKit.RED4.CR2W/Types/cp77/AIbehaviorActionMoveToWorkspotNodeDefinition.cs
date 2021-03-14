using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveToWorkspotNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(1)] [RED("workspotSetup")] public CHandle<AIArgumentMapping> WorkspotSetup { get; set; }
		[Ordinal(2)] [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
		[Ordinal(3)] [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
		[Ordinal(4)] [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
		[Ordinal(5)] [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(6)] [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(7)] [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(8)] [RED("spotReservation")] public CHandle<AIArgumentMapping> SpotReservation { get; set; }
		[Ordinal(9)] [RED("startTangent")] public CHandle<AIArgumentMapping> StartTangent { get; set; }
		[Ordinal(10)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }
		[Ordinal(11)] [RED("ignoreExploration")] public CHandle<AIArgumentMapping> IgnoreExploration { get; set; }

		public AIbehaviorActionMoveToWorkspotNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
