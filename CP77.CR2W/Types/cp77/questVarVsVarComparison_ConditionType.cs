using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVarVsVarComparison_ConditionType : questIFactsDBConditionType
	{
		[Ordinal(0)] [RED("factName1")] public CString FactName1 { get; set; }
		[Ordinal(1)] [RED("factName2")] public CString FactName2 { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public questVarVsVarComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
