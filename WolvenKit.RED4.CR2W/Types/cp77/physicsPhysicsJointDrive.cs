using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDrive : CVariable
	{
		[Ordinal(0)] [RED("forceLimit")] public CFloat ForceLimit { get; set; }
		[Ordinal(1)] [RED("isAcceleration")] public CBool IsAcceleration { get; set; }
		[Ordinal(2)] [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(3)] [RED("damping")] public CFloat Damping { get; set; }

		public physicsPhysicsJointDrive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
