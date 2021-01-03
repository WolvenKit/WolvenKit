using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpTestPlatformController : gameObject
	{
		[Ordinal(0)]  [RED("platform")] public NodeRef Platform { get; set; }
		[Ordinal(1)]  [RED("pointA")] public NodeRef PointA { get; set; }
		[Ordinal(2)]  [RED("pointB")] public NodeRef PointB { get; set; }
		[Ordinal(3)]  [RED("speed")] public CFloat Speed { get; set; }

		public cpTestPlatformController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
