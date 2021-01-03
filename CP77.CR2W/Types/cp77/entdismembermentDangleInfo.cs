using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentDangleInfo : CVariable
	{
		[Ordinal(0)]  [RED("DangleBendStiffness")] public CFloat DangleBendStiffness { get; set; }
		[Ordinal(1)]  [RED("DangleCollisionSphereRadius")] public CFloat DangleCollisionSphereRadius { get; set; }
		[Ordinal(2)]  [RED("DangleSegmentLenght")] public CFloat DangleSegmentLenght { get; set; }
		[Ordinal(3)]  [RED("DangleSegmentStiffness")] public CFloat DangleSegmentStiffness { get; set; }
		[Ordinal(4)]  [RED("DangleVelocityDamping")] public CFloat DangleVelocityDamping { get; set; }

		public entdismembermentDangleInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
