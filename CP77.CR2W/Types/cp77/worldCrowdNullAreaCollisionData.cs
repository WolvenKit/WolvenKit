using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldCrowdNullAreaCollisionData : CVariable
	{
		[Ordinal(0)]  [RED("areaID")] public CUInt64 AreaID { get; set; }
		[Ordinal(1)]  [RED("collisions")] public CArray<worldTrafficStaticCollisionSphere> Collisions { get; set; }

		public worldCrowdNullAreaCollisionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
