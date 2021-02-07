using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionResource : CResource
	{
		[Ordinal(0)]  [RED("nullAreasCollisionData")] public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData { get; set; }
		[Ordinal(1)]  [RED("nullAreaBlockadeData")] public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData { get; set; }

		public worldTrafficNullAreaCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
