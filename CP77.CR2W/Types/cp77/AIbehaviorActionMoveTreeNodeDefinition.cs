using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("destinationTangent")] public CHandle<AIArgumentMapping> DestinationTangent { get; set; }
		[Ordinal(1)]  [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(2)]  [RED("ignoreRestrictedArea")] public CHandle<AIArgumentMapping> IgnoreRestrictedArea { get; set; }
		[Ordinal(3)]  [RED("lookAtTarget")] public CHandle<AIArgumentMapping> LookAtTarget { get; set; }
		[Ordinal(4)]  [RED("movementTarget")] public CHandle<AIArgumentMapping> MovementTarget { get; set; }
		[Ordinal(5)]  [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
		[Ordinal(6)]  [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(7)]  [RED("spotReservation")] public CHandle<AIArgumentMapping> SpotReservation { get; set; }
		[Ordinal(8)]  [RED("startTangent")] public CHandle<AIArgumentMapping> StartTangent { get; set; }
		[Ordinal(9)]  [RED("tolerance")] public CHandle<AIArgumentMapping> Tolerance { get; set; }
		[Ordinal(10)]  [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(11)]  [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }

		public AIbehaviorActionMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
