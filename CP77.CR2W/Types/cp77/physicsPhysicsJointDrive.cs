using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointDrive : CVariable
	{
		[Ordinal(0)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(1)]  [RED("forceLimit")] public CFloat ForceLimit { get; set; }
		[Ordinal(2)]  [RED("isAcceleration")] public CBool IsAcceleration { get; set; }
		[Ordinal(3)]  [RED("stiffness")] public CFloat Stiffness { get; set; }

		public physicsPhysicsJointDrive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
