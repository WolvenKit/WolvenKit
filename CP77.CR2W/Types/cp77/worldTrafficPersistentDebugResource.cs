using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentDebugResource : resStreamedResource
	{
		[Ordinal(0)]  [RED("brokenUIDs")] public CArray<worldTrafficLaneUID> BrokenUIDs { get; set; }
		[Ordinal(1)]  [RED("brokenUIDsDeadEnds")] public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds { get; set; }

		public worldTrafficPersistentDebugResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
