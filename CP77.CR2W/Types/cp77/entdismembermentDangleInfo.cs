using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDangleInfo : CVariable
	{
		[Ordinal(0)] [RED("DangleSegmentLenght")] public CFloat DangleSegmentLenght { get; set; }
		[Ordinal(1)] [RED("DangleVelocityDamping")] public CFloat DangleVelocityDamping { get; set; }
		[Ordinal(2)] [RED("DangleBendStiffness")] public CFloat DangleBendStiffness { get; set; }
		[Ordinal(3)] [RED("DangleSegmentStiffness")] public CFloat DangleSegmentStiffness { get; set; }
		[Ordinal(4)] [RED("DangleCollisionSphereRadius")] public CFloat DangleCollisionSphereRadius { get; set; }

		public entdismembermentDangleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
