using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentDebugResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("brokenUIDs")] public CArray<worldTrafficLaneUID> BrokenUIDs { get; set; }
		[Ordinal(1)]  [RED("brokenUIDsDeadEnds")] public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds { get; set; }

		public worldTrafficPersistentDebugResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
