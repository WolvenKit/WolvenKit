using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDriveVelocity : CVariable
	{
		[Ordinal(0)]  [RED("angularVelocity")] public Vector4 AngularVelocity { get; set; }
		[Ordinal(1)]  [RED("linearVelocity")] public Vector4 LinearVelocity { get; set; }

		public physicsPhysicsJointDriveVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
