using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDepthCollision : IParticleModificator
	{
		[Ordinal(0)]  [RED("maxCollisions")] public CUInt32 MaxCollisions { get; set; }
		[Ordinal(1)]  [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(2)]  [RED("friction")] public CFloat Friction { get; set; }
		[Ordinal(3)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(4)]  [RED("collisionEffect")] public CEnum<EDepthCollisionEffect> CollisionEffect { get; set; }

		public CParticleModificatorDepthCollision(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
