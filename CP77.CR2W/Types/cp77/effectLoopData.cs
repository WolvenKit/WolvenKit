using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectLoopData : CVariable
	{
		[Ordinal(0)] [RED("startTime")] public CFloat StartTime { get; set; }
		[Ordinal(1)] [RED("endTime")] public CFloat EndTime { get; set; }

		public effectLoopData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
