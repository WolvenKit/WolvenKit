using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] [RED("twist")] public CEnum<physicsPhysicsJointMotion> Twist { get; set; }
		[Ordinal(6)] [RED("upper")] public CFloat Upper { get; set; }
		[Ordinal(7)] [RED("lower")] public CFloat Lower { get; set; }

		public physicsPhysicsJointAngularLimitPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
