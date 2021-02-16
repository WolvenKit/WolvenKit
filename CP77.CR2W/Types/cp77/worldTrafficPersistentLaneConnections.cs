using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneConnections : CVariable
	{
		[Ordinal(0)] [RED("outlanes")] public CArray<worldTrafficConnectivityOutLane> Outlanes { get; set; }
		[Ordinal(1)] [RED("inLanes")] public CArray<worldTrafficConnectivityInLane> InLanes { get; set; }

		public worldTrafficPersistentLaneConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
