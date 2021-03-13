using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficNullAreaCollisionResource : CResource
	{
		[Ordinal(1)] [RED("nullAreasCollisionData")] public CHandle<worldTrafficNullAreaCollisionData> NullAreasCollisionData { get; set; }
		[Ordinal(2)] [RED("nullAreaBlockadeData")] public CHandle<worldTrafficNullAreaDynamicBlockadeData> NullAreaBlockadeData { get; set; }

		public worldTrafficNullAreaCollisionResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
