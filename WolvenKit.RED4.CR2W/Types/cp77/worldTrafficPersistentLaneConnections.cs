using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneConnections : CVariable
	{
		[Ordinal(0)] [RED("outlanes")] public CArray<worldTrafficConnectivityOutLane> Outlanes { get; set; }
		[Ordinal(1)] [RED("inLanes")] public CArray<worldTrafficConnectivityInLane> InLanes { get; set; }

		public worldTrafficPersistentLaneConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
