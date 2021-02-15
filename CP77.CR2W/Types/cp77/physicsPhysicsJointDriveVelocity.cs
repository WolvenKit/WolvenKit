using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDriveVelocity : CVariable
	{
		[Ordinal(0)] [RED("linearVelocity")] public Vector4 LinearVelocity { get; set; }
		[Ordinal(1)] [RED("angularVelocity")] public Vector4 AngularVelocity { get; set; }

		public physicsPhysicsJointDriveVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
