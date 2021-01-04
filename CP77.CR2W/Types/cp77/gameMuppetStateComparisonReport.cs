using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetStateComparisonReport : CVariable
	{
		[Ordinal(0)]  [RED("frameID")] public CUInt32 FrameID { get; set; }
		[Ordinal(1)]  [RED("items")] public CArray<gameMuppetComparisonReportItem> Items { get; set; }

		public gameMuppetStateComparisonReport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
