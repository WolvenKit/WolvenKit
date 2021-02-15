using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_SectionTimings : CVariable
	{
		[Ordinal(0)] [RED("sectionName")] public CName SectionName { get; set; }
		[Ordinal(1)] [RED("updateTimeMS")] public CFloat UpdateTimeMS { get; set; }
		[Ordinal(2)] [RED("sampleTimeMS")] public CFloat SampleTimeMS { get; set; }

		public animAnimProfilerData_SectionTimings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
