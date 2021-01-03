using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointAngularLimitPair : physicsPhysicsJointLimitBase
	{
		[Ordinal(0)]  [RED("lower")] public CFloat Lower { get; set; }
		[Ordinal(1)]  [RED("twist")] public CEnum<physicsPhysicsJointMotion> Twist { get; set; }
		[Ordinal(2)]  [RED("upper")] public CFloat Upper { get; set; }

		public physicsPhysicsJointAngularLimitPair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
