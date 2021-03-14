using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaCollisionData : CVariable
	{
		[Ordinal(0)] [RED("areaID")] public CUInt64 AreaID { get; set; }
		[Ordinal(1)] [RED("collisions")] public CArray<worldTrafficStaticCollisionSphere> Collisions { get; set; }

		public worldCrowdNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
