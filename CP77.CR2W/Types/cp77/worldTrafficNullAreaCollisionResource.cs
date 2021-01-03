using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionResource : CResource
	{
		[Ordinal(0)]  [RED("nullAreaBlockadeData")] public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData { get; set; }
		[Ordinal(1)]  [RED("nullAreasCollisionData")] public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData { get; set; }

		public worldTrafficNullAreaCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
