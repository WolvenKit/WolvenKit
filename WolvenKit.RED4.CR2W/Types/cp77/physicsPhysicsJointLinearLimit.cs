using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLinearLimit : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] [RED("x")] public CEnum<physicsPhysicsJointMotion> X { get; set; }
		[Ordinal(6)] [RED("y")] public CEnum<physicsPhysicsJointMotion> Y { get; set; }
		[Ordinal(7)] [RED("z")] public CEnum<physicsPhysicsJointMotion> Z { get; set; }
		[Ordinal(8)] [RED("value")] public CFloat Value { get; set; }

		public physicsPhysicsJointLinearLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
