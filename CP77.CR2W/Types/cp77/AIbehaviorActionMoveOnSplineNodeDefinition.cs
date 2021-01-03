using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionMoveOnSplineNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("ignoreNavigation")] public CHandle<AIArgumentMapping> IgnoreNavigation { get; set; }
		[Ordinal(1)]  [RED("isBackAndForth")] public CHandle<AIArgumentMapping> IsBackAndForth { get; set; }
		[Ordinal(2)]  [RED("isInfinite")] public CHandle<AIArgumentMapping> IsInfinite { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CHandle<AIArgumentMapping> MovementType { get; set; }
		[Ordinal(4)]  [RED("numberOfLoops")] public CHandle<AIArgumentMapping> NumberOfLoops { get; set; }
		[Ordinal(5)]  [RED("reverse")] public CHandle<AIArgumentMapping> Reverse { get; set; }
		[Ordinal(6)]  [RED("rotateEntity")] public CHandle<AIArgumentMapping> RotateEntity { get; set; }
		[Ordinal(7)]  [RED("snapToTerrain")] public CHandle<AIArgumentMapping> SnapToTerrain { get; set; }
		[Ordinal(8)]  [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }
		[Ordinal(9)]  [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }
		[Ordinal(10)]  [RED("strafingTarget")] public CHandle<AIArgumentMapping> StrafingTarget { get; set; }
		[Ordinal(11)]  [RED("useOffMeshLinkReservation")] public CHandle<AIArgumentMapping> UseOffMeshLinkReservation { get; set; }
		[Ordinal(12)]  [RED("useStart")] public CHandle<AIArgumentMapping> UseStart { get; set; }
		[Ordinal(13)]  [RED("useStop")] public CHandle<AIArgumentMapping> UseStop { get; set; }

		public AIbehaviorActionMoveOnSplineNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
