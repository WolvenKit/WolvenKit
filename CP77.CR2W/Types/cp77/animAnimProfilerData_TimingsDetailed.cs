using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimProfilerData_TimingsDetailed : CVariable
	{
		[Ordinal(0)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)]  [RED("avarageExclusiveUpdateTimeMS")] public CFloat AvarageExclusiveUpdateTimeMS { get; set; }
		[Ordinal(2)]  [RED("avarageInclusiveUpdateTimeMS")] public CFloat AvarageInclusiveUpdateTimeMS { get; set; }
		[Ordinal(3)]  [RED("avarageExclusiveSampleTimeMS")] public CFloat AvarageExclusiveSampleTimeMS { get; set; }
		[Ordinal(4)]  [RED("avarageInclusiveSampleTimeMS")] public CFloat AvarageInclusiveSampleTimeMS { get; set; }
		[Ordinal(5)]  [RED("totalExclusiveUpdateTimeMS")] public CFloat TotalExclusiveUpdateTimeMS { get; set; }
		[Ordinal(6)]  [RED("totalInclusiveUpdateTimeMS")] public CFloat TotalInclusiveUpdateTimeMS { get; set; }
		[Ordinal(7)]  [RED("totalExclusiveSampleTimeMS")] public CFloat TotalExclusiveSampleTimeMS { get; set; }
		[Ordinal(8)]  [RED("totalInclusiveSampleTimeMS")] public CFloat TotalInclusiveSampleTimeMS { get; set; }
		[Ordinal(9)]  [RED("updatesCount")] public CUInt32 UpdatesCount { get; set; }
		[Ordinal(10)]  [RED("samplesCount")] public CUInt32 SamplesCount { get; set; }

		public animAnimProfilerData_TimingsDetailed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
