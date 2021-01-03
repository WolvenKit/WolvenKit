using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetDestinationWaypoint : AIActionHelperTask
	{
		[Ordinal(0)]  [RED("destinations")] public CArray<Vector4> Destinations { get; set; }
		[Ordinal(1)]  [RED("finalDestinations")] public CArray<Vector4> FinalDestinations { get; set; }
		[Ordinal(2)]  [RED("findClosest")] public CBool FindClosest { get; set; }
		[Ordinal(3)]  [RED("refTargetType")] public CEnum<EAITargetType> RefTargetType { get; set; }
		[Ordinal(4)]  [RED("waypointsName")] public CName WaypointsName { get; set; }

		public SetDestinationWaypoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
