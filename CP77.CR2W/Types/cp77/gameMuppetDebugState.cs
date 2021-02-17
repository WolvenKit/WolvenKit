using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetDebugState : ISerializable
	{
		[Ordinal(0)] [RED("comparisonReports")] public CArray<gameMuppetStateComparisonReport> ComparisonReports { get; set; }
		[Ordinal(1)] [RED("comparisonReportIndex")] public CUInt32 ComparisonReportIndex { get; set; }
		[Ordinal(2)] [RED("subStepsData")] public CArray<gameMuppetSubStepData> SubStepsData { get; set; }

		public gameMuppetDebugState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
