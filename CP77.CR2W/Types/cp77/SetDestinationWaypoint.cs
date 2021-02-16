using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetDestinationWaypoint : AIActionHelperTask
	{
		[Ordinal(5)] [RED("refTargetType")] public CEnum<EAITargetType> RefTargetType { get; set; }
		[Ordinal(6)] [RED("findClosest")] public CBool FindClosest { get; set; }
		[Ordinal(7)] [RED("waypointsName")] public CName WaypointsName { get; set; }
		[Ordinal(8)] [RED("destinations")] public CArray<Vector4> Destinations { get; set; }
		[Ordinal(9)] [RED("finalDestinations")] public CArray<Vector4> FinalDestinations { get; set; }

		public SetDestinationWaypoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
