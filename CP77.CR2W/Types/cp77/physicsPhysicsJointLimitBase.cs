using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class physicsPhysicsJointLimitBase : CVariable
	{
		[Ordinal(0)]  [RED("bounceThreshold")] public CFloat BounceThreshold { get; set; }
		[Ordinal(1)]  [RED("contactDistance")] public CFloat ContactDistance { get; set; }
		[Ordinal(2)]  [RED("damping")] public CFloat Damping { get; set; }
		[Ordinal(3)]  [RED("restitution")] public CFloat Restitution { get; set; }
		[Ordinal(4)]  [RED("stiffness")] public CFloat Stiffness { get; set; }

		public physicsPhysicsJointLimitBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
