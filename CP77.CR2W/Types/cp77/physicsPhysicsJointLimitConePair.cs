using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitConePair : physicsPhysicsJointLimitBase
	{
		[Ordinal(0)]  [RED("swingY")] public CEnum<physicsPhysicsJointMotion> SwingY { get; set; }
		[Ordinal(1)]  [RED("swingZ")] public CEnum<physicsPhysicsJointMotion> SwingZ { get; set; }
		[Ordinal(2)]  [RED("yAngle")] public CFloat YAngle { get; set; }
		[Ordinal(3)]  [RED("zAngle")] public CFloat ZAngle { get; set; }

		public physicsPhysicsJointLimitConePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
