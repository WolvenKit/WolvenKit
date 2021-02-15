using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnWalkToEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("actorId")] public scnActorId ActorId { get; set; }
		[Ordinal(7)] [RED("targetWaypointTag")] public CName TargetWaypointTag { get; set; }
		[Ordinal(8)] [RED("usePathfinding")] public CBool UsePathfinding { get; set; }

		public scnWalkToEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
