using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SNewsFeedData : CVariable
	{
		[Ordinal(0)]  [RED("interval")] public CFloat Interval { get; set; }
		[Ordinal(1)]  [RED("elements")] public CArray<SNewsFeedElementData> Elements { get; set; }

		public SNewsFeedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
