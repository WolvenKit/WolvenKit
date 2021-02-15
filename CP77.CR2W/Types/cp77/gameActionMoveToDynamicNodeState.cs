using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToDynamicNodeState : gameActionMoveToState
	{
		[Ordinal(9)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(10)] [RED("strafingTarget")] public wCHandle<gameObject> StrafingTarget { get; set; }
		[Ordinal(11)] [RED("desiredDistanceFromTarget")] public CFloat DesiredDistanceFromTarget { get; set; }
		[Ordinal(12)] [RED("stopWhenDestinationReached")] public CBool StopWhenDestinationReached { get; set; }
		[Ordinal(13)] [RED("pathfindingUpdateInterval")] public CFloat PathfindingUpdateInterval { get; set; }
		[Ordinal(14)] [RED("usePathfinding")] public CBool UsePathfinding { get; set; }
		[Ordinal(15)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(16)] [RED("useStop")] public CBool UseStop { get; set; }

		public gameActionMoveToDynamicNodeState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
