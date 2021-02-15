using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetComparisonReportItem : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gameMuppetComparisonReportItemType> Type { get; set; }
		[Ordinal(1)] [RED("propertyName")] public CString PropertyName { get; set; }
		[Ordinal(2)] [RED("serverValue")] public CString ServerValue { get; set; }
		[Ordinal(3)] [RED("clientValue")] public CString ClientValue { get; set; }

		public gameMuppetComparisonReportItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
