using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticLaneCollisions : CVariable
	{
		[Ordinal(0)] [RED("lane")] public worldTrafficLaneUID Lane { get; set; }
		[Ordinal(1)] [RED("collisions")] public CArray<worldTrafficStaticCollisionSphere> Collisions { get; set; }
		[Ordinal(2)] [RED("deadEndStart")] public CFloat DeadEndStart { get; set; }

		public worldStaticLaneCollisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
