using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldRaceSplineNodeOffset : CVariable
	{
		[Ordinal(0)]  [RED("from")] public CFloat From { get; set; }
		[Ordinal(1)]  [RED("to")] public CFloat To { get; set; }
		[Ordinal(2)]  [RED("left")] public CFloat Left { get; set; }
		[Ordinal(3)]  [RED("right")] public CFloat Right { get; set; }

		public worldRaceSplineNodeOffset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
