using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentLaneConnections : CVariable
	{
		[Ordinal(0)]  [RED("inLanes")] public CArray<worldTrafficConnectivityInLane> InLanes { get; set; }
		[Ordinal(1)]  [RED("outlanes")] public CArray<worldTrafficConnectivityOutLane> Outlanes { get; set; }

		public worldTrafficPersistentLaneConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
