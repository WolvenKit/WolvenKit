using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionDroneMoveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("desiredDistanceFromTarget")] public CHandle<AIArgumentMapping> DesiredDistanceFromTarget { get; set; }
		[Ordinal(1)]  [RED("moveType")] public CHandle<AIArgumentMapping> MoveType { get; set; }
		[Ordinal(2)]  [RED("movementTarget")] public CHandle<AIArgumentMapping> MovementTarget { get; set; }
		[Ordinal(3)]  [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(4)]  [RED("stopWhenDestinationReached")] public CHandle<AIArgumentMapping> StopWhenDestinationReached { get; set; }
		[Ordinal(5)]  [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
		[Ordinal(6)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(7)]  [RED("toleranceRadius")] public CHandle<AIArgumentMapping> ToleranceRadius { get; set; }

		public AIbehaviorActionDroneMoveTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
