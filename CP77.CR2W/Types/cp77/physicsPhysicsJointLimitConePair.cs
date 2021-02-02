using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		[Ordinal(0)]  [RED("yAngle")] public CFloat YAngle { get; set; }
		[Ordinal(1)]  [RED("zAngle")] public CFloat ZAngle { get; set; }
		[Ordinal(2)]  [RED("swingY")] public CEnum<physicsPhysicsJointMotion> SwingY { get; set; }
		[Ordinal(3)]  [RED("swingZ")] public CEnum<physicsPhysicsJointMotion> SwingZ { get; set; }

		public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
