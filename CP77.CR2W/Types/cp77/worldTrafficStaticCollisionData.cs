using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficStaticCollisionData : ISerializable
	{
		[Ordinal(0)] [RED("laneCollisions")] public CArray<worldStaticLaneCollisions> LaneCollisions { get; set; }

		public worldTrafficStaticCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
