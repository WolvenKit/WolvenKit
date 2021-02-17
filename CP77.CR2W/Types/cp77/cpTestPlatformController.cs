using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class cpTestPlatformController : gameObject
	{
		[Ordinal(40)] [RED("platform")] public NodeRef Platform { get; set; }
		[Ordinal(41)] [RED("pointA")] public NodeRef PointA { get; set; }
		[Ordinal(42)] [RED("pointB")] public NodeRef PointB { get; set; }
		[Ordinal(43)] [RED("speed")] public CFloat Speed { get; set; }

		public cpTestPlatformController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
