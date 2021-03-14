using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		[Ordinal(5)] [RED("swingY")] public CEnum<physicsPhysicsJointMotion> SwingY { get; set; }
		[Ordinal(6)] [RED("swingZ")] public CEnum<physicsPhysicsJointMotion> SwingZ { get; set; }
		[Ordinal(7)] [RED("yAngle")] public CFloat YAngle { get; set; }
		[Ordinal(8)] [RED("zAngle")] public CFloat ZAngle { get; set; }

		public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
