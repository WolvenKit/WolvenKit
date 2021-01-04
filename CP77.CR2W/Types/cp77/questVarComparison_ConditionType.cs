using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVarComparison_ConditionType : questIFactsDBConditionType
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("factName")] public CString FactName { get; set; }
		[Ordinal(2)]  [RED("value")] public CInt32 Value { get; set; }

		public questVarComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
