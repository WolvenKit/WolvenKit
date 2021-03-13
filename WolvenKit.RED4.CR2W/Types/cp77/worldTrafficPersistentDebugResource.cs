using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentDebugResource : resStreamedResource
	{
		[Ordinal(1)] [RED("brokenUIDs")] public CArray<worldTrafficLaneUID> BrokenUIDs { get; set; }
		[Ordinal(2)] [RED("brokenUIDsDeadEnds")] public CArray<worldTrafficLaneUID> BrokenUIDsDeadEnds { get; set; }

		public worldTrafficPersistentDebugResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
