using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AINavigationSystemResult : CVariable
	{
		[Ordinal(0)] [RED("hasFailed")] public CBool HasFailed { get; set; }
		[Ordinal(1)] [RED("hasPath")] public CBool HasPath { get; set; }
		[Ordinal(2)] [RED("hasClosestPointOnNavmesh")] public CBool HasClosestPointOnNavmesh { get; set; }
		[Ordinal(3)] [RED("hasClosestReachablePoint")] public CBool HasClosestReachablePoint { get; set; }
		[Ordinal(4)] [RED("lastSourcePosition")] public WorldPosition LastSourcePosition { get; set; }
		[Ordinal(5)] [RED("lastTargetPosition")] public WorldPosition LastTargetPosition { get; set; }
		[Ordinal(6)] [RED("adjustedTargetPosition")] public WorldPosition AdjustedTargetPosition { get; set; }
		[Ordinal(7)] [RED("closestPointOnNavmesh")] public WorldPosition ClosestPointOnNavmesh { get; set; }
		[Ordinal(8)] [RED("closestReachablePoint")] public WorldPosition ClosestReachablePoint { get; set; }

		public AINavigationSystemResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
