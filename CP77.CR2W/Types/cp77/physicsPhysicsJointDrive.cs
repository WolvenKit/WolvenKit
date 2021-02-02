using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDrive : CVariable
	{
		[Ordinal(0)]  [RED("forceLimit")] public CFloat ForceLimit { get; set; }
		[Ordinal(1)]  [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(2)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(3)]  [RED("isAcceleration")] public CBool IsAcceleration { get; set; }

		public physicsPhysicsJointDrive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
