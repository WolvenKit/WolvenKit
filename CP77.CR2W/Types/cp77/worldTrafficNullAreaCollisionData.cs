using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionData : ISerializable
	{
		[Ordinal(0)] [RED("header")] public worldCrowdNullAreaCollisionHeader Header { get; set; }
		[Ordinal(1)] [RED("nullAreaCollisions")] public CArray<worldCrowdNullAreaCollisionData> NullAreaCollisions { get; set; }

		public worldTrafficNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
