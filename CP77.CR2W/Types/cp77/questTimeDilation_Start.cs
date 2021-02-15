using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_Start : questTimeDilation_Operation
	{
		[Ordinal(0)] [RED("dilation")] public CFloat Dilation { get; set; }
		[Ordinal(1)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(2)] [RED("easeInCurve")] public CName EaseInCurve { get; set; }
		[Ordinal(3)] [RED("easeOutCurve")] public CName EaseOutCurve { get; set; }

		public questTimeDilation_Start(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
